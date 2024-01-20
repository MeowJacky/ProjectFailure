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
    public partial class EditProds : Form
    {
        int productID;
        string imageUrl = null;
        private string username;
        private int loggedInAdminAuthority; // Store the authority of the logged-in admin
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        public EditProds(string username, int authority)
        {
            this.username = username;
            loggedInAdminAuthority = authority;
            InitializeComponent();
            Adusername.Text = username;
            Console.WriteLine(this.username);
            Console.WriteLine(this.loggedInAdminAuthority);
        }


        private void ProdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    imageUrl = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbSearchBar.Text, out productID))
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Query to retrieve product details based on ProductID
                    string strCommandText = "SELECT Product_Name, Description, Stock, Price, Image, ProductRFID, FileName, Category, Shelve FROM Products ";
                    strCommandText += "WHERE ProductID=@ProductID";

                    SqlCommand cmd = new SqlCommand(strCommandText, connection);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Populate form fields with retrieved information
                        PopulateFormFields(reader);

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

        private void PopulateFormFields(SqlDataReader reader)
        {
            // Populate form fields with retrieved information
            ProdName.Text = reader["Product_Name"].ToString();
            stocksnum.Value = Convert.ToInt32(reader["Stock"]);
            numprice.Value = Convert.ToDecimal(reader["Price"]);
            rfid.Text = reader["ProductRFID"].ToString();
            tbdesc.Text = reader["Description"].ToString();
            comboBox1.SelectedItem = reader["Category"].ToString();
            tbshelve.Text = reader["Shelve"].ToString();
            tbfile.Text = reader["FileName"].ToString();
        }

private void btnDelete_Click(object sender, EventArgs e)
{
    // Ensure that the user has entered a valid Product ID
    if (int.TryParse(tbSearchBar.Text, out productID))
    {
        // Check if the logged-in admin has the appropriate authority level (1 to 3)
        if (loggedInAdminAuthority >= 1 && loggedInAdminAuthority <= 3)
        {
            if (MessageBox.Show("Confirm Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Query to delete the product based on ProductID
                    string strCommandText = "DELETE FROM Products WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(strCommandText, connection);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully.");
                        // Optionally, clear the form fields or perform any other action after deletion.
                        ClearFormFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product.");
                    }

                    connection.Close();
                }
            }
        }
        else
        {
            MessageBox.Show("You do not have the authority to delete products.");
        }
    }
    else
    {
        MessageBox.Show("Please enter a valid Product ID.");
    }
}



        private void ClearFormFields()
        {
            // Clear or reset form fields as needed
            tbSearchBar.Text = "";
            ProdName.Text = "";
            stocksnum.Text = "";
            tbdesc.Text = "";
            numprice.Text = "";
            rfid.Text = "";
            tbshelve.Text = "";
            comboBox1.SelectedIndex = -1;
            pictureBox1.Image = null;
            // Clear other form fields
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbSearchBar.Text, out productID))
            {
                using (SqlConnection connection = new SqlConnection(strConnectionString))
                {
                    connection.Open();

                    // Query to update product details based on ProductID
                    string strCommandText = "UPDATE Products SET Product_Name=@ProductName, Description=@Description, ";
                    strCommandText += "Stock=@Stock, Price=@Price, Image=@Image, ProductRFID=@ProductRFID, ";
                    strCommandText += "FileName=@FileName, Category=@Category, Shelve=@Shelve WHERE ProductID=@ProductID";

                    SqlCommand cmd = new SqlCommand(strCommandText, connection);
                    cmd.Parameters.AddWithValue("@ProductName", ProdName.Text);
                    cmd.Parameters.AddWithValue("@Description", tbdesc.Text);
                    cmd.Parameters.AddWithValue("@Stock", stocksnum.Value);
                    cmd.Parameters.AddWithValue("@Price", numprice.Value);

                    // Update the image
                    Image img = pictureBox1.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    cmd.Parameters.AddWithValue("@Image", arr);

                    cmd.Parameters.AddWithValue("@ProductRFID", rfid.Text);
                    cmd.Parameters.AddWithValue("@FileName", Path.GetFileName(imageUrl));
                    cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Shelve", GetShelveNumber(comboBox1.SelectedItem.ToString()));
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product details updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update product details.");
                    }

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.");
            }
        }


        private int GetShelveNumber(string category)
        {
            // You can implement your logic to map categories to shelve numbers
            // For example, you can use a switch statement or a dictionary
            switch (category)
            {
                case "Powder":
                    return 1;
                case "Bottles":
                    return 2;
                case "Stationary":
                    return 3;
                case "Pictures":
                    return 4;
                // Add more cases for other categories
                default:
                    return 5;
            }
        }

        private void tbSearchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void stocksnum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numprice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rfid_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbshelve_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }
    }
}
