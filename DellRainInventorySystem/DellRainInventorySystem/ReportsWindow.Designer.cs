namespace DellRainInventorySystem
{
    partial class ReportsWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsWindow));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalSales = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesReports = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.pictureBox9);
            this.tabPage1.Controls.Add(this.btnSaveAccount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TotalSales);
            this.tabPage1.Controls.Add(this.To);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.From);
            this.tabPage1.Controls.Add(this.Chart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1139, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(395, 53);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sales";
            series1.ToolTip = "Revenue:  #VAL{N2}\\nDate       :  #VALX";
            series1.YValuesPerPoint = 2;
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(728, 489);
            this.Chart.TabIndex = 82;
            this.Chart.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(47, 24);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.Visible = false;
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAccount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAccount.Location = new System.Drawing.Point(136, 393);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(180, 43);
            this.btnSaveAccount.TabIndex = 78;
            this.btnSaveAccount.Text = "continue";
            this.btnSaveAccount.UseVisualStyleBackColor = true;
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Total sales";
            // 
            // TotalSales
            // 
            this.TotalSales.BackColor = System.Drawing.Color.White;
            this.TotalSales.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSales.Location = new System.Drawing.Point(94, 129);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.ReadOnly = true;
            this.TotalSales.Size = new System.Drawing.Size(291, 47);
            this.TotalSales.TabIndex = 76;
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(238, 283);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(151, 30);
            this.To.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Select time frame";
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(52, 283);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(151, 30);
            this.From.TabIndex = 73;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1139, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Reports";
            // 
            // SalesReports
            // 
            this.SalesReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesReports.Image = global::DellRainInventorySystem.Properties.Resources.reports;
            this.SalesReports.Location = new System.Drawing.Point(19, 12);
            this.SalesReports.Margin = new System.Windows.Forms.Padding(10);
            this.SalesReports.Name = "SalesReports";
            this.SalesReports.Size = new System.Drawing.Size(30, 30);
            this.SalesReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalesReports.TabIndex = 44;
            this.SalesReports.TabStop = false;
            // 
            // pictureBack
            // 
            this.pictureBack.Image = global::DellRainInventorySystem.Properties.Resources.Back;
            this.pictureBack.Location = new System.Drawing.Point(1143, 12);
            this.pictureBack.Name = "pictureBack";
            this.pictureBack.Size = new System.Drawing.Size(30, 30);
            this.pictureBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBack.TabIndex = 42;
            this.pictureBack.TabStop = false;
            this.pictureBack.Click += new System.EventHandler(this.pictureBack_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::DellRainInventorySystem.Properties.Resources.Philippine;
            this.pictureBox9.Location = new System.Drawing.Point(41, 129);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(47, 47);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 79;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::DellRainInventorySystem.Properties.Resources.right_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(207, 285);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::DellRainInventorySystem.Properties.Resources.print;
            this.pictureBox2.Location = new System.Drawing.Point(1035, 75);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DellRainInventorySystem.Properties.Resources.reload1;
            this.pictureBox1.Location = new System.Drawing.Point(1103, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(1055, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Print";
            // 
            // ReportsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 674);
            this.Controls.Add(this.SalesReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SalesReports;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalSales;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}