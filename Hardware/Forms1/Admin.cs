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
    public partial class Admin : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private DBTempUpdate temperatureUpdateService;

        private string username;
        private int loggedInAdminAuthority;
        public Admin(string username, int authority)
        {
            InitializeComponent();
            this.username = username;
            loggedInAdminAuthority = authority;
            AUsername.Text = username;
            PopulateChartData();
            TemperaturePopulateChartData();
            PopulateIntrusionChartData();
            LoadData();
            if (username == "")
            {
                SessionID IDCheck = SessionID.Instance;
                this.username = IDCheck.RetrieveID();
                AUsername.Text = IDCheck.RetrieveID();
            }
            timer1.Interval = 1000;
            timer1.Enabled = true;
            UpdateLabelText();
        }

        private void UpdateLabelText()
        {
            if (CheckBuzzer())
            {
                BuzzerCheck.Text = "Buzzer is active";
            }
            else
            {
                BuzzerCheck.Text = "Buzzer is not active";
            }
        }
        private void TemperaturePopulateChartData(DateTime ChangeMax = default(DateTime))
        {
            try
            {
                // Clear existing series from the chart
                TemperatureChart.Series.Clear();

                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();
                    string query;
                    // Use your actual table name and column names
                    if (ChangeMax != default(DateTime))
                    {
                        // If ChangeMax is provided, use it as a filter in the WHERE clause
                        query = $"SELECT TOP 36 Time, Temp FROM Temperature WHERE Time <= '{ChangeMax.ToString("yyyy-MM-dd HH:mm:ss")}' ORDER BY Time DESC";
                    }
                    else
                    {
                        // If ChangeMax is not provided, retrieve the top 36 records without a filter
                        query = "SELECT TOP 36 Time, Temp FROM Temperature ORDER BY Time DESC";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a series for the chart
                            Series series = new Series("Temperature");
                            series.ChartType = SeriesChartType.Line; // Assuming you want a line chart for temperature

                            while ((reader.Read()))
                            {
                                DateTime time = Convert.ToDateTime(reader["Time"]);
                                float temperature = Convert.ToSingle(reader["Temp"]);

                                // Add a data point to the series
                                series.Points.AddXY(time, temperature);

                            }

                            // Set the X-axis labels to time values
                            TemperatureChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss"; // Adjust the format as needed


                            if (TemperatureChart.Titles.Count == 0)
                            {
                                Title chartTitle = new Title();
                                chartTitle.Text = "Temperature Chart";
                                chartTitle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                                TemperatureChart.Titles.Add(chartTitle);
                            }
                            TemperatureChart.ChartAreas[0].AxisY.Minimum = double.NaN;
                            TemperatureChart.ChartAreas[0].AxisY.Maximum = double.NaN;
                            TemperatureChart.ChartAreas[0].RecalculateAxesScale();

                            SetDateTemp.Value = DateTime.Now;



                            // Check if the series has data before adding it to the chart
                            if (series.Points.Count > 0)
                            {
                                // Add the series to the chart
                                TemperatureChart.Series.Add(series);
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
                MessageBox.Show($"Error populating temperature chart data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateIntrusionChartData(DateTime IntrusionDateSelector = default(DateTime))
        {
            try
            {
                // Clear existing series from the chart
                IntrusionChart.Series.Clear();

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString))
                {
                    connection.Open();
                    string query;
                    if (IntrusionDateSelector == default(DateTime))
                    {
                        query = "SELECT CONVERT(DATE, Time) AS IntrusionDate, COUNT(*) AS IntrusionCount FROM Detection GROUP BY CONVERT(DATE, Time) ORDER BY IntrusionDate DESC";

                    }
                    else
                    {
                        query = $"SELECT CONVERT(DATE, Time) AS IntrusionDate, COUNT(*) AS IntrusionCount FROM Detection WHERE CONVERT(DATE, Time) = '{IntrusionDateSelector.ToString("yyyy-MM-dd")}' GROUP BY CONVERT(DATE, Time) ORDER BY IntrusionDate DESC";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a series for the chart
                            Series series = new Series("Intrusion Events");
                            series.ChartType = SeriesChartType.Column;

                            while (reader.Read())
                            {
                                DateTime intrusionDate = Convert.ToDateTime(reader["IntrusionDate"]);
                                int intrusionCount = Convert.ToInt32(reader["IntrusionCount"]);

                                // Add a data point to the series with the specified count
                                series.Points.Add(intrusionCount);

                                // Set the data point label to indicate the count of intrusions for the day
                                series.Points.Last().AxisLabel = $"{intrusionDate.ToString("MM/dd/yyyy")}\n({intrusionCount} intrusions)";
                            }

                            IntrusionChart.ChartAreas[0].AxisY.Minimum = double.NaN;
                            IntrusionChart.ChartAreas[0].AxisY.Maximum = double.NaN;
                            IntrusionChart.ChartAreas[0].RecalculateAxesScale();

                            

                            // Customize the chart appearance and labels based on your requirements
                            if (IntrusionChart.Titles.Count == 0)
                            {
                                Title chartTitle = new Title();
                                chartTitle.Text = "Intrusion Chart";
                                chartTitle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                                IntrusionChart.Titles.Add(chartTitle);
                            }
                            // Check if the series has data before adding it to the chart
                            if (series.Points.Count > 0)
                            {
                                // Add the series to the chart
                                IntrusionChart.Series.Add(series);
                                //IntrusionChart.MouseUp -= IntrusionChart_Click;
                                //IntrusionChart.MouseUp += IntrusionChart_Click;
                                IntrusionChart.MouseClick -= IntrusionChart_MouseClick;
                                IntrusionChart.MouseClick += IntrusionChart_MouseClick;
                            }
                            else
                            {
                                // Handle the case where the series is empty
                                MessageBox.Show("No intrusion events to display in the chart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error populating intrusion chart data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            clockin.ChartAreas[0].AxisY.Interval = 1;
                            clockin.ChartAreas[0].AxisY.Minimum = 0; // Set based on your data
                            clockin.ChartAreas[0].AxisY.Maximum = databaserows(); // Set based on your data
                            Console.WriteLine(databaserows());


                            clockin.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

                            clockin.MouseUp -= Clockin_MouseClick;
                            clockin.MouseUp += Clockin_MouseClick;

                            


                            if (clockin.Titles.Count == 1) //idk why its 1 i think i messed with the properties
                            {
                                Title chart1Title = new Title();
                                chart1Title.Text = "Employee Clock In";
                                chart1Title.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                                clockin.Titles.Add(chart1Title);
                                Console.WriteLine("clockin title added");
                            }
                            



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
        private int databaserows()
        {
            int rowCount = 0;

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Admins";
    
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    rowCount = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return rowCount;
        }

        private void Clockin_MouseClick(object sender, MouseEventArgs e)
        {
            // Get the clicked data point
            HitTestResult result = clockin.HitTest(e.X, e.Y);

            if (result.Series != null && result.PointIndex >= 0)
            {
                // Check if the clicked bar represents "Present"
                Console.WriteLine(result.Series.Points[result.PointIndex].Tag);
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
            SetDateTemp.Value = DateTime.Now;

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
            string userid = "0";
            ManageAdmin manage = new ManageAdmin(this.username,userid, loggedInAdminAuthority);
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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAllUsers allusers = new ViewAllUsers(this.username, loggedInAdminAuthority);
            allusers.Show();
            this.Close();
        }

        private void currentAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userid = "0";
            ManageAdmin manage = new ManageAdmin(this.username, userid, loggedInAdminAuthority);
            manage.Show();
            this.Close();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin addmin = new AddAdmin(this.username, loggedInAdminAuthority);
            addmin.Show();
            this.Close();
        }

        private void addAdminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddAdmin addmin = new AddAdmin(this.username, loggedInAdminAuthority);
            addmin.Show();
            this.Close();
        }

        private void AUsername_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            PopulateChartData();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clockin_Click(object sender, EventArgs e)
        {

        }

        private void historialDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temperatureLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void RefreshTempData_Click(object sender, EventArgs e)
        {
            TemperaturePopulateChartData();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EditProds prods = new EditProds(this.username, loggedInAdminAuthority);
            prods.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddProduct addpro = new AddProduct();
            addpro.Show();
            this.Close();
        }

        private void SetDateTemp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void selectDate_Click(object sender, EventArgs e)
        {
            DateTime maxdate = SetDateTemp.Value;
            TemperaturePopulateChartData(maxdate);
        }

        private void IntrusionChart_Click(object sender, EventArgs e)
        {

        }

        private void IntrusionButton_Click(object sender, EventArgs e)
        {
            PopulateIntrusionChartData();
            IntrusionDatePicker.Value = DateTime.Now;
        }
        //private void IntrusionChart_MouseClick(object sender, MouseEventArgs e)
        //{
        //    // Get the clicked data point
        //    HitTestResult result = IntrusionChart.HitTest(e.X, e.Y);

        //    if (result.Series != null && result.PointIndex >= 0)
        //    {
        //        // Retrieve information about the clicked intrusion event
        //        DateTime intrusionTime = Convert.ToDateTime(result.Series.Points[result.PointIndex].AxisLabel.Split('\n')[0]);
        //        int intrusionCount = Convert.ToInt32(result.Series.Points[result.PointIndex].AxisLabel.Split('(')[1].Split(' ')[0]);

        //        Console.WriteLine(intrusionTime);
        //    }
        //}

        private void IntrusionChart_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if the clicked area is a data point
            HitTestResult result = IntrusionChart.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Get the clicked data point
                DataPoint dataPoint = IntrusionChart.Series[0].Points[result.PointIndex];

                // Extract the information from the data point
                string dateStringWithCount = dataPoint.AxisLabel;
                string dateString = dateStringWithCount.Split('\n')[0].Trim();

                ShowIntrusions intrusionpage = new ShowIntrusions();
                intrusionpage.SetDate(dateString);
                intrusionpage.ShowDialog();   

                // Attempt to parse the date without specifying the format

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IntrusionDateButton_Click(object sender, EventArgs e)
        {
            DateTime selected = IntrusionDatePicker.Value;
            PopulateIntrusionChartData(selected);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                // Clear existing data
                this.userLoginDBDataSet.LoginLogs.Clear();

                // Load fresh data into the 'userDBDataSet.Admins' table
                this.loginLogsTableAdapter.Fill(this.userLoginDBDataSet.LoginLogs);

                // Sort the data in descending order based on the 'Time' column
                userLoginDBDataSet.LoginLogs.DefaultView.Sort = "Time DESC";

                // Set the DataGridView data source to the sorted view
                dataGridView1.DataSource = userLoginDBDataSet.LoginLogs.DefaultView;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void assignProductsToWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignItems AssigningItems = new AssignItems();
            AssigningItems.Show();
            this.Hide();

        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BuzzerDeactivate_Click(object sender, EventArgs e)
        {
            DeactivateBuzzer();
            BuzzerCheck.Text = "Buzzer is not active";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLabelText();
        }
        private void DeactivateBuzzer()
        {
            //do something here that deactivates buzzer
        }
        private bool CheckBuzzer()
        {
            return false;
            //do something that checks if buzzer is currently on
        }
    }
}
