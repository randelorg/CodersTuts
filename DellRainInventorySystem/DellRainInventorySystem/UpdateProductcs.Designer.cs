namespace DellRainInventorySystem
{
    partial class UpdateProductcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProductcs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductPreview = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.ShelfLife = new System.Windows.Forms.DateTimePicker();
            this.btnDone = new System.Windows.Forms.Button();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.tbSuppContact = new System.Windows.Forms.TextBox();
            this.tbSuppName = new System.Windows.Forms.TextBox();
            this.prodQty = new System.Windows.Forms.NumericUpDown();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DellRainInventorySystem.Properties.Resources.Supplier;
            this.pictureBox1.Location = new System.Drawing.Point(418, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductPreview);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Location = new System.Drawing.Point(428, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 246);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // ProductPreview
            // 
            this.ProductPreview.Image = global::DellRainInventorySystem.Properties.Resources.Photo;
            this.ProductPreview.Location = new System.Drawing.Point(28, 26);
            this.ProductPreview.Name = "ProductPreview";
            this.ProductPreview.Size = new System.Drawing.Size(160, 160);
            this.ProductPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPreview.TabIndex = 73;
            this.ProductPreview.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(26, 194);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(162, 30);
            this.btnImage.TabIndex = 67;
            this.btnImage.Text = "Upload New Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click_1);
            // 
            // ShelfLife
            // 
            this.ShelfLife.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfLife.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShelfLife.Location = new System.Drawing.Point(661, 348);
            this.ShelfLife.Name = "ShelfLife";
            this.ShelfLife.Size = new System.Drawing.Size(326, 30);
            this.ShelfLife.TabIndex = 100;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Tahoma", 16F);
            this.btnDone.Location = new System.Drawing.Point(864, 439);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(123, 107);
            this.btnDone.TabIndex = 99;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(955, 26);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 93;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // tbSuppContact
            // 
            this.tbSuppContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSuppContact.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuppContact.Location = new System.Drawing.Point(456, 516);
            this.tbSuppContact.MaxLength = 11;
            this.tbSuppContact.Name = "tbSuppContact";
            this.tbSuppContact.Size = new System.Drawing.Size(323, 30);
            this.tbSuppContact.TabIndex = 92;
            // 
            // tbSuppName
            // 
            this.tbSuppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSuppName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuppName.Location = new System.Drawing.Point(456, 467);
            this.tbSuppName.Name = "tbSuppName";
            this.tbSuppName.Size = new System.Drawing.Size(323, 30);
            this.tbSuppName.TabIndex = 91;
            // 
            // prodQty
            // 
            this.prodQty.Font = new System.Drawing.Font("Tahoma", 35F);
            this.prodQty.Location = new System.Drawing.Point(661, 101);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(326, 64);
            this.prodQty.TabIndex = 90;
            // 
            // tbLocation
            // 
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(661, 291);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(326, 30);
            this.tbLocation.TabIndex = 89;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(661, 242);
            this.tbPrice.MaxLength = 11;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(323, 30);
            this.tbPrice.TabIndex = 88;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(661, 193);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(326, 30);
            this.tbName.TabIndex = 87;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(451, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 27);
            this.label12.TabIndex = 86;
            this.label12.Text = "Update Supplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(451, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 27);
            this.label11.TabIndex = 85;
            this.label11.Text = "Update Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(453, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 84;
            this.label9.Text = "Supplier Contact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Supplier Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Product Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Product Shelf Life";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Add Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Product name";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::DellRainInventorySystem.Properties.Resources.pencil__1_;
            this.closeButton.Location = new System.Drawing.Point(418, 24);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 76;
            this.closeButton.TabStop = false;
            // 
            // ProductView
            // 
            this.ProductView.AllowUserToAddRows = false;
            this.ProductView.AllowUserToDeleteRows = false;
            this.ProductView.BackgroundColor = System.Drawing.Color.White;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.GridColor = System.Drawing.Color.White;
            this.ProductView.Location = new System.Drawing.Point(29, 62);
            this.ProductView.Name = "ProductView";
            this.ProductView.ReadOnly = true;
            this.ProductView.Size = new System.Drawing.Size(361, 484);
            this.ProductView.TabIndex = 103;
            this.ProductView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductView_RowHeaderMouseClick);
            this.ProductView.MouseHover += new System.EventHandler(this.ProductView_MouseHover);
            // 
            // Refresh
            // 
            this.Refresh.Image = global::DellRainInventorySystem.Properties.Resources.update;
            this.Refresh.Location = new System.Drawing.Point(29, 23);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(30, 30);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Refresh.TabIndex = 105;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            this.Refresh.MouseHover += new System.EventHandler(this.Refresh_MouseHover);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(68, 23);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(322, 30);
            this.tbSearch.TabIndex = 104;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.MouseHover += new System.EventHandler(this.tbSearch_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateProductcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 568);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShelfLife);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.tbSuppContact);
            this.Controls.Add(this.tbSuppName);
            this.Controls.Add(this.prodQty);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProductcs";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ProductPreview;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DateTimePicker ShelfLife;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.TextBox tbSuppContact;
        private System.Windows.Forms.TextBox tbSuppName;
        private System.Windows.Forms.NumericUpDown prodQty;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.DataGridView ProductView;
        public System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}