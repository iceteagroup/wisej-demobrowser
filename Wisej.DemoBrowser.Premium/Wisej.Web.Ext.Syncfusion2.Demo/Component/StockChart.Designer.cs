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
            this.stockChart1 = new Wisej.Web.Ext.Syncfusion2.StockChart();
            this.checkBoxIsTranspoed = new Wisej.Web.CheckBox();
            this.checkBoxIsSelect = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/stock-chart/es5-getting-start" +
    "ed/";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/stock-chart/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsSelect);
            this.groupBox1.Controls.Add(this.checkBoxIsTranspoed);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxIsTranspoed, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxIsSelect, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.stockChart1);
            // 
            // stockChart1
            // 
            this.stockChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.stockChart1.Location = new System.Drawing.Point(8, 8);
            this.stockChart1.Name = "stockChart1";
            this.stockChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"title\":\"Sales Analysis\",\"series\":[{\"name\":\"Sales\",\"type\":\"Candle\"}]}")));
            this.stockChart1.Size = new System.Drawing.Size(1073, 542);
            this.stockChart1.TabIndex = 0;
            this.stockChart1.Text = "stockChart1";
            // 
            // checkBoxIsTranspoed
            // 
            this.checkBoxIsTranspoed.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxIsTranspoed.Location = new System.Drawing.Point(16, 33);
            this.checkBoxIsTranspoed.Name = "checkBoxIsTranspoed";
            this.checkBoxIsTranspoed.Size = new System.Drawing.Size(131, 24);
            this.checkBoxIsTranspoed.TabIndex = 1;
            this.checkBoxIsTranspoed.Text = "Is transposed";
            // 
            // checkBoxIsSelect
            // 
            this.checkBoxIsSelect.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxIsSelect.Location = new System.Drawing.Point(16, 66);
            this.checkBoxIsSelect.Name = "checkBoxIsSelect";
            this.checkBoxIsSelect.Size = new System.Drawing.Size(100, 24);
            this.checkBoxIsSelect.TabIndex = 2;
            this.checkBoxIsSelect.Text = "Is select";
            // 
            // StockChart
            // 
            this.Name = "StockChart";
            this.Load += new System.EventHandler(this.StockChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.StockChart stockChart1;
        private CheckBox checkBoxIsSelect;
        private CheckBox checkBoxIsTranspoed;
    }
}
