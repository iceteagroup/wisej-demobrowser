
namespace Wisej.DemoBrowser.SalesDashboard.Components.Items.ComplexComponent
{
    partial class ComplexItem
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new Wisej.Web.Panel();
            this.mainChart = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.BarChartExample();
            this.panel2 = new Wisej.Web.Panel();
            this.tableLayoutPanel1 = new Wisej.Web.TableLayoutPanel();
            this.chartProduct3 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.BarChartExample();
            this.chartProduct2 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.BarChartExample();
            this.chartProduct1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.BarChartExample();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 427);
            this.button1.Size = new System.Drawing.Size(934, 38);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainChart);
            this.panel1.Dock = Wisej.Web.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 278);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // mainChart
            // 
            this.mainChart.Dock = Wisej.Web.DockStyle.Fill;
            this.mainChart.Name = "mainChart";
            this.mainChart.Size = new System.Drawing.Size(934, 278);
            this.mainChart.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 149);
            this.panel2.TabIndex = 2;
            this.panel2.TabStop = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.chartProduct3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartProduct2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartProduct1, 0, 0);
            this.tableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new Wisej.Web.Padding(10);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // chartProduct3
            // 
            this.chartProduct3.Location = new System.Drawing.Point(621, 13);
            this.chartProduct3.MaxValue = 300;
            this.chartProduct3.Name = "chartProduct3";
            this.chartProduct3.Size = new System.Drawing.Size(300, 123);
            this.chartProduct3.TabIndex = 2;
            // 
            // chartProduct2
            // 
            this.chartProduct2.Location = new System.Drawing.Point(317, 13);
            this.chartProduct2.MaxValue = 3600;
            this.chartProduct2.Name = "chartProduct2";
            this.chartProduct2.Size = new System.Drawing.Size(298, 123);
            this.chartProduct2.TabIndex = 1;
            // 
            // chartProduct1
            // 
            this.chartProduct1.Location = new System.Drawing.Point(13, 13);
            this.chartProduct1.MaxValue = 5400;
            this.chartProduct1.Name = "chartProduct1";
            this.chartProduct1.Size = new System.Drawing.Size(298, 123);
            this.chartProduct1.TabIndex = 0;
            // 
            // ComplexItem
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ComplexItem";
            this.Size = new System.Drawing.Size(934, 465);
            this.Load += new System.EventHandler(this.ComplexItem_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Charts.BarChartExample mainChart;
        private Web.Panel panel2;
        private Web.TableLayoutPanel tableLayoutPanel1;
        private Charts.BarChartExample chartProduct1;
        private Charts.BarChartExample chartProduct3;
        private Charts.BarChartExample chartProduct2;
    }
}
