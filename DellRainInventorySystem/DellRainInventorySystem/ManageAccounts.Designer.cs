namespace DellRainInventorySystem
{
    partial class ManageAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccounts));
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDBDataSet = new DellRainInventorySystem.InventoryDBDataSet();
            this.accountTableAdapter = new DellRainInventorySystem.InventoryDBDataSetTableAdapters.AccountTableAdapter();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.NewEmployee = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.AutoGenerateColumns = false;
            this.EmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.accTypeDataGridViewTextBoxColumn});
            this.EmployeeList.DataSource = this.accountBindingSource;
            this.EmployeeList.GridColor = System.Drawing.Color.White;
            this.EmployeeList.Location = new System.Drawing.Point(33, 69);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeList.Size = new System.Drawing.Size(717, 408);
            this.EmployeeList.TabIndex = 0;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Mobile No.";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // accTypeDataGridViewTextBoxColumn
            // 
            this.accTypeDataGridViewTextBoxColumn.DataPropertyName = "accType";
            this.accTypeDataGridViewTextBoxColumn.HeaderText = "Position";
            this.accTypeDataGridViewTextBoxColumn.Name = "accTypeDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProduct.Location = new System.Drawing.Point(437, 33);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(226, 30);
            this.tbSearchProduct.TabIndex = 46;
            this.tbSearchProduct.TextChanged += new System.EventHandler(this.tbSearchProduct_TextChanged);
            this.tbSearchProduct.MouseHover += new System.EventHandler(this.tbSearchProduct_MouseHover);
            // 
            // Refresh
            // 
            this.Refresh.Image = global::DellRainInventorySystem.Properties.Resources.reload1;
            this.Refresh.Location = new System.Drawing.Point(669, 33);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(30, 30);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Refresh.TabIndex = 49;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // NewEmployee
            // 
            this.NewEmployee.Image = global::DellRainInventorySystem.Properties.Resources.AddAccount;
            this.NewEmployee.Location = new System.Drawing.Point(33, 33);
            this.NewEmployee.Name = "NewEmployee";
            this.NewEmployee.Size = new System.Drawing.Size(30, 30);
            this.NewEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewEmployee.TabIndex = 47;
            this.NewEmployee.TabStop = false;
            this.NewEmployee.Click += new System.EventHandler(this.NewEmployee_Click);
            this.NewEmployee.MouseHover += new System.EventHandler(this.NewEmployee_MouseHover);
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(720, 33);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 19;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            this.pictureBack.MouseHover += new System.EventHandler(this.Back);
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 509);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.NewEmployee);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.EmployeeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employe List";
            this.Load += new System.EventHandler(this.ManageAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.PictureBox pictureBack;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private InventoryDBDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accTypeDataGridViewTextBoxColumn;
        public System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.PictureBox NewEmployee;
        private System.Windows.Forms.TextBox tbSearchProduct;
    }
}