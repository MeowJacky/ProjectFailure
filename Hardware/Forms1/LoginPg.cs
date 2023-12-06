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


        public LoginPg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Step 1: Open Connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            //Step 2: Create command
            string strCommandText = "SELECT Name, Password FROM Admins";
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
                    
                    AdminPg frm = new AdminPg();
                    frm.ShowDialog();

                }
                else

                    MessageBox.Show("Incorrect Username or Password");
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
    }

}