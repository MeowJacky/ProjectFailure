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
using System.Data.SqlClient;

namespace Forms1
{
    public partial class User : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        DataComms dataComms = DataCommsHelper.GetDataCommsInstance();
        string rfidnum;

        public delegate void myprocessDataDelegate(string strData);

        private Timer temperatureUpdateTimer;

        private DBUserTempUpdate dbTempUpdate; // Assuming you have an instance of DBTempUpdate

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
        private int selectedpackingID;
        private string username;
        public User(string username)
        {
            InitializeComponent();
            this.username = username;

            userusername.Text = username;

            //ClockButton.Click += ClockButton_Click;
            dbTempUpdate = new DBUserTempUpdate(); // Assuming you have an instance of DBTempUpdate

            InitTemperatureUpdateTimer();

            LabelChangeWhenLoad();

            DisplayAssignedItems();

            DisplayClockStatus();

            if (comboBox1.Items.Count > 0)
            {
                selectedpackingID = Convert.ToInt32(comboBox1.Items[0]);
            }
            else
            {
                // Set a default value if no items are available in the combo box
                selectedpackingID = 0; // Or any other default value you prefer
            }

            DisplayAllProducts(selectedpackingID);

            Populatecombo();

        }
        private void DisplayAssignedItems()
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Query to retrieve assigned items for the current user
                string query = "SELECT Products.Product_Name, ItemsAssigned.Quantity, WorkerAssigned.PackingID " +
                               "FROM ItemsAssigned " +
                               "INNER JOIN WorkerAssigned ON ItemsAssigned.PackingID = WorkerAssigned.PackingID " +
                               "INNER JOIN Products ON ItemsAssigned.ItemID = Products.ProductID " +
                               "WHERE WorkerAssigned.WorkerName = @CurrentUser";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CurrentUser", username); // Use username field

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Add items to the FlowLayoutPanel
                        while (reader.Read())
                        {
                            // Retrieve item details from the database
                            string productName = reader["Product_Name"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            int packingID = Convert.ToInt32(reader["PackingID"]);

                            // Create a Label to display item details
                            Label lblItems = new Label();
                            lblItems.Text = $"{productName}: {quantity} (Packing ID: {packingID})";
                            lblItems.AutoSize = true;

                            Console.WriteLine($"Added label for product: {productName}, Quantity: {quantity}, Packing ID: {packingID}");

                            flowLayoutPanel.Controls.Add(lblItems);
                            // Add the Label to the FlowLayoutPanel
                            // flowLayoutPanel.Controls.Add(lblItem);
                        }
                    }
                }
            }
        }

        private void DisplayAllProducts(int selectedPackingID)
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing controls

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Query to retrieve all products
                string query = "SELECT ProductID, Product_Name FROM Products";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int productID = Convert.ToInt32(reader["ProductID"]);
                            string productName = reader["Product_Name"].ToString();

                            // Create labels and buttons for each product
                            Label lblProductName = new Label();
                            lblProductName.Text = productName;
                            lblProductName.AutoSize = true;

                            Button btnScan = new Button();
                            btnScan.Text = "Scan";
                            btnScan.Tag = new Tuple<int, int>(productID, selectedPackingID);
                            // Store product ID and packing ID
                            btnScan.Click += BtnScan_Click; // Add event handler for button click

                            // Add controls to the flow layout panel
                            flowLayoutPanel1.Controls.Add(lblProductName);
                            flowLayoutPanel1.Controls.Add(btnScan);
                        }
                    }
                }
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int selectedPackingID = Convert.ToInt32(comboBox1.SelectedItem);
                Console.WriteLine($"Selected Packing ID: {selectedPackingID}");
                DisplayAllProducts(selectedPackingID);
                this.selectedpackingID = selectedPackingID; // Set the selectedPackingID variable
            }
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            // Get the clicked button and the associated product ID and packing ID
            Button btnScan = (Button)sender;
            var tags = (Tuple<int, int>)btnScan.Tag;
            int productID = tags.Item1;
            int packingID = tags.Item2;

            // Decrease quantity for the scanned product in the selected packing ID
            DecreaseProductQuantity(packingID, productID);

            // Check if all items are scanned, if so, remove the packing ID from the database
            if (IsPackingIDEmpty(packingID))
            {
                RemovePackingIDFromDatabase(packingID);
            }

            // Refresh the display
            DisplayAllProducts(packingID);
        }
        private void DecreaseProductQuantity(int packingID, int productID)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Query to update quantity for the scanned product in the selected packing ID
                string query = "UPDATE ItemsAssigned " +
                               "SET Quantity = CASE WHEN Quantity > 0 THEN Quantity - 1 ELSE 0 END " +
                               "WHERE PackingID = @PackingID AND ItemID = @ProductID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PackingID", packingID);
                    command.Parameters.AddWithValue("@ProductID", productID);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated for Product ID: {productID}, Packing ID: {packingID}");

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Successfully scanned Product ID {productID} from Packing ID {packingID}");
                        this.Close();
                        User user = new User(username);
                        user.Show();
                    }
                }
            }
        }
        private bool IsPackingIDEmpty(int packingID)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Query to check if any items are left for the packing ID
                string query = "SELECT COUNT(*) FROM ItemsAssigned WHERE PackingID = @PackingID AND Quantity > 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PackingID", packingID);

                    int itemCount = (int)command.ExecuteScalar();

                    return itemCount == 0;
                }
            }
        }
        private void RemovePackingIDFromDatabase(int packingID)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Query to update the IsCompleted flag for the packing ID
                string updateQuery = "UPDATE WorkerAssigned SET IsCompleted = 1 WHERE PackingID = @PackingID";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@PackingID", packingID);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated for Packing ID: {packingID}");

                    if (rowsAffected > 0)
                    {
                        // Insert into Quota table
                        string insertQuery = "INSERT INTO Quota (WorkerName, CompletedDate, CompletedPackingID) VALUES (@WorkerName, @CompletedDate, @CompletedPackingID)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@WorkerName", username);
                            insertCommand.Parameters.AddWithValue("@CompletedDate", DateTime.Now);
                            insertCommand.Parameters.AddWithValue("@CompletedPackingID", packingID);

                            int insertedRows = insertCommand.ExecuteNonQuery();
                            Console.WriteLine($"{insertedRows} row(s) inserted into Quota table");
                        }

                        MessageBox.Show($"Successfully completed the quota for Packing ID {packingID}");
                        this.Close();
                        User user = new User(username);
                        user.Show();
                    }
                }
            }

            // Refresh the page
            DisplayAllProducts(selectedpackingID);
            Populatecombo();
            DisplayAssignedItems();
        }


        private void Populatecombo()
        {
            // TODO: This line of code loads data into the 'userDBDataSet.Admins' table. You can move, or remove it, as needed.
            //this.adminsTableAdapter.Fill(this.userDBDataSet.Admins);
            comboBox1.Items.Clear(); // Clear the ComboBox items

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Query to retrieve distinct packing IDs assigned to the worker
                string query = "SELECT DISTINCT PackingID FROM WorkerAssigned WHERE WorkerName = @CurrentUser";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CurrentUser", username); // Use username field

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int packingID = Convert.ToInt32(reader["PackingID"]);
                            comboBox1.Items.Add(packingID); // Add packing ID to ComboBox
                        }
                    }
                }
            }
        }
        private void User_Load(object sender, EventArgs e)
        {
            
        }

        private void LabelChangeWhenLoad()
        {
            Temp.Text = dbTempUpdate.LatestTemperature().ToString() + " Degrees";
        }


        private void InitTemperatureUpdateTimer()
        {
            temperatureUpdateTimer = new Timer();
            temperatureUpdateTimer.Interval = 10000; // Update every 10 seconds (adjust as needed)
            temperatureUpdateTimer.Tick += TemperatureUpdateTimer_Tick;
            temperatureUpdateTimer.Start();


        }

        private void TemperatureUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Update the temperature label here
            //Temp.Text = dbTempUpdate.LatestTemperature().ToString() + " Degrees";
            Console.WriteLine(dbTempUpdate.LatestTemperature() + "this bitch not working");

            DBUserTempUpdate TempCheck = DBUserTempUpdate.tempinstance;
            //TempCheck.settemp();
            Temp.Text = (dbTempUpdate.LatestTemperature().ToString() + " degrees");
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            temperatureUpdateTimer.Stop();
            temperatureUpdateTimer.Dispose();
        }

        private void DisplayClockStatus()
        {
            InitComms();
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
                        ClockButton.Text = "clock in";
                    }
                    else if (clockInStatus == 1)
                    {
                        label1.Text = "You are currently clocked in";
                        ClockButton.Text = "Clock Out";
                    }
                }
            }
        }

        private void ClockButton_Click_1(object sender, EventArgs e)
        {
            int currentStatus = GetCurrentClockStatus();
            Console.WriteLine("stat="+currentStatus);

            // Assuming that RFID data is received and processed in processDataReceive method
            // You can modify this part based on your actual RFID data handling

            // Check if the scanned RFID matches the RFID of the logged-in user

            if (currentStatus == 0)
            {
                Console.WriteLine(rfidnum);
                Console.WriteLine(IsRFIDMatch(rfidnum));
                if (IsRFIDMatch(rfidnum))
                {
                    rfidnum = "";
                    dataComms.dataReceiveEvent -= commsdatareceive;
                    dataComms.dataSendErrorEvent -= commsSendError;
                    DateTime currentTime = DateTime.Now;
                    TimeSpan lateStartTime = new TimeSpan(9, 0, 0);
                    TimeSpan lateEndTime = new TimeSpan(7, 59, 59);
                    TimeSpan targetTime = new TimeSpan(8, 0, 0);

                    if ((currentTime.TimeOfDay >= lateStartTime && currentTime.TimeOfDay <= TimeSpan.FromHours(24)) ||
                        (currentTime.TimeOfDay >= TimeSpan.Zero && currentTime.TimeOfDay <= lateEndTime))
                    {
                        TimeSpan lateDuration = currentTime.TimeOfDay - targetTime;
                        if (lateDuration < TimeSpan.Zero)
                        {
                            lateDuration = TimeSpan.FromHours(24) + lateDuration; // Adding a day for it to be positive
                        }

                        int lateHours = (int)lateDuration.TotalHours;
                        int lateMinutes = lateDuration.Minutes;

                        string lateMessage = "You are late by " + lateHours + " hours and " + lateMinutes + " minutes!";
                        MessageBox.Show(lateMessage);
                        UpdateClockStatus(1);
                    }
                }
                else
                {
                    MessageBox.Show("RFID does not match the logged-in user.");
                }
            }
            else
            {
                UpdateClockStatus(0);

            }
            DisplayClockStatus(); // Update UI to reflect the new clock-in status

            
        }

        private void RedirectBasedOnPriority()
        {
            // Query to retrieve the priority of the logged-in user
            string query = "SELECT Authority FROM Admins WHERE Name = @Username";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    // Retrieve the priority value of the logged-in user from the database
                    int userAuthority = Convert.ToInt32(command.ExecuteScalar());

                    // Redirect to the respective page based on the priority
                    if (userAuthority >= 1 && userAuthority <= 4)
                    {
                        // Admin
                        //Admin adminPage = new Admin(username);
                        //this.Hide();
                        //adminPage.ShowDialog();
                        //this.Show();
                    }
                    else if (userAuthority == 999)
                    {
                        // User
                        User userPage = new User(username);
                        this.Hide();
                        userPage.ShowDialog();
                        this.Show();
                    }
                }
            }
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

        private bool IsRFIDMatch(string scannedRFIDData)
        {
            // Query to retrieve the RFID of the logged-in user
            string query = "SELECT UniqueRFID FROM Admins WHERE Name = @Username";

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    // Retrieve the RFID value of the logged-in user from the database
                    string userRFIDValue = Convert.ToString(command.ExecuteScalar());

                    // Compare the scanned RFID value with the user's RFID value
                    return scannedRFIDData == userRFIDValue;
                }
            }
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
            User user = new User(this.username);
            user.Show();
            this.Close();
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

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string productid = "0";
            Viewallproductsuser viewallpro = new Viewallproductsuser(username, productid);
            viewallpro.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Temp_Click(object sender, EventArgs e)
        {

        }
    }
}
