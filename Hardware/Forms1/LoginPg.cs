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
        DataComms dataComms = DataCommsHelper.GetDataCommsInstance();
        string rfidnum;

        public delegate void myprocessDataDelegate(string strData);
        private DBTempUpdate temperatureUpdateService;
        private DBOffHoursDetect intrusionDetectionService;

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
            dataComms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
            dataComms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }


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

                    if (reader.Read())
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
                cmd.Parameters.Add("@success", SqlDbType.VarChar, 3).Value = success;

                cmd.ExecuteNonQuery();
            }
        }


        private void LoginPg_Load(object sender, EventArgs e)
        {
            //temperatureUpdateService = new DBTempUpdate();
            //temperatureUpdateService.UpdateTemperatureDB();

            //intrusionDetectionService = new DBOffHoursDetect();
            //intrusionDetectionService.UpdateIntrusionDB();

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
    }

}

