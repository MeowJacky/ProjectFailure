using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;


public class Temperature
{
    DataComms datacomms = DataCommsHelper.GetDataCommsInstance();
    public delegate void myprocessDataDelegate(string strData);
    float temp;
    double tempsend;

    public void InitTemp()
    {
        InitComms();
        GetTemp();
    }
    public double GetTemp()
    {
        InitComms();
        datacomms.sendData("GIBTEMP");
        tempsend = Math.Round(temp, 2);
        datacomms.dataReceiveEvent += commsdatareceive;
        datacomms.dataSendErrorEvent += commsSendError;
        return tempsend;
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

