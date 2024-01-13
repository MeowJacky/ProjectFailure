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
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        private int loggedInAdminAuthority;
        public ViewAllUsers(string username, int authority)
        {
            InitializeComponent();
            Adusername.Text = username;
            loggedInAdminAuthority = authority;
        }


        private void ViewAllUsers_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'userDBDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.userDBDataSet.Admins);
            RefreshDataGridView();


        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshDataGridView();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.Rows[e.RowIndex];

                // Extract data from the selected row
                string selectedUserID = selectedRow.Cells["UniqueUserID"].Value.ToString();

                // Pass the data to the ManageAdmin form
                ManageAdmin manage = new ManageAdmin(Adusername.Text, selectedUserID, this.loggedInAdminAuthority);
                Console.WriteLine(Adusername.Text);
                manage.Show();
                this.Close();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String UserID = "0"; 
            ManageAdmin manage = new ManageAdmin(this.username, UserID,this.loggedInAdminAuthority);
            manage.Show();
            this.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin addmin = new AddAdmin(this.username);
            addmin.Show();
            this.Close();
        }

        private void RefreshDataGridView()
        {
            try
            {
                // Create a new SqlConnection using the connection string
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a new SqlDataAdapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Admins", connection))
                    {
                        // Create a new DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the database
                        adapter.Fill(dataTable);

                        // Set the DataGridView's DataSource to the DataTable
                        dataGridViewUsers.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the data retrieval
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
