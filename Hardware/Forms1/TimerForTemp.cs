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

public class DBTempUpdate
{
    private static Timer timer;
    private static readonly object timerLock = new object(); // Lock object to prevent race conditions
    private static bool isTimerStarted = false;
    DataComms datacomms;
    public delegate void myprocessDataDelegate(string strData);
    float temp;

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
        //Random random = new Random();
        //float Temperature = (float)(random.NextDouble() * 10.0 + 20.0);
        InitComms();
        //get temperature

        return Temperature;
    }
    private string extractStringValue(string strData, string ID)
    {
        string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
        Console.WriteLine(result);
        return result;
    }
    private float extractFloatValue(string strData, string ID)
    {
        return (float.Parse(extractStringValue(strData, ID)));
    }
    private float HandleTemp(string strData, string ID)
    {
        temp = extractFloatValue(strData, ID);
        return temp;
    }

    public void extractSensorData(string strData)
    {
        if (strData.IndexOf("Temp=") != -1)
            HandleTemp(strData, "Temp=");
    
    }

    public void processDataReceive(string strData)
    {
        myprocessDataDelegate d = new myprocessDataDelegate(extractSensorData);
        d(strData);
    }

    public void commsdatareceive(string datareceived)
    {
        processDataReceive(datareceived);
    }

    public void commsSendError(string errMsg)
    {
        MessageBox.Show(errMsg);
        processDataReceive(errMsg);
    }

    private void InitComms()
    {
        datacomms = new DataComms();
        datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
        datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
    }
}
