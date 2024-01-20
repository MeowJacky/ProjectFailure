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
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }
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
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                Image img = pictureBox.Image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                connection.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Products (Product_Name,Description,Stock,Price,Image,ProductRFID,FileName,Category,Shelve) VALUES (@Product_Name,@Description,@Stock,@Price,@Image,@ProductRFID,@FileName,@Category,@Shelve)",connection);
                cmd.Parameters.AddWithValue("@Product_Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Description", textBox3.Text);
                cmd.Parameters.AddWithValue("@Stock", textBox4.Text);
                cmd.Parameters.AddWithValue("@Price", textBox5.Text);
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
    }
}
