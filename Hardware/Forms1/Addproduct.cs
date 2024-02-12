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
    public partial class AddProduct : Form
    {
        string imageUrl = null;
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Check file extension to ensure it's an image file
                    string fileExtension = Path.GetExtension(ofd.FileName).ToLower();
                    if (fileExtension != ".png" && fileExtension != ".jpg" && fileExtension != ".jpeg")
                    {
                        MessageBox.Show("Please select a valid image file (PNG, JPG, JPEG).");
                        return;
                    }

                    // Dispose existing image if any
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }

                    // Assign the selected image to the picture box
                    imageUrl = ofd.FileName;
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.productDataSet.Products);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Check if an image is selected
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Please select an image.");
                return;
            }

            // Validate image format
            string fileExtension = Path.GetExtension(imageUrl).ToLower();
            if (fileExtension != ".png" && fileExtension != ".jpg" && fileExtension != ".jpeg")
            {
                MessageBox.Show("Please select a valid image file (PNG, JPG, JPEG).");
                return;
            }

            // Validate product name
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            // Validate description
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            // Validate stock

            int stock;
            if (!int.TryParse(textBox4.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(textBox5.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Validate RFID
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length != 8)
            {
                MessageBox.Show("Please enter a valid 8-digit RFID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                Image img = pictureBox.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Products (Product_Name,Description,Stock,Price,Image,ProductRFID,FileName,Category,Shelve) VALUES (@Product_Name,@Description,@Stock,@Price,@Image,@ProductRFID,@FileName,@Category,@Shelve)", connection);
                cmd.Parameters.AddWithValue("@Product_Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Description", textBox3.Text);
                cmd.Parameters.AddWithValue("@Stock", stock);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Image", arr);
                cmd.Parameters.AddWithValue("@ProductRFID", textBox1.Text);
                string ImageName = Path.GetFileName(imageUrl);
                cmd.Parameters.AddWithValue("@FileName", ImageName);
                string selectedCategory = comboBox1.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@Category", selectedCategory);

                // Set Shelve based on the selected category
                int shelveNumber = GetShelveNumber(selectedCategory);
                cmd.Parameters.AddWithValue("@Shelve", shelveNumber);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product saved into database!");

                SqlCommand cmd2 = new SqlCommand("select * from Products", connection);
                DataTable dt = new DataTable();
                dt.Load(cmd2.ExecuteReader());
                dataGridView.DataSource = dt;
                connection.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            SessionID sessionId = SessionID.Instance;
            Admin adminpg = new Admin(this.username, sessionId.RetrieveAuthority());
            adminpg.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
