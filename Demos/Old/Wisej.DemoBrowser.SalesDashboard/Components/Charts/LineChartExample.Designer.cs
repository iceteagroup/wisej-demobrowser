
namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
    partial class LineChartExample
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
            this.chartLineExample = new Wisej.Web.Ext.ChartJS3.ChartJS3();
            this.SuspendLayout();
            // 
            // chartLineExample
            // 
            this.chartLineExample.Dock = Wisej.Web.DockStyle.Fill;
            this.chartLineExample.Labels = new string[] {
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
            this.chartLineExample.Name = "chartLineExample";
            this.chartLineExample.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartLineExample.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartLineExample.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartLineExample.Options.DataLabel.Opacity = 1F;
            this.chartLineExample.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS3.DataLabelTextAlignment.Start;
            this.chartLineExample.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartLineExample.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartLineExample.Size = new System.Drawing.Size(743, 254);
            this.chartLineExample.TabIndex = 0;
            this.chartLineExample.Text = "chartJS31";
            // 
            // LineChartExample
            // 
            this.Controls.Add(this.chartLineExample);
            this.Name = "LineChartExample";
            this.Size = new System.Drawing.Size(743, 300);
            this.Load += new System.EventHandler(this.LineChartExample_Load);
            this.Controls.SetChildIndex(this.chartLineExample, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public Web.Ext.ChartJS3.ChartJS3 chartLineExample;
    }
}
