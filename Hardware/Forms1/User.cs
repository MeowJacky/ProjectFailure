using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Forms1
{
    public partial class User : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        DataComms dataComms;
        string rfidnum;

        public delegate void myprocessDataDelegate(string strData);

        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            Console.WriteLine(result);
            return result;
        }

        private string handelRFID(string strData, string ID)
        {
            rfidnum = extractStringValue(strData, ID);
            Console.WriteLine(rfidnum);
            return rfidnum;
        }

        public void extractSensorData(string strData)
        {
            if (strData.IndexOf("RFID=") != -1)
                handelRFID(strData, "RFID=");

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
            dataComms = new DataComms();
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }

        private string username;
        public User(string username)
        {
            InitializeComponent();
            this.username = username;

            userusername.Text = username;

            ClockButton.Click += ClockButton_Click;

            DisplayClockStatus();
        }

        private void DisplayClockStatus()
        {
            string query = "SELECT ClockIn FROM Admins WHERE Name = @Username"; // Query to retrieve ClockIn status by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    int clockInStatus = Convert.ToInt32(command.ExecuteScalar());

                    if (clockInStatus == 0)
                    {
                        label1.Text = "You have not clocked in";
                        ClockButton.Text = "Clock In";
                    }
                    else if (clockInStatus == 1)
                    {
                        label1.Text = "You are currently clocked in";
                        ClockButton.Text = "Clock Out";
                    }
                }
            }
        }

        //private void ClockButton_Click(object sender, EventArgs e)
        //{
        //    int currentStatus = GetCurrentClockStatus();

        //    if (currentStatus == 0)
        //    {
        //        if (currentStatus == 0)
        //        {
        //            DateTime currentTime = DateTime.Now;
        //            TimeSpan lateStartTime = new TimeSpan(9, 0, 0);
        //            TimeSpan lateEndTime = new TimeSpan(7, 59, 59);
        //            TimeSpan targetTime = new TimeSpan(8, 0, 0);

        //            if ((currentTime.TimeOfDay >= lateStartTime && currentTime.TimeOfDay <= TimeSpan.FromHours(24)) ||
        //                (currentTime.TimeOfDay >= TimeSpan.Zero && currentTime.TimeOfDay <= lateEndTime))
        //            {
        //                TimeSpan lateDuration = currentTime.TimeOfDay - targetTime;
        //                if (lateDuration < TimeSpan.Zero)
        //                {
        //                    lateDuration = TimeSpan.FromHours(24) + lateDuration; //Adding a day for it to be positive
        //                }

        //                int lateHours = (int)lateDuration.TotalHours;
        //                int lateMinutes = lateDuration.Minutes;

        //                string lateMessage = "You are late by " + lateHours + " hours and " + lateMinutes + " minutes!";
        //                MessageBox.Show(lateMessage);
        //                UpdateClockStatus(1);
        //            }

        //        }
        //    }
        //    else
        //    {
        //        UpdateClockStatus(0);
        //    }

        //    DisplayClockStatus(); // Update UI to reflect the new clock-in status
        //}

        private void ClockButton_Click(object sender, EventArgs e)
        {
            int currentStatus = GetCurrentClockStatus();

            // Assuming that RFID data is received and processed in processDataReceive method
            // You can modify this part based on your actual RFID data handling

            // Check if the scanned RFID matches the RFID of the logged-in user

            if (currentStatus == 0)
            {
                Console.WriteLine(rfidnum);
                Console.WriteLine(IsRFIDMatch(rfidnum));
                if (IsRFIDMatch(rfidnum))
                {
                    rfidnum = "";
                    DateTime currentTime = DateTime.Now;
                    TimeSpan lateStartTime = new TimeSpan(9, 0, 0);
                    TimeSpan lateEndTime = new TimeSpan(7, 59, 59);
                    TimeSpan targetTime = new TimeSpan(8, 0, 0);

                    if ((currentTime.TimeOfDay >= lateStartTime && currentTime.TimeOfDay <= TimeSpan.FromHours(24)) ||
                        (currentTime.TimeOfDay >= TimeSpan.Zero && currentTime.TimeOfDay <= lateEndTime))
                    {
                        TimeSpan lateDuration = currentTime.TimeOfDay - targetTime;
                        if (lateDuration < TimeSpan.Zero)
                        {
                            lateDuration = TimeSpan.FromHours(24) + lateDuration; // Adding a day for it to be positive
                        }

                        int lateHours = (int)lateDuration.TotalHours;
                        int lateMinutes = lateDuration.Minutes;

                        string lateMessage = "You are late by " + lateHours + " hours and " + lateMinutes + " minutes!";
                        MessageBox.Show(lateMessage);
                        UpdateClockStatus(1);
                    }
                }
                else
                {
                    MessageBox.Show("RFID does not match the logged-in user.");
                }
            }
            else
            {
                UpdateClockStatus(0);

            }
            DisplayClockStatus(); // Update UI to reflect the new clock-in status
        }

        private int GetCurrentClockStatus()
        {
            string query = "SELECT ClockIn FROM Admins WHERE Name = @Username"; // Query to retrieve ClockIn status by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void UpdateClockStatus(int status)
        {
            string updateQuery = "UPDATE Admins SET ClockIn = @Status WHERE Name = @Username"; // Update ClockIn status by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool IsRFIDMatch(string scannedRFIDData)
        {
            // Query to retrieve the RFID of the logged-in user
            string query = "SELECT UniqueRFID FROM Admins WHERE Name = @Username";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    // Retrieve the RFID value of the logged-in user from the database
                    string userRFIDValue = Convert.ToString(command.ExecuteScalar());

                    // Compare the scanned RFID value with the user's RFID value
                    return scannedRFIDData == userRFIDValue;
                }
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            InitComms();
        }

        private void userusername_Click(object sender, EventArgs e)
        {
            ManageUser userProfile = new ManageUser(this.username);
            userProfile.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void projectWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void username_MouseHover(object sender, EventArgs e)
        {
            userusername.BackColor = Color.Red;
        }

        private void userusername_MouseEnter(object sender, EventArgs e)
        {
            userusername.BackColor = Color.Red;
        }

        private void userusername_MouseLeave(object sender, EventArgs e)
        {
            userusername.BackColor = Color.White;
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
