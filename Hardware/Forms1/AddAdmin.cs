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
    public partial class AddAdmin : Form
    {
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm New Add Admin?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int result = 0;
                //Step 1: Create connection
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                //Step 2: Create command
                String strCommandText =
                "INSERT Admins (Name, UniqueRFID, NRIC, Address, Contact, Authority)" + "VALUES (@NewName, @NewRFID, @NewNRIC, @NewAdd, @NewContact, @NewAuthority)";
                SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
                updateCmd.Parameters.AddWithValue("@NewName", tbname.Text);
                updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
                updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
                updateCmd.Parameters.AddWithValue("@NewAdd", tbadd.Text);
                updateCmd.Parameters.AddWithValue("@NewContact", tbcontact.Text);
                updateCmd.Parameters.AddWithValue("@NewAuthority", AuthoritySelect);
                //Step 3: Open Connection and retrieve data by calling ExecuteReader
                myConnect.Open();
                //Step 4: ExecuteCommand
                //result indicates number of record created 
                result = updateCmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("New Admin Added Successfully!");
                else
                    MessageBox.Show("New Admin Failed to Add");
                //Step 5: Close Connection
                myConnect.Close();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
