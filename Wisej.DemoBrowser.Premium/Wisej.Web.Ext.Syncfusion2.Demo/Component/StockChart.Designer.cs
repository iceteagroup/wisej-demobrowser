namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class StockChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockChart));
			this.stockChart1 = new Wisej.Web.Ext.Syncfusion2.StockChart();
			this.checkBoxIsTransposed = new Wisej.Web.CheckBox();
			this.checkBoxIsSelecEnableRtl = new Wisej.Web.CheckBox();
			this.checkBoxMultiSelect = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/stock-chart/es5-getting-start" +
    "ed/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/stock-chart/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.stockChart1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBoxIsSelecEnableRtl);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxIsTransposed);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxMultiSelect);
			// 
			// stockChart1
			// 
			this.stockChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.stockChart1.Location = new System.Drawing.Point(8, 8);
			this.stockChart1.Name = "stockChart1";
			this.stockChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("stockChart1.Options"))));
			this.stockChart1.Size = new System.Drawing.Size(872, 560);
			this.stockChart1.TabIndex = 0;
			this.stockChart1.Text = "stockChart1";
			// 
			// checkBoxIsTransposed
			// 
			this.checkBoxIsTransposed.Appearance = Wisej.Web.Appearance.Switch;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxIsTransposed, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxIsTransposed, true);
			this.checkBoxIsTransposed.Location = new System.Drawing.Point(3, 46);
			this.checkBoxIsTransposed.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxIsTransposed.Name = "checkBoxIsTransposed";
			this.checkBoxIsTransposed.Size = new System.Drawing.Size(212, 24);
			this.checkBoxIsTransposed.TabIndex = 1;
			this.checkBoxIsTransposed.Text = "Transposed";
			// 
			// checkBoxIsSelecEnableRtl
			// 
			this.checkBoxIsSelecEnableRtl.Appearance = Wisej.Web.Appearance.Switch;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxIsSelecEnableRtl, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxIsSelecEnableRtl, true);
			this.checkBoxIsSelecEnableRtl.Location = new System.Drawing.Point(3, 3);
			this.checkBoxIsSelecEnableRtl.Name = "checkBoxIsSelecEnableRtl";
			this.checkBoxIsSelecEnableRtl.Size = new System.Drawing.Size(212, 24);
			this.checkBoxIsSelecEnableRtl.TabIndex = 2;
			this.checkBoxIsSelecEnableRtl.Text = "Enable Right-To-Left";
			// 
			// checkBoxMultiSelect
			// 
			this.checkBoxMultiSelect.Appearance = Wisej.Web.Appearance.Switch;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxMultiSelect, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMultiSelect, true);
			this.checkBoxMultiSelect.Location = new System.Drawing.Point(3, 89);
			this.checkBoxMultiSelect.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxMultiSelect.Name = "checkBoxMultiSelect";
			this.checkBoxMultiSelect.Size = new System.Drawing.Size(212, 24);
			this.checkBoxMultiSelect.TabIndex = 3;
			this.checkBoxMultiSelect.Text = "Multi Select";
			// 
			// StockChart
			// 
			this.Name = "StockChart";
			this.Load += new System.EventHandler(this.StockChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.StockChart stockChart1;
        private CheckBox checkBoxIsSelecEnableRtl;
        private CheckBox checkBoxIsTransposed;
        private CheckBox checkBoxMultiSelect;
    }
}
