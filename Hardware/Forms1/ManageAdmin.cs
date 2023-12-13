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
    public partial class ManageAdmin : Form
    {
        // retrieve connection information from App.Config
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        private string username;

        public ManageAdmin(string username, string userID)
        {
            InitializeComponent();
            this.username = username;

            tbUserID.Text = userID;
            if (userID == "0"){

            }
            else {
                GetUserDetails();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetUserDetails();
        }

        private void GetUserDetails()
        {
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            //Step 2: Create Command
            string strCommandText = "SELECT UniqueUserID, Name, UniqueRFID, NRIC, Address, Contact, Authority FROM Admins "; //Add a WHERE clause to SQL statement
            strCommandText += "WHERE UniqueUserID=@UserID OR Name=@Name Or UniqueRFID=@UniqueRFID";
           
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@UniqueRFID", tbRFID.Text);
            //Step 3: Open Connection and retrieve data by calling ExecuteReader
            myConnect.Open();
            //Step 4: Access Data
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                tbUserID.Text = reader["UniqueUserID"].ToString();
                tbName.Text = reader["Name"].ToString();
                tbRFID.Text = reader["UniqueRFID"].ToString();
                tbNRIC.Text = reader["NRIC"].ToString();
                tbAdd.Text = reader["Address"].ToString();
                tbContact.Text = reader["Contact"].ToString();
                tbAuthority.Text = reader["Authority"].ToString();
            }
            else

                MessageBox.Show("No Record Found");
            reader.Close();
            myConnect.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (ModifyUserRecord() > 0)
                MessageBox.Show("Modified");
            else
                MessageBox.Show("Modify Fail");
        }

        private int ModifyUserRecord()
        {
            //step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString); String strCommandText =
            "UPDATE Admins SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact, Authority=@NewAuthority WHERE UniqueUserID=@UserID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            //step 2: Create command
            updateCmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            updateCmd.Parameters.AddWithValue("@NewName", tbName.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", tbContact.Text);
            updateCmd.Parameters.AddWithValue("@NewAuthority", tbAuthority.Text);
            //step 3: open connection and retrieve data by calling ExecuteNonQuery 
            myConnect.Open();
            //step4: Execute command
            //indicates number of records updated
            int result = updateCmd.ExecuteNonQuery();
            //step 5: Close
            myConnect.Close();
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username);
            adminpg.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (DeleteUserRecord(tbRFID.Text) > 0)
                {
                    MessageBox.Show("UserName = " + tbName.Text + "has been deleted");
                    tbAdd.Text = "";
                    tbAuthority.Text = "";
                    tbContact.Text = "";
                    tbName.Text = "";
                    tbNRIC.Text = "";
                    tbRFID.Text = "";
                    tbUserID.Text = "";
                }
                else
                    MessageBox.Show("Delete Failed");
            }
        }

        private int DeleteUserRecord(string strRFID)
        {
            int result = 0;
            //Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            //Step 2: Create command
            String strCommandText = "DELETE FROM Admins WHERE UniqueRFID = @UniqueRFID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@UniqueRFID", strRFID);
            //Step 3: Open connection and detele data by calling ExecutenonQuery() 
            myConnect.Open();
            //Step 4: Execute command
            result = updateCmd.ExecuteNonQuery();
            //Step 5: Close Connection
            myConnect.Close();
            return result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbAdd.Text = "";
            tbAuthority.Text = "";
            tbContact.Text = "";
            tbName.Text = "";
            tbNRIC.Text = "";
            tbRFID.Text = "";
            tbUserID.Text = "";
        }
    }
}
