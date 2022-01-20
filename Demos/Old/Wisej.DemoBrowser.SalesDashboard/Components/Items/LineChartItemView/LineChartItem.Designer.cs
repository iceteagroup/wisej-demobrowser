
using Wisej.DemoBrowser.SalesDashboard.Components.Charts;

namespace Wisej.DemoBrowser.Dashboards.Sales.Views.Items.LineChartItemView
{
    partial class LineChartItem
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
            this.lineChartExample1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.LineChartExample();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 262);
            // 
            // lineChartExample1
            // 
            this.lineChartExample1.Dock = Wisej.Web.DockStyle.Fill;
            this.lineChartExample1.Name = "lineChartExample1";
            this.lineChartExample1.Size = new System.Drawing.Size(743, 262);
            this.lineChartExample1.TabIndex = 1;
            // 
            // LineChartItem
            // 
            this.Controls.Add(this.lineChartExample1);
            this.Name = "LineChartItem";
            this.Size = new System.Drawing.Size(743, 300);
            this.Load += new System.EventHandler(this.LineChartExample_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lineChartExample1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private LineChartExample lineChartExample1;
    }
}
