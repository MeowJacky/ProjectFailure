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
            this.username = username;
            AUsername.Text = username;
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
                if (AuthoritySelect.Value == 2 || AuthoritySelect.Value == 3 || AuthoritySelect.Value == 4)
                {
                    AddUser();
                }
                else
                {
                    MessageBox.Show("Authority level 2 can only add people with authority level 2, 3, 4, or 999.");
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
            // Check if the logged-in admin has the authority to add admins
            if (loggedInAdminAuthority == 1 || loggedInAdminAuthority == 2 || loggedInAdminAuthority == 3)
            {
                AddWorker();
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

        private void tbNRIC_TextChanged(object sender, EventArgs e)
        {
            // Set your desired character limit, for example, 10 characters
            int characterLimit = 9;

            // Check if the length of the text exceeds the limit
            if (tbNRIC.Text.Length > characterLimit)
            {
                // If it does, truncate the text to the allowed length
                tbNRIC.Text = tbNRIC.Text.Substring(0, characterLimit);
                tbNRIC.Select(characterLimit, 0); // Move the cursor to the end
            }
        }

        private void tbcontact_TextChanged(object sender, EventArgs e)
        {
            // Unsubscribe from the event temporarily
            tbcontact.TextChanged -= tbcontact_TextChanged;

            int characterLimit = 8;
            if (tbcontact.Text.Length > characterLimit)
            {
                // Trim the text to the character limit
                tbcontact.Text = tbcontact.Text.Substring(0, characterLimit);
                // Move the cursor to the end of the text
                tbcontact.Select(characterLimit, 0);
            }

            // Subscribe back to the event
            tbcontact.TextChanged += tbcontact_TextChanged;
        }

        private void AddWorker()
        {
            // Similar to AddUser method, adjust as needed
            if (MessageBox.Show("Confirm New Add Worker?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int result = 0;
                SqlConnection myConnect = new SqlConnection(strConnectionString);
                String strCommandText =
                    "INSERT Admins (Name, UniqueRFID, NRIC, Address, Contact, Authority, Password, Email)" + "VALUES (@NewName, @NewRFID, @NewNRIC, @NewAdd, @NewContact, @NewAuthority, @NewPassword, @NewEmail)";
                SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
                updateCmd.Parameters.AddWithValue("@NewName", tbName1.Text);
                updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID1.Text);
                updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC1.Text);
                updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd1.Text);
                updateCmd.Parameters.AddWithValue("@NewContact", tbContact1.Text);
                updateCmd.Parameters.AddWithValue("@NewAuthority", 999); // Worker authority is always 999
                updateCmd.Parameters.AddWithValue("@NewPassword", tbPassword1.Text);

                string emailPrefix = RemoveSpacesAndToLower(tbName1.Text.Substring(0, Math.Min(5, tbName1.Text.Length)));
                string newEmail = $"{emailPrefix}@gmail.com";
                updateCmd.Parameters.AddWithValue("@NewEmail", newEmail);

                myConnect.Open();
                result = updateCmd.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("New Worker Added Successfully!");
                else
                    MessageBox.Show("New Worker Failed to Add");
                myConnect.Close();

                // Reset the form fields after successful addition
                tbPassword1.Text = "";
                tbRFID1.Text = "";
                tbNRIC1.Text = "";
                tbName1.Text = "";
                tbContact1.Text = "";
                tbAdd1.Text = "";
            }
        }

        private void tbNRIC1_TextChanged(object sender, EventArgs e)
        {
            int characterLimit = 9;
            if (tbNRIC1.Text.Length > characterLimit)
            {
                tbNRIC1.Text = tbNRIC1.Text.Substring(0, characterLimit);
                tbNRIC1.Select(characterLimit, 0);
            }
        }

        // Event handler for text change in contact textbox for workers
        private void tbContact1_TextChanged(object sender, EventArgs e)
        {
            tbContact1.TextChanged -= tbContact1_TextChanged; // Unsubscribe temporarily

            int characterLimit = 8;
            if (tbContact1.Text.Length > characterLimit)
            {
                tbContact1.Text = tbContact1.Text.Substring(0, characterLimit);
                tbContact1.Select(characterLimit, 0);
            }

            tbContact1.TextChanged += tbContact1_TextChanged; // Subscribe back
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Viewusers_Click(object sender, EventArgs e)
        {
            ViewAllUsers allusers = new ViewAllUsers(this.username, loggedInAdminAuthority);
            allusers.Show();
            this.Close();
        }

        private void currentAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userid = "0";
            ManageAdmin manage = new ManageAdmin(this.username, userid, loggedInAdminAuthority);
            manage.Show();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int productionID = 0;
            EditProds prods = new EditProds(this.username, loggedInAdminAuthority, productionID);
            prods.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddProduct addpro = new AddProduct();
            addpro.Show();
            this.Close();
        }

        private void assignProductsToWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignItems AssigningItems = new AssignItems(username, loggedInAdminAuthority);
            AssigningItems.Show();
            this.Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void projectWSYSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void workerQuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminquota quota = new adminquota();
            quota.Show();
        }

        private void loginLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_logs logs = new Login_logs(this.username, loggedInAdminAuthority);
            logs.Show();
            this.Hide();
        }
    }
}
