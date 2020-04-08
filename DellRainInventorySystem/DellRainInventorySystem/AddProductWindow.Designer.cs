namespace DellRainInventorySystem
{
    partial class AddProductWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductWindow));
            this.lbAdddProduct = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.prodQty = new System.Windows.Forms.NumericUpDown();
            this.tbSuppName = new System.Windows.Forms.TextBox();
            this.tbSuppContact = new System.Windows.Forms.TextBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.cbListOfSupplier = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbProductLocation = new System.Windows.Forms.ComboBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.ShelfLife = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAdddProduct
            // 
            this.lbAdddProduct.AutoSize = true;
            this.lbAdddProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdddProduct.Location = new System.Drawing.Point(55, 20);
            this.lbAdddProduct.Name = "lbAdddProduct";
            this.lbAdddProduct.Size = new System.Drawing.Size(140, 25);
            this.lbAdddProduct.TabIndex = 39;
            this.lbAdddProduct.Text = "Add Product";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::DellRainInventorySystem.Properties.Resources.NewAdd;
            this.closeButton.Location = new System.Drawing.Point(12, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 38;
            this.closeButton.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Product Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Product Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Product Shelf Life";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Product Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(525, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Supplier Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Supplier Contact";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Product Image";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "Product Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(523, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "Supplier Details";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(47, 100);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(449, 30);
            this.tbName.TabIndex = 52;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(47, 272);
            this.tbPrice.MaxLength = 6;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(449, 30);
            this.tbPrice.TabIndex = 55;
            // 
            // tbLocation
            // 
            this.tbLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLocation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(45, 384);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(449, 30);
            this.tbLocation.TabIndex = 57;
            this.tbLocation.TextChanged += new System.EventHandler(this.tbLocation_TextChanged);
            // 
            // prodQty
            // 
            this.prodQty.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodQty.Location = new System.Drawing.Point(47, 214);
            this.prodQty.Name = "prodQty";
            this.prodQty.Size = new System.Drawing.Size(449, 30);
            this.prodQty.TabIndex = 60;
            // 
            // tbSuppName
            // 
            this.tbSuppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSuppName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuppName.Location = new System.Drawing.Point(528, 251);
            this.tbSuppName.Name = "tbSuppName";
            this.tbSuppName.Size = new System.Drawing.Size(449, 30);
            this.tbSuppName.TabIndex = 62;
            this.tbSuppName.TextChanged += new System.EventHandler(this.tbSuppName_TextChanged);
            // 
            // tbSuppContact
            // 
            this.tbSuppContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSuppContact.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSuppContact.Location = new System.Drawing.Point(527, 304);
            this.tbSuppContact.MaxLength = 11;
            this.tbSuppContact.Name = "tbSuppContact";
            this.tbSuppContact.Size = new System.Drawing.Size(449, 30);
            this.tbSuppContact.TabIndex = 63;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(947, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 64;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            this.pictureBack.MouseHover += new System.EventHandler(this.Back);
            // 
            // cbListOfSupplier
            // 
            this.cbListOfSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListOfSupplier.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListOfSupplier.FormattingEnabled = true;
            this.cbListOfSupplier.Location = new System.Drawing.Point(527, 204);
            this.cbListOfSupplier.Name = "cbListOfSupplier";
            this.cbListOfSupplier.Size = new System.Drawing.Size(449, 31);
            this.cbListOfSupplier.TabIndex = 65;
            this.cbListOfSupplier.SelectedIndexChanged += new System.EventHandler(this.cbListOfSupplier_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label13.Location = new System.Drawing.Point(526, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 66;
            this.label13.Text = "or add new";
            // 
            // btnImage
            // 
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(48, 443);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(446, 30);
            this.btnImage.TabIndex = 67;
            this.btnImage.Text = "Choose Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label14.Location = new System.Drawing.Point(45, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "or add new";
            // 
            // cbProductLocation
            // 
            this.cbProductLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductLocation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductLocation.FormattingEnabled = true;
            this.cbProductLocation.Location = new System.Drawing.Point(45, 332);
            this.cbProductLocation.Name = "cbProductLocation";
            this.cbProductLocation.Size = new System.Drawing.Size(449, 31);
            this.cbProductLocation.TabIndex = 68;
            this.cbProductLocation.SelectedIndexChanged += new System.EventHandler(this.cbProductLocation_SelectedIndexChanged);
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Items.AddRange(new object[] {
            "Appliance",
            "Grocery"});
            this.cbProductType.Location = new System.Drawing.Point(46, 156);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(449, 31);
            this.cbProductType.TabIndex = 70;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.Location = new System.Drawing.Point(621, 375);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(245, 57);
            this.btnSaveProduct.TabIndex = 71;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // ShelfLife
            // 
            this.ShelfLife.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShelfLife.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShelfLife.Location = new System.Drawing.Point(527, 101);
            this.ShelfLife.Name = "ShelfLife";
            this.ShelfLife.Size = new System.Drawing.Size(450, 30);
            this.ShelfLife.TabIndex = 72;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Title = "Browse Product Image";
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 507);
            this.Controls.Add(this.ShelfLife);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.cbProductType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbProductLocation);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbListOfSupplier);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.tbSuppContact);
            this.Controls.Add(this.tbSuppName);
            this.Controls.Add(this.prodQty);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAdddProduct);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.AddProductWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdddProduct;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.NumericUpDown prodQty;
        private System.Windows.Forms.TextBox tbSuppName;
        private System.Windows.Forms.TextBox tbSuppContact;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.ComboBox cbListOfSupplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbProductLocation;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.DateTimePicker ShelfLife;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}