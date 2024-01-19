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
    public partial class Viewallproductsuser : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        public Viewallproductsuser(string username, string ID)
        {
            InitializeComponent();

            textBox1.Text = ID;
            if (ID != "0")
            {
                Viewproduct();
            }
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
        private void Viewproduct()
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {

                string strCommandText = "SELECT ProductID, Product_Name, Description, Stock, Price, Image, ProductRFID FROM Products";
                strCommandText += "WHERE ProductID=@PRODUCTID";
                SqlCommand cmd = new SqlCommand(strCommandText, connection);

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewproduct();
        }
    }
}
