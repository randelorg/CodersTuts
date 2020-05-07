using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class ReportsWindow : Form
    {
        private SqlConnection con = new SqlConnection(Connect.MainConn);
        private SqlCommand cmd;
        private BindingSource binder = new BindingSource();
        private Inventory inventory = new Inventory();
        private ToolTip tt = new ToolTip();

        private int appliance, grocery;
        
        public ReportsWindow()
        {
            InitializeComponent();

            //load the graph qty
            appliance = inventory.CountApplianceProductsQty();
            grocery = inventory.CountGroceriesProductsQty();
            LoadProductQTyGraph();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //initiate report class 
            var repo = new Report(From.Text, To.Text);

            //invoke sales reports method
            var total = repo.SalesReport();

            //display the total sales in the time frame provided
            TotalSales.Text = total.ToString("F", CultureInfo.InvariantCulture);

            //load data grid
            LoadTable();

            //load the bar graph
            LoadSalesGraph();
        }

        private void LoadSalesGraph()
        {
            Chart.Series["Sales"].XValueMember = "date";
            Chart.Series["Sales"].XValueType = ChartValueType.Date;
            Chart.Series["Sales"].YValueMembers = "sales";
            Chart.Series["Sales"].YValueType= ChartValueType.Double;
            Chart.DataSource = binder;
            Chart.DataBind();
        }

        private void LoadTable()
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT DISTINCT date, sales FROM Inventory.Sales WHERE date BETWEEN @from AND @to ORDER BY sales DESC";
                cmd.Parameters.AddWithValue("@from", From.Text);
                cmd.Parameters.AddWithValue("@to", To.Text);

                DataTable record;
                using (var sdr = new SqlDataAdapter(cmd))
                {
                    record = new DataTable();
                    sdr.Fill(record);
                }

                GridSalesDates.DataSource = binder;
                binder.DataSource = record;
            }

            catch (SqlException a)
            {
                Console.WriteLine(a.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        //print the bar chart sales graph
        private void LoadProductQTyGraph()
        {
            QtyChart.Series["Type"].Points.AddXY("Appliance", appliance);
            QtyChart.Series["Type"].Points.AddXY("Grocery", grocery);
        }

        private void Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (Hide.Checked)
                QtyGroup.Hide();
            else 
                QtyGroup.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                groupBox1.Hide();
            else
                groupBox1.Show();
        }

        private void ProductsGraph_MouseClick(object sender, MouseEventArgs e)
        {
            OpenInventory();

            if (appliance < 0 || grocery < 0)
                return;
        }

        //open inventory window
        private void OpenInventory()
        {
            var inventory = new InventoryWindow();
            inventory.TopLevel = false;
            inventory.Visible = true;
            inventory.FormBorderStyle = FormBorderStyle.None;
            inventory.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(inventory);
        }

        //tooltips
        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(checkBox1, "Hide this grid");
            if(checkBox1.Checked)
                tt.SetToolTip(checkBox1, "Show the grid");
        }

        private void Hide_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Hide, "Hide this graph");
            if (Hide.Checked)
                tt.SetToolTip(Hide, "Show the graph");
        }

        //printing
        private void PrintProductQtyGraph_Click(object sender, EventArgs e)
        {
            QtyChart.Printing.PrintPreview();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox2_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            PrintProductQtyGraph_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Chart.Printing.PrintPreview();
        }
    }
}
