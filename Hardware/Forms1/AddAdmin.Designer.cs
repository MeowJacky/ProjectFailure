namespace Forms1
{
    partial class AddAdmin
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
            System.Windows.Forms.TabControl tabControl1;
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AuthoritySelect = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.tbadd = new System.Windows.Forms.TextBox();
            this.tbcontact = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRFID1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAdd1 = new System.Windows.Forms.TextBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbContact1 = new System.Windows.Forms.TextBox();
            this.tbNRIC1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewusers = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Productmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignProductsToWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerQuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AUsername = new System.Windows.Forms.Label();
            this.loginLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthoritySelect)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.tabPage1);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Location = new System.Drawing.Point(190, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(672, 352);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbname);
            this.tabPage1.Controls.Add(this.tbpassword);
            this.tabPage1.Controls.Add(this.lblname);
            this.tabPage1.Controls.Add(this.lblpassword);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAddAdmin);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.AuthoritySelect);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbRFID);
            this.tabPage1.Controls.Add(this.tbNRIC);
            this.tabPage1.Controls.Add(this.tbadd);
            this.tabPage1.Controls.Add(this.tbcontact);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(125, 27);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(153, 26);
            this.tbname.TabIndex = 6;
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(438, 119);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(208, 26);
            this.tbpassword.TabIndex = 17;
            this.tbpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(34, 30);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(55, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(345, 119);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(82, 20);
            this.lblpassword.TabIndex = 16;
            this.lblpassword.Text = "Password:";
            this.lblpassword.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NRIC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(38, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 41);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Location = new System.Drawing.Point(349, 235);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(240, 41);
            this.btnAddAdmin.TabIndex = 13;
            this.btnAddAdmin.Text = "Add User";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Authority:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AuthoritySelect
            // 
            this.AuthoritySelect.Location = new System.Drawing.Point(438, 24);
            this.AuthoritySelect.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.AuthoritySelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AuthoritySelect.Name = "AuthoritySelect";
            this.AuthoritySelect.Size = new System.Drawing.Size(120, 26);
            this.AuthoritySelect.TabIndex = 12;
            this.AuthoritySelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "RFID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(438, 71);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(208, 26);
            this.tbRFID.TabIndex = 11;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(125, 77);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(153, 26);
            this.tbNRIC.TabIndex = 7;
            this.tbNRIC.TextChanged += new System.EventHandler(this.tbNRIC_TextChanged);
            // 
            // tbadd
            // 
            this.tbadd.Location = new System.Drawing.Point(125, 171);
            this.tbadd.Name = "tbadd";
            this.tbadd.Size = new System.Drawing.Size(277, 26);
            this.tbadd.TabIndex = 9;
            // 
            // tbcontact
            // 
            this.tbcontact.Location = new System.Drawing.Point(125, 122);
            this.tbcontact.Name = "tbcontact";
            this.tbcontact.Size = new System.Drawing.Size(153, 26);
            this.tbcontact.TabIndex = 8;
            this.tbcontact.TextChanged += new System.EventHandler(this.tbcontact_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbPassword1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnAdd1);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbRFID1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbAdd1);
            this.tabPage2.Controls.Add(this.tbName1);
            this.tabPage2.Controls.Add(this.tbContact1);
            this.tabPage2.Controls.Add(this.tbNRIC1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Workers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(429, 83);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.Size = new System.Drawing.Size(208, 26);
            this.tbPassword1.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "NRIC:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 41);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Contact:";
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(342, 240);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(240, 41);
            this.btnAdd1.TabIndex = 31;
            this.btnAdd1.Text = "Add User";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Address:";
            // 
            // tbRFID1
            // 
            this.tbRFID1.Location = new System.Drawing.Point(429, 35);
            this.tbRFID1.Name = "tbRFID1";
            this.tbRFID1.Size = new System.Drawing.Size(208, 26);
            this.tbRFID1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "RFID:";
            // 
            // tbAdd1
            // 
            this.tbAdd1.Location = new System.Drawing.Point(118, 176);
            this.tbAdd1.Name = "tbAdd1";
            this.tbAdd1.Size = new System.Drawing.Size(277, 26);
            this.tbAdd1.TabIndex = 28;
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(118, 32);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(153, 26);
            this.tbName1.TabIndex = 25;
            // 
            // tbContact1
            // 
            this.tbContact1.Location = new System.Drawing.Point(118, 127);
            this.tbContact1.Name = "tbContact1";
            this.tbContact1.Size = new System.Drawing.Size(153, 26);
            this.tbContact1.TabIndex = 27;
            this.tbContact1.TextChanged += new System.EventHandler(this.tbContact1_TextChanged);
            // 
            // tbNRIC1
            // 
            this.tbNRIC1.Location = new System.Drawing.Point(118, 82);
            this.tbNRIC1.Name = "tbNRIC1";
            this.tbNRIC1.Size = new System.Drawing.Size(153, 26);
            this.tbNRIC1.TabIndex = 26;
            this.tbNRIC1.TextChanged += new System.EventHandler(this.tbNRIC1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add New User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.menuStrip2.Size = new System.Drawing.Size(184, 427);
            this.menuStrip2.TabIndex = 19;
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
            this.loginLogsToolStripMenuItem});
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
            // AUsername
            // 
            this.AUsername.AutoSize = true;
            this.AUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AUsername.ForeColor = System.Drawing.Color.Black;
            this.AUsername.Location = new System.Drawing.Point(40, 223);
            this.AUsername.Name = "AUsername";
            this.AUsername.Size = new System.Drawing.Size(137, 22);
            this.AUsername.TabIndex = 20;
            this.AUsername.Text = "adminusername";
            // 
            // loginLogsToolStripMenuItem
            // 
            this.loginLogsToolStripMenuItem.Name = "loginLogsToolStripMenuItem";
            this.loginLogsToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.loginLogsToolStripMenuItem.Text = "Login Logs";
            this.loginLogsToolStripMenuItem.Click += new System.EventHandler(this.loginLogsToolStripMenuItem_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(874, 427);
            this.Controls.Add(this.AUsername);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthoritySelect)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.TextBox tbcontact;
        private System.Windows.Forms.TextBox tbadd;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.NumericUpDown AuthoritySelect;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRFID1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAdd1;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbContact1;
        private System.Windows.Forms.TextBox tbNRIC1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projectWSYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Viewusers;
        private System.Windows.Forms.ToolStripMenuItem currentAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Productmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem assignProductsToWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label AUsername;
        private System.Windows.Forms.ToolStripMenuItem workerQuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginLogsToolStripMenuItem;
    }
}