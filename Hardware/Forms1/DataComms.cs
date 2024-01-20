using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DataCommsHelper
{
    private static DataComms dataCommsInstance;

    public static DataComms GetDataCommsInstance()
    {
        if (dataCommsInstance == null)
        {
            // Instantiate DataComms only if it hasn't been created yet
            dataCommsInstance = new DataComms();
            // You might want to set up event handlers or perform other initialization here
        }

        return dataCommsInstance;
    }
}