namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.chart1 = new Wisej.Web.Ext.Syncfusion2.Chart();
            this.comboBoxChartType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/chart/es5-getting-started/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/chart/overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chart1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxChartType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 45);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 470);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/chart/line.html";
            // 
            // chart1
            // 
            this.chart1.Dock = Wisej.Web.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(8, 8);
            this.chart1.Name = "chart1";
            this.chart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("chart1.Options"))));
            this.chart1.Size = new System.Drawing.Size(872, 560);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxChartType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxChartType, true);
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Line",
            "Spline",
            "StepLine"});
            this.comboBoxChartType.LabelText = "Chart Type";
            this.comboBoxChartType.Location = new System.Drawing.Point(3, 3);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(212, 50);
            this.comboBoxChartType.TabIndex = 1;
            // 
            // Chart
            // 
            this.Name = "Chart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.Chart chart1;
        private ComboBox comboBoxChartType;
    }
}
