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
        private int loggedInAdminAuthority; // Store the authority of the logged-in admin

        public ManageAdmin(string username, string userID, int authority)
        {
            InitializeComponent();
            ShiftStart.Value = DateTime.Today;
            this.username = username;
            Adusername.Text = username;
            this.loggedInAdminAuthority = authority; // Store the authority of the logged-in admin
            Console.WriteLine(this.username);
            Console.WriteLine(this.loggedInAdminAuthority);

            tbUserID.Text = userID;
            if (userID != "0")
            {
                GetAdminDetails();
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
            GetAdminDetails();
        }

        private void GetAdminDetails()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT UniqueUserID, Name, UniqueRFID, NRIC, Address, Contact, Authority, SupposedToClockIn FROM Admins ";
            strCommandText += "WHERE UniqueUserID=@UserID OR Name=@Name Or UniqueRFID=@UniqueRFID";

            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            cmd.Parameters.AddWithValue("@Name", tbName.Text);
            cmd.Parameters.AddWithValue("@UniqueRFID", tbRFID.Text);

            myConnect.Open();
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

                int loggedInAuthority = Convert.ToInt32(tbAuthority.Text);
                int searchedAuthority = Convert.ToInt32(reader["Authority"]);

                if (loggedInAuthority >= searchedAuthority)
                {
                    SetTextBoxReadOnly(loggedInAuthority < searchedAuthority);
                }
                else
                {
                    MessageBox.Show("You do not have the authority to modify or delete user details with higher authority.");
                    SetTextBoxReadOnly(true);
                }

                if (reader["SupposedToClockIn"] != DBNull.Value)
                {
                    ShiftStart.Value = DateTime.Parse(reader["SupposedToClockIn"].ToString());
                }
                else
                {
                    ShiftStart.Value = new DateTime(2024, 1, 1, 0, 0, 0);
                }
            }
            else
            {
                MessageBox.Show("No Record Found");
            }

            reader.Close();
            myConnect.Close();
        }

        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            tbName.ReadOnly = isReadOnly;
            tbRFID.ReadOnly = isReadOnly;
            tbNRIC.ReadOnly = isReadOnly;
            tbAdd.ReadOnly = isReadOnly;
            tbContact.ReadOnly = isReadOnly;
            // Other textboxes related to user details
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckAuthorityLevel())
            {
                if (ModifyUserRecord() > 0)
                    MessageBox.Show("Modified");
                else
                    MessageBox.Show("Modify Fail");
            }
            else
            {
                MessageBox.Show("You do not have the authority level to modify user's Authority.");
            }
        }

        private bool CheckAuthorityLevel()
        {
            return loggedInAdminAuthority == 1;
        }


        private int ModifyUserRecord()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "UPDATE Admins SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact, Authority=@NewAuthority, SupposedToClockIn=@NewShiftStart WHERE UniqueUserID=@UserID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);

            updateCmd.Parameters.AddWithValue("@UserID", tbUserID.Text);
            updateCmd.Parameters.AddWithValue("@NewName", tbName.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", tbContact.Text);
            updateCmd.Parameters.AddWithValue("@NewAuthority", tbAuthority.Text);
            ShiftStart.Value = DateTime.Today.Add(ShiftStart.Value.TimeOfDay);
            updateCmd.Parameters.AddWithValue("@NewShiftStart", ShiftStart.Value);

            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();

            return result;
        }


        private void GetWorkerDetails()
        {
            // Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            // Step 2: Create Command
            string strCommandText = "SELECT UniqueUserID, Name, UniqueRFID, NRIC, Address, Contact, SupposedToClockIn FROM Admins ";
            strCommandText += "WHERE UniqueUserID=@UserID OR Name=@Name Or UniqueRFID=@UniqueRFID AND Authority >= 1 AND Authority <= 4";

            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", tbUserID1.Text); // Use tbUserID1 for worker details
            cmd.Parameters.AddWithValue("@Name", tbName1.Text);    // Use tbName1 for worker details
            cmd.Parameters.AddWithValue("@UniqueRFID", tbRFID1.Text); // Use tbRFID1 for worker details

            // Step 3: Open Connection and retrieve data by calling ExecuteReader
            myConnect.Open();
            // Step 4: Access Data
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string uniqueUserID = reader["UniqueUserID"].ToString();

                // Check if the searched ID is an admin's ID
                if (IsAdminID(uniqueUserID))
                {
                    MessageBox.Show("No record available for the given ID.");
                }
                else
                {
                    tbUserID1.Text = uniqueUserID;
                    tbName1.Text = reader["Name"].ToString();
                    tbRFID1.Text = reader["UniqueRFID"].ToString();
                    tbNRIC1.Text = reader["NRIC"].ToString();
                    tbAdd1.Text = reader["Address"].ToString();
                    tbContact1.Text = reader["Contact"].ToString();

                    if (reader["SupposedToClockIn"] != DBNull.Value)
                    {
                        ShiftStart1.Value = DateTime.Parse(reader["SupposedToClockIn"].ToString());
                    }
                    else
                    {
                        ShiftStart1.Value = new DateTime(2024, 1, 1, 0, 0, 0);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found");
            }

            reader.Close();
            myConnect.Close();
        }


        private bool IsAdminID(string uniqueUserID)
        {
            // Check if the searched ID is an admin's ID
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Authority FROM Admins WHERE UniqueUserID=@UserID";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@UserID", uniqueUserID);

            myConnect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int authority = Convert.ToInt32(reader["Authority"]);
                if (authority != 999)
                {
                    // It's an admin's ID
                    reader.Close();
                    myConnect.Close();
                    return true;
                }
            }

            reader.Close();
            myConnect.Close();
            return false;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin adminpg = new Admin(this.username, loggedInAdminAuthority);
            adminpg.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string loggedInUsername = username.Trim();
                string userToDelete = tbName.Text.Trim();

                if (userToDelete == loggedInUsername)
                {
                    MessageBox.Show("Cannot delete the currently logged-in user.");
                }
                else
                {
                    int loggedInAuthority = loggedInAdminAuthority;

                    if (loggedInAuthority > Convert.ToInt32(tbAuthority.Text))
                    {
                        if (DeleteUserRecord(tbRFID.Text) > 0)
                        {
                            MessageBox.Show($"UserName = {tbName.Text} has been deleted");
                            button1_Click_1(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Delete Failed");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have the authority to delete user details with equal or higher authority.");
                    }
                }
            }
        }

        private int DeleteUserRecord(string strRFID)
        {
            int result = 0;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "DELETE FROM Admins WHERE UniqueRFID = @UniqueRFID";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@UniqueRFID", strRFID);

            myConnect.Open();
            result = updateCmd.ExecuteNonQuery();
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
            ShiftStart.Value = DateTime.Today;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ShiftStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShiftStart_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ShiftStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllUsers allusers = new ViewAllUsers(this.username, loggedInAdminAuthority);
            allusers.Show();
            this.Close();
        }

        private void signOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void SearchWorker_Click(object sender, EventArgs e)
        {
            GetWorkerDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            tbAdd1.Text = "";
            tbContact1.Text = "";
            tbName1.Text = "";
            tbNRIC1.Text = "";
            tbRFID1.Text = "";
            tbUserID1.Text = "";
            ShiftStart1.Value = DateTime.Today;
        }

        private void btnDeleteW_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                    // Check if the logged-in admin's authority is higher than or equal to the searched admin's authority
                    int loggedInAuthority = this.loggedInAdminAuthority; // Assuming you want to use the authority of the logged-in admin

                    if (loggedInAuthority <= 3)
                    {
                        if (DeleteUserRecord(tbRFID1.Text) > 0)
                        {
                            MessageBox.Show("UserName = " + tbName1.Text + " has been deleted");
                            tbAdd1.Text = "";
                            tbContact1.Text = "";
                            tbName1.Text = "";
                            tbNRIC1.Text = "";
                            tbRFID1.Text = "";
                            tbUserID1.Text = "";
                            ShiftStart1.Value = DateTime.Today;
                        }
                        else
                            MessageBox.Show("Delete Failed");
                    }
                    else
                    {
                        MessageBox.Show("You do not have the authority to delete worker details.");
                    }
                }
            }


        private int ModifyWorkerRecord()
        {
            // Step 1: Create connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            // Step 2: Create command
            string strCommandText = "UPDATE Admins SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact, SupposedToClockIn=@NewShiftStart WHERE UniqueUserID=@UserID";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);

            // Step 3: Create parameters
            updateCmd.Parameters.AddWithValue("@UserID", tbUserID1.Text); // Use tbUserID1 for worker details
            updateCmd.Parameters.AddWithValue("@NewName", tbName1.Text);
            updateCmd.Parameters.AddWithValue("@NewRFID", tbRFID1.Text);
            updateCmd.Parameters.AddWithValue("@NewNRIC", tbNRIC1.Text);
            updateCmd.Parameters.AddWithValue("@NewAdd", tbAdd1.Text);
            updateCmd.Parameters.AddWithValue("@NewContact", tbContact1.Text);
            updateCmd.Parameters.AddWithValue("@NewShiftStart", ShiftStart1.Value);

            // Step 4: Open connection and execute command
            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();

            // Step 5: Close connection
            myConnect.Close();

            return result;
        }

        private void btnModW_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Modify?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Get the username of the user currently logged in
                string loggedInUsername = username.Trim();

                // Get the username of the worker to be modified
                string workerToModify = tbName1.Text.Trim();

                // Check if the worker to be modified is the same as the logged-in user
                if (workerToModify == loggedInUsername)
                {
                    MessageBox.Show("Cannot modify the currently logged-in user.");
                }
                else
                {
                    
                        if (ModifyWorkerRecord() > 0)
                        {
                            MessageBox.Show("Worker details modified successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Modify Failed");
                        }
                    
                }
            }
        }

    }
}
