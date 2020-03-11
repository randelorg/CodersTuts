namespace DellRainInventorySystem
{
    partial class index
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
            this.groupDasboard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopNav = new System.Windows.Forms.GroupBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnYourAccount = new System.Windows.Forms.Button();
            this.lbLogout = new System.Windows.Forms.Label();
            this.bg1 = new System.Windows.Forms.Button();
            this.bg2 = new System.Windows.Forms.Button();
            this.lbReports = new System.Windows.Forms.Label();
            this.lbInventory = new System.Windows.Forms.Label();
            this.bgTools = new System.Windows.Forms.Button();
            this.pictureTools = new System.Windows.Forms.PictureBox();
            this.Inventory = new System.Windows.Forms.PictureBox();
            this.SalesReports = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupDasboard.SuspendLayout();
            this.TopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDasboard
            // 
            this.groupDasboard.Controls.Add(this.label1);
            this.groupDasboard.Controls.Add(this.pictureBox2);
            this.groupDasboard.Location = new System.Drawing.Point(34, 64);
            this.groupDasboard.Name = "groupDasboard";
            this.groupDasboard.Size = new System.Drawing.Size(1035, 683);
            this.groupDasboard.TabIndex = 9;
            this.groupDasboard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dashboard";
            // 
            // TopNav
            // 
            this.TopNav.BackColor = System.Drawing.Color.Black;
            this.TopNav.Controls.Add(this.pictureBox1);
            this.TopNav.Controls.Add(this.UserIcon);
            this.TopNav.Controls.Add(this.lbUsername);
            this.TopNav.Controls.Add(this.btnCreateAccount);
            this.TopNav.Controls.Add(this.btnYourAccount);
            this.TopNav.Location = new System.Drawing.Point(-1, -1);
            this.TopNav.Name = "TopNav";
            this.TopNav.Size = new System.Drawing.Size(1271, 59);
            this.TopNav.TabIndex = 10;
            this.TopNav.TabStop = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(1072, 27);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(77, 17);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Username";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Gray;
            this.btnCreateAccount.Location = new System.Drawing.Point(420, 17);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(134, 36);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            this.btnCreateAccount.MouseLeave += new System.EventHandler(this.btnCreateAccount_MouseLeave);
            this.btnCreateAccount.MouseHover += new System.EventHandler(this.btnCreateAccount_MouseHover);
            // 
            // btnYourAccount
            // 
            this.btnYourAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourAccount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYourAccount.ForeColor = System.Drawing.Color.Gray;
            this.btnYourAccount.Location = new System.Drawing.Point(280, 17);
            this.btnYourAccount.Name = "btnYourAccount";
            this.btnYourAccount.Size = new System.Drawing.Size(134, 36);
            this.btnYourAccount.TabIndex = 5;
            this.btnYourAccount.Text = "Your Account";
            this.btnYourAccount.UseVisualStyleBackColor = true;
            this.btnYourAccount.Click += new System.EventHandler(this.btnYourAccount_Click);
            this.btnYourAccount.MouseLeave += new System.EventHandler(this.btnYourAccount_MouseLeave);
            this.btnYourAccount.MouseHover += new System.EventHandler(this.btnYourAccount_MouseHover);
            // 
            // lbLogout
            // 
            this.lbLogout.AutoSize = true;
            this.lbLogout.BackColor = System.Drawing.Color.Transparent;
            this.lbLogout.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogout.ForeColor = System.Drawing.Color.Black;
            this.lbLogout.Location = new System.Drawing.Point(1205, 64);
            this.lbLogout.Name = "lbLogout";
            this.lbLogout.Size = new System.Drawing.Size(52, 14);
            this.lbLogout.TabIndex = 10;
            this.lbLogout.Text = "Logout";
            this.lbLogout.Visible = false;
            // 
            // bg1
            // 
            this.bg1.Enabled = false;
            this.bg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg1.Location = new System.Drawing.Point(1075, 159);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(182, 208);
            this.bg1.TabIndex = 12;
            this.bg1.UseVisualStyleBackColor = true;
            // 
            // bg2
            // 
            this.bg2.Enabled = false;
            this.bg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bg2.Location = new System.Drawing.Point(1075, 366);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(182, 208);
            this.bg2.TabIndex = 12;
            this.bg2.UseVisualStyleBackColor = true;
            // 
            // lbReports
            // 
            this.lbReports.AutoSize = true;
            this.lbReports.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReports.ForeColor = System.Drawing.Color.White;
            this.lbReports.Location = new System.Drawing.Point(1129, 534);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(80, 14);
            this.lbReports.TabIndex = 15;
            this.lbReports.Text = "Sales Reports";
            this.lbReports.Visible = false;
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.ForeColor = System.Drawing.Color.White;
            this.lbInventory.Location = new System.Drawing.Point(1138, 314);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(60, 14);
            this.lbInventory.TabIndex = 16;
            this.lbInventory.Text = "Inventory";
            this.lbInventory.Visible = false;
            // 
            // bgTools
            // 
            this.bgTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgTools.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgTools.ForeColor = System.Drawing.Color.White;
            this.bgTools.Location = new System.Drawing.Point(1075, 129);
            this.bgTools.Name = "bgTools";
            this.bgTools.Size = new System.Drawing.Size(182, 30);
            this.bgTools.TabIndex = 17;
            this.bgTools.Text = "Tools";
            this.bgTools.UseVisualStyleBackColor = true;
            // 
            // pictureTools
            // 
            this.pictureTools.Image = global::DellRainInventorySystem.Properties.Resources.Tools;
            this.pictureTools.Location = new System.Drawing.Point(1075, 129);
            this.pictureTools.Name = "pictureTools";
            this.pictureTools.Size = new System.Drawing.Size(30, 30);
            this.pictureTools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTools.TabIndex = 10;
            this.pictureTools.TabStop = false;
            // 
            // Inventory
            // 
            this.Inventory.Image = global::DellRainInventorySystem.Properties.Resources.inventory2;
            this.Inventory.Location = new System.Drawing.Point(1110, 200);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(114, 123);
            this.Inventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Inventory.TabIndex = 14;
            this.Inventory.TabStop = false;
            this.Inventory.MouseLeave += new System.EventHandler(this.Inventory_MouseLeave);
            this.Inventory.MouseHover += new System.EventHandler(this.Inventory_MouseHover);
            // 
            // SalesReports
            // 
            this.SalesReports.Image = global::DellRainInventorySystem.Properties.Resources.Sales;
            this.SalesReports.Location = new System.Drawing.Point(1110, 408);
            this.SalesReports.Name = "SalesReports";
            this.SalesReports.Size = new System.Drawing.Size(114, 123);
            this.SalesReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalesReports.TabIndex = 13;
            this.SalesReports.TabStop = false;
            this.SalesReports.MouseLeave += new System.EventHandler(this.SalesReports_MouseLeave);
            this.SalesReports.MouseHover += new System.EventHandler(this.SalesReport_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DellRainInventorySystem.Properties.Resources.store;
            this.pictureBox1.Location = new System.Drawing.Point(51, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // UserIcon
            // 
            this.UserIcon.Image = global::DellRainInventorySystem.Properties.Resources.User;
            this.UserIcon.Location = new System.Drawing.Point(1030, 19);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(30, 30);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserIcon.TabIndex = 8;
            this.UserIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DellRainInventorySystem.Properties.Resources.dashboardHome;
            this.pictureBox2.Location = new System.Drawing.Point(16, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 771);
            this.Controls.Add(this.pictureTools);
            this.Controls.Add(this.bgTools);
            this.Controls.Add(this.lbInventory);
            this.Controls.Add(this.lbReports);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.SalesReports);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.Controls.Add(this.lbLogout);
            this.Controls.Add(this.TopNav);
            this.Controls.Add(this.groupDasboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.groupDasboard.ResumeLayout(false);
            this.groupDasboard.PerformLayout();
            this.TopNav.ResumeLayout(false);
            this.TopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupDasboard;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TopNav;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnYourAccount;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox UserIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLogout;
        private System.Windows.Forms.Button bg1;
        private System.Windows.Forms.Button bg2;
        private System.Windows.Forms.PictureBox SalesReports;
        private System.Windows.Forms.PictureBox Inventory;
        private System.Windows.Forms.Label lbReports;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.PictureBox pictureTools;
        private System.Windows.Forms.Button bgTools;
    }
}