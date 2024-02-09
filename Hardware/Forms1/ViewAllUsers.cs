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
    public partial class ViewAllUsers : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        private int loggedInAdminAuthority;
        public ViewAllUsers(string username, int authority)
        {
            InitializeComponent();
            AUsername.Text = username;
            LoadData();
        }

        private void ViewAllUsers_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Action" column
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                // Get the UniqueUserID from the selected row
                string selectedUserID = dataGridView1.Rows[e.RowIndex].Cells["uniqueUserIDDataGridViewTextBoxColumn"].Value.ToString();

                // Open the ManageAdmin form with the selected user's details
                ManageAdmin manageAdmin = new ManageAdmin(username, selectedUserID, loggedInAdminAuthority);
                manageAdmin.Show();
                this.Hide(); // Optionally, hide the current form
            }

            LoadData();
        }
        private void LoadData()
        {
            try
            {
                // Clear existing data
                this.userDBDataSet.Admins.Clear();

                // Load fresh data into the 'userDBDataSet.Admins' table
                this.adminsTableAdapter.Fill(this.userDBDataSet.Admins);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void currentAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userid = "0";
            ManageAdmin manage = new ManageAdmin(this.username, userid, loggedInAdminAuthority);
            manage.Show();
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin addmin = new AddAdmin(this.username, loggedInAdminAuthority);
            addmin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddProduct addpro = new AddProduct();
            addpro.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int productionID = 0;
            EditProds prods = new EditProds(this.username, loggedInAdminAuthority, productionID);
            prods.Show();
            this.Close();
        }

        private void projectWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin addmin = new AddAdmin(this.username, loggedInAdminAuthority);
            addmin.Show();
            this.Close();
        }
    }
    
}
