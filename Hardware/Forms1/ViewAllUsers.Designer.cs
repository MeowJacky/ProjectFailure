namespace Forms1
{
    partial class ViewAllUsers
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
            this.AUsername = new System.Windows.Forms.Label();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewusers = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginOutLogsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Productmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersToolStrip = new System.Windows.Forms.ToolStrip();
            this.usersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.uniqueUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet = new Forms1.UserDBDataSet();
            this.adminsTableAdapter = new Forms1.UserDBDataSetTableAdapters.AdminsTableAdapter();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.usersToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AUsername
            // 
            this.AUsername.AutoSize = true;
            this.AUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUsername.ForeColor = System.Drawing.Color.Black;
            this.AUsername.Location = new System.Drawing.Point(23, 225);
            this.AUsername.Name = "AUsername";
            this.AUsername.Size = new System.Drawing.Size(137, 22);
            this.AUsername.TabIndex = 4;
            this.AUsername.Text = "adminusername";
            // 
            // projectWSYSToolStripMenuItem
            // 
            this.projectWSYSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.projectWSYSToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.projectWSYSToolStripMenuItem.Name = "projectWSYSToolStripMenuItem";
            this.projectWSYSToolStripMenuItem.Size = new System.Drawing.Size(171, 36);
            this.projectWSYSToolStripMenuItem.Text = "Project W-SYS";
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
            this.menuStrip2.Size = new System.Drawing.Size(184, 440);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
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
            // 
            // Viewusers
            // 
            this.Viewusers.Name = "Viewusers";
            this.Viewusers.Size = new System.Drawing.Size(206, 30);
            this.Viewusers.Text = "View All Users";
            // 
            // currentAdminToolStripMenuItem
            // 
            this.currentAdminToolStripMenuItem.Name = "currentAdminToolStripMenuItem";
            this.currentAdminToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.currentAdminToolStripMenuItem.Text = "Search Users";
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
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
            // 
            // temperatureLogsToolStripMenuItem
            // 
            this.temperatureLogsToolStripMenuItem.Name = "temperatureLogsToolStripMenuItem";
            this.temperatureLogsToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.temperatureLogsToolStripMenuItem.Text = "Temperature Logs";
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 30);
            this.toolStripMenuItem2.Text = "View products";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 30);
            this.toolStripMenuItem3.Text = "Add products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniqueUserIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nRICDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.authorityDataGridViewTextBoxColumn,
            this.uniqueRFIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(743, 167);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // usersToolStrip
            // 
            this.usersToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.usersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripButton});
            this.usersToolStrip.Location = new System.Drawing.Point(184, 0);
            this.usersToolStrip.Name = "usersToolStrip";
            this.usersToolStrip.Size = new System.Drawing.Size(1084, 32);
            this.usersToolStrip.TabIndex = 7;
            this.usersToolStrip.Text = "usersToolStrip";
            // 
            // usersToolStripButton
            // 
            this.usersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.usersToolStripButton.Name = "usersToolStripButton";
            this.usersToolStripButton.Size = new System.Drawing.Size(59, 29);
            this.usersToolStripButton.Text = "Users";
            this.usersToolStripButton.Click += new System.EventHandler(this.usersToolStripButton_Click);
            // 
            // uniqueUserIDDataGridViewTextBoxColumn
            // 
            this.uniqueUserIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueUserID";
            this.uniqueUserIDDataGridViewTextBoxColumn.HeaderText = "UniqueUserID";
            this.uniqueUserIDDataGridViewTextBoxColumn.Name = "uniqueUserIDDataGridViewTextBoxColumn";
            this.uniqueUserIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // nRICDataGridViewTextBoxColumn
            // 
            this.nRICDataGridViewTextBoxColumn.DataPropertyName = "NRIC";
            this.nRICDataGridViewTextBoxColumn.HeaderText = "NRIC";
            this.nRICDataGridViewTextBoxColumn.Name = "nRICDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // authorityDataGridViewTextBoxColumn
            // 
            this.authorityDataGridViewTextBoxColumn.DataPropertyName = "Authority";
            this.authorityDataGridViewTextBoxColumn.HeaderText = "Authority";
            this.authorityDataGridViewTextBoxColumn.Name = "authorityDataGridViewTextBoxColumn";
            // 
            // uniqueRFIDDataGridViewTextBoxColumn
            // 
            this.uniqueRFIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueRFID";
            this.uniqueRFIDDataGridViewTextBoxColumn.HeaderText = "UniqueRFID";
            this.uniqueRFIDDataGridViewTextBoxColumn.Name = "uniqueRFIDDataGridViewTextBoxColumn";
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.userDBDataSet;
            // 
            // userDBDataSet
            // 
            this.userDBDataSet.DataSetName = "UserDBDataSet";
            this.userDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1268, 440);
            this.Controls.Add(this.usersToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AUsername);
            this.Controls.Add(this.menuStrip2);
            this.Name = "ViewAllUsers";
            this.Text = "ViewAllUsers";
            this.Load += new System.EventHandler(this.ViewAllUsers_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.usersToolStrip.ResumeLayout(false);
            this.usersToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AUsername;
        private System.Windows.Forms.ToolStripMenuItem projectWSYSToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Viewusers;
        private System.Windows.Forms.ToolStripMenuItem currentAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginOutLogsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Productmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UserDBDataSet userDBDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private UserDBDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueRFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip usersToolStrip;
        private System.Windows.Forms.ToolStripButton usersToolStripButton;
    }
}