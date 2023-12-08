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
        public ViewAllUsers(string username)
        {
            InitializeComponent();
            Adusername.Text = username;
        }


        private void ViewAllUsers_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'userDBDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.userDBDataSet.Admins);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageAdmin manage = new ManageAdmin(this.username);
            manage.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAdmin manage = new ManageAdmin(this.username);
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
            Admin adminpg = new Admin(this.username);
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
    }
}
