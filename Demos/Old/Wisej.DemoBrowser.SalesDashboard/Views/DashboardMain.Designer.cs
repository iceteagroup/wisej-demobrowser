
namespace Wisej.DemoBrowser.SalesDashboard.Views
{
    partial class DashboardMain
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
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.card1 = new Wisej.DemoBrowser.Common.Components.Card();
			this.card2 = new Wisej.DemoBrowser.Common.Components.Card();
			this.card3 = new Wisej.DemoBrowser.Common.Components.Card();
			this.card4 = new Wisej.DemoBrowser.Common.Components.Card();
			this.flowLayoutPanel2 = new Wisej.Web.FlowLayoutPanel();
			this.panel2 = new Wisej.Web.Panel();
			this.barChartItem1 = new Wisej.DemoBrowser.SalesDashboard.Components.Charts.Items.BarChartItemView.BarChartItem();
			this.panel3 = new Wisej.Web.Panel();
			this.lineChartItem1 = new Wisej.DemoBrowser.Dashboards.Sales.Views.Items.LineChartItemView.LineChartItem();
			this.panel4 = new Wisej.Web.Panel();
			this.pieChartItem1 = new Wisej.DemoBrowser.Dashboards.Sales.Components.Items.PieChartItemView.PieChartItem();
			this.panel5 = new Wisej.Web.Panel();
			this.progressView1 = new Wisej.DemoBrowser.SalesDashboard.Components.Items.ProgressView.ProgressView();
			this.panel6 = new Wisej.Web.Panel();
			this.cacClvView1 = new Wisej.DemoBrowser.SalesDashboard.Components.Items.CAC_CLVView.CacClvView();
			this.tabControl1.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
			// 
			// tabMain
			// 
			this.tabMain.Location = new System.Drawing.Point(1, 35);
			this.tabMain.Size = new System.Drawing.Size(1498, 814);
			this.tabMain.Text = "Sales Dashboard";
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(0, 764);
			this.panel1.Size = new System.Drawing.Size(1498, 50);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Clear();
			this.tableLayoutPanel1.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Padding = new Wisej.Web.Padding(3);
			this.tableLayoutPanel1.RowStyles.Clear();
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 19F));
			this.tableLayoutPanel1.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 75F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1498, 814);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.card1);
			this.flowLayoutPanel1.Controls.Add(this.card2);
			this.flowLayoutPanel1.Controls.Add(this.card3);
			this.flowLayoutPanel1.Controls.Add(this.card4);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(5);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1486, 157);
			this.flowLayoutPanel1.TabIndex = 0;
			this.flowLayoutPanel1.TabStop = true;
			// 
			// card1
			// 
			this.card1.BackgroundColor = System.Drawing.Color.FromArgb(73, 134, 194);
			this.card1.ButtonText = "See more";
			this.card1.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/cart-plus.svg";
			this.card1.Content = "1250";
			this.flowLayoutPanel1.SetFillWeight(this.card1, 1);
			this.card1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card1.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card1.Location = new System.Drawing.Point(8, 8);
			this.card1.Name = "card1";
			this.card1.Size = new System.Drawing.Size(363, 140);
			this.card1.TabIndex = 0;
			this.card1.Title = "New Orders";
			// 
			// card2
			// 
			this.card2.BackgroundColor = System.Drawing.Color.FromArgb(11, 205, 112);
			this.card2.ButtonText = "See more";
			this.card2.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/bar-chart.svg";
			this.card2.Content = "61%";
			this.flowLayoutPanel1.SetFillWeight(this.card2, 1);
			this.card2.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card2.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card2.Location = new System.Drawing.Point(377, 8);
			this.card2.Name = "card2";
			this.card2.Size = new System.Drawing.Size(363, 140);
			this.card2.TabIndex = 1;
			this.card2.Title = "Bounce Rate";
			// 
			// card3
			// 
			this.card3.BackgroundColor = System.Drawing.Color.FromName("@invalid");
			this.card3.ButtonText = "See more";
			this.card3.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/user-plus.svg";
			this.card3.Content = "450";
			this.flowLayoutPanel1.SetFillWeight(this.card3, 1);
			this.card3.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card3.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card3.Location = new System.Drawing.Point(746, 8);
			this.card3.Name = "card3";
			this.card3.Size = new System.Drawing.Size(363, 140);
			this.card3.TabIndex = 2;
			this.card3.Title = "Registrations";
			// 
			// card4
			// 
			this.card4.BackgroundColor = System.Drawing.Color.FromArgb(224, 63, 17);
			this.card4.ButtonText = "See more";
			this.card4.CardIconSource = "resource.wx/Wisej.Ext.FontAwesome/pie-chart.svg";
			this.card4.Content = "2577";
			this.flowLayoutPanel1.SetFillWeight(this.card4, 1);
			this.card4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card4.ForegroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
			this.card4.Location = new System.Drawing.Point(1115, 8);
			this.card4.Name = "card4";
			this.card4.Size = new System.Drawing.Size(363, 140);
			this.card4.TabIndex = 3;
			this.card4.Title = "Unique Users";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.panel2);
			this.flowLayoutPanel2.Controls.Add(this.panel3);
			this.flowLayoutPanel2.Controls.Add(this.panel4);
			this.flowLayoutPanel2.Controls.Add(this.panel5);
			this.flowLayoutPanel2.Controls.Add(this.panel6);
			this.flowLayoutPanel2.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 169);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(1486, 639);
			this.flowLayoutPanel2.TabIndex = 1;
			this.flowLayoutPanel2.TabStop = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.barChartItem1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.ShowCloseButton = false;
			this.panel2.ShowHeader = true;
			this.panel2.Size = new System.Drawing.Size(545, 247);
			this.panel2.TabIndex = 0;
			this.panel2.TabStop = true;
			this.panel2.Text = "Sales Chart";
			// 
			// barChartItem1
			// 
			this.barChartItem1.Dock = Wisej.Web.DockStyle.Fill;
			this.barChartItem1.Name = "barChartItem1";
			this.barChartItem1.Size = new System.Drawing.Size(545, 219);
			this.barChartItem1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lineChartItem1);
			this.panel3.Location = new System.Drawing.Point(554, 3);
			this.panel3.Name = "panel3";
			this.panel3.ShowCloseButton = false;
			this.panel3.ShowHeader = true;
			this.panel3.Size = new System.Drawing.Size(545, 247);
			this.panel3.TabIndex = 1;
			this.panel3.TabStop = true;
			this.panel3.Text = "Visitors Chart";
			// 
			// lineChartItem1
			// 
			this.lineChartItem1.Dock = Wisej.Web.DockStyle.Fill;
			this.lineChartItem1.Name = "lineChartItem1";
			this.lineChartItem1.Size = new System.Drawing.Size(545, 219);
			this.lineChartItem1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.pieChartItem1);
			this.flowLayoutPanel2.SetFillWeight(this.panel4, 1);
			this.flowLayoutPanel2.SetFlowBreak(this.panel4, true);
			this.panel4.Location = new System.Drawing.Point(1105, 3);
			this.panel4.Name = "panel4";
			this.panel4.ShowCloseButton = false;
			this.panel4.ShowHeader = true;
			this.panel4.Size = new System.Drawing.Size(378, 247);
			this.panel4.TabIndex = 2;
			this.panel4.TabStop = true;
			this.panel4.Text = "Campagne Statistics Chart";
			// 
			// pieChartItem1
			// 
			this.pieChartItem1.Dock = Wisej.Web.DockStyle.Fill;
			this.pieChartItem1.Name = "pieChartItem1";
			this.pieChartItem1.Size = new System.Drawing.Size(378, 219);
			this.pieChartItem1.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.progressView1);
			this.panel5.Location = new System.Drawing.Point(3, 256);
			this.panel5.Name = "panel5";
			this.panel5.ShowCloseButton = false;
			this.panel5.ShowHeader = true;
			this.panel5.Size = new System.Drawing.Size(629, 329);
			this.panel5.TabIndex = 3;
			this.panel5.TabStop = true;
			this.panel5.Text = "Targets";
			// 
			// progressView1
			// 
			this.progressView1.Dock = Wisej.Web.DockStyle.Fill;
			this.progressView1.Name = "progressView1";
			this.progressView1.Padding = new Wisej.Web.Padding(0);
			this.progressView1.Size = new System.Drawing.Size(629, 301);
			this.progressView1.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.cacClvView1);
			this.flowLayoutPanel2.SetFillWeight(this.panel6, 1);
			this.panel6.Location = new System.Drawing.Point(638, 256);
			this.panel6.Name = "panel6";
			this.panel6.ShowHeader = true;
			this.panel6.Size = new System.Drawing.Size(845, 329);
			this.panel6.TabIndex = 4;
			this.panel6.TabStop = true;
			this.panel6.Text = "Additional Info";
			// 
			// cacClvView1
			// 
			this.cacClvView1.Dock = Wisej.Web.DockStyle.Fill;
			this.cacClvView1.Name = "cacClvView1";
			this.cacClvView1.Size = new System.Drawing.Size(845, 301);
			this.cacClvView1.TabIndex = 0;
			// 
			// DashboardMain
			// 
			this.Name = "DashboardMain";
			this.Load += new System.EventHandler(this.DashboardMain_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Common.Components.Card card1;
        private Common.Components.Card card2;
        private Common.Components.Card card3;
        private Common.Components.Card card4;
        private Web.FlowLayoutPanel flowLayoutPanel2;
        private Web.Panel panel2;
        private Components.Charts.Items.BarChartItemView.BarChartItem barChartItem1;
        private Web.Panel panel3;
        private Dashboards.Sales.Views.Items.LineChartItemView.LineChartItem lineChartItem1;
        private Web.Panel panel4;
        private Dashboards.Sales.Components.Items.PieChartItemView.PieChartItem pieChartItem1;
        private Web.Panel panel5;
        private Components.Items.ProgressView.ProgressView progressView1;
        private Web.Panel panel6;
        private Components.Items.CAC_CLVView.CacClvView cacClvView1;

        #endregion

        //private Views.Items.PieChartItemView.PieChartItem pieChartItem1;
        //private Views.Items.BarChartItemView.BarChartItem barChartItem1;
        //private Views.Items.LineChartItemView.LineChartItem lineChartItem1;
    }
}
