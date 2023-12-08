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
    public partial class notpresent : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        public notpresent()
        {
            InitializeComponent();
            nothere.Text = "";
            LoadNonPresentEmployees();

        }
        private void LoadNonPresentEmployees()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Name FROM Admins WHERE ClockIn = 0";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nothere.Text += reader["Name"].ToString() + Environment.NewLine;
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

        private void notpresent_Load(object sender, EventArgs e)
        {

        }
    }
}
