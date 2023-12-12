﻿using System;
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

        private string username;
        public User(string username)
        {
            InitializeComponent();
            this.username=username;

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

        private void ClockButton_Click(object sender, EventArgs e)
        {
            int currentStatus = GetCurrentClockStatus();

            if (currentStatus == 0)
            {
                UpdateClockStatus(1); // Clock In
            }
            else
            {
                UpdateClockStatus(0); // Clock Out
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
    
    private void User_Load(object sender, EventArgs e)
        {

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
    }
}
