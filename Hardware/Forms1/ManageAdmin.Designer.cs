namespace Forms1
{
    partial class ManageAdmin
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
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ShiftStart = new System.Windows.Forms.DateTimePicker();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetUser = new System.Windows.Forms.Button();
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAuthority = new System.Windows.Forms.TextBox();
            this.tbNRIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Adusername = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(208, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 37);
            this.label16.TabIndex = 24;
            this.label16.Text = "Edit Admins";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(813, 395);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 60);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ShiftStart
            // 
            this.ShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ShiftStart.Location = new System.Drawing.Point(740, 255);
            this.ShiftStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShiftStart.Name = "ShiftStart";
            this.ShiftStart.ShowUpDown = true;
            this.ShiftStart.Size = new System.Drawing.Size(145, 26);
            this.ShiftStart.TabIndex = 23;
            this.ShiftStart.Value = new System.DateTime(2024, 1, 10, 16, 48, 34, 0);
            this.ShiftStart.ValueChanged += new System.EventHandler(this.ShiftStart_ValueChanged);
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(321, 95);
            this.tbUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(141, 26);
            this.tbUserID.TabIndex = 0;
            this.tbUserID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(631, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Shift Start";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(321, 156);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(221, 26);
            this.tbName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "Clear Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(321, 269);
            this.tbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(221, 26);
            this.tbContact.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(620, 395);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 60);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Admin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(420, 395);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(150, 60);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(635, 79);
            this.btnGetUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetUser.Name = "btnGetUser";
            this.btnGetUser.Size = new System.Drawing.Size(251, 52);
            this.btnGetUser.TabIndex = 14;
            this.btnGetUser.Text = "Search Admin";
            this.btnGetUser.UseVisualStyleBackColor = true;
            this.btnGetUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(740, 206);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(145, 26);
            this.tbRFID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(630, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Authority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(630, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbAuthority
            // 
            this.tbAuthority.Location = new System.Drawing.Point(740, 156);
            this.tbAuthority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAuthority.Name = "tbAuthority";
            this.tbAuthority.Size = new System.Drawing.Size(145, 26);
            this.tbAuthority.TabIndex = 12;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(321, 213);
            this.tbNRIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(221, 26);
            this.tbNRIC.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(211, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(211, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "NRIC";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(321, 327);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(381, 26);
            this.tbAdd.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.manageUsersToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(184, 1025);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 36);
            this.toolStripMenuItem1.Text = "Project W-SYS";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Checked = true;
            this.manageUsersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllUsersToolStripMenuItem,
            this.addAdminToolStripMenuItem,
            this.addUsersToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 200, 0, 0);
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // viewAllUsersToolStripMenuItem
            // 
            this.viewAllUsersToolStripMenuItem.Name = "viewAllUsersToolStripMenuItem";
            this.viewAllUsersToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.viewAllUsersToolStripMenuItem.Text = "View All Users";
            this.viewAllUsersToolStripMenuItem.Click += new System.EventHandler(this.viewAllUsersToolStripMenuItem_Click);
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addUsersToolStripMenuItem.Text = "Add Users";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click_1);
            // 
            // Adusername
            // 
            this.Adusername.AutoSize = true;
            this.Adusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Adusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adusername.Location = new System.Drawing.Point(26, 226);
            this.Adusername.Name = "Adusername";
            this.Adusername.Size = new System.Drawing.Size(137, 22);
            this.Adusername.TabIndex = 26;
            this.Adusername.Text = "adminusername";
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1499, 1025);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Adusername);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.ShiftStart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbNRIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAuthority);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageAdmin";
            this.Text = "ManageAdmin";
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNRIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAuthority;
        private System.Windows.Forms.Button btnGetUser;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ShiftStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllUsersToolStripMenuItem;
        private System.Windows.Forms.Label Adusername;
        private System.Windows.Forms.Label label16;
    }
}