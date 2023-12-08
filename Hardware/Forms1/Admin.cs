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

            AUsername.Text = username;
            PopulateChartData();

        }

        private void PopulateChartData()
        {
            try
            {
                // Clear existing series from the chart
                clockin.Series.Clear();

                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    string query = "SELECT ClockIn, COUNT(*) AS Count FROM Admins GROUP BY ClockIn";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a series for the chart
                            Series series = new Series("Clock In Status");
                            series.ChartType = SeriesChartType.Column;

                            while (reader.Read())
                            {
                                int clockInValue = Convert.ToInt32(reader["ClockIn"]);
                                int count = Convert.ToInt32(reader["Count"]);

                                // Set color based on ClockIn value
                                Color barColor = clockInValue == 0 ? Color.Red : Color.Blue;

                                // Add a data point to the series with the specified color
                                series.Points.Add(count);

                                // Set the data point label to indicate present or not present
                                series.Points.Last().AxisLabel = clockInValue == 1 ? "Present" : "Not Present";

                                // Set the color of the data point
                                series.Points.Last().Color = barColor;

                                // Attach data to the data point for later use
                                series.Points.Last().Tag = clockInValue;
                            }

                            // Set the X-axis labels to admin names
                            clockin.ChartAreas[0].AxisX.Interval = 1;
                            clockin.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

                            // Set the Y-axis labels with the desired interval
                            clockin.ChartAreas[0].AxisY.Interval = 1; // Assuming one unit per person
                            clockin.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                            clockin.MouseUp += Clockin_MouseClick;

                            // Check if the series has data before adding it to the chart
                            if (series.Points.Count > 0)
                            {
                                // Add the series to the chart
                                clockin.Series.Add(series);
                            }
                            else
                            {
                                // Handle the case where the series is empty
                                MessageBox.Show("No data to display in the chart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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

        private void Clockin_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the clicked data point
            HitTestResult result = clockin.HitTest(e.X, e.Y);

            if (result.Series != null && result.PointIndex >= 0)
            {
                // Check if the clicked bar represents "Present"
                int clockInValue = Convert.ToInt32(result.Series.Points[result.PointIndex].Tag);

                if (clockInValue == 1)
                {
                    // Open another WinForm (replace FormToOpen with your actual form)
                    present form = new present();
                    form.ShowDialog(); // Use ShowDialog to make it a modal form
                }
                else
                {
                    notpresent form = new notpresent();
                    form.ShowDialog(); // Use ShowDialog to make it a modal form

                }
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

        private void Admin_Load_1(object sender, EventArgs e)
        {

        }

        private void debug_Click(object sender, EventArgs e)
        {

        }

        private void editclockin_Click(object sender, EventArgs e)
        {
            editclockin form = new editclockin();
            form.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
