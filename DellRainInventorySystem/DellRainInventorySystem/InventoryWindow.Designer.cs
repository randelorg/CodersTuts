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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryWindow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.AddProduct = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.inventoryDBDataSet = new DellRainInventorySystem.InventoryDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DellRainInventorySystem.InventoryDBDataSetTableAdapters.ProductTableAdapter();
            this.inventoryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodShelfLifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.prodTypeDataGridViewTextBoxColumn,
            this.prodQtyDataGridViewTextBoxColumn,
            this.prodSoldDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.prodShelfLifeDataGridViewTextBoxColumn,
            this.salesDataGridViewTextBoxColumn,
            this.prodImageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 534);
            this.dataGridView1.TabIndex = 0;
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
            this.tbSearchProduct.Location = new System.Drawing.Point(942, 65);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(226, 33);
            this.tbSearchProduct.TabIndex = 38;
            // 
            // Search
            // 
            this.Search.Image = global::DellRainInventorySystem.Properties.Resources.Search;
            this.Search.Location = new System.Drawing.Point(906, 67);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(33, 33);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search.TabIndex = 42;
            this.Search.TabStop = false;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(1138, 12);
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
            this.AddProduct.Location = new System.Drawing.Point(24, 57);
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
            // inventoryDBDataSet
            // 
            this.inventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.inventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.inventoryDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // inventoryDBDataSetBindingSource
            // 
            this.inventoryDBDataSetBindingSource.DataSource = this.inventoryDBDataSet;
            this.inventoryDBDataSetBindingSource.Position = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "productId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "productId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "prodName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "prodName";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodTypeDataGridViewTextBoxColumn
            // 
            this.prodTypeDataGridViewTextBoxColumn.DataPropertyName = "prodType";
            this.prodTypeDataGridViewTextBoxColumn.HeaderText = "prodType";
            this.prodTypeDataGridViewTextBoxColumn.Name = "prodTypeDataGridViewTextBoxColumn";
            this.prodTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodQtyDataGridViewTextBoxColumn
            // 
            this.prodQtyDataGridViewTextBoxColumn.DataPropertyName = "prodQty";
            this.prodQtyDataGridViewTextBoxColumn.HeaderText = "prodQty";
            this.prodQtyDataGridViewTextBoxColumn.Name = "prodQtyDataGridViewTextBoxColumn";
            this.prodQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodSoldDataGridViewTextBoxColumn
            // 
            this.prodSoldDataGridViewTextBoxColumn.DataPropertyName = "prodSold";
            this.prodSoldDataGridViewTextBoxColumn.HeaderText = "prodSold";
            this.prodSoldDataGridViewTextBoxColumn.Name = "prodSoldDataGridViewTextBoxColumn";
            this.prodSoldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "prodPrice";
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodShelfLifeDataGridViewTextBoxColumn
            // 
            this.prodShelfLifeDataGridViewTextBoxColumn.DataPropertyName = "prodShelfLife";
            this.prodShelfLifeDataGridViewTextBoxColumn.HeaderText = "prodShelfLife";
            this.prodShelfLifeDataGridViewTextBoxColumn.Name = "prodShelfLifeDataGridViewTextBoxColumn";
            this.prodShelfLifeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesDataGridViewTextBoxColumn
            // 
            this.salesDataGridViewTextBoxColumn.DataPropertyName = "sales";
            this.salesDataGridViewTextBoxColumn.HeaderText = "sales";
            this.salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            this.salesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodImageDataGridViewTextBoxColumn
            // 
            this.prodImageDataGridViewTextBoxColumn.DataPropertyName = "prodImage";
            this.prodImageDataGridViewTextBoxColumn.HeaderText = "prodImage";
            this.prodImageDataGridViewTextBoxColumn.Name = "prodImageDataGridViewTextBoxColumn";
            this.prodImageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InventoryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1189, 656);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.tbSearchProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchProduct;
        private System.Windows.Forms.PictureBox AddProduct;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.PictureBox Search;
        private InventoryDBDataSet inventoryDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private InventoryDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodShelfLifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inventoryDBDataSetBindingSource;
    }
}