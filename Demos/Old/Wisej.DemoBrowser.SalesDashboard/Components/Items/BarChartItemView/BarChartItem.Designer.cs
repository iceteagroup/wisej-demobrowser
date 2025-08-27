
using Wisej.DemoBrowser.SalesDashboard.Components.Charts;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts.Items.BarChartItemView
{
    partial class BarChartItem
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
            this.barChartExample1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.BarChartExample();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barChartExample1
            // 
            this.barChartExample1.Dock = Wisej.Web.DockStyle.Fill;
            this.barChartExample1.Name = "barChartExample1";
            this.barChartExample1.Size = new System.Drawing.Size(743, 310);
            this.barChartExample1.TabIndex = 1;
            // 
            // BarChartItem
            // 
            this.Controls.Add(this.barChartExample1);
            this.Name = "BarChartItem";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.barChartExample1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private BarChartExample barChartExample1;
    }
}
