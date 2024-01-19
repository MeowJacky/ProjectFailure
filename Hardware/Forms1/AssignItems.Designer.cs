namespace Forms1
{
    partial class AssignItems
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
            this.EmployeeDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityForEmployee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataSet = new Forms1.ProductDataSet();
            this.productsTableAdapter = new Forms1.ProductDataSetTableAdapters.ProductsTableAdapter();
            this.AssignButton = new System.Windows.Forms.Button();
            this.userDBDataSet = new Forms1.UserDBDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new Forms1.UserDBDataSetTableAdapters.AdminsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDropDown
            // 
            this.EmployeeDropDown.FormattingEnabled = true;
            this.EmployeeDropDown.Location = new System.Drawing.Point(150, 16);
            this.EmployeeDropDown.Name = "EmployeeDropDown";
            this.EmployeeDropDown.Size = new System.Drawing.Size(121, 24);
            this.EmployeeDropDown.TabIndex = 0;
            this.EmployeeDropDown.SelectedIndexChanged += new System.EventHandler(this.EmployeeDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(678, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 23);
            this.Back.TabIndex = 3;
            this.Back.Text = "Go Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.productNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.QuantityForEmployee});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 375);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // QuantityForEmployee
            // 
            this.QuantityForEmployee.HeaderText = "Quantity";
            this.QuantityForEmployee.Name = "QuantityForEmployee";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.productDataSet;
            // 
            // productDataSet
            // 
            this.productDataSet.DataSetName = "ProductDataSet";
            this.productDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(678, 440);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(94, 30);
            this.AssignButton.TabIndex = 5;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // userDBDataSet
            // 
            this.userDBDataSet.DataSetName = "UserDBDataSet";
            this.userDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.userDBDataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // AssignItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 473);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDropDown);
            this.Name = "AssignItems";
            this.Text = "AssignItems";
            this.Load += new System.EventHandler(this.AssignItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EmployeeDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductDataSet productDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ProductDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn QuantityForEmployee;
        private UserDBDataSet userDBDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private UserDBDataSetTableAdapters.AdminsTableAdapter adminsTableAdapter;
    }
}