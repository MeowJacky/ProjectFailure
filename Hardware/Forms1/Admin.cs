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
using System.Windows.Forms.DataVisualization.Charting;

namespace Forms1
{
    public partial class Admin : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        private string username;
        public Admin(string username)
        {
            InitializeComponent();
            this.username = username;

            adminusername.Text = username;
            PopulateChartData();

        }

        private void PopulateChartData()
        {
            try
            {
                // Clear existing series from the chart
                ClockedIn.Series.Clear();

                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Name, ClockIn FROM Admins";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a series for the chart
                            Series series = new Series("Clock In Status");
                            series.ChartType = SeriesChartType.Bar;

                            while (reader.Read())
                            {
                                string adminName = reader["Name"].ToString();

                                byte[] clockInBytes = (byte[])reader["ClockIn"];
                                byte clockInValue = clockInBytes[0];

                                // Add a data point to the series
                                series.Points.AddXY(adminName, Convert.ToInt32(clockInValue));
                            }





                            // Add the series to the chart
                            ClockedIn.Series.Add(series);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error populating chart data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAdmin manage = new ManageAdmin(this.username);
            manage.Show();
            this.Close();
        }
    }
}
