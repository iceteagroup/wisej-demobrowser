using Wisej.DemoBrowser.SalesDashboard.Components.Charts;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Items.BarChartItemView
{
	partial class BarChartItemInfo
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
            this.tabPage3 = new Wisej.Web.TabPage();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.barChartExample1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.BarChartExample();
            this.overviewDocItem1 = new Wisej.DemoBrowser.Common.Components.OverviewDocItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.labelTitle.Size = new System.Drawing.Size(409, 40);
            this.labelTitle.Text = "ChartJS Component / Bar Chart";
            // 
            // picBoxControl
            // 
            this.pictureBoxControl.ImageSource = "resource.wx/Icons/chartJS.png";
            // 
            // label1
            // 
            this.labelDescription.Size = new System.Drawing.Size(694, 20);
            this.labelDescription.Text = "With the ChartJS extention, Wisej offers easy ways to customize and bind your dat" +
    "a to display useful charts";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.overviewDocItem1);
            this.panel1.Controls.SetChildIndex(this.pictureBoxControl, 0);
            this.panel1.Controls.SetChildIndex(this.labelTitle, 0);
            this.panel1.Controls.SetChildIndex(this.labelDescription, 0);
            this.panel1.Controls.SetChildIndex(this.overviewDocItem1, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.barChartExample1);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.Text = "Coming Soon";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.Text = "Coming Soon";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.Text = "Coming Soon";
            // 
            // barChartExample1
            // 
            this.barChartExample1.Dock = Wisej.Web.DockStyle.Fill;
            this.barChartExample1.Location = new System.Drawing.Point(3, 21);
            this.barChartExample1.Name = "barChartExample1";
            this.barChartExample1.Size = new System.Drawing.Size(1466, 663);
            this.barChartExample1.TabIndex = 0;
            // 
            // overviewDocItem1
            // 
            this.overviewDocItem1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
            this.overviewDocItem1.Location = new System.Drawing.Point(1016, 91);
            this.overviewDocItem1.Name = "overviewDocItem1";
            this.overviewDocItem1.SampleIconSource = "Icons\\chartJS.png";
            this.overviewDocItem1.TabIndex = 4;
            this.overviewDocItem1.Title = "ChartJS";
            // 
            // BarChartItemInfo
            // 
            this.Name = "BarChartItemInfo";
            this.Load += new System.EventHandler(this.BarChartItemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxControl)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BarChartExample barChartExample1;
        private Web.TabPage tabPage1;
        private Common.Components.OverviewDocItem overviewDocItem1;
        private Web.TabPage tabPage2;
        private Web.TabPage tabPage3;
    }
}
