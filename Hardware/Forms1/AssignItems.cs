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

        public AssignItems()
        {
            InitializeComponent();
            PopulateEmployeeDropdown();
            CheckItems();
            PopulateQuantityComboBox();
            dataGridView1.DataBindingComplete += DataGridViewProducts_DataBindingComplete;
            EmployeeDropDown.SelectedIndexChanged += EmployeeDropDown_SelectedIndexChanged;

        }

        private void DataGridViewProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            PopulateQuantityComboBox();
            Console.WriteLine("Binding");
        }
        private void PopulateQuantityComboBox()
        {
            // Store the selected quantities
            var selectedQuantities = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                DataGridViewComboBoxCell quantityCell = row.Cells["QuantityForEmployee"] as DataGridViewComboBoxCell;
                if (quantityCell.Value != null && quantityCell.Value != DBNull.Value)
                {
                    selectedQuantities.Add(Convert.ToInt32(quantityCell.Value));
                }
            }

            // Clear and populate the comboboxes
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["ProductID"] == null || row.Cells["ProductID"].Value == null)
                    continue;

                DataGridViewComboBoxCell quantityCell = row.Cells["QuantityForEmployee"] as DataGridViewComboBoxCell;

                if (quantityCell == null)
                    continue;

                int maxQuantity = GetMaxQuantityFromDatabase(row.Cells["ProductID"].Value.ToString());

                // Check if the combobox is empty or the selected item is null
                if (quantityCell.Items.Count == 0 || quantityCell.Value == null)
                {
                    quantityCell.Items.Clear();
                    for (int i = 0; i <= maxQuantity; i++)
                    {
                        quantityCell.Items.Add(i);
                    }
                }

                if (!row.IsNewRow && row.Cells["QuantityForEmployee"].Value != null && row.Cells["QuantityForEmployee"].Value.ToString() != "")
                {
                    row.Cells["QuantityForEmployee"].Value = null;
                }

                // Re-select the previously selected quantity
                if (selectedQuantities.Count > row.Index && selectedQuantities[row.Index] > 0)
                {
                    quantityCell.Value = selectedQuantities[row.Index];
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PopulateQuantityComboBox();
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

            MessageBox.Show("Items assigned successfully.");
        }
        private void AssignItem(int PackingID, int ItemID, int quantity)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO ItemsAssigned (PackingID, ItemID, Quantity) VALUES (@PackingID, @ItemID, @Quantity);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PackingID", PackingID);
                    command.Parameters.AddWithValue("@ItemID", ItemID);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    object result = command.ExecuteScalar();
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


    }
}
