﻿using System;
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
                    MessageBox.Show("Login Successful");
                    int userAuthority = Convert.ToInt32(reader["Authority"]);
                    if (userAuthority == 999)
                    {
                        User userform = new User(tbUserName.Text);
                        userform.Show();
                    }
                    else
                    {
                        Admin adminform = new Admin(tbUserName.Text);
                        adminform.Show();



                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Fail");
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

        private void LoginPg_Load(object sender, EventArgs e)
        {

        }
    }

}