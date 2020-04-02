namespace DellRainInventorySystem
{
    partial class CreateAccount
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
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbProfile = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDefaultPassword = new System.Windows.Forms.TextBox();
            this.lbGenPass = new System.Windows.Forms.Label();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.PictureBox();
            this.GenPass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.White;
            this.tbLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.Location = new System.Drawing.Point(212, 176);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(172, 27);
            this.tbLastName.TabIndex = 32;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.White;
            this.tbFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(32, 176);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(165, 27);
            this.tbFirstName.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 30;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Lastname";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(29, 159);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(59, 14);
            this.label.TabIndex = 28;
            this.label.Text = "Firstname";
            // 
            // lbProfile
            // 
            this.lbProfile.AutoSize = true;
            this.lbProfile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfile.Location = new System.Drawing.Point(148, 28);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(116, 19);
            this.lbProfile.TabIndex = 36;
            this.lbProfile.Text = "Create Account";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(29, 272);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(47, 14);
            this.lbGender.TabIndex = 37;
            this.lbGender.Text = "Gender";
            // 
            // cbGender
            // 
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(32, 289);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(350, 27);
            this.cbGender.TabIndex = 38;
            this.cbGender.Text = "Select gender";
            // 
            // cbPosition
            // 
            this.cbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPosition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbPosition.Location = new System.Drawing.Point(32, 349);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(350, 27);
            this.cbPosition.TabIndex = 39;
            this.cbPosition.Text = "Select position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "Default Password";
            // 
            // tbDefaultPassword
            // 
            this.tbDefaultPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefaultPassword.Location = new System.Drawing.Point(31, 451);
            this.tbDefaultPassword.Name = "tbDefaultPassword";
            this.tbDefaultPassword.PasswordChar = '.';
            this.tbDefaultPassword.Size = new System.Drawing.Size(313, 26);
            this.tbDefaultPassword.TabIndex = 41;
            // 
            // lbGenPass
            // 
            this.lbGenPass.AutoSize = true;
            this.lbGenPass.Location = new System.Drawing.Point(291, 482);
            this.lbGenPass.Name = "lbGenPass";
            this.lbGenPass.Size = new System.Drawing.Size(100, 13);
            this.lbGenPass.TabIndex = 43;
            this.lbGenPass.Text = "Generate Password";
            this.lbGenPass.Visible = false;
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAccount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAccount.Location = new System.Drawing.Point(117, 507);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(180, 43);
            this.btnSaveAccount.TabIndex = 44;
            this.btnSaveAccount.Text = "Save Account";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // showPassword
            // 
            this.showPassword.Image = global::DellRainInventorySystem.Properties.Resources.Eye;
            this.showPassword.Location = new System.Drawing.Point(315, 455);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(20, 20);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassword.TabIndex = 45;
            this.showPassword.TabStop = false;
            // 
            // GenPass
            // 
            this.GenPass.Image = global::DellRainInventorySystem.Properties.Resources.generatePassword;
            this.GenPass.Location = new System.Drawing.Point(350, 449);
            this.GenPass.Name = "GenPass";
            this.GenPass.Size = new System.Drawing.Size(30, 30);
            this.GenPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GenPass.TabIndex = 42;
            this.GenPass.TabStop = false;
            this.GenPass.MouseLeave += new System.EventHandler(this.GenPass_MouseLeave);
            this.GenPass.MouseHover += new System.EventHandler(this.GenPass_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DellRainInventorySystem.Properties.Resources.CreateAccountIcon;
            this.pictureBox1.Location = new System.Drawing.Point(164, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(366, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 34;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(31, 398);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(313, 27);
            this.tbUsername.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "Username";
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.White;
            this.tbNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumber.ForeColor = System.Drawing.Color.Black;
            this.tbNumber.Location = new System.Drawing.Point(34, 232);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(350, 27);
            this.tbNumber.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 48;
            this.label5.Text = "Contact number";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 561);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.btnSaveAccount);
            this.Controls.Add(this.lbGenPass);
            this.Controls.Add(this.GenPass);
            this.Controls.Add(this.tbDefaultPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDefaultPassword;
        private System.Windows.Forms.PictureBox GenPass;
        private System.Windows.Forms.Label lbGenPass;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.PictureBox showPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label5;
    }
}