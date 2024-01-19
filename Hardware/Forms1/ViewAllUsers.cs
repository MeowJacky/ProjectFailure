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
        public ViewAllUsers(string username)
        {
            InitializeComponent();
            AUsername.Text = username;
            LoadData();
        }

        private void ViewAllUsers_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void usersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.adminsTableAdapter.Users(this.userDBDataSet.Admins);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
    
}
