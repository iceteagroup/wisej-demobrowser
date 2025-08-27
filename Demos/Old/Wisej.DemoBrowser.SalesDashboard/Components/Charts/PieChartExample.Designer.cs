
namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
    partial class PieChartExample
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
            this.chartJS31.Size = new System.Drawing.Size(699, 275);
            this.chartJS31.TabIndex = 2;
            this.chartJS31.Text = "chartJS31";
            // 
            // PieChartExample
            // 
            this.Controls.Add(this.chartJS31);
            this.Name = "PieChartExample";
            this.Size = new System.Drawing.Size(699, 275);
            this.Load += new System.EventHandler(this.PieChartExample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.ChartJS3.ChartJS3 chartJS31;
    }
}
