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
    float blametristen;
    Temperature tempuwu;

    public float LatestTemperature()
    {
        if (temp != 0)
        {
            //blametristen = temp;
            //Console.WriteLine("Handle temp3:" + blametristen);
            //temp = (float)Math.Round(new Random().NextDouble() * 10.0 + 20.0, 2);
            blametristen = (float)tempuwu.GetTemp();
            Console.WriteLine("latest temp: " + blametristen);
            
        }
        return blametristen;
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
        Console.WriteLine("updating temp");

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

    private void Timer_Tick(object sender, EventArgs e)
    {
        //InitComms();
        datacomms.sendData("GIBTEMP");
        Console.WriteLine("Handle temp4:" + temp);
        blametristen = temp;
        Console.WriteLine("Handle temp5:" + blametristen);
        //datacomms.dataReceiveEvent -= commsdatareceive;
        //datacomms.dataSendErrorEvent -= commsSendError;
        Console.WriteLine("faking data");
        //temp = (float)(new Random().NextDouble() * 10.0 + 20.0);

        //Console.WriteLine("Latest temperature: " + LatestTemperature());
    }



    //private string extractStringValue(string strData, string ID)
    //{
    //    string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
    //    return result;
    //}
    //private float extractFloatValue(string strData, string ID)
    //{
    //    return (float.Parse(extractStringValue(strData, ID)));
    //}
    //private float HandleTemp(string strData, string ID)
    //{
    //    //float temp = (float)(new Random().NextDouble() * 10.0 + 20.0);
    //    Console.WriteLine("Handle teamp:" + temp);
    //    temp = extractFloatValue(strData, ID);
    //    Console.WriteLine("Handle temp2:" + temp);
    //    return temp;
    //}

    //public void extractSensorData(string strData)
    //{
    //    Console.WriteLine(strData);
    //    if (strData.IndexOf("Temp=") != -1)
    //        HandleTemp(strData, "Temp=");

    //}

    //public void processDataReceive(string strData)
    //{
    //    Console.WriteLine("process data");
    //    myprocessDataDelegate d = new myprocessDataDelegate(extractSensorData);
    //    d(strData);
    //}

    //public void commsdatareceive(string datareceived)
    //{
    //    try
    //    {
    //        Console.WriteLine(datareceived);
    //        Console.WriteLine("what");
    //        processDataReceive(datareceived);
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Error in commsdatareceive: " + ex.Message);
    //    }
    //}

    //public void commsSendError(string errMsg)
    //{
    //    MessageBox.Show(errMsg);
    //    processDataReceive(errMsg);
    //}

    //private void InitComms()
    //{
    //    Console.WriteLine("Why");
    //    datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
    //    datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
    //    datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
    //}
}