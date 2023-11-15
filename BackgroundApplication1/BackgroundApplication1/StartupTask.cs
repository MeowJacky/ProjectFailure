using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;

// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

using System.Diagnostics;
using System.Threading.Tasks;
using GrovePi;
using GrovePi.Sensors;

namespace BackgroundApplication1
{
    public sealed class StartupTask : IBackgroundTask
    {
        private static SerialComms uartComms;
        private static string rfid = "";
        private void sleep(int s)
        {             
            Task.Delay(s).Wait();
        }
        static void UartDataHandler(Object sender, SerialComms.UartEventArgs e)
        {
            rfid = e.data;
            Debug.WriteLine("Card Detected: " + rfid);
        }
        private void StartUart()
        {
            uartComms = new SerialComms();
            uartComms.UartEvent += new SerialComms.UartEventDelegate(UartDataHandler);
        }
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            // 
            // TODO: Insert code to perform background work
            //
            // If you start any asynchronous methods here, prevent the task
            // from closing prematurely by using BackgroundTaskDeferral as
            // described in http://aka.ms/backgroundtaskdeferral
            //
            StartUart();
            while (true)
            {
                sleep(200);

                rfid = "";
            }
        }
    }
}
