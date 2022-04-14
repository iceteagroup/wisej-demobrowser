namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoStockChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoStockChart));
            this.kendoStockChart1 = new Wisej.Web.Ext.Kendo.kendoStockChart();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoStockChart1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/financial/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/stock-chart";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/charts/stockchart/overview";
            // 
            // kendoStockChart1
            // 
            this.kendoStockChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoStockChart1.Location = new System.Drawing.Point(23, 20);
            this.kendoStockChart1.Name = "kendoStockChart1";
            this.kendoStockChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoStockChart1.Options"))));
            this.kendoStockChart1.Size = new System.Drawing.Size(1042, 518);
            this.kendoStockChart1.TabIndex = 0;
            this.kendoStockChart1.Text = "kendoStockChart1";
            this.kendoStockChart1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoStockChart1_WebRequest);
            // 
            // kendoStockChart
            // 
            this.MinimumSize = new System.Drawing.Size(830, 504);
            this.Name = "kendoStockChart";
            this.Load += new System.EventHandler(this.kendoStockChart_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoStockChart kendoStockChart1;
	}
}
