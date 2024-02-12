namespace Forms1
{
    partial class EditProds
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
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stocksnum = new System.Windows.Forms.NumericUpDown();
            this.numprice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rfid = new System.Windows.Forms.TextBox();
            this.tbdesc = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadfile = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbshelve = new System.Windows.Forms.TextBox();
            this.tbfile = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Adusername = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.projectWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Viewusers = new System.Windows.Forms.ToolStripMenuItem();
            this.currentAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Productmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.assignProductsToWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerQuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.stocksnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(225, 77);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(423, 26);
            this.tbSearchBar.TabIndex = 0;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.Location = new System.Drawing.Point(702, 73);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(119, 35);
            this.btnIDSearch.TabIndex = 2;
            this.btnIDSearch.Text = "Search ID";
            this.btnIDSearch.UseVisualStyleBackColor = true;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(231, 166);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(417, 26);
            this.ProdName.TabIndex = 5;
            this.ProdName.Text = "Product";
            this.ProdName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Current Stocks";
            // 
            // stocksnum
            // 
            this.stocksnum.Location = new System.Drawing.Point(231, 229);
            this.stocksnum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stocksnum.Name = "stocksnum";
            this.stocksnum.Size = new System.Drawing.Size(120, 26);
            this.stocksnum.TabIndex = 13;
            this.stocksnum.ValueChanged += new System.EventHandler(this.stocksnum_ValueChanged);
            // 
            // numprice
            // 
            this.numprice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numprice.Location = new System.Drawing.Point(523, 228);
            this.numprice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numprice.Name = "numprice";
            this.numprice.Size = new System.Drawing.Size(120, 26);
            this.numprice.TabIndex = 14;
            this.numprice.ValueChanged += new System.EventHandler(this.numprice_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(508, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "RFID";
            // 
            // rfid
            // 
            this.rfid.Location = new System.Drawing.Point(228, 291);
            this.rfid.Name = "rfid";
            this.rfid.Size = new System.Drawing.Size(217, 26);
            this.rfid.TabIndex = 18;
            this.rfid.TextChanged += new System.EventHandler(this.rfid_TextChanged);
            // 
            // tbdesc
            // 
            this.tbdesc.Location = new System.Drawing.Point(225, 353);
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(420, 157);
            this.tbdesc.TabIndex = 19;
            this.tbdesc.Text = "";
            this.tbdesc.TextChanged += new System.EventHandler(this.tbdesc_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Current Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Powder",
            "Bottles",
            "Stationary",
            "Pictures",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(372, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(702, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uploadfile
            // 
            this.uploadfile.Location = new System.Drawing.Point(702, 374);
            this.uploadfile.Name = "uploadfile";
            this.uploadfile.Size = new System.Drawing.Size(244, 29);
            this.uploadfile.TabIndex = 24;
            this.uploadfile.Text = "Upload New";
            this.uploadfile.UseVisualStyleBackColor = true;
            this.uploadfile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(827, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(702, 450);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(123, 37);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Modify Item";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Current Shelve";
            // 
            // tbshelve
            // 
            this.tbshelve.Location = new System.Drawing.Point(488, 291);
            this.tbshelve.Name = "tbshelve";
            this.tbshelve.Size = new System.Drawing.Size(100, 26);
            this.tbshelve.TabIndex = 28;
            this.tbshelve.TextChanged += new System.EventHandler(this.tbshelve_TextChanged);
            // 
            // tbfile
            // 
            this.tbfile.Location = new System.Drawing.Point(702, 342);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(244, 26);
            this.tbfile.TabIndex = 29;
            this.tbfile.TextChanged += new System.EventHandler(this.tbfile_TextChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(833, 73);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(119, 35);
            this.Clear.TabIndex = 30;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Adusername
            // 
            this.Adusername.AutoSize = true;
            this.Adusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Adusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adusername.Location = new System.Drawing.Point(25, 227);
            this.Adusername.Name = "Adusername";
            this.Adusername.Size = new System.Drawing.Size(137, 22);
            this.Adusername.TabIndex = 32;
            this.Adusername.Text = "adminusername";
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
            this.menuStrip2.Size = new System.Drawing.Size(184, 532);
            this.menuStrip2.TabIndex = 33;
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
            this.Viewusers.Size = new System.Drawing.Size(206, 30);
            this.Viewusers.Text = "View All Users";
            this.Viewusers.Click += new System.EventHandler(this.Viewusers_Click);
            // 
            // currentAdminToolStripMenuItem
            // 
            this.currentAdminToolStripMenuItem.Name = "currentAdminToolStripMenuItem";
            this.currentAdminToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.currentAdminToolStripMenuItem.Text = "Search Users";
            this.currentAdminToolStripMenuItem.Click += new System.EventHandler(this.currentAdminToolStripMenuItem_Click);
            // 
            // addAdminToolStripMenuItem
            // 
            this.addAdminToolStripMenuItem.Name = "addAdminToolStripMenuItem";
            this.addAdminToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.addAdminToolStripMenuItem.Text = "Add Users";
            this.addAdminToolStripMenuItem.Click += new System.EventHandler(this.addAdminToolStripMenuItem_Click);
            // 
            // Productmenu
            // 
            this.Productmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.assignProductsToWorkersToolStripMenuItem,
            this.workerQuotaToolStripMenuItem});
            this.Productmenu.Name = "Productmenu";
            this.Productmenu.Size = new System.Drawing.Size(171, 29);
            this.Productmenu.Text = "Manage products";
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
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // workerQuotaToolStripMenuItem
            // 
            this.workerQuotaToolStripMenuItem.Name = "workerQuotaToolStripMenuItem";
            this.workerQuotaToolStripMenuItem.Size = new System.Drawing.Size(316, 30);
            this.workerQuotaToolStripMenuItem.Text = "Worker Quota";
            this.workerQuotaToolStripMenuItem.Click += new System.EventHandler(this.workerQuotaToolStripMenuItem_Click);
            // 
            // EditProds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.Adusername);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.tbfile);
            this.Controls.Add(this.tbshelve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.uploadfile);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbdesc);
            this.Controls.Add(this.rfid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numprice);
            this.Controls.Add(this.stocksnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIDSearch);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.menuStrip2);
            this.Name = "EditProds";
            this.Text = "EditProds";
            ((System.ComponentModel.ISupportInitialize)(this.stocksnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown stocksnum;
        private System.Windows.Forms.NumericUpDown numprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rfid;
        private System.Windows.Forms.RichTextBox tbdesc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button uploadfile;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbshelve;
        private System.Windows.Forms.TextBox tbfile;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Adusername;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem projectWSYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Viewusers;
        private System.Windows.Forms.ToolStripMenuItem currentAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Productmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem assignProductsToWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workerQuotaToolStripMenuItem;
    }
}