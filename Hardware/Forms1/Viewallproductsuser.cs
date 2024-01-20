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
using System.IO;

namespace Forms1
{
    public partial class Viewallproductsuser : Form
    {
        int productID;
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        
        public Viewallproductsuser(string username, string ID)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionID sessionId = SessionID.Instance;
            User userpg = new User(sessionId.RetrieveID());
            userpg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure that the user has entered a valid Product ID
            if (int.TryParse(textBox1.Text, out productID))
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Query to retrieve product details based on ProductID
                    string strCommandText = "SELECT Product_Name, Description, Stock, Price, Image, ProductRFID, FileName FROM Products ";
                    strCommandText += "WHERE ProductID=@ProductID";

                    SqlCommand cmd = new SqlCommand(strCommandText, connection);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Display product information
                        label7.Text = reader["Product_Name"].ToString();
                        label11.Text = reader["Description"].ToString();
                        label8.Text = reader["Stock"].ToString();
                        label9.Text = reader["Price"].ToString();
                        label10.Text = reader["ProductRFID"].ToString();

                        // Display the image
                        byte[] imageData = (byte[])reader["Image"];
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.");
            }
        }
    }
}
