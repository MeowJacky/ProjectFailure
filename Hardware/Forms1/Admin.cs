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
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;


namespace Forms1
{
    public partial class Admin : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private DBTempUpdate temperatureUpdateService;
        DataComms datacomms = DataCommsHelper.GetDataCommsInstance();
        public delegate void myprocessDataDelegate(string strData);
        private string username;
        private int loggedInAdminAuthority;
        private int mode;
        public Admin(string username, int authority)
        {
            InitializeComponent();
            this.username = username;
            loggedInAdminAuthority = authority;
            AUsername.Text = username;
            PopulateChartData();
            TemperaturePopulateChartData();
            PopulateIntrusionChartData();
            if (username == "")
            {
                SessionID IDCheck = SessionID.Instance;
                this.username = IDCheck.RetrieveID();
                AUsername.Text = IDCheck.RetrieveID();
            }
            timer1.Interval = 60000;
            timer1.Enabled = true;
            PopulateInventory();
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
                        DateTime TemporaryChangeMax = ChangeMax.AddDays(1);
                        // If ChangeMax is provided, use it as a filter in the WHERE clause
                        query = $"SELECT TOP 23 Time, Temp FROM Temperature WHERE Time <= '{TemporaryChangeMax.ToString("yyyy-MM-dd HH:mm:ss")}' ORDER BY Time DESC";
                        SetDateTemp.Value = ChangeMax;

                    }
                    else
                    {
                        // If ChangeMax is not provided, retrieve the top 36 records without a filter
                        query = "SELECT TOP 23 Time, Temp FROM Temperature ORDER BY Time DESC";
                        SetDateTemp.Value = DateTime.Now;
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


        //private void PopulateChartData(DateTime date = default(DateTime))
        //{
        //    DateTime dateday = date.Date;
        //    try
        //    {
        //        // Clear existing series from the chart
        //        clockin.Series.Clear();

        //        using (SqlConnection connection = new SqlConnection(strConnectionString))
        //        {
        //            connection.Open();

        //            string query = "SELECT ClockIn, COUNT(*) AS Count FROM Admins GROUP BY ClockIn";
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                using (SqlDataReader reader = command.ExecuteReader())
        //                {
        //                    // Create a series for the chart
        //                    Series series = new Series("Clock In Status");
        //                    series.ChartType = SeriesChartType.Column;

        //                    while (reader.Read())
        //                    {
        //                        int clockInValue = Convert.ToInt32(reader["ClockIn"]);
        //                        int count = Convert.ToInt32(reader["Count"]);

        //                        // Set color based on ClockIn value
        //                        Color barColor = clockInValue == 0 ? Color.Red : Color.Blue;

        //                        // Add a data point to the series with the specified color
        //                        series.Points.Add(count);

        //                        // Set the data point label to indicate present or not present
        //                        series.Points.Last().AxisLabel = clockInValue == 1 ? "Present" : "Not Present";

        //                        // Set the color of the data point
        //                        series.Points.Last().Color = barColor;

        //                        // Attach data to the data point for later use
        //                        series.Points.Last().Tag = clockInValue;
        //                    }

        //                    // Set the X-axis labels to admin names
        //                    clockin.ChartAreas[0].AxisX.Interval = 1;
        //                    clockin.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

        //                    // Set the Y-axis labels with the desired interval
        //                    clockin.ChartAreas[0].AxisY.Interval = 1;
        //                    clockin.ChartAreas[0].AxisY.Minimum = 0; // Set based on your data
        //                    clockin.ChartAreas[0].AxisY.Maximum = databaserows(); // Set based on your data
        //                    Console.WriteLine(databaserows());


        //                    clockin.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

        //                    clockin.MouseUp -= Clockin_MouseClick;
        //                    clockin.MouseUp += Clockin_MouseClick;




        //                    if (clockin.Titles.Count == 1) //idk why its 1 i think i messed with the properties
        //                    {
        //                        Title chart1Title = new Title();
        //                        chart1Title.Text = "Employee Clock In";
        //                        chart1Title.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
        //                        clockin.Titles.Add(chart1Title);
        //                        Console.WriteLine("clockin title added");
        //                    }




        //                    // Check if the series has data before adding it to the chart
        //                    if (series.Points.Count > 0)
        //                    {
        //                        // Add the series to the chart
        //                        clockin.Series.Add(series);
        //                    }
        //                    else
        //                    {
        //                        // Handle the case where the series is empty
        //                        MessageBox.Show("No data to display in the chart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle exceptions appropriately
        //        MessageBox.Show($"Error populating chart data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void PopulateChartData(DateTime date = default(DateTime))
        {
            try
            {
                // If no date is provided, default to today's date
                if (date == default(DateTime))
                {
                    date = DateTime.Now.Date;
                }
                else
                {
                    date = date.Date;
                    ClockDate.Value = date;
                }

                // Clear existing series from the chart
                clockin.Series.Clear();

                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Select all users and mark whether they have clocked in on the given date
                    string query = "SELECT COUNT(C.UserID) AS PresentCount, COUNT(A.UniqueRFID) - COUNT(C.UserID) AS NotPresentCount " +
                                   "FROM Admins A " +
                                   "LEFT JOIN Clockin C ON A.UniqueRFID = C.UserID AND C.Date = @Date";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for the date
                        command.Parameters.AddWithValue("@Date", date);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a single series for the chart
                            Series series = new Series("Clock In Status");
                            series.ChartType = SeriesChartType.StackedColumn;

                            reader.Read();

                            DataPoint notPresentPoint = new DataPoint();
                            notPresentPoint.SetValueXY(0, Convert.ToInt32(reader["NotPresentCount"]));
                            notPresentPoint.AxisLabel = "Not Present";
                            notPresentPoint.Color = Color.Red;
                            notPresentPoint.Tag = 0; // Set the Tag to 0 for "Not Present"
                            series.Points.Add(notPresentPoint);

                            // Add a data point for "Present"
                            DataPoint presentPoint = new DataPoint();
                            presentPoint.SetValueXY(1, Convert.ToInt32(reader["PresentCount"]));
                            presentPoint.AxisLabel = "Present";
                            presentPoint.Color = Color.Blue;
                            presentPoint.Tag = 1; // Set the Tag to 1 for "Present"
                            series.Points.Add(presentPoint);

                            // Add the series to the chart
                            clockin.Series.Add(series);

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

                            if (series.Points.Count > 0)
                            {
                                // Add chart title if not already present
                                if (clockin.Titles.Count == 0)
                                {
                                    Title chartTitle = new Title();
                                    chartTitle.Text = "Employee Clock In";
                                    chartTitle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                                    clockin.Titles.Add(chartTitle);
                                    Console.WriteLine("Chart title added");
                                }
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




        private bool IsPresent(string uniqueRFID, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Clockin WHERE UserID = @UniqueRFID AND Date = @Date";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UniqueRFID", uniqueRFID);
                    command.Parameters.AddWithValue("@Date", date);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
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

        //private void Clockin_MouseClick(object sender, MouseEventArgs e)
        //{
        //    // Get the clicked data point
        //    HitTestResult result = clockin.HitTest(e.X, e.Y);

        //    if (result.Series != null && result.PointIndex >= 0)
        //    {
        //        // Check if the clicked bar represents "Present"
        //        Console.WriteLine(result.Series.Points[result.PointIndex].Tag);
        //        int clockInValue = Convert.ToInt32(result.Series.Points[result.PointIndex].Tag);

        //        if (clockInValue == 1)
        //        {
        //            // Open another WinForm (replace FormToOpen with your actual form)
        //            present form = new present();
        //            form.ShowDialog(); // Use ShowDialog to make it a modal form
        //        }
        //        else
        //        {
        //            notpresent form = new notpresent();
        //            form.ShowDialog(); // Use ShowDialog to make it a modal form

        //        }
        //    }
        //}
        private void Clockin_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date = ClockDate.Value;
            date = date.Date;
            // Get the clicked data point
            HitTestResult result = clockin.HitTest(e.X, e.Y);

            if (result.Series != null && result.PointIndex >= 0)
            {
                // Check if the clicked bar represents "Present"
                int clockInValue = Convert.ToInt32(result.Series.Points[result.PointIndex].Tag);

                if (clockInValue == 1)
                {
                    // Open another WinForm (replace FormToOpen with your actual form)
                    present form = new present(date);
                    form.ShowDialog(); // Use ShowDialog to make it a modal form
                }
                else
                {
                    notpresent form = new notpresent(date);
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
            ManageAdmin manage = new ManageAdmin(this.username, userid, loggedInAdminAuthority);
            manage.Show();
            this.Close();
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
            ClockDate.Value = DateTime.Now;
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
            int productionID = 0;
            EditProds prods = new EditProds(this.username, loggedInAdminAuthority, productionID);
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


        private void assignProductsToWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignItems AssigningItems = new AssignItems(username, loggedInAdminAuthority);
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
            datacomms.sendData("Stoppls");
            //do something here that deactivates buzzer
        }
        private bool CheckBuzzer()
        {
            datacomms.sendData("ModePls");
            bool Value = (mode != 0);
            return Value;
            //do something that checks if buzzer is currently on
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewProds vProds = new viewProds(username, loggedInAdminAuthority);
            vProds.Show();
            this.Close();
        }
        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }
        private int extractIntValue(string strData, string ID)
        {
            return (Int32.Parse(extractStringValue(strData, ID)));
        }
        private int HandleDetect(string strData, string ID)
        {
            mode = extractIntValue(strData, ID);
            return mode;
        }

        public void extractSensorData(string strData)
        {
            if (strData.IndexOf("mode=") != -1)
                HandleDetect(strData, "mode=");

        }

        private void projectWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void ClockDateButton_Click(object sender, EventArgs e)
        {
            DateTime date = ClockDate.Value;
            PopulateChartData(date);
        }

        private void workerQuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminquota quota = new adminquota();
            quota.Show();
        }

        private void chart1_Click_2(object sender, EventArgs e)
        {
            PopulateInventory();
        }

        private void PopulateInventory()
        {
            string query = "SELECT Category, SUM(Stock) AS TotalStock FROM Products GROUP BY Category";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Clear existing series in chart
                    chart1.Series.Clear();

                    // Add a new series
                    chart1.Series.Add("Total Items");

                    // Set chart type to bar
                    chart1.Series["Total Items"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

                    // Bind data to the chart
                    chart1.DataSource = dataTable;
                    chart1.Series["Total Items"].XValueMember = "Category";
                    chart1.Series["Total Items"].YValueMembers = "TotalStock";


                    // Set axis labels
                    chart1.ChartAreas[0].AxisX.Title = "Category";
                    chart1.ChartAreas[0].AxisY.Title = "Total Stock";

                    chart1.Titles.Clear();
                    chart1.Titles.Add("Products by Category");


                    // Refresh chart
                    chart1.DataBind();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void refreshinv_Click(object sender, EventArgs e)
        {
            PopulateInventory();
        }

        private void loginLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_logs logs = new Login_logs(this.username, loggedInAdminAuthority);
            logs.Show();
            this.Hide();

        }




        private void BuzzerCheck_Click(object sender, EventArgs e)
        {

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
            datacomms.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsdatareceive);
            datacomms.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }

        private void BuzzerDeactivate_Click_1(object sender, EventArgs e)
        {
            DeactivateBuzzer();
            BuzzerCheck.Text = "Buzzer is not active";
        }
    }
}
