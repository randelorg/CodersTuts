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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsWindow));
            this.ProductsGraph = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridSalesDates = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnSaveAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalSales = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Hide = new System.Windows.Forms.CheckBox();
            this.QtyGroup = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrintProductQtyGraph = new System.Windows.Forms.PictureBox();
            this.QtyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.SalesReports = new System.Windows.Forms.PictureBox();
            this.pictureBack = new System.Windows.Forms.PictureBox();
            this.ProductsGraph.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalesDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.QtyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintProductQtyGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGraph
            // 
            this.ProductsGraph.Controls.Add(this.tabPage1);
            this.ProductsGraph.Controls.Add(this.tabPage2);
            this.ProductsGraph.Location = new System.Drawing.Point(20, 49);
            this.ProductsGraph.Name = "ProductsGraph";
            this.ProductsGraph.SelectedIndex = 0;
            this.ProductsGraph.Size = new System.Drawing.Size(1147, 604);
            this.ProductsGraph.TabIndex = 0;
            this.ProductsGraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductsGraph_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
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
            this.tabPage1.Text = "Revenue Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Image = global::DellRainInventorySystem.Properties.Resources.Hide_Window;
            this.checkBox1.Location = new System.Drawing.Point(1103, 9);
            this.checkBox1.MaximumSize = new System.Drawing.Size(30, 30);
            this.checkBox1.MinimumSize = new System.Drawing.Size(30, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 30);
            this.checkBox1.TabIndex = 83;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GridSalesDates);
            this.groupBox1.Location = new System.Drawing.Point(704, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 383);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Sales and Dates";
            // 
            // GridSalesDates
            // 
            this.GridSalesDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSalesDates.GridColor = System.Drawing.Color.White;
            this.GridSalesDates.Location = new System.Drawing.Point(60, 51);
            this.GridSalesDates.Name = "GridSalesDates";
            this.GridSalesDates.Size = new System.Drawing.Size(267, 311);
            this.GridSalesDates.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(1052, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Print";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.btnSaveAccount.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 77;
            this.label3.Text = "Total revenue";
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
            this.pictureBox2.Location = new System.Drawing.Point(1033, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(391, 45);
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
            title1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Revenue on each day";
            this.Chart.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Hide);
            this.tabPage2.Controls.Add(this.QtyGroup);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1139, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Hide
            // 
            this.Hide.Appearance = System.Windows.Forms.Appearance.Button;
            this.Hide.AutoSize = true;
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide.Image = global::DellRainInventorySystem.Properties.Resources.Hide_Window;
            this.Hide.Location = new System.Drawing.Point(1103, 6);
            this.Hide.MaximumSize = new System.Drawing.Size(30, 30);
            this.Hide.MinimumSize = new System.Drawing.Size(30, 30);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(30, 30);
            this.Hide.TabIndex = 45;
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.CheckedChanged += new System.EventHandler(this.Hide_CheckedChanged);
            this.Hide.MouseHover += new System.EventHandler(this.Hide_MouseHover);
            // 
            // QtyGroup
            // 
            this.QtyGroup.Controls.Add(this.label6);
            this.QtyGroup.Controls.Add(this.PrintProductQtyGraph);
            this.QtyGroup.Controls.Add(this.QtyChart);
            this.QtyGroup.Location = new System.Drawing.Point(517, 6);
            this.QtyGroup.Name = "QtyGroup";
            this.QtyGroup.Size = new System.Drawing.Size(616, 353);
            this.QtyGroup.TabIndex = 48;
            this.QtyGroup.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(71, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Print";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PrintProductQtyGraph
            // 
            this.PrintProductQtyGraph.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PrintProductQtyGraph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintProductQtyGraph.Image = global::DellRainInventorySystem.Properties.Resources.print;
            this.PrintProductQtyGraph.Location = new System.Drawing.Point(50, 322);
            this.PrintProductQtyGraph.Margin = new System.Windows.Forms.Padding(10);
            this.PrintProductQtyGraph.Name = "PrintProductQtyGraph";
            this.PrintProductQtyGraph.Size = new System.Drawing.Size(20, 20);
            this.PrintProductQtyGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PrintProductQtyGraph.TabIndex = 50;
            this.PrintProductQtyGraph.TabStop = false;
            this.PrintProductQtyGraph.Click += new System.EventHandler(this.PrintProductQtyGraph_Click);
            // 
            // QtyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.QtyChart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend2.Name = "Legend1";
            this.QtyChart.Legends.Add(legend2);
            this.QtyChart.Location = new System.Drawing.Point(26, 56);
            this.QtyChart.Name = "QtyChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Type";
            series2.ToolTip = "Qty      :  #VAL{N0}";
            series2.YValuesPerPoint = 2;
            this.QtyChart.Series.Add(series2);
            this.QtyChart.Size = new System.Drawing.Size(564, 284);
            this.QtyChart.TabIndex = 83;
            this.QtyChart.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Grocery and Appliance Quantity";
            this.QtyChart.Titles.Add(title2);
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
            // ReportsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 674);
            this.Controls.Add(this.SalesReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBack);
            this.Controls.Add(this.ProductsGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.ProductsGraph.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalesDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.QtyGroup.ResumeLayout(false);
            this.QtyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrintProductQtyGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ProductsGraph;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SalesReports;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalSales;
        private System.Windows.Forms.Button btnSaveAccount;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView GridSalesDates;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox QtyGroup;
        private System.Windows.Forms.DataVisualization.Charting.Chart QtyChart;
        private System.Windows.Forms.CheckBox Hide;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PrintProductQtyGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
    }
}