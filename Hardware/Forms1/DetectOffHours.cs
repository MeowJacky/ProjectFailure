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
    DataComms datacomms = DataCommsHelper.GetDataCommsInstance();
    public delegate void myprocessDataDelegate(string strData);
    bool detect;

    public void UpdateIntrusionDB()
    {
        //InitComms();
        lock (timerLock)
        {
            if (Intrusiontimer == null)
            {
                Intrusiontimer = new Timer();
                Intrusiontimer.Interval = 10000;
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
        datacomms.sendData("GIBMOVE");
        Intrusion();
        datacomms.dataReceiveEvent -= commsdatareceive;
        datacomms.dataSendErrorEvent -= commsSendError;
    }
    //if (DetectIntrusionsRPI())
    //if ((CheckTimeRange()) && RandomDetect())
    //if ((RandomDetect()))
    //if ((CheckTimeRange()) && (detect))

    private void Intrusion()
    {
        if ((detect))
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
                //do something that turn on buzzer. 
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

    private static bool RandomDetect()
    {
        // Use a random number generator to generate a value between 0 and 1
        double randomValue = new Random().NextDouble();

        // Set the activation percentage (0.01% or 0.0001)
        double activationPercentage = 0.01;

        // Check if the generated value is within the activation range
        return randomValue < activationPercentage;
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
    private string extractStringValue(string strData, string ID)
    {
        string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
        return result;
    }
    private bool extractBoolValue(string strData, string ID)
    {
        return (bool.Parse(extractStringValue(strData, ID)));
    }
    private bool HandleDetect(string strData, string ID)
    {
        detect = extractBoolValue(strData, ID);
        return detect;
    }

    public void extractSensorData(string strData)
    {
        if (strData.IndexOf("Detect=") != -1)
            HandleDetect(strData, "Detect=");

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
        datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
        datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
    }
}
