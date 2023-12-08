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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;



namespace Forms1
{
    public partial class editclockin : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        public editclockin()
        {
            InitializeComponent();
        }

        private void editclockin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Retrieve_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlConnection connection = new SqlConnection(strConnectionString);
            connection.Open();

            using (SqlCommand cmd = new SqlCommand("SELECT Contact, Department, ClockIn FROM Admins WHERE Name = @Name", connection))
            {
                cmd.Parameters.AddWithValue("@Name", name);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        PhonePlaceholder.Text = reader["Contact"].ToString();
                        DepartmentPlaceholder.Text = reader["Department"].ToString();

                        if (Convert.ToInt32(reader["ClockIn"]) == 1)
                        {
                            Clockedin.Checked = true;
                            Clockedin.Text = "Clocked In";
                        }
                        else
                        {
                            Clockedin.Checked = false;
                            Clockedin.Text = "Not Clocked In";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data not found for the specified name.");
                        // Clear UI controls if data is not found
                        PhonePlaceholder.Text = string.Empty;
                        DepartmentPlaceholder.Text = string.Empty;
                        Clockedin.Checked = false;
                        Clockedin.Text = "No Data";

                    }
                }
            }
        }

        private void Clockedin_CheckedChanged(object sender, EventArgs e)
        {
            if (Clockedin.Checked)
            {
                Clockedin.Text = "Clocked In";
            }
            else
            {
                Clockedin.Text = "Not Clocked In";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            // Get the values from the UI controls
            string name = textBox1.Text;
            string contact = PhonePlaceholder.Text;
            string department = DepartmentPlaceholder.Text;
            int clockin = Clockedin.Checked ? 1 : 0;

            // Update the database
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Admins SET ClockIn = @ClockIn WHERE Name = @Name";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.Add("@ClockIn", SqlDbType.Int).Value = clockin;
                    updateCmd.Parameters.AddWithValue("@Name", name);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
            }
        }

    }
}
