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


public class DBUserTempUpdate
{
    private static Timer timer;
    private static readonly object timerLock = new object(); // Lock object to prevent race conditions
    private static bool isTimerStarted = false;
    DataComms datacomms = DataCommsHelper.GetDataCommsInstance();
    public delegate void myprocessDataDelegate(string strData);
    float temp;
    private static DBUserTempUpdate TempInstance;
    private float temperature;



    public float LatestTemperature()
    {
        //get { return temp; }
        return temp;
    }
    public float RetrieveTemp()
    {
        return temperature;
    }

    public void settemp(float temperatures)
    {
        temp = temperatures;
        temperature = temperatures;
    }

    public static DBUserTempUpdate tempinstance
    {
        get
        {
            if (TempInstance == null)
            {
                TempInstance = new DBUserTempUpdate();
            }
            return TempInstance;
        }
    }


    public void UpdateTemperature()
    {
        InitComms();
        lock (timerLock)
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 15000; // 15 seconds for testing 10000

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
        datacomms.sendData("GIBTEMP");
        datacomms.dataReceiveEvent -= commsdatareceive;
        datacomms.dataSendErrorEvent -= commsSendError;
        //temp = (float)(new Random().NextDouble() * 10.0 + 20.0);
        settemp((float)(new Random().NextDouble() * 10.0 + 20.0));

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
        float temp = (float)(new Random().NextDouble() * 10.0 + 20.0);
        //temp = extractFloatValue(strData, ID);
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
        datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
        datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
    }
}