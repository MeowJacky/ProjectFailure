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
    public partial class Login_logs : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        private int loggedInAdminAuthority;

        public Login_logs(string username, int authority)
        {
            InitializeComponent();
            this.username = username;
            loggedInAdminAuthority = authority;
            AUsername.Text = username;

        }

        private void Login_logs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userLoginDBDataSet.LoginLogs' table. You can move, or remove it, as needed.
            this.loginLogsTableAdapter.Fill(this.userLoginDBDataSet.LoginLogs);

        }

        private void Viewusers_Click(object sender, EventArgs e)
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

        private void assignProductsToWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignItems AssigningItems = new AssignItems(username, loggedInAdminAuthority);
            AssigningItems.Show();
            this.Hide();
        }

        private void workerQuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminquota quota = new adminquota();
            quota.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void projectWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }
    }
}
