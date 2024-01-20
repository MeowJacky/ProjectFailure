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

namespace Forms1
{
    public partial class viewProds : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        public viewProds()
        {
            InitializeComponent();
            InitializeTable();
            PopulateTableWithData();
        }
        private void InitializeTable()
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            Controls.Add(tableLayoutPanel);

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

            tableLayoutPanel.Controls.Add(CreateLabel("ID", true), 0, 0);
            tableLayoutPanel.Controls.Add(CreateLabel("Product Name", true), 1, 0);
            tableLayoutPanel.Controls.Add(CreateLabel("Description", true), 2, 0);
            tableLayoutPanel.Controls.Add(CreateLabel("Stock", true), 3, 0);
            tableLayoutPanel.Controls.Add(CreateLabel("Price", true), 4, 0);
            tableLayoutPanel.Controls.Add(CreateLabel("Category", true), 5, 0);
            tableLayoutPanel.Controls.Add(CreateLabel("Shelve", true), 6, 0);
        }

        private Label CreateLabel(string text, bool isHeader = false)
        {
            Label label = new Label();
            label.Text = text;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BackColor = isHeader ? SystemColors.ControlDark : SystemColors.ControlLight;
            label.ForeColor = isHeader ? SystemColors.ControlLightLight : SystemColors.ControlText;
            label.BorderStyle = BorderStyle.FixedSingle;
            return label;
        }

        private void PopulateTableWithData()
        {
            List<Product> products = GetProductsFromDatabase();

            TableLayoutPanel tableLayoutPanel = Controls.OfType<TableLayoutPanel>().FirstOrDefault();
            if (tableLayoutPanel != null)
            {
                int rowIndex = tableLayoutPanel.RowCount;
                foreach (var product in products)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                    tableLayoutPanel.Controls.Add(CreateLabel(product.ProductID.ToString()), 0, rowIndex);
                    tableLayoutPanel.Controls.Add(CreateLabel(product.ProductName), 1, rowIndex);
                    tableLayoutPanel.Controls.Add(CreateLabel(product.Description), 2, rowIndex);
                    tableLayoutPanel.Controls.Add(CreateLabel(product.Stock.ToString()), 3, rowIndex);
                    tableLayoutPanel.Controls.Add(CreateLabel(product.Price.ToString("C")), 4, rowIndex);
                    tableLayoutPanel.Controls.Add(CreateLabel(product.Category), 5, rowIndex);
                    tableLayoutPanel.Controls.Add(CreateLabel(product.Shelve?.ToString() ?? "N/A"), 6, rowIndex);
                    rowIndex++;
                }
            }
        }

        private List<Product> GetProductsFromDatabase()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Products";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                            ProductName = reader.GetString(reader.GetOrdinal("Product_Name")),
                            Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                            Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                            Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                            Category = reader.IsDBNull(reader.GetOrdinal("Category")) ? null : reader.GetString(reader.GetOrdinal("Category")),
                            Shelve = reader.IsDBNull(reader.GetOrdinal("Shelve")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("Shelve"))
                        };
                        products.Add(product);
                    }
                }
            }

            return products;
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int? Shelve { get; set; }
    }
}

