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
            ((System.ComponentModel.ISupportInitialize)(this.stocksnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(19, 77);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(423, 26);
            this.tbSearchBar.TabIndex = 0;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.Location = new System.Drawing.Point(496, 73);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(119, 35);
            this.btnIDSearch.TabIndex = 2;
            this.btnIDSearch.Text = "ID";
            this.btnIDSearch.UseVisualStyleBackColor = true;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // ProdName
            // 
            this.ProdName.Location = new System.Drawing.Point(25, 166);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(417, 26);
            this.ProdName.TabIndex = 5;
            this.ProdName.Text = "Product";
            this.ProdName.TextChanged += new System.EventHandler(this.ProdName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Current Stocks";
            // 
            // stocksnum
            // 
            this.stocksnum.Location = new System.Drawing.Point(25, 229);
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
            this.numprice.Location = new System.Drawing.Point(317, 228);
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
            this.label8.Location = new System.Drawing.Point(302, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Current Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "RFID";
            // 
            // rfid
            // 
            this.rfid.Location = new System.Drawing.Point(22, 291);
            this.rfid.Name = "rfid";
            this.rfid.Size = new System.Drawing.Size(217, 26);
            this.rfid.TabIndex = 18;
            this.rfid.TextChanged += new System.EventHandler(this.rfid_TextChanged);
            // 
            // tbdesc
            // 
            this.tbdesc.Location = new System.Drawing.Point(19, 353);
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.Size = new System.Drawing.Size(420, 157);
            this.tbdesc.TabIndex = 19;
            this.tbdesc.Text = "";
            this.tbdesc.TextChanged += new System.EventHandler(this.tbdesc_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Current Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 205);
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
            this.comboBox1.Location = new System.Drawing.Point(166, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(496, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uploadfile
            // 
            this.uploadfile.Location = new System.Drawing.Point(496, 374);
            this.uploadfile.Name = "uploadfile";
            this.uploadfile.Size = new System.Drawing.Size(244, 29);
            this.uploadfile.TabIndex = 24;
            this.uploadfile.Text = "Upload New";
            this.uploadfile.UseVisualStyleBackColor = true;
            this.uploadfile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(621, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(496, 450);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(123, 35);
            this.btnChange.TabIndex = 26;
            this.btnChange.Text = "Modify Item";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Current Shelve";
            // 
            // tbshelve
            // 
            this.tbshelve.Location = new System.Drawing.Point(282, 291);
            this.tbshelve.Name = "tbshelve";
            this.tbshelve.Size = new System.Drawing.Size(100, 26);
            this.tbshelve.TabIndex = 28;
            this.tbshelve.TextChanged += new System.EventHandler(this.tbshelve_TextChanged);
            // 
            // tbfile
            // 
            this.tbfile.Location = new System.Drawing.Point(496, 342);
            this.tbfile.Name = "tbfile";
            this.tbfile.Size = new System.Drawing.Size(244, 26);
            this.tbfile.TabIndex = 29;
            this.tbfile.TextChanged += new System.EventHandler(this.tbfile_TextChanged);
            // 
            // EditProds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 534);
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
            this.Name = "EditProds";
            this.Text = "EditProds";
            ((System.ComponentModel.ISupportInitialize)(this.stocksnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}