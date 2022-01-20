
namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
    partial class BarChartExample
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
            this.chartBarExample = new Wisej.Web.Ext.ChartJS3.ChartJS3();
            this.SuspendLayout();
            // 
            // chartBarExample
            // 
            this.chartBarExample.ChartType = Wisej.Web.Ext.ChartJS3.ChartType.Bar;
            this.chartBarExample.Dock = Wisej.Web.DockStyle.Fill;
            this.chartBarExample.Labels = new string[] {
        "Jan",
        "Feb",
        "Mar",
        "Apr",
        "May",
        "Jun",
        "Jul",
        "Aug",
        "Sep",
        "Oct",
        "Nov",
        "Dec"};
            this.chartBarExample.Name = "chartBarExample";
            this.chartBarExample.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartBarExample.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartBarExample.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartBarExample.Options.DataLabel.Opacity = 1F;
            this.chartBarExample.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS3.DataLabelTextAlignment.Start;
            this.chartBarExample.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartBarExample.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartBarExample.Size = new System.Drawing.Size(735, 267);
            this.chartBarExample.TabIndex = 2;
            this.chartBarExample.Text = "chartJS31";
            // 
            // BarChartExample
            // 
            this.Controls.Add(this.chartBarExample);
            this.Name = "BarChartExample";
            this.Size = new System.Drawing.Size(735, 267);
            this.Load += new System.EventHandler(this.BarChartExample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Web.Ext.ChartJS3.ChartJS3 chartBarExample;
    }
}
