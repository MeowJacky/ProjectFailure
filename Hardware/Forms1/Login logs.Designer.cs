namespace Forms1
{
    partial class Login_logs
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.AUsername = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewusers = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Productmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignProductsToWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerQuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoginDBDataSet = new Forms1.UserLoginDBDataSet();
            this.loginLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginLogsTableAdapter = new Forms1.UserLoginDBDataSetTableAdapters.LoginLogsTableAdapter();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.loginOutDataGridViewTextBoxColumn,
            this.successDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginLogsBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(208, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(554, 337);
            this.dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(203, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login Logs";
            // 
            // AUsername
            // 
            this.AUsername.AutoSize = true;
            this.AUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUsername.ForeColor = System.Drawing.Color.Black;
            this.AUsername.Location = new System.Drawing.Point(40, 223);
            this.AUsername.Name = "AUsername";
            this.AUsername.Size = new System.Drawing.Size(137, 22);
            this.AUsername.TabIndex = 5;
            this.AUsername.Text = "adminusername";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectWSYSToolStripMenuItem,
            this.manageUsersToolStripMenuItem,
            this.Productmenu,
            this.signOutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(184, 440);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // projectWSYSToolStripMenuItem
            // 
            this.projectWSYSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectWSYSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.projectWSYSToolStripMenuItem.Name = "projectWSYSToolStripMenuItem";
            this.projectWSYSToolStripMenuItem.Size = new System.Drawing.Size(171, 36);
            this.projectWSYSToolStripMenuItem.Text = "Project W-SYS";
            this.projectWSYSToolStripMenuItem.Click += new System.EventHandler(this.projectWSYSToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Viewusers,
            this.currentAdminToolStripMenuItem,
            this.addAdminToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 125, 0, 0);
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // Viewusers
            // 
            this.Viewusers.Name = "Viewusers";
            this.Viewusers.Size = new System.Drawing.Size(210, 30);
            this.Viewusers.Text = "View All Users";
            this.Viewusers.Click += new System.EventHandler(this.Viewusers_Click);
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
            this.addAdminToolStripMenuItem.Text = "Add Users";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // Productmenu
            // 
            this.Productmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.assignProductsToWorkersToolStripMenuItem,
            this.workerQuotaToolStripMenuItem});
            this.Productmenu.Name = "Productmenu";
            this.Productmenu.Size = new System.Drawing.Size(171, 29);
            this.Productmenu.Text = "Manage products";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(316, 30);
            this.toolStripMenuItem2.Text = "Edit products";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(316, 30);
            this.toolStripMenuItem3.Text = "Add products";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // assignProductsToWorkersToolStripMenuItem
            // 
            this.assignProductsToWorkersToolStripMenuItem.Name = "assignProductsToWorkersToolStripMenuItem";
            this.assignProductsToWorkersToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.assignProductsToWorkersToolStripMenuItem.Text = "Assign Products to Workers";
            this.assignProductsToWorkersToolStripMenuItem.Click += new System.EventHandler(this.assignProductsToWorkersToolStripMenuItem_Click);
            // 
            // workerQuotaToolStripMenuItem
            // 
            this.workerQuotaToolStripMenuItem.Name = "workerQuotaToolStripMenuItem";
            this.workerQuotaToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.workerQuotaToolStripMenuItem.Text = "Worker Quota";
            this.workerQuotaToolStripMenuItem.Click += new System.EventHandler(this.workerQuotaToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // userLoginDBDataSet
            // 
            this.userLoginDBDataSet.DataSetName = "UserLoginDBDataSet";
            this.userLoginDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginLogsBindingSource
            // 
            this.loginLogsBindingSource.DataMember = "LoginLogs";
            this.loginLogsBindingSource.DataSource = this.userLoginDBDataSet;
            // 
            // loginLogsTableAdapter
            // 
            this.loginLogsTableAdapter.ClearBeforeFill = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginOutDataGridViewTextBoxColumn
            // 
            this.loginOutDataGridViewTextBoxColumn.DataPropertyName = "Login/Out";
            this.loginOutDataGridViewTextBoxColumn.HeaderText = "Login/Out";
            this.loginOutDataGridViewTextBoxColumn.Name = "loginOutDataGridViewTextBoxColumn";
            this.loginOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // successDataGridViewTextBoxColumn
            // 
            this.successDataGridViewTextBoxColumn.DataPropertyName = "Success";
            this.successDataGridViewTextBoxColumn.HeaderText = "Success";
            this.successDataGridViewTextBoxColumn.Name = "successDataGridViewTextBoxColumn";
            this.successDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Login_logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(836, 440);
            this.Controls.Add(this.AUsername);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "Login_logs";
            this.Text = "Login_logs";
            this.Load += new System.EventHandler(this.Login_logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AUsername;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projectWSYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Viewusers;
        private System.Windows.Forms.ToolStripMenuItem currentAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Productmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem assignProductsToWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerQuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private UserLoginDBDataSet userLoginDBDataSet;
        private System.Windows.Forms.BindingSource loginLogsBindingSource;
        private UserLoginDBDataSetTableAdapters.LoginLogsTableAdapter loginLogsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn successDataGridViewTextBoxColumn;
    }
}