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
    public partial class ClockIn : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        DataComms dataComms = DataCommsHelper.GetDataCommsInstance();
        string rfidnum;
        public ClockIn()
        {
            InitializeComponent();
            label2.Visible = false;
            label8.Visible = false;
        }

        private void ClockIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionID sessionId = SessionID.Instance;
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string rfid = RFID_textbox.Text;

            if (string.IsNullOrEmpty(rfid))
            {
                MessageBox.Show("Please enter a valid RFID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateRFID(rfid))
            {
                int currentStatus = GetCurrentClockStatus();
                Console.WriteLine("stat=" + currentStatus);

                if (currentStatus == 0)
                {
                    DateTime currentTime = DateTime.Now;
                    TimeSpan lateStartTime = new TimeSpan(9, 0, 0);
                    TimeSpan lateEndTime = new TimeSpan(7, 59, 59);
                    TimeSpan targetTimeStart = new TimeSpan(8, 0, 0);
                    TimeSpan targetTimeEnd = new TimeSpan(8, 30, 0);

                    TimeSpan currentTimeOfDay = currentTime.TimeOfDay;

                    // Check if the current time falls within the allowed clock-in time range
                    if ((currentTimeOfDay >= targetTimeStart && currentTimeOfDay <= targetTimeEnd) ||
                        (currentTime.TimeOfDay >= lateStartTime && currentTime.TimeOfDay <= TimeSpan.FromHours(24)) ||
                        (currentTime.TimeOfDay >= TimeSpan.Zero && currentTime.TimeOfDay <= lateEndTime))
                    {
                        if (!(currentTimeOfDay >= targetTimeStart && currentTimeOfDay <= targetTimeEnd))
                        {
                            TimeSpan lateDuration = currentTime.TimeOfDay - targetTimeStart;

                            // Check if lateDuration is negative, adjust accordingly
                            if (lateDuration < TimeSpan.Zero)
                            {
                                lateDuration = TimeSpan.FromHours(24) + lateDuration; // Add a day to make it positive
                            }

                            int lateHours = (int)lateDuration.TotalHours;
                            int lateMinutes = lateDuration.Minutes;

                            string lateMessage = "You are late by " + lateHours + " hours and " + lateMinutes + " minutes!";
                            MessageBox.Show(lateMessage);
                        }

                        Displayuserinfo(rfid);
                        UpdateClockStatus(1);
                    }
                }
                else
                {
                    MessageBox.Show("User is already clocked in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid RFID. Please enter a valid RFID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateRFID(string rfid)
        {
            string query = "SELECT COUNT(*) FROM Admins WHERE UniqueRFID = @RFID";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RFID", rfid);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    return count > 0; // If count > 0, the RFID exists; otherwise, it does not exist
                }
            }
        }

        private void Displayuserinfo(string rfid)
        {
            // Fetch user information from the database based on the RFID
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string strCommandText = "SELECT Name, Department,NRIC,UniqueUserID,Contact,Email FROM Admins WHERE UniqueRFID = @RFID";

                SqlCommand cmd = new SqlCommand(strCommandText, connection);
                cmd.Parameters.AddWithValue("@RFID", rfid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Update your UI with user information
                    label2.Text = reader["Name"].ToString();
                    label10.Text = reader["Department"].ToString();
                    label13.Text = reader["UniqueUserID"].ToString();
                    label12.Text = reader["NRIC"].ToString();
                    label11.Text  = reader["Contact"].ToString();
                    label9.Text = reader["Email"].ToString();
                    label2.Visible = true;
                    label8.Visible = true;
                }
                reader.Close();
                connection.Close();
            }

        }

        private int GetCurrentClockStatus()
        {
            string query = "SELECT ClockIn FROM Admins WHERE UniqueRFID = @RFID"; 

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RFID", RFID_textbox.Text);

                    connection.Open();

                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }
        private void UpdateClockStatus(int status)
        {
            string updateQuery = "UPDATE Admins SET ClockIn = @Status WHERE UniqueRFID=@RFID"; // Update ClockIn status by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@RFID", RFID_textbox.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset_Values();
        }
        private void Reset_Values()
        {
            RFID_textbox.Text = "";

            // Hide labels
            label8.Visible = false;
            label2.Visible = false;
            label10.Text = "";
            label13.Text = "";
            label12.Text = "";
            label11.Text = "";
            label9.Text = "";
        }
    }
}
