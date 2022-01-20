
namespace Wisej.DemoBrowser.SalesDashboard.Components.Items.ChartsGroupView
{
    partial class ChartsGroupItem
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
            this.chartsGroup1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.ChartsGroup();
            this.SuspendLayout();
            // 
            // chartsGroup1
            // 
            this.chartsGroup1.ChartType1 = Wisej.Web.Ext.ChartJS3.ChartType.Pie;
            this.chartsGroup1.ChartType2 = Wisej.Web.Ext.ChartJS3.ChartType.Pie;
            this.chartsGroup1.ChartType3 = Wisej.Web.Ext.ChartJS3.ChartType.Pie;
            this.chartsGroup1.Dock = Wisej.Web.DockStyle.Fill;
            this.chartsGroup1.Name = "chartsGroup1";
            this.chartsGroup1.Size = new System.Drawing.Size(743, 310);
            this.chartsGroup1.TabIndex = 1;
            // 
            // ChartsGroupItem
            // 
            this.Controls.Add(this.chartsGroup1);
            this.Name = "ChartsGroupItem";
            this.Load += new System.EventHandler(this.ChartsGroupItem_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.chartsGroup1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Charts.ChartsGroup chartsGroup1;
    }
}
