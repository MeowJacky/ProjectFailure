using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms1
{
    public partial class Admin : Form
    {
        private string username;
        public Admin(string username)
        {
            InitializeComponent();
            this.username = username;

            adminusername.Text = username;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAdmin manage = new ManageAdmin(this.username);
            manage.Show();
            this.Close();
        }
    }
}
