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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.uniqueUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDBDataSet = new Forms1.UserDBDataSet();
            this.adminsTableAdapter = new Forms1.UserDBDataSetTableAdapters.AdminsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uniqueUserIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.nRICDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.authorityDataGridViewTextBoxColumn,
            this.uniqueRFIDDataGridViewTextBoxColumn,
            this.Action});
            this.dataGridViewUsers.DataSource = this.adminsBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(192, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(855, 529);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nRICDataGridViewTextBoxColumn
            // 
            this.nRICDataGridViewTextBoxColumn.DataPropertyName = "NRIC";
            this.nRICDataGridViewTextBoxColumn.HeaderText = "NRIC";
            this.nRICDataGridViewTextBoxColumn.Name = "nRICDataGridViewTextBoxColumn";
            this.nRICDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorityDataGridViewTextBoxColumn
            // 
            this.authorityDataGridViewTextBoxColumn.DataPropertyName = "Authority";
            this.authorityDataGridViewTextBoxColumn.HeaderText = "Authority";
            this.authorityDataGridViewTextBoxColumn.Name = "authorityDataGridViewTextBoxColumn";
            this.authorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniqueRFIDDataGridViewTextBoxColumn
            // 
            this.uniqueRFIDDataGridViewTextBoxColumn.DataPropertyName = "UniqueRFID";
            this.uniqueRFIDDataGridViewTextBoxColumn.HeaderText = "UniqueRFID";
            this.uniqueRFIDDataGridViewTextBoxColumn.Name = "uniqueRFIDDataGridViewTextBoxColumn";
            this.uniqueRFIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Manage";
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
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(142, 554);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(131, 29);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(149, 30);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Forms1.Properties.Resources.logo1;
            this.pictureBox1.InitialImage = global::Forms1.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1059, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewAllUsers";
            this.Text = "ViewAllUsers";
            this.Load += new System.EventHandler(this.ViewAllUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
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
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}