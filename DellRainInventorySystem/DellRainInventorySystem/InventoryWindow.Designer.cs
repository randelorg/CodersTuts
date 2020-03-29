namespace DellRainInventorySystem
{
    partial class InventoryWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_QuantityLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ShelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SuppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SuppContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_UpdateProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.AddProduct = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ProductName,
            this.col_ProductType,
            this.col_QuantityLeft,
            this.col_Price,
            this.col_ShelfLife,
            this.col_Location,
            this.col_Unit,
            this.col_SuppName,
            this.col_SuppContact,
            this.col_UpdateProduct});
            this.dataGridView1.Location = new System.Drawing.Point(60, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 525);
            this.dataGridView1.TabIndex = 0;
            // 
            // col_ProductName
            // 
            this.col_ProductName.HeaderText = "Product name";
            this.col_ProductName.Name = "col_ProductName";
            this.col_ProductName.ReadOnly = true;
            // 
            // col_ProductType
            // 
            this.col_ProductType.HeaderText = "Product Type";
            this.col_ProductType.Name = "col_ProductType";
            this.col_ProductType.ReadOnly = true;
            // 
            // col_QuantityLeft
            // 
            this.col_QuantityLeft.HeaderText = "Quantity Left";
            this.col_QuantityLeft.Name = "col_QuantityLeft";
            this.col_QuantityLeft.ReadOnly = true;
            // 
            // col_Price
            // 
            this.col_Price.HeaderText = "Price";
            this.col_Price.Name = "col_Price";
            this.col_Price.ReadOnly = true;
            // 
            // col_ShelfLife
            // 
            this.col_ShelfLife.HeaderText = "Shelf Life";
            this.col_ShelfLife.Name = "col_ShelfLife";
            this.col_ShelfLife.ReadOnly = true;
            // 
            // col_Location
            // 
            this.col_Location.HeaderText = "Location";
            this.col_Location.Name = "col_Location";
            this.col_Location.ReadOnly = true;
            // 
            // col_Unit
            // 
            this.col_Unit.HeaderText = "Product Unit";
            this.col_Unit.Name = "col_Unit";
            this.col_Unit.ReadOnly = true;
            // 
            // col_SuppName
            // 
            this.col_SuppName.HeaderText = "Supplier Name";
            this.col_SuppName.Name = "col_SuppName";
            this.col_SuppName.ReadOnly = true;
            // 
            // col_SuppContact
            // 
            this.col_SuppContact.HeaderText = "Supplier Contact";
            this.col_SuppContact.Name = "col_SuppContact";
            this.col_SuppContact.ReadOnly = true;
            // 
            // col_UpdateProduct
            // 
            this.col_UpdateProduct.HeaderText = "Update Product";
            this.col_UpdateProduct.Name = "col_UpdateProduct";
            this.col_UpdateProduct.ReadOnly = true;
            this.col_UpdateProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_UpdateProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Inventory";
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchProduct.Location = new System.Drawing.Point(877, 82);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(226, 33);
            this.tbSearchProduct.TabIndex = 38;
            // 
            // Search
            // 
            this.Search.Image = global::DellRainInventorySystem.Properties.Resources.Search;
            this.Search.Location = new System.Drawing.Point(841, 84);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(33, 33);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search.TabIndex = 42;
            this.Search.TabStop = false;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(1123, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 41;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.Image = global::DellRainInventorySystem.Properties.Resources.addProduct;
            this.AddProduct.Location = new System.Drawing.Point(60, 76);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(176, 39);
            this.AddProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddProduct.TabIndex = 40;
            this.AddProduct.TabStop = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::DellRainInventorySystem.Properties.Resources.inventory2;
            this.closeButton.Location = new System.Drawing.Point(12, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 36;
            this.closeButton.TabStop = false;
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 669);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InventoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_QuantityLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ShelfLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SuppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SuppContact;
        private System.Windows.Forms.DataGridViewButtonColumn col_UpdateProduct;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.PictureBox AddProduct;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.PictureBox Search;
    }
}