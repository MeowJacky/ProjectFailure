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
        private int loggedInAdminAuthority;
        public AddAdmin(string username, int authority)
        {
            InitializeComponent();
            this.loggedInAdminAuthority = authority;
            Console.WriteLine(loggedInAdminAuthority);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the logged-in admin has the authority to add admins
            if (loggedInAdminAuthority == 1)
            {
                // Admin with authority level 1 can add anyone with any authority level
                AddUser();
            }
            else if (loggedInAdminAuthority == 2)
            {
                // Admin with authority level 2 can add people with authority level 2, 3, 4, or 999
                if (AuthoritySelect.Value == 2 || AuthoritySelect.Value == 3 || AuthoritySelect.Value == 4 || AuthoritySelect.Value == 999)
                {
                    AddUser();
                }
                else
                {
                    MessageBox.Show("Authority level 2 can only add people with authority level 2, 3, 4, or 999.");
                }
            }
            else if (loggedInAdminAuthority == 3)
            {
                // Admin with authority level 3 can only add people with authority level 999
                if (AuthoritySelect.Value == 999)
                {
                    AddUser();
                }
                else
                {
                    MessageBox.Show("Authority level 3 can only add people with authority level 999.");
                }
            }
            else
            {
                MessageBox.Show("You don't have the authority to add users.");
            }
        }

        private void AddUser()
        {
            if (MessageBox.Show("Confirm New Add User?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int result = 0;
                //Step 1: Create connection
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                //Step 2: Create command
                String strCommandText =
                "INSERT Admins (Name, UniqueRFID, NRIC, Address, Contact, Authority, Password, Email)" + "VALUES (@NewName, @NewRFID, @NewNRIC, @NewAdd, @NewContact, @NewAuthority, @NewPassword, @NewEmail)";
                SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
                updateCmd.Parameters.AddWithValue("@NewName", tbname.Text);
                updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
                updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
                updateCmd.Parameters.AddWithValue("@NewAdd", tbadd.Text);
                updateCmd.Parameters.AddWithValue("@NewContact", tbcontact.Text);
                updateCmd.Parameters.AddWithValue("@NewAuthority", GetAuthorityValue());
                updateCmd.Parameters.AddWithValue("@NewPassword", tbpassword.Text);

                // Generate the email based on the first 5 characters of the name
                string emailPrefix = RemoveSpacesAndToLower(tbname.Text.Substring(0, Math.Min(5, tbname.Text.Length)));
                string newEmail = $"{emailPrefix}@gmail.com";
                updateCmd.Parameters.AddWithValue("@NewEmail", newEmail);

                //Step 3: Open Connection and retrieve data by calling ExecuteReader
                myConnect.Open();
                //Step 4: ExecuteCommand
                //result indicates the number of records created 
                result = updateCmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("New User Added Successfully!");
                else
                    MessageBox.Show("New User Failed to Add");
                //Step 5: Close Connection
                myConnect.Close();
                // Reset the form fields after successful addition
                tbpassword.Text = "";
                tbRFID.Text = "";
                tbNRIC.Text = "";
                tbname.Text = "";
                tbcontact.Text = "";
                tbadd.Text = "";
                AuthoritySelect.Value = 1;
            }
        }

        private string RemoveSpacesAndToLower(string input)
        {
            // Remove spaces and convert to lowercase
            return input.Replace(" ", string.Empty).ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            int workerauthority = 999;
            // Check if the logged-in admin has the authority to add admins
            if (loggedInAdminAuthority == 1 || loggedInAdminAuthority == 2 || loggedInAdminAuthority == 3)
            {
                AddUser();
            }
            else
            {
                MessageBox.Show("You don't have the authority to add users.");
            }
        }

        private int GetAuthorityValue()
        {
            // Check which button triggered the function and return the appropriate authority value
            if (btnAdd1.Focused)
            {
                return 999; // Set authority value for btnAdd1
            }
            else
            {
                return (int)AuthoritySelect.Value; // Use the value from the AuthoritySelect for other buttons
            }
        }
    }
}
