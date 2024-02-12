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
using System.Globalization;

namespace Forms1
{
    public partial class adminquota : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        public adminquota()
        {
            InitializeComponent();
            LoadChartData();
            ClockDate.Value = DateTime.Now;
        }
        private void adminquota_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }
        private void LoadChartData(DateTime date = default(DateTime))
        {
            chart1.Series.Clear();

            if (date == default(DateTime))
            {
                date = DateTime.Now.Date;
            }
            else
            {
                date = date.Date;
                ClockDate.Value = date;
            }

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                string query = $"SELECT w.WorkerName, COUNT(q.CompletedPackingID) AS CompletedQuotaCount " +
                       $"FROM WorkerAssigned w " +
                       $"LEFT JOIN Quota q ON w.PackingID = q.CompletedPackingID AND CONVERT(DATE, q.CompletedDate) = @CompletedDate " +
                       $"WHERE w.IsCompleted = 1 " +
                       $"GROUP BY w.WorkerName";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@CompletedDate", date);

                    // Create a new series for the chart
                    Series newSeries = new Series("Completed Quota Count");
                    newSeries.ChartType = SeriesChartType.Column;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string workerName = reader["WorkerName"].ToString();
                            int completedQuotaCount = Convert.ToInt32(reader["CompletedQuotaCount"]);

                            // Add data point to the new series with the count
                            newSeries.Points.AddXY(workerName, completedQuotaCount);
                        }
                    }

                    // Customize the color or other properties if needed
                    // Add the new series to the chart
                    chart1.Series.Add(newSeries);
                }
            }

            // Customize the chart appearance if needed
            if (chart1.Titles.Count == 0)
            {
                chart1.Titles.Add("Completed Quota Chart");
            }
            chart1.ChartAreas[0].AxisY.Title = "Completed Quota Count";
            chart1.ChartAreas[0].AxisX.Title = "Worker Name";
        }






        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime date = ClockDate.Value;
            LoadChartData(date);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
