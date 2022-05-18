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
            this.textBoxTitle = new Wisej.Web.TextBox();
            this.buttonExportPDF = new Wisej.Web.Button();
            this.buttonExportImage = new Wisej.Web.Button();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoStockChart1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/financial/index";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/stock-chart";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/charts/stockchart/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBoxTitle);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonExportPDF);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonExportImage);
            // 
            // kendoStockChart1
            // 
            this.kendoStockChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoStockChart1.Location = new System.Drawing.Point(8, 8);
            this.kendoStockChart1.Name = "kendoStockChart1";
            this.kendoStockChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoStockChart1.Options"))));
            this.kendoStockChart1.Size = new System.Drawing.Size(872, 560);
            this.kendoStockChart1.TabIndex = 0;
            this.kendoStockChart1.Text = "kendoStockChart1";
            this.kendoStockChart1.WebRequest += new Wisej.Web.WebRequestHandler(this.kendoStockChart1_WebRequest);
            // 
            // textBoxTitle
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.textBoxTitle, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxTitle, true);
            this.textBoxTitle.LabelText = "Title";
            this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(212, 57);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "The Boeing Company\\nNYSE:BA";
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.ImageSource = "file-pdf";
            this.buttonExportPDF.Location = new System.Drawing.Point(3, 79);
            this.buttonExportPDF.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(40, 40);
            this.buttonExportPDF.TabIndex = 1;
            this.buttonExportPDF.Click += new System.EventHandler(this.buttonExportPDF_Click);
            // 
            // buttonExportImage
            // 
            this.buttonExportImage.ImageSource = "file-zip";
            this.buttonExportImage.Location = new System.Drawing.Point(49, 79);
            this.buttonExportImage.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExportImage.Name = "buttonExportImage";
            this.buttonExportImage.Size = new System.Drawing.Size(40, 40);
            this.buttonExportImage.TabIndex = 2;
            this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
            // 
            // kendoStockChart
            // 
            this.Name = "kendoStockChart";
            this.Load += new System.EventHandler(this.kendoStockChart_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoStockChart kendoStockChart1;
        private TextBox textBoxTitle;
        private Button buttonExportPDF;
        private Button buttonExportImage;
    }
}
