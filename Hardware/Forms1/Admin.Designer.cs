namespace Forms1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AUsername = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewusers = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginOutLogsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.clockin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.editclockin = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RefreshTempData = new System.Windows.Forms.Button();
            this.TemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Productmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // AUsername
            // 
            this.AUsername.AutoSize = true;
            this.AUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUsername.ForeColor = System.Drawing.Color.Black;
            this.AUsername.Location = new System.Drawing.Point(27, 223);
            this.AUsername.Name = "AUsername";
            this.AUsername.Size = new System.Drawing.Size(137, 22);
            this.AUsername.TabIndex = 1;
            this.AUsername.Text = "adminusername";
            this.AUsername.Click += new System.EventHandler(this.AUsername_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectWSYSToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.historialDataToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.Productmenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(184, 514);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // projectWSYSToolStripMenuItem
            // 
            this.projectWSYSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectWSYSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.projectWSYSToolStripMenuItem.Name = "projectWSYSToolStripMenuItem";
            this.projectWSYSToolStripMenuItem.Size = new System.Drawing.Size(171, 36);
            this.projectWSYSToolStripMenuItem.Text = "Project W-SYS";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Viewusers,
            this.currentAdminToolStripMenuItem,
            this.addAdminToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // Viewusers
            // 
            this.Viewusers.Name = "Viewusers";
            this.Viewusers.Size = new System.Drawing.Size(210, 30);
            this.Viewusers.Text = "View All Users";
            this.Viewusers.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // currentAdminToolStripMenuItem
            // 
            this.currentAdminToolStripMenuItem.Name = "currentAdminToolStripMenuItem";
            this.currentAdminToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.currentAdminToolStripMenuItem.Text = "Search Users";
            this.currentAdminToolStripMenuItem.Click += new System.EventHandler(this.currentAdminToolStripMenuItem_Click);
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click_1);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // historialDataToolStripMenuItem
            // 
            this.historialDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureLogsToolStripMenuItem,
            this.loginOutLogsToolStripMenuItem1});
            this.historialDataToolStripMenuItem.Name = "historialDataToolStripMenuItem";
            this.historialDataToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.historialDataToolStripMenuItem.Text = "Historical Logs";
            this.historialDataToolStripMenuItem.Click += new System.EventHandler(this.historialDataToolStripMenuItem_Click);
            // 
            // temperatureLogsToolStripMenuItem
            // 
            this.temperatureLogsToolStripMenuItem.Name = "temperatureLogsToolStripMenuItem";
            this.temperatureLogsToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.temperatureLogsToolStripMenuItem.Text = "Temperature Logs";
            this.temperatureLogsToolStripMenuItem.Click += new System.EventHandler(this.temperatureLogsToolStripMenuItem_Click);
            // 
            // loginOutLogsToolStripMenuItem1
            // 
            this.loginOutLogsToolStripMenuItem1.Name = "loginOutLogsToolStripMenuItem1";
            this.loginOutLogsToolStripMenuItem1.Size = new System.Drawing.Size(237, 30);
            this.loginOutLogsToolStripMenuItem1.Text = "Login/Out Logs";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome Back";
            // 
            // clockin
            // 
            chartArea3.Name = "ChartArea1";
            this.clockin.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.clockin.Legends.Add(legend3);
            this.clockin.Location = new System.Drawing.Point(0, 0);
            this.clockin.Name = "clockin";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.clockin.Series.Add(series3);
            this.clockin.Size = new System.Drawing.Size(591, 292);
            this.clockin.TabIndex = 0;
            this.clockin.Text = "Employee Clock In";
            title2.Name = "Employee Clock In";
            this.clockin.Titles.Add(title2);
            this.clockin.Click += new System.EventHandler(this.clockin_Click);
            // 
            // editclockin
            // 
            this.editclockin.Location = new System.Drawing.Point(457, 124);
            this.editclockin.Name = "editclockin";
            this.editclockin.Size = new System.Drawing.Size(107, 34);
            this.editclockin.TabIndex = 2;
            this.editclockin.Text = "Edit Clocked In";
            this.editclockin.UseVisualStyleBackColor = true;
            this.editclockin.Click += new System.EventHandler(this.editclockin_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(457, 178);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(107, 36);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Refresh Data";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(159, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.refresh);
            this.splitContainer1.Panel1.Controls.Add(this.editclockin);
            this.splitContainer1.Panel1.Controls.Add(this.clockin);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RefreshTempData);
            this.splitContainer1.Panel2.Controls.Add(this.TemperatureChart);
            this.splitContainer1.Size = new System.Drawing.Size(1115, 292);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 6;
            // 
            // RefreshTempData
            // 
            this.RefreshTempData.Location = new System.Drawing.Point(391, 145);
            this.RefreshTempData.Name = "RefreshTempData";
            this.RefreshTempData.Size = new System.Drawing.Size(108, 41);
            this.RefreshTempData.TabIndex = 1;
            this.RefreshTempData.Text = "Refresh Data";
            this.RefreshTempData.UseVisualStyleBackColor = true;
            this.RefreshTempData.Click += new System.EventHandler(this.RefreshTempData_Click);
            // 
            // TemperatureChart
            // 
            chartArea4.Name = "ChartArea1";
            this.TemperatureChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.TemperatureChart.Legends.Add(legend4);
            this.TemperatureChart.Location = new System.Drawing.Point(3, 0);
            this.TemperatureChart.Name = "TemperatureChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.TemperatureChart.Series.Add(series4);
            this.TemperatureChart.Size = new System.Drawing.Size(511, 292);
            this.TemperatureChart.TabIndex = 0;
            this.TemperatureChart.Text = "TemperatureLogs";
            this.TemperatureChart.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // Productmenu
            // 
            this.Productmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.Productmenu.Name = "Productmenu";
            this.Productmenu.Size = new System.Drawing.Size(171, 29);
            this.Productmenu.Text = "Manage products";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 30);
            this.toolStripMenuItem2.Text = "View products";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 30);
            this.toolStripMenuItem3.Text = "Add products";
            // 
            // Admin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1299, 514);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AUsername);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockin)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adminusername;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Label AUsername;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projectWSYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart clockin;
        private System.Windows.Forms.Button editclockin;
        private System.Windows.Forms.ToolStripMenuItem Viewusers;
        private System.Windows.Forms.Button refreshed;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ToolStripMenuItem historialDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginOutLogsToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TemperatureChart;
        private System.Windows.Forms.Button RefreshTempData;
        private System.Windows.Forms.ToolStripMenuItem Productmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}