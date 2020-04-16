namespace DellRainInventorySystem
{
    partial class SoldProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoldProduct));
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.SoldView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductPreview = new System.Windows.Forms.PictureBox();
            this.ShelfLife = new System.Windows.Forms.DateTimePicker();
            this.btnDone = new System.Windows.Forms.Button();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.prodQty = new System.Windows.Forms.NumericUpDown();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoldView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Refresh
            // 
            this.Refresh.Image = global::DellRainInventorySystem.Properties.Resources.update;
            this.Refresh.Location = new System.Drawing.Point(27, 25);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(30, 30);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Refresh.TabIndex = 129;
            this.Refresh.TabStop = false;
            this.Refresh.MouseHover += new System.EventHandler(this.Refresh_MouseHover);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(66, 25);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 30);
            this.tbSearch.TabIndex = 128;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // SoldView
            // 
            this.SoldView.AllowUserToAddRows = false;
            this.SoldView.AllowUserToDeleteRows = false;
            this.SoldView.BackgroundColor = System.Drawing.Color.White;
            this.SoldView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoldView.GridColor = System.Drawing.Color.White;
            this.SoldView.Location = new System.Drawing.Point(27, 64);
            this.SoldView.Name = "SoldView";
            this.SoldView.ReadOnly = true;
            this.SoldView.Size = new System.Drawing.Size(361, 478);
            this.SoldView.TabIndex = 127;
            this.SoldView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SoldView_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductPreview);
            this.groupBox1.Location = new System.Drawing.Point(425, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 246);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // ProductPreview
            // 
            this.ProductPreview.Image = global::DellRainInventorySystem.Properties.Resources.Photo;
            this.ProductPreview.Location = new System.Drawing.Point(29, 47);
            this.ProductPreview.Name = "ProductPreview";
            this.ProductPreview.Size = new System.Drawing.Size(160, 160);
            this.ProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPreview.TabIndex = 73;
            this.ProductPreview.TabStop = false;
            // 
            // ShelfLife
            // 
            this.ShelfLife.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfLife.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShelfLife.Location = new System.Drawing.Point(659, 369);
            this.ShelfLife.Name = "ShelfLife";
            this.ShelfLife.Size = new System.Drawing.Size(326, 30);
            this.ShelfLife.TabIndex = 124;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnDone.Location = new System.Drawing.Point(569, 439);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(300, 76);
            this.btnDone.TabIndex = 123;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(953, 28);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 122;
            this.pictureBack.TabStop = false;
            this.pictureBack.MouseHover += new System.EventHandler(this.pictureBack_MouseHover);
            // 
            // prodQty
            // 
            this.prodQty.Font = new System.Drawing.Font("Tahoma", 45F);
            this.prodQty.Location = new System.Drawing.Point(659, 103);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(326, 80);
            this.prodQty.TabIndex = 119;
            // 
            // tbLocation
            // 
            this.tbLocation.BackColor = System.Drawing.Color.White;
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(659, 312);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.ReadOnly = true;
            this.tbLocation.Size = new System.Drawing.Size(326, 23);
            this.tbLocation.TabIndex = 118;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.White;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(659, 263);
            this.tbPrice.MaxLength = 11;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(326, 23);
            this.tbPrice.TabIndex = 117;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(659, 214);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(326, 23);
            this.tbName.TabIndex = 116;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(449, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 27);
            this.label11.TabIndex = 114;
            this.label11.Text = "Sold Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Product Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(656, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Product Shelf Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Quantity Sold";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 107;
            this.label1.Text = "Product name";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::DellRainInventorySystem.Properties.Resources.Sold;
            this.closeButton.Location = new System.Drawing.Point(416, 26);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 106;
            this.closeButton.TabStop = false;
            // 
            // SoldProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 572);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.SoldView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShelfLife);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.prodQty);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoldProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sold Product";
            this.Load += new System.EventHandler(this.SoldProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoldView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView SoldView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ProductPreview;
        private System.Windows.Forms.DateTimePicker ShelfLife;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.NumericUpDown prodQty;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeButton;
    }
}