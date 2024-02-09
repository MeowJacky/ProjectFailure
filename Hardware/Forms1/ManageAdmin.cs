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
            string strCommandText = "SELECT UniqueUserID, Name, UniqueRFID, NRIC, Address, Contact, Authority, SupposedToClockIn, Password FROM Admins ";
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
                tbpass.Text = reader["Password"].ToString();

                int loggedInAuthority = Convert.ToInt32(tbAuthority.Text);
                int searchedAuthority = Convert.ToInt32(reader["Authority"]);


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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckAuthorityLevelForModify() == true)
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

        private bool CheckAuthorityLevelForModify()
        {
            int userAuthority = Convert.ToInt32(tbAuthority.Text);
            int loggedInAuthority = loggedInAdminAuthority;

            // Lvl 1 authority can modify any record
            if (loggedInAuthority == 1)
            {
                return true;
            }
            // Lvl 2 authority can only modify records lower than itself
            else if (loggedInAuthority == 2 && userAuthority > 2)
            {
                return true;
            }
            // Lvl 3 authority can only modify records lower than itself but not authority level
            else if (loggedInAuthority == 3 && (userAuthority > 3))
            {
                return true;
            }
            // Lvl 4 authority can only modify records with authority 999 but not authority level
            else if (loggedInAuthority == 4 && userAuthority == 999)
            {
                return true;
            }
            else
            {
                MessageBox.Show("You do not have the authority to modify records at this level.");
            }

            return false;
        }

        private int ModifyUserRecord()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "UPDATE Admins SET Name=@NewName, UniqueRFID=@NewRFID, NRIC=@NewNRIC, Address=@NewAdd, Contact=@NewContact, Authority=@NewAuthority, SupposedToClockIn=@NewShiftStart, Password=@NewPassword WHERE UniqueUserID=@UserID";
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
            updateCmd.Parameters.AddWithValue("@NewPassword", tbpass.Text);

            myConnect.Open();
            int result = updateCmd.ExecuteNonQuery();
            myConnect.Close();

            return result;
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
            if (CheckAuthorityLevelForDelete()==true)
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
                            if (DeleteUserRecord(tbRFID.Text) > 0)
                            {
                                MessageBox.Show($"{tbName.Text} has been deleted");
                                button1_Click_1(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Delete Failed");
                            }
                    }
                }
            }
        }

        private bool CheckAuthorityLevelForDelete()
        {
            int userAuthority = Convert.ToInt32(tbAuthority.Text);
            int loggedInAuthority = loggedInAdminAuthority;

            // Lvl 1 authority can delete any record
            if (loggedInAuthority == 1)
            {
                return true;
            }
            // Lvl 2 authority can delete records lower than itself
            else if (loggedInAuthority == 2 && userAuthority > loggedInAuthority)
            {
                return true;
            }
            // Lvl 3 authority can only delete records with authority 999 and lower than itself
            else if (loggedInAuthority == 3 && (userAuthority == 999 || userAuthority > loggedInAuthority))
            {
                return true;
            }
            // Lvl 4 cannot delete any records
            else if (loggedInAuthority == 4)
            {
                MessageBox.Show("You do not have the authority to delete records.");
                return false;
            }
            else
            {
                MessageBox.Show("You do not have the authority to delete records at this level.");
            }

            // If none of the conditions are met, return false
            return false;
        }

        // ... (other methods and event handlers)

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
            tbpass.Text = "";
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

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ViewAllUsers allusers = new ViewAllUsers(this.username, loggedInAdminAuthority);
            //allusers.Show();
            //this.Close();
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

        private void addAdminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddAdmin addmin = new AddAdmin(this.username, loggedInAdminAuthority);
            addmin.Show();
            this.Close();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
