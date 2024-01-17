using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;

public class DBOffHoursDetect
{
    private static Timer Intrusiontimer;
    private static readonly object timerLock = new object(); // Lock object to prevent race conditions
    private static bool isTimerStartedIntrusion = false;
    DataComms datacomms;
    public delegate void myprocessDataDelegate(string strData);
    float temp;

    public void UpdateIntrusionDB()
    {
        //InitComms();
        lock (timerLock)
        {
            if (Intrusiontimer == null)
            {
                Intrusiontimer = new Timer();
                Intrusiontimer.Interval = 100;
                Intrusiontimer.Tick += Intrusiontimer_Tick;

                // Ensure that timer operations run on the UI thread
                if (!isTimerStartedIntrusion && Application.OpenForms.Count > 0)
                {
                    Intrusiontimer.Start();
                    isTimerStartedIntrusion = true;
                }
            }
        }
    }
    private void Intrusiontimer_Tick(object sender, EventArgs e)
    {
        Intrusion();
    }

    private void Intrusion()
    {
        if ((CheckTimeRange()) && (DetectIntrusionsRPI()))
            //if (DetectIntrusionsRPI())
        {
            int result = 0;
            int detectionStatus = 1;

            SqlConnection myConnect = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString);
            string strCommandText = "INSERT INTO Detection (Time, Detection) VALUES (@CurrentTime, @DetectionStatus)";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@DetectionStatus", detectionStatus);
            cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now);

            myConnect.Open();

            try
            {
                result = cmd.ExecuteNonQuery();
                Console.WriteLine("Intrusion Detected!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating the database: {ex.Message}");
            }
            finally
            {
                myConnect.Close();
            }
        }
    }

    private static bool DetectIntrusionsRPI()
    {
        bool result = new Random().Next(2) == 0;

        return result;
    }

    private static bool CheckTimeRange()
    {
        DateTime currentTime = DateTime.Now;
        DateTime startTime = DateTime.Today.AddHours(1); // 1 am
        DateTime endTime = DateTime.Today.AddHours(6).AddMinutes(30); // 6:30 am
        bool result = false;

        if (currentTime.TimeOfDay > startTime.TimeOfDay && currentTime.TimeOfDay < endTime.TimeOfDay)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }
}
