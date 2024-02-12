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

namespace Hardware
{
    public sealed class StartupTask : IBackgroundTask
    {
        static int curMode;
        IUltrasonicRangerSensor ultra = DeviceFactory.Build.UltraSonicSensor(Pin.DigitalPin8);
        ILed red = DeviceFactory.Build.Led(Pin.DigitalPin5);
        ILed green = DeviceFactory.Build.Led(Pin.DigitalPin6);
        Pin thermo = Pin.AnalogPin0;
        Pin motion = Pin.DigitalPin2;
        Pin buzzer = Pin.DigitalPin3;
        IButtonSensor button = DeviceFactory.Build.ButtonSensor(Pin.DigitalPin4);
        private static SerialComms uartComms;
        private string rfid = "";
        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);
        private int distance = 400;
        private bool detect = false;
        private bool press = false;
        double temp = 23;
        int truedistance;
        double truetemp;
        DataComms dataComms;
        string incoming = "";
        bool close = false;

        private void sleep(int s)
        {
            Task.Delay(s).Wait();
        }

        private int getDistance()
        {
            sm.WaitOne();
            int sensed = ultra.MeasureInCentimeters();
            sm.Release();
            if (sensed < 400 && sensed > 0)
                distance = sensed;
            return distance;
        }

        private int readtemp(Pin pin)
        {
            sm.WaitOne();
            int val = DeviceFactory.Build.GrovePi().AnalogRead(pin);
            sm.Release();
            return val;
        }

        private double getTemp()
        {
            int adcValue; double tempCalculated = 0, R;
            adcValue = readtemp(thermo);
            Debug.WriteLine(adcValue);
            int B = 4250, R0 = 100000;
            R = 100000 * (1023.0 - adcValue) / adcValue;
            tempCalculated = 1 / (Math.Log(R / R0) / B + 1 / 298.15) - 273.15;
            if (!Double.IsNaN(tempCalculated) && tempCalculated > 15 && tempCalculated < 40)
            {
                temp = tempCalculated;
            }
            Debug.WriteLine(temp);
            return temp;
        }

        private async void StartMotion()
        {
            await Task.Delay(100);
            while (true)
            {
                sleep(100);
                sm.WaitOne();
                string motionState = DeviceFactory.Build.GrovePi().DigitalRead(motion).ToString();
                sm.Release();
                if (motionState.Equals("1"))
                {
                    detect = true;
                    Task.Delay(100).Wait();
                }
            }
        }

        private string GetButton(IButtonSensor but)
        {
            sm.WaitOne();
            string butstate = button.CurrentState.ToString();
            sm.Release();
            return butstate;
        }

        private async void StartButton()
        {
            await Task.Delay(100);
            while (true)
            {
                sleep(100);
                string buttonstate = GetButton(button);
                if (buttonstate.Equals("On"))
                {
                    sleep(100);
                    buttonstate = GetButton(button);
                    if (buttonstate.Equals("On"))
                    {
                        press = true;
                    }
                }
            }
        }

        private void activateBuzzer(Pin pin, byte val)
        {
            sm.WaitOne();
            DeviceFactory.Build.GrovePi().AnalogWrite(pin, val);
            sm.Release();
        }

        private void buzzing()
        {
            activateBuzzer(buzzer, 60);
            sleep(80);
            activateBuzzer(buzzer, 120);
            sleep(80);
            activateBuzzer(buzzer, 60);
            sleep(80);
            activateBuzzer(buzzer, 120);
            sleep(80);
            activateBuzzer(buzzer, 0);
            sleep(2000);
        }

        private SensorStatus ledstatus(ILed led)
        {
            sm.WaitOne();
            SensorStatus sensorstate = led.CurrentState;
            sm.Release();
            return sensorstate;
        }

        private void changeled(ILed led, SensorStatus targetState)
        {
            sm.WaitOne();
            led.ChangeState(targetState);
            sm.Release();
        }

        private void redon()
        {
            changeled(red, SensorStatus.On);
            if (press == true)
            {
                press = false;
                curMode = 0;
            }
        }

        private void greenon()
        {
            changeled(green, SensorStatus.On);
            if (press == true)
            {
                press = false;
                curMode = 0;
            }
        }

        private void redoff()
        {
            changeled(red, SensorStatus.Off);
            if (press == true)
            {
                press = false;
                curMode = 1;
            }
        }

        private void greenoff()
        {
            changeled(green, SensorStatus.Off);
            if (press == true)
            {
                press = false;
                curMode = 1;
            }
        }

        private void Temp()
        {
            truetemp = getTemp();
            sendtowindows("Temp=" + truetemp);
        }

        private void UartDataHandler(Object sender, SerialComms.UartEventArgs e)
        {
            rfid = e.data;
            Debug.WriteLine("Card Detected: " + rfid);
        }
        private void StartUart()
        {
            uartComms = new SerialComms();
            uartComms.UartEvent += new SerialComms.UartEventDelegate(UartDataHandler);
        }

        public void commsDataReceive(string dataReceived)
        {
            incoming = dataReceived;
            Debug.WriteLine("Data Received : " + incoming);
        }

        private void sendtowindows(string outgoing)
        {
            try
            {
                dataComms.sendData(outgoing);
                Debug.WriteLine("Sending Msg : " + outgoing);
            }
            catch (Exception)
            {
                Debug.WriteLine("ERROR. Did you forget to initComms()?");
            }
        }

        private void initComms()
        {
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
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
            initComms();
            StartUart();
            StartMotion();
            StartButton();
            activateBuzzer(buzzer, 0);
            redoff();
            greenoff();
            while (true)
            {
                sleep(300);
                if (incoming.Equals("GIBTEMP"))
                {
                    incoming = "";
                    Temp();
                }
                //truedistance = getDistance();
                //if (truedistance < 20)
                //{
                //    close = true;
                //    sendtowindows("Close=" + close);
                //    close = false;
                //}
                //else
                //{
                //    sendtowindows("Close=" + close);
                //}
                if (incoming.Equals("GIBMOVE"))
                {
                    bool truedetect = detect;
                    detect = false;
                    incoming = "";
                    sendtowindows("Detect=" + truedetect);
                    if (truedetect == true)
                    {
                        truedetect = false;
                        curMode = 1;
                        while (curMode == 1)
                        {
                            redon();
                            buzzing();
                        }
                    }
                    greenon();
                    truedetect = false;
                }
                    if (rfid != "")
                    {
                        sendtowindows("RFID=" + rfid);
                        rfid = "";
                    }
                    if (press == true)
                    {
                        press = false;
                        if (curMode == 1)
                        {
                            curMode = 0;
                            redoff();
                            greenon();
                        }
                        else if (curMode == 0)
                        {
                            curMode = 1;
                            greenoff();
                            redon();
                        }
                    }
                    if (incoming.Equals("Stoppls"))
                    {
                        incoming = "";
                        if (curMode == 1)
                        {
                            curMode = 0;
                            redoff();
                            greenon();
                    }
                    }
                    if (incoming.Equals("ModePls"))
                    {
                        incoming = "";
                        sendtowindows("mode=" + curMode);
                    }
                }
            }

        }
    }