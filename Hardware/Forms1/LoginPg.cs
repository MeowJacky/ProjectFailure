using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Forms1
{
    public partial class LoginPg : Form
    {

        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        //HENG LE PC DONT LIKE DATACOMMS
        //DataComms dataComms = DataCommsHelper.GetDataCommsInstance();
        string rfidnum;

        //public delegate void myprocessDataDelegate(string strData);
        private DBTempUpdate temperatureUpdateService;
        private DBOffHoursDetect intrusionDetectionService;
        private DBUserTempUpdate UserTempService;

        //private string extractStringValue(string strData, string ID)
        //{
        //    string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
        //    Console.WriteLine(result);
        //    return result;
        //}
        //private string handelRFID(string strData, string ID)
        //{
        //    rfidnum = extractStringValue(strData, ID);
        //    Console.WriteLine(rfidnum);
        //    return rfidnum;
        //}

        //public void extractSensorData(string strData)
        //{
        //    if (strData.IndexOf("RFID=") != -1)
        //        handelRFID(strData, "RFID=");

        //}

        //public void processDataReceive(string strData)
        //{
        //    myprocessDataDelegate d = new myprocessDataDelegate(extractSensorData);
        //    d(strData);
        //}

        //public void commsdatareceive(string datareceived)
        //{
        //    processDataReceive(datareceived);
        //}

        //public void commsSendError(string errMsg)
        //{
        //    MessageBox.Show(errMsg);
        //    processDataReceive(errMsg);
        //}

        //private void InitComms()
        //{
        //    dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
        //    dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        //}


        public LoginPg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Step 1: Open Connection
            try
            {
                // Code that interacts with the database
                SqlConnection myConnect = new SqlConnection(strConnectionString);

                //Step 2: Create command
                string strCommandText = "SELECT Name, Password, Authority FROM Admins";
                //Add a WHERE clause to SQL statement
                strCommandText += " WHERE Name=@uname AND Password=@pwd";
                SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
                cmd.Parameters.AddWithValue("@uname", tbUserName.Text);
                cmd.Parameters.AddWithValue("@pwd", tbPassword.Text);

                try
                {
                    //Step 3: Open connection and retrieve data by calling ExecuteReader
                    myConnect.Open();

                    //Step 4: Access data
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() && (tbUserName.Text == (reader["Name"]).ToString()))
                    {
                        // Login Successful
                        MessageBox.Show("Login Successful");

                        // Record login attempt to LoginLogs table
                        RecordLogin(tbUserName.Text, "Login", "Yes");
                        Console.WriteLine("1");
                        int userAuthority = Convert.ToInt32(reader["Authority"]);
                        Console.WriteLine("2");
                        if (userAuthority == 999)
                        {
                            Console.WriteLine("3");
                            User userform = new User(tbUserName.Text);
                            SessionID sessionId = SessionID.Instance;
                            sessionId.SetID(tbUserName.Text);
                            

                            userform.Show();
                        }
                        else
                        {
                            Console.WriteLine("4");
                            Admin adminform = new Admin(tbUserName.Text, userAuthority);
                            adminform.Show();
                            Console.WriteLine(userAuthority);
                            SessionID sessionId = SessionID.Instance;
                            sessionId.SetID(tbUserName.Text, userAuthority);
                        }

                        this.Hide();
                    }
                    else
                    {
                        // Login Fail
                        MessageBox.Show("Login Fail");

                        // Record failed login attempt to LoginLogs table
                        RecordLogin(tbUserName.Text, "Login", "No");
                    }

                    //Step 5: Close connection
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
                finally
                {
                    //Step 5: Close connection
                    
                    myConnect.Close();
                }
            }
            catch (SqlException ex)
            {
                // Log the exception details
                Console.WriteLine($"SQL Exception: {ex.Message}");
                // You can also log additional details like ex.StackTrace, ex.Number, etc.
            }
        }


        private void RecordLogin(string userName, string loginStatus, string success)
        {
            string insertQuery = "INSERT INTO LoginLogs ([Time], [UserName], [Login/Out], [Success]) VALUES (@time, @userName, @loginStatus, @success)";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                connection.Open();

                cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = userName;
                cmd.Parameters.Add("@loginStatus", SqlDbType.VarChar, 50).Value = loginStatus;
                cmd.Parameters.Add("@success", SqlDbType.NChar, 10).Value = success;

                cmd.ExecuteNonQuery();
            }
        }


        private void LoginPg_Load(object sender, EventArgs e)
        {
            temperatureUpdateService = new DBTempUpdate();
            temperatureUpdateService.UpdateTemperatureDB();

            //intrusionDetectionService = new DBOffHoursDetect();
            //intrusionDetectionService.UpdateIntrusionDB();

            //UserTempService = new DBUserTempUpdate();
            //UserTempService.UpdateTemperature();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void forgetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass forgetform = new ForgetPass();
            forgetform.Show();

        }

        //Below is some dumb code
        private void button1_Click_1(object sender, EventArgs e)
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
                    //dataComms.dataReceiveEvent -= commsdatareceive;
                    //dataComms.dataSendErrorEvent -= commsSendError;
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
                //else
                //{
                //    MessageBox.Show("RFID does not match the logged-in user.");
                //}
            }
            else
            {
                UpdateClockStatus(0);

            }

            RedirectBasedOnPriority();
        }
        private void RedirectBasedOnPriority()
        {
            // Query to retrieve the authority and name of the logged-in user
            string query = "SELECT Authority, Name FROM Admins WHERE UniqueRFID = @RFID";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RFID", textBox1.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userAuthority = Convert.ToInt32(reader["Authority"]);
                            string username = reader["Name"].ToString();

                            // Redirect to the respective page based on the priority
                            if (userAuthority >= 1 && userAuthority <= 4)
                            {
                                // Admin
                                Admin adminPage = new Admin(username, userAuthority);
                                adminPage.Show();
                                Console.WriteLine(userAuthority);
                                SessionID sessionId = SessionID.Instance;
                                sessionId.SetID(textBox1.Text, userAuthority);
                                
                            }
                            else if (userAuthority == 999)
                            {
                                // User
                                User userPage = new User(username);
                                SessionID sessionId = SessionID.Instance;
                                sessionId.SetID(username);
                                userPage.Show();
                            }

                            this.Hide();
                        }
                    }
                }
            }
        }
        private int GetCurrentClockStatus()
        {
            string query = "SELECT ClockIn FROM Admins WHERE UniqueRFID = @RFID"; // Query to retrieve ClockIn status by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RFID", textBox1.Text);

                    connection.Open();

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void UpdateClockStatus(int status)
        {
            string updateQuery = "UPDATE Admins SET ClockIn = @Status WHERE UniqueRFID = @RFID"; // Update ClockIn status by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@RFID", textBox1.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool IsRFIDMatch(string scannedRFIDData)
        {
            // Query to retrieve the RFID of the logged-in user
            string query = "SELECT UniqueRFID FROM Admins WHERE UniqueRFID = @RFID";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RFID", textBox1.Text);

                    connection.Open();

                    // Retrieve the RFID value of the logged-in user from the database
                    string userRFIDValue = Convert.ToString(command.ExecuteScalar());

                    // Compare the scanned RFID value with the user's RFID value
                    return scannedRFIDData == userRFIDValue;
                }
            }
        }
    }


}

