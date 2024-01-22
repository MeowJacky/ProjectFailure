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
    public partial class ClockIn : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;

        DataComms dataComms = DataCommsHelper.GetDataCommsInstance();
        string rfidnum;
        public ClockIn()
        {
            InitializeComponent();
        }

        private void ClockIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionID sessionId = SessionID.Instance;
            LoginPg login = new LoginPg();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
