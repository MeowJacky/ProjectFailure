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
        private string username;
        private int loggedInAdminAuthority;
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        public viewProds(string username, int authoriy)
        {
            InitializeComponent();
            AUsername.Text = this.username;
        }

        private void viewProds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.prodsDataSet.Products);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the double-click occurred on a valid row (not header or empty row)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the product ID from the selected row
                int selectedProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["productIDDataGridViewTextBoxColumn"].Value);

                // Open the EditProds form with the selected product's details
                EditProds editProds = new EditProds(username, loggedInAdminAuthority, selectedProductID);
                editProds.Show();
                this.Hide(); // Optionally, hide the current form
            }
        }
    }
}

