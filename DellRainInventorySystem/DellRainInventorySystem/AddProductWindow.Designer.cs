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
            this.lbAdddProduct = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAdddProduct
            // 
            this.lbAdddProduct.AutoSize = true;
            this.lbAdddProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdddProduct.Location = new System.Drawing.Point(46, 15);
            this.lbAdddProduct.Name = "lbAdddProduct";
            this.lbAdddProduct.Size = new System.Drawing.Size(140, 25);
            this.lbAdddProduct.TabIndex = 39;
            this.lbAdddProduct.Text = "Add Product";
            // 
            // closeButton
            // 
            this.closeButton.Image = global::DellRainInventorySystem.Properties.Resources.add;
            this.closeButton.Location = new System.Drawing.Point(12, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 38;
            this.closeButton.TabStop = false;
            // 
            // AddProductWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 856);
            this.Controls.Add(this.lbAdddProduct);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductWindow";
            this.Text = "AddProductWindow";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAdddProduct;
        private System.Windows.Forms.PictureBox closeButton;
    }
}