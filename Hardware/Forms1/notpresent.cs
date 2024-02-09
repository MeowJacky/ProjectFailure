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

        public notpresent(DateTime time)
        {
            InitializeComponent();
            nothere.Text = "";
            LoadNonPresentEmployees(time);


        }
        private void LoadNonPresentEmployees(DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Select names of users who haven't clocked in on the given date
                    string query = "SELECT DISTINCT A.Name FROM Admins A " +
                                   "LEFT JOIN Clockin C ON A.UniqueRFID = C.UserID AND C.Date = @Date " +
                                   "WHERE C.UserID IS NULL";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for the date
                        command.Parameters.AddWithValue("@Date", date);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming there is a label named nothere on the form
                                nothere.Text += reader["Name"].ToString() + Environment.NewLine;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                MessageBox.Show($"Error loading non-present employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void notpresent_Load(object sender, EventArgs e)
        {

        }
    }
}
