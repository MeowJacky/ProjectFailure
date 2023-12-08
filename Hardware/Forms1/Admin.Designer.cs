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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AUsername = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewusers = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.clockin = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.editclockin = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockin)).BeginInit();
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
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(184, 527);
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
            this.currentUserToolStripMenuItem,
            this.addAdminToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
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
            this.currentAdminToolStripMenuItem.Text = "Search Admin";
            this.currentAdminToolStripMenuItem.Click += new System.EventHandler(this.currentAdminToolStripMenuItem_Click);
            // 
            // currentUserToolStripMenuItem
            // 
            this.currentUserToolStripMenuItem.Name = "currentUserToolStripMenuItem";
            this.currentUserToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.currentUserToolStripMenuItem.Text = "Search User";
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
            chartArea2.Name = "ChartArea1";
            this.clockin.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.clockin.Legends.Add(legend2);
            this.clockin.Location = new System.Drawing.Point(197, 188);
            this.clockin.Name = "clockin";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.clockin.Series.Add(series2);
            this.clockin.Size = new System.Drawing.Size(732, 327);
            this.clockin.TabIndex = 0;
            this.clockin.Text = "clockin";
            // 
            // editclockin
            // 
            this.editclockin.Location = new System.Drawing.Point(768, 417);
            this.editclockin.Name = "editclockin";
            this.editclockin.Size = new System.Drawing.Size(139, 36);
            this.editclockin.TabIndex = 2;
            this.editclockin.Text = "Edit Clocked In";
            this.editclockin.UseVisualStyleBackColor = true;
            this.editclockin.Click += new System.EventHandler(this.editclockin_Click);
            // 
            // Admin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1141, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editclockin);
            this.Controls.Add(this.AUsername);
            this.Controls.Add(this.clockin);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockin)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem currentUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart clockin;
        private System.Windows.Forms.Button editclockin;
        private System.Windows.Forms.ToolStripMenuItem Viewusers;
    }
}