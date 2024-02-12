using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;

public class DBTempUpdate
{
    private static Timer timer;
    private static readonly object timerLock = new object(); // Lock object to prevent race conditions
    private static bool isTimerStarted = false;
    DataComms datacomms = DataCommsHelper.GetDataCommsInstance();
    public delegate void myprocessDataDelegate(string strData);
    float temp;
    private Temperature somethingsomethingtemp;

    public void UpdateTemperatureDB()
    {
        InitComms();
        //lock (timerLock)
        //{
            
        //}
        if (timer == null)
        {
            timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += Timer_Tick;

            // Ensure that timer operations run on the UI thread
            if (!isTimerStarted && Application.OpenForms.Count > 0)
            {
                timer.Start();
                isTimerStarted = true;
            }
        }
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        //Console.WriteLine("work?");
        //datacomms.sendData("GIBTEMP");
        UpdateTemperatureInDatabase();
        //datacomms.dataReceiveEvent += commsdatareceive;
        //datacomms.dataSendErrorEvent += commsSendError;
    }

    private void UpdateTemperatureInDatabase()
    {
        int result = 0;
        //float temperature = temp;
        //float temperature = (float)(new Random().NextDouble() * 10.0 + 20.0);
        float temperature = (float)somethingsomethingtemp.GetTemp();
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

    private string extractStringValue(string strData, string ID)
    {
        string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
        return result;
    }
    private float extractFloatValue(string strData, string ID)
    {
        return (float.Parse(extractStringValue(strData, ID)));
    }
    private float HandleTemp(string strData, string ID)
    {
        temp = extractFloatValue(strData, ID);
        //Console.WriteLine("Temp="+temp);
        return temp;
    }

    public void extractSensorData(string strData)
    {
        //Console.WriteLine("extract sensor data");
        //Console.WriteLine("admin side index"+strData.IndexOf("Temp="));
        if (strData.IndexOf("Temp=") != -1)
            HandleTemp(strData, "Temp=");
    }

    public void processDataReceive(string strData)
    {
        //Console.WriteLine("Process Data Receive");
        myprocessDataDelegate d = new myprocessDataDelegate(extractSensorData);
        d(strData);
    }

    public void commsdatareceive(string datareceived)
    {
        //Console.WriteLine("commsdatareceive");

        processDataReceive(datareceived);
    }

    public void commsSendError(string errMsg)
    {
       // Console.WriteLine("error coms");
        MessageBox.Show(errMsg);
        processDataReceive(errMsg);
    }

    private void InitComms()
    {
       // Console.WriteLine("InitComms");
        datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
        datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
    }
}