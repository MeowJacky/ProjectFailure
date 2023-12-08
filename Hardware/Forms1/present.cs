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
    public partial class present : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        public present()
        {
            InitializeComponent();
        }

        private void present_Load(object sender, EventArgs e)
        {
            here.Text = "";

            LoadPresentEmployees();
        }
        private void LoadPresentEmployees()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Name FROM Admins WHERE ClockIn = 1";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming there is a label named labelName on FormToOpen
                                here.Text += reader["Name"].ToString() + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error loading present employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void here_Click(object sender, EventArgs e)
        {

        }
    }
}
