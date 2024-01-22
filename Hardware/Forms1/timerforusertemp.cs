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

    public float LatestTemperature
    {
        get { return temp; }
    }
    //public void settemp(float temperature)
    //{
    //    temp = temperature;
    //}


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
        Console.WriteLine("Timer_Tick" + temp);
    }



    private string extractStringValue(string strData, string ID)
    {
        Console.WriteLine("extractStringValue");
        string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
        return result;
    }
    private float extractFloatValue(string strData, string ID)
    {
        Console.WriteLine("extractFloatValue");
        return (float.Parse(extractStringValue(strData, ID)));
    }
    private float HandleTemp(string strData, string ID)
    {
        Console.WriteLine("Handletemp");
        temp = extractFloatValue(strData, ID);
        Console.WriteLine("HandleTemp" + temp);
        return temp;
    }

    public void extractSensorData(string strData)
    {
        Console.WriteLine("extract sensor data: "+ strData.IndexOf("Temp="));
        if (strData.IndexOf("Temp=") != -1)
        {
            HandleTemp(strData, "Temp=");

        }
    }

    public void processDataReceive(string strData)
    {
        Console.WriteLine("Process Data Receive");
        myprocessDataDelegate d = new myprocessDataDelegate(extractSensorData);
        d(strData);
    }

    public void commsdatareceive(string datareceived)
    {
        Console.WriteLine("commsdatareceive");

        processDataReceive(datareceived);
    }

    public void commsSendError(string errMsg)
    {
        Console.WriteLine("error coms");
        MessageBox.Show(errMsg);
        processDataReceive(errMsg);
    }

    private void InitComms()
    {
        Console.WriteLine("InitComms????");
        datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
        datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
    }
}