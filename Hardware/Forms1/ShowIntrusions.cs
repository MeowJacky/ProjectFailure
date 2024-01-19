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
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace Forms1
{
    public partial class ShowIntrusions : Form
    {
        public event EventHandler DeleteButtonClick;

        string ShowThisDate = (default(DateTime)).ToString();

        public ShowIntrusions()
        {
            InitializeComponent();
        }
        //private void LoadIntrusions()
        //{
        //    listBoxIntrusions.Items.Clear();
        //    using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString))
        //    {
        //        connection.Open();

        //        string query = "SELECT * FROM Detection WHERE CONVERT(DATE, Time) = @ShowDate";
        //        SqlCommand command = new SqlCommand(query, connection);
        //        command.Parameters.AddWithValue("@ShowDate", ShowThisDate);

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {

        //            while (reader.Read())
        //            {
        //                // Assuming your database has columns 'Time' and 'Detection'
        //                string intrusionTime = reader["Time"].ToString();
        //                int intrusionCount = Convert.ToInt32(reader["Detection"]);
        //                // Display the data in the ListBox
        //                listBoxIntrusions.Items.Add($"{intrusionTime} - {intrusionCount} intrusions");
        //            }
        //        }
        //        connection.Close();
        //    }
        //}
        private void LoadIntrusions()
        {
            listBoxIntrusions.Items.Clear();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Detection WHERE CONVERT(DATE, Time) = @ShowDate";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ShowDate", ShowThisDate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string intrusionTime = reader["Time"].ToString();
                        int intrusionCount = Convert.ToInt32(reader["Detection"]);

                        // Create a string with a delete button
                        string listItem = $"{intrusionTime} - {intrusionCount} intrusions  [Delete]";

                        // Add the string to the ListBox
                        listBoxIntrusions.Items.Add(listItem);
                    }
                }
                connection.Close();
            }
        }


        private void listBoxIntrusions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected item ends with "[Delete]"
            if (listBoxIntrusions.SelectedItem != null && listBoxIntrusions.SelectedItem.ToString().EndsWith("[Delete]"))
            {
                // Ask for confirmation or directly delete the item
                if (MessageBox.Show("Are you sure you want to delete this entry?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Delete the item from the database
                    DeleteSelectedItemFromDatabase();

                    // Reload the intrusions after deletion
                    LoadIntrusions();
                }
            }
        }

        private void DeleteSelectedItemFromDatabase()
        {
            // Get the selected item as a string
            string selectedItem = listBoxIntrusions.SelectedItem.ToString();

            // Extract necessary information from the string (e.g., intrusionTime)
            string intrusionTime = selectedItem.Split(new string[] { " - ", " intrusions" }, StringSplitOptions.RemoveEmptyEntries)[0];

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString);

            int result = 0;

            string strCommandText = "DELETE FROM Detection WHERE Time >= @StartTime AND Time <= @EndTime";
            SqlCommand updateCmd = new SqlCommand(strCommandText, connection);
            
            string StartTime = ((DateTime.Parse(intrusionTime)).AddSeconds(-1)).ToString();
            string EndTime = ((DateTime.Parse(intrusionTime)).AddSeconds(1)).ToString();
            updateCmd.Parameters.AddWithValue("@StartTime", DateTime.Parse(StartTime));
            updateCmd.Parameters.AddWithValue("@EndTime", DateTime.Parse(EndTime));

            connection.Open();
            result = updateCmd.ExecuteNonQuery();
            connection.Close();


        }

        private void ShowIntrusions_Load(object sender, EventArgs e)
        {            
            LoadIntrusions();
        }


        public void SetDate(string intrusionDate)
        {
            ShowThisDate = intrusionDate;
        }

        private void IntrusionDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString))
            //{
            //    connection.Open();

            //    string deleteQuery = "DELETE FROM Detection WHERE Time = @IntrusionTime";
            //    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);

            //    // Use parameterized query for DateTime
            //    deleteCommand.Parameters.Add("@IntrusionTime", SqlDbType.DateTime).Value = DateTime.ParseExact("19/1/2024 4:34:33 pm", "dd/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

            //    try
            //    {
            //        // Execute the delete command
            //        deleteCommand.ExecuteNonQuery();
            //    }
            //    catch (Exception ex)
            //    {
            //        // Handle the exception (e.g., show an error message)
            //        MessageBox.Show($"Error deleting entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            //}
        }

    }
}
