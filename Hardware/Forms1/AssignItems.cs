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

    public partial class AssignItems : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private List<int> selectedQuantities = new List<int>();
        private string _selectedEmployee;
        private ComboBox comboBoxEditingControl;
        Dictionary<int, int> myDictionary = new Dictionary<int, int>();



        public AssignItems()
        {
            InitializeComponent();
            PopulateEmployeeDropdown();
            CheckItems();
            PopulateQuantityComboBox();
            dataGridView1.DataBindingComplete += DataGridViewProducts_DataBindingComplete;
            EmployeeDropDown.SelectedIndexChanged += EmployeeDropDown_SelectedIndexChanged;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
        }

        private void DataGridViewProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PopulateQuantityComboBox();
            Console.WriteLine("Binding");
        }
        private void PopulateQuantityComboBox()
        {
            var selectedQuantities = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                DataGridViewComboBoxCell quantityCell = row.Cells["QuantityForEmployee"] as DataGridViewComboBoxCell;
                if (quantityCell.Value != null && quantityCell.Value != DBNull.Value)
                {
                    int quantity;
                    if (int.TryParse(quantityCell.Value.ToString(), out quantity))
                    {
                        selectedQuantities.Add(quantity);
                    }
                    else
                    {
                        // Handle the case where the value is not a valid integer (optional)
                        // You can show a message, log the issue, or take appropriate action.
                        MessageBox.Show("you fucked up");
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                List<int> dropodown = new List<int>();

                if (row.IsNewRow)
                    continue;

                if (row.Cells["ProductID"] == null || row.Cells["ProductID"].Value == null)
                    continue;

                DataGridViewComboBoxCell quantityCell = row.Cells["QuantityForEmployee"] as DataGridViewComboBoxCell;

                if (quantityCell == null)
                    continue;

                int maxQuantity = GetMaxQuantityFromDatabase(row.Cells["ProductID"].Value.ToString());

                for (int i = 0; i <= maxQuantity; i++)
                {
                    dropodown.Add(i);
                }
                quantityCell.DataSource = dropodown;
                quantityCell.Value = quantityCell.Value == DBNull.Value ? null : quantityCell.Value;
            }
        }
        //private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    //PopulateQuantityComboBox();
        //}
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed cell is in the QuantityForEmployee column
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridViewColumn quantityColumn = dataGridView1.Columns["QuantityForEmployee"];

                if (quantityColumn != null && e.ColumnIndex == quantityColumn.Index)
                {
                    DataGridViewComboBoxCell quantityCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                    if (quantityCell != null && quantityCell.Value != null && quantityCell.Value != DBNull.Value)
                    {
                        int productID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);

                        // Use int.TryParse to handle the conversion more gracefully
                        int quantity;
                        if (int.TryParse(quantityCell.Value.ToString(), out quantity))
                        {
                            // If the conversion is successful, proceed with the logic
                            Console.WriteLine("is this even working");

                            if (myDictionary.ContainsKey(productID))
                            {
                                myDictionary[productID] = quantity;
                            }
                            else
                            {
                                myDictionary.Add(productID, quantity);
                            }
                        }
                        else
                        {
                            // Handle the case where the value is not a valid integer (optional)
                            // You can show a message, log the issue, or take appropriate action.
                            MessageBox.Show("Fuck. What went wrong.");
                            // Optionally, you can set a default value or clear the cell
                            quantityCell.Value = null;
                        }
                    }
                }
            }
            // Temporary list to store key value pairs
            List<KeyValuePair<int, int>> tempList = new List<KeyValuePair<int, int>>();

            // Loop through DataGridViewRows and add key value pairs to tempList
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["ProductID"].Value != null)
                {
                    int productIDInRow = Convert.ToInt32(row.Cells["ProductID"].Value);
                    int quantityInRow = Convert.ToInt32(row.Cells["QuantityForEmployee"].Value);

                    tempList.Add(new KeyValuePair<int, int>(productIDInRow, quantityInRow));
                }
            }

            // Loop through the temporary list and set the values of the DataGridViewComboBoxCell accordingly
            foreach (var kvp in tempList)
            {
                int productIDToFind = kvp.Key;
                int quantityToSet = kvp.Value;

                // Iterate through rows and find the row with the matching ProductID
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow && row.Cells["ProductID"].Value != null)
                    {
                        int productIDInRow = Convert.ToInt32(row.Cells["ProductID"].Value);

                        if (productIDInRow == productIDToFind)
                        {
                            // Set the value of the QuantityForEmployee ComboBox cell
                            DataGridViewComboBoxCell quantityCell = row.Cells["QuantityForEmployee"] as DataGridViewComboBoxCell;
                            if (quantityCell != null)
                            {
                                quantityCell.Value = quantityToSet;
                            }
                            break; // Once the row is found and updated, exit the inner loop
                        }
                    }
                }
            }

        }


        private void EmployeeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedEmployee != EmployeeDropDown.SelectedItem?.ToString())
            {
                _selectedEmployee = EmployeeDropDown.SelectedItem?.ToString();
                PopulateQuantityComboBox();
            }
        }

        // Example data retrieval function (replace with your actual implementation)
        private int GetMaxQuantityFromDatabase(string productId)
        {
            // Replace this with your logic to fetch the max quantity for a specific product
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();
                string query = $"SELECT MAX(Stock) FROM Products WHERE ProductID = '{productId}'"; // Replace YourProductsTable and ProductID with the actual table and column names

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CheckItems()
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Products"; // Assuming your table name is "Products"

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int productCount = (int)command.ExecuteScalar();

                    // Now you have the product count, you can do whatever you want with it.
                    if (productCount == 0)
                    {
                        MessageBox.Show("No items in database!");
                    }
                }
            }
        }


        private void PopulateEmployeeDropdown()
        {
            EmployeeDropDown.Items.Clear();
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string query = "SELECT Name FROM Admins WHERE Authority = 999";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmployeeDropDown.Items.Add(reader["Name"].ToString());
                        }
                    }
                }

            }
        }


        private void AssignItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.userDBDataSet.Admins);
            // TODO: This line of code loads data into the 'productDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDataSet.Products);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            SessionID ID = SessionID.Instance;
            Admin hello = new Admin(ID.RetrieveID(), ID.RetrieveAuthority());
            hello.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            // Get selected employee and validate
            string selectedEmployee = EmployeeDropDown.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedEmployee))
            {
                MessageBox.Show("Please select an employee.");
                return;
            }
            bool atLeastOneItemAssigned = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductID"].Value != null && row.Cells["QuantityForEmployee"].Value != null)
                {
                    int quantity = Convert.ToInt32(row.Cells["QuantityForEmployee"].Value);

                    if (quantity > 0)
                    {
                        atLeastOneItemAssigned = true;
                        break;
                    }
                }
            }

            if (atLeastOneItemAssigned)
            {
                int PackingID = AssignWorker(selectedEmployee);
                // Get selected items and quantities
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ProductID"].Value != null && row.Cells["QuantityForEmployee"].Value != null)
                    {
                        int ItemID = Convert.ToInt32(row.Cells["ProductID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["QuantityForEmployee"].Value);

                        if (quantity > 0)
                        {
                            AssignItem(PackingID, ItemID, quantity);
                        }
                    }
                }
            }

            MessageBox.Show("Items assigned successfully. Refreshing page.");
            this.Close();
            AssignItems fuckthis = new AssignItems();
            fuckthis.Show();

        }
        private void AssignItem(int PackingID, int ItemID, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                // Start a transaction to ensure both updates happen atomically
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string insertQuery = "INSERT INTO ItemsAssigned (PackingID, ItemID, Quantity) VALUES (@PackingID, @ItemID, @Quantity);";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@PackingID", PackingID);
                        insertCommand.Parameters.AddWithValue("@ItemID", ItemID);
                        insertCommand.Parameters.AddWithValue("@Quantity", quantity);

                        insertCommand.ExecuteNonQuery();
                    }

                    // Update the stock in the Products table
                    string updateStockQuery = "UPDATE Products SET Stock = Stock - @Quantity WHERE ProductID = @ItemID;";
                    using (SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, connection, transaction))
                    {
                        updateStockCommand.Parameters.AddWithValue("@ItemID", ItemID);
                        updateStockCommand.Parameters.AddWithValue("@Quantity", quantity);

                        updateStockCommand.ExecuteNonQuery();
                    }

                    // Commit the transaction if everything succeeded
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // An error occurred, rollback the transaction
                    transaction.Rollback();
                    // Handle or log the exception
                    MessageBox.Show($"Error assigning item: {ex.Message}");
                }
            }
        }


        private int AssignWorker(string worker)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO WorkerAssigned (WorkerName) VALUES (@WorkerName); SELECT SCOPE_IDENTITY();";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@WorkerName", worker);
                    object result = command.ExecuteScalar();

                    // Check if the result is not null before converting to int
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Handle the case where the identity value retrieval fails
                        return -1; // or throw an exception, depending on your requirements
                    }
                }
            }
        }




        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //Console.WriteLine("start");
            //int productID = ((ComboBox)comboBox.SelectedItem).ProductID;
            //int Quantity = ((ComboBox)comboBox.SelectedItem).Quantity;

            //myDictionary.Add(ProductID, Quantity);

        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("fuck");
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Value = cell.EditedFormattedValue;
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= comboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
                    comboBoxEditingControl = comboBox;
                }
            }
        }

    }
}
