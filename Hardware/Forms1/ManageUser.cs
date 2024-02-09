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
    public partial class ManageUser : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        public ManageUser(string username)
        {
            InitializeComponent();
            this.username = username;

            userusername.Text = username;

            userusername.Font = new Font(userusername.Font.FontFamily, 14);
            userusername.Font = new Font(userusername.Font.FontFamily, 14);

            dataGridView1.AllowUserToAddRows = false;

            DisplayUserInfo(username);

        }

        private void DisplayUserInfo(string username)
        {
            string query = "SELECT * FROM Admins WHERE Name = @Username"; // Query to retrieve user info by username

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable userData = new DataTable();
                    adapter.Fill(userData);

                    dataGridView1.DataSource = userData;
                }
            }
        }
    
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDBDataSet.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.userDBDataSet.Admins);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userusername_Click(object sender, EventArgs e)
        {

        }

        private void userusername_MouseLeave(object sender, EventArgs e)
        {

        }

        private void username_MouseHover(object sender, EventArgs e)
        {

        }

        private void userusername_Click_1(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void projectWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User(this.username);
            user.Show();
            this.Close();
        }
    }
}
