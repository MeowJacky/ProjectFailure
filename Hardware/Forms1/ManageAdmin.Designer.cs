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
            System.Windows.Forms.TabPage tabPage1;
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Adusername = new System.Windows.Forms.Label();
            this.tbUserID1 = new System.Windows.Forms.TextBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbContact1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNRIC1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbAdd1 = new System.Windows.Forms.TextBox();
            this.ShiftStart1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.tbRFID1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClearS = new System.Windows.Forms.Button();
            this.btnDeleteW = new System.Windows.Forms.Button();
            this.btnModW = new System.Windows.Forms.Button();
            this.SearchWorker = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            tabPage1.Controls.Add(this.label16);
            tabPage1.Controls.Add(this.btnCancel);
            tabPage1.Controls.Add(this.ShiftStart);
            tabPage1.Controls.Add(this.tbUserID);
            tabPage1.Controls.Add(this.label8);
            tabPage1.Controls.Add(this.tbName);
            tabPage1.Controls.Add(this.button1);
            tabPage1.Controls.Add(this.tbContact);
            tabPage1.Controls.Add(this.label1);
            tabPage1.Controls.Add(this.btnDelete);
            tabPage1.Controls.Add(this.label2);
            tabPage1.Controls.Add(this.btnModify);
            tabPage1.Controls.Add(this.label3);
            tabPage1.Controls.Add(this.btnGetUser);
            tabPage1.Controls.Add(this.tbRFID);
            tabPage1.Controls.Add(this.label7);
            tabPage1.Controls.Add(this.label4);
            tabPage1.Controls.Add(this.tbAuthority);
            tabPage1.Controls.Add(this.tbNRIC);
            tabPage1.Controls.Add(this.label6);
            tabPage1.Controls.Add(this.label5);
            tabPage1.Controls.Add(this.tbAdd);
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(917, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Admin";
            tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(652, 395);
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
            this.ShiftStart.Location = new System.Drawing.Point(579, 255);
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
            this.tbUserID.Location = new System.Drawing.Point(160, 95);
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
            this.label8.Location = new System.Drawing.Point(470, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Shift Start";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(160, 156);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(221, 26);
            this.tbName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 395);
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
            this.tbContact.Location = new System.Drawing.Point(160, 269);
            this.tbContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(221, 26);
            this.tbContact.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(459, 395);
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
            this.label2.Location = new System.Drawing.Point(50, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(259, 395);
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
            this.label3.Location = new System.Drawing.Point(50, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact";
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(474, 79);
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
            this.tbRFID.Location = new System.Drawing.Point(579, 206);
            this.tbRFID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(145, 26);
            this.tbRFID.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(469, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Authority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(469, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "RFID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbAuthority
            // 
            this.tbAuthority.Location = new System.Drawing.Point(579, 156);
            this.tbAuthority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAuthority.Name = "tbAuthority";
            this.tbAuthority.Size = new System.Drawing.Size(145, 26);
            this.tbAuthority.TabIndex = 12;
            // 
            // tbNRIC
            // 
            this.tbNRIC.Location = new System.Drawing.Point(160, 213);
            this.tbNRIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNRIC.Name = "tbNRIC";
            this.tbNRIC.Size = new System.Drawing.Size(221, 26);
            this.tbNRIC.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "NRIC";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(160, 327);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(381, 26);
            this.tbAdd.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(197, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 519);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.SearchWorker);
            this.tabPage2.Controls.Add(this.btnClose);
            this.tabPage2.Controls.Add(this.btnClearS);
            this.tabPage2.Controls.Add(this.btnDeleteW);
            this.tabPage2.Controls.Add(this.btnModW);
            this.tabPage2.Controls.Add(this.ShiftStart1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbRFID1);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbUserID1);
            this.tabPage2.Controls.Add(this.tbName1);
            this.tabPage2.Controls.Add(this.tbContact1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbNRIC1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tbAdd1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Users";
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
            this.menuStrip1.Size = new System.Drawing.Size(184, 540);
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
            this.viewAllUsersToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.viewAllUsersToolStripMenuItem.Text = "View All Users";
            this.viewAllUsersToolStripMenuItem.Click += new System.EventHandler(this.viewAllUsersToolStripMenuItem_Click);
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.addAdminToolStripMenuItem.Text = "Add Admin";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
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
            // tbUserID1
            // 
            this.tbUserID1.Location = new System.Drawing.Point(160, 97);
            this.tbUserID1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUserID1.Name = "tbUserID1";
            this.tbUserID1.Size = new System.Drawing.Size(141, 26);
            this.tbUserID1.TabIndex = 12;
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(160, 158);
            this.tbName1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(221, 26);
            this.tbName1.TabIndex = 13;
            // 
            // tbContact1
            // 
            this.tbContact1.Location = new System.Drawing.Point(160, 271);
            this.tbContact1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContact1.Name = "tbContact1";
            this.tbContact1.Size = new System.Drawing.Size(221, 26);
            this.tbContact1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(50, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(50, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(50, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Contact";
            // 
            // tbNRIC1
            // 
            this.tbNRIC1.Location = new System.Drawing.Point(160, 215);
            this.tbNRIC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNRIC1.Name = "tbNRIC1";
            this.tbNRIC1.Size = new System.Drawing.Size(221, 26);
            this.tbNRIC1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(50, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(50, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "NRIC";
            // 
            // tbAdd1
            // 
            this.tbAdd1.Location = new System.Drawing.Point(160, 329);
            this.tbAdd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdd1.Name = "tbAdd1";
            this.tbAdd1.Size = new System.Drawing.Size(381, 26);
            this.tbAdd1.TabIndex = 20;
            // 
            // ShiftStart1
            // 
            this.ShiftStart1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ShiftStart1.Location = new System.Drawing.Point(579, 204);
            this.ShiftStart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShiftStart1.Name = "ShiftStart1";
            this.ShiftStart1.ShowUpDown = true;
            this.ShiftStart1.Size = new System.Drawing.Size(145, 26);
            this.ShiftStart1.TabIndex = 27;
            this.ShiftStart1.Value = new System.DateTime(2024, 1, 10, 16, 48, 34, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(470, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Shift Start";
            // 
            // tbRFID1
            // 
            this.tbRFID1.Location = new System.Drawing.Point(579, 155);
            this.tbRFID1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRFID1.Name = "tbRFID1";
            this.tbRFID1.Size = new System.Drawing.Size(145, 26);
            this.tbRFID1.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(469, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "RFID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(652, 395);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 60);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClearS
            // 
            this.btnClearS.Location = new System.Drawing.Point(54, 395);
            this.btnClearS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearS.Name = "btnClearS";
            this.btnClearS.Size = new System.Drawing.Size(150, 60);
            this.btnClearS.TabIndex = 31;
            this.btnClearS.Text = "Clear Search";
            this.btnClearS.UseVisualStyleBackColor = true;
            this.btnClearS.Click += new System.EventHandler(this.btnClearS_Click);
            // 
            // btnDeleteW
            // 
            this.btnDeleteW.Location = new System.Drawing.Point(459, 395);
            this.btnDeleteW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteW.Name = "btnDeleteW";
            this.btnDeleteW.Size = new System.Drawing.Size(150, 60);
            this.btnDeleteW.TabIndex = 29;
            this.btnDeleteW.Text = "Delete Worker";
            this.btnDeleteW.UseVisualStyleBackColor = true;
            this.btnDeleteW.Click += new System.EventHandler(this.btnDeleteW_Click);
            // 
            // btnModW
            // 
            this.btnModW.Location = new System.Drawing.Point(259, 395);
            this.btnModW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModW.Name = "btnModW";
            this.btnModW.Size = new System.Drawing.Size(150, 60);
            this.btnModW.TabIndex = 28;
            this.btnModW.Text = "Modify";
            this.btnModW.UseVisualStyleBackColor = true;
            this.btnModW.Click += new System.EventHandler(this.btnModW_Click);
            // 
            // SearchWorker
            // 
            this.SearchWorker.Location = new System.Drawing.Point(474, 84);
            this.SearchWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchWorker.Name = "SearchWorker";
            this.SearchWorker.Size = new System.Drawing.Size(251, 52);
            this.SearchWorker.TabIndex = 32;
            this.SearchWorker.Text = "Search Worker";
            this.SearchWorker.UseVisualStyleBackColor = true;
            this.SearchWorker.Click += new System.EventHandler(this.SearchWorker_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(47, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 37);
            this.label16.TabIndex = 24;
            this.label16.Text = "Edit Admins";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(47, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(201, 37);
            this.label17.TabIndex = 33;
            this.label17.Text = "Edit Workers";
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1134, 540);
            this.Controls.Add(this.Adusername);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageAdmin";
            this.Text = "ManageAdmin";
            this.Load += new System.EventHandler(this.ManageAdmin_Load);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllUsersToolStripMenuItem;
        private System.Windows.Forms.Label Adusername;
        private System.Windows.Forms.Button SearchWorker;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClearS;
        private System.Windows.Forms.Button btnDeleteW;
        private System.Windows.Forms.Button btnModW;
        private System.Windows.Forms.DateTimePicker ShiftStart1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbRFID1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbUserID1;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbContact1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNRIC1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbAdd1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}