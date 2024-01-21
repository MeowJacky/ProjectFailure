using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


namespace Forms1
{
    public partial class ForgetPass : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            string userEmail = tbEmail.Text.Trim();

            // Validate email (you might want to add more sophisticated validation)
            if (IsValidEmail(userEmail))
            {
                // Check if the email exists in the database
                if (IsEmailExists(userEmail))
                {
                    // Generate a new random password (you might want to use a more secure method)
                    string newPassword = GenerateRandomPassword();

                    //// Update the password in the database

                    UpdatePassword(userEmail, newPassword);

                    //// Send the new password to the user via email
                    SendEmail(userEmail, newPassword);

                    MessageBox.Show("Password reset successfully. Check your email for the new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email not found. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid email address. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Admins WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private string GenerateRandomPassword()
        {
            // Implement code to generate a random password
            // You might want to use a library or a more secure method

            // For simplicity, using a basic method to generate a random password

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());


            //return "robertM";
        }

        private void UpdatePassword(string email, string newPassword)
        {
            // Implement code to update the password in the database
            // Use an UPDATE query to set the new password for the given email
            using (SqlConnection connection = new SqlConnection(strConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("UPDATE Admins SET Password = @Password WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", newPassword);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void SendEmail(string to, string newPassword)
        {
            // Replace the following information with your SMTP server details
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "pax337.ml@gmail.com";
            string smtpAppPassword = "xoog ppja ulws ytzn";

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("pax337.ml@gmail.com");
                    mail.To.Add(to);
                    mail.Subject = "Password Reset";
                    mail.Body = $"Your new password is: {newPassword}";

                    using (SmtpClient smtp = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtp.Credentials = new NetworkCredential(smtpUsername, smtpAppPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
            }

            catch (SmtpException ex)
            {
                // Handle the exception
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
