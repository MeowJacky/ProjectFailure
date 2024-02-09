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

        public present(DateTime date)
        {
            InitializeComponent();
            here.Text = "";
            DateTime TargetTime = date;

            LoadPresentEmployees(TargetTime);
        }

        private void present_Load(object sender, EventArgs e)
        {
        }
        private void LoadPresentEmployees(DateTime date)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Select names of users who have clocked in on the given date
                    string query = "SELECT DISTINCT A.Name FROM Admins A " +
                                   "INNER JOIN Clockin C ON A.UniqueRFID = C.UserID AND C.Date = @Date";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter for the date
                        command.Parameters.AddWithValue("@Date", date);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming there is a label named here on the form
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
