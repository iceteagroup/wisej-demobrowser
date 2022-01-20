
using Wisej.DemoBrowser.SalesDashboard.Components.Charts;

namespace Wisej.DemoBrowser.Dashboards.Sales.Components.Items.PieChartItemView
{
    partial class PieChartItem
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
            this.chartJS31 = new Wisej.Web.Ext.ChartJS3.ChartJS3();
            this.pieChartExample1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.PieChartExample();
            this.SuspendLayout();
            // 
            // chartJS31
            // 
            this.chartJS31.ChartType = Wisej.Web.Ext.ChartJS3.ChartType.Pie;
            this.chartJS31.Dock = Wisej.Web.DockStyle.Fill;
            this.chartJS31.Name = "chartJS31";
            this.chartJS31.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS31.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS31.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS31.Options.DataLabel.Opacity = 1F;
            this.chartJS31.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS3.DataLabelTextAlignment.Start;
            this.chartJS31.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS31.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS31.Size = new System.Drawing.Size(743, 310);
            this.chartJS31.TabIndex = 2;
            this.chartJS31.Text = "chartJS31";
            // 
            // pieChartExample1
            // 
            this.pieChartExample1.Dock = Wisej.Web.DockStyle.Fill;
            this.pieChartExample1.Name = "pieChartExample1";
            this.pieChartExample1.Size = new System.Drawing.Size(743, 310);
            this.pieChartExample1.TabIndex = 3;
            // 
            // PieChartItem
            // 
            this.Controls.Add(this.pieChartExample1);
            this.Controls.Add(this.chartJS31);
            this.Name = "PieChartItem";
            this.Load += new System.EventHandler(this.PieChartExample_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.chartJS31, 0);
            this.Controls.SetChildIndex(this.pieChartExample1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.ChartJS3.ChartJS3 chartJS31;
        private PieChartExample pieChartExample1;
    }
}
