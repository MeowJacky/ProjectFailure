using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

public class DBTempUpdate
{
    private static Timer timer;
    private static readonly object timerLock = new object(); // Lock object to prevent race conditions
    private static bool isTimerStarted = false;

    public void UpdateTemperatureDB()
    {
        lock (timerLock)
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 10000; // 10 seconds for testing
                timer.Tick += Timer_Tick;

                // Ensure that timer operations run on the UI thread
                if (!isTimerStarted && Application.OpenForms.Count > 0)
                {
                    timer.Start();
                    isTimerStarted = true;
                }
            }
        }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        UpdateTemperatureInDatabase();
    }

    private void UpdateTemperatureInDatabase()
    {
        int result = 0;
        float temperature = GetRoomTemperature();
        SqlConnection myConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString);
        string strCommandText = "INSERT INTO Temperature (Time, Temp) VALUES (@CurrentTime, @NewTemperature)";
        SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
        cmd.Parameters.AddWithValue("@NewTemperature", temperature);
        cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now);

        myConnect.Open();
        result = cmd.ExecuteNonQuery();
        myConnect.Close();

        Console.WriteLine($"Updating temperature: {temperature}");
    }

    private float GetRoomTemperature()
    {
        Random random = new Random();
        float randomTemperature = (float)(random.NextDouble() * 10.0 + 20.0);

        return randomTemperature;
    }
}
