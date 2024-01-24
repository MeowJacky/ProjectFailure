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
    public partial class ClockOut : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        DataComms dataComms = DataCommsHelper.GetDataCommsInstance();
        string rfidnum;
        public ClockOut()
        {
            InitializeComponent();
            label8.Visible = false;
            label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RFID_textbox_TextChanged(object sender, EventArgs e)
        {

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

                if (currentStatus == 1)
                {
                    UpdateClockStatus(0);
                    Displayuserinfo(rfid);
                }
                else
                {
                    MessageBox.Show("How did you even get to this page bruh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid RFID. Please enter a valid RFID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionID sessionId = SessionID.Instance;
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
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

        private void Displayuserinfo(string rfid)
        {
            // Fetch user information from the database based on the RFID
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string strCommandText = "SELECT Name FROM Admins WHERE UniqueRFID = @RFID";

                SqlCommand cmd = new SqlCommand(strCommandText, connection);
                cmd.Parameters.AddWithValue("@RFID", rfid);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Update your UI with user information
                    label2.Text = reader["Name"].ToString();
                    label2.Visible = true;
                    label8.Visible = true;
                }
                reader.Close();
                connection.Close();
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

        private void ClockOut_Load(object sender, EventArgs e)
        {

        }
    }
}
