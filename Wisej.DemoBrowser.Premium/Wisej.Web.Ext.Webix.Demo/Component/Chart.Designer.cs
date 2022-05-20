namespace Wisej.Web.Ext.Webix.Demo.Component
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
            this.chart1 = new Wisej.Web.Ext.Webix.Chart();
            this.comboBoxChartType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__chart.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#chart";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.chart.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chart1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBoxChartType);
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
            this.comboBoxChartType.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxChartType.Items.AddRange(new object[] {
            "bar",
            "area",
            "donut",
            "spline",
            "line"});
            this.comboBoxChartType.LabelText = "Chart Type";
            this.comboBoxChartType.Location = new System.Drawing.Point(3, 3);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(212, 57);
            this.comboBoxChartType.TabIndex = 0;
            // 
            // Chart
            // 
            this.MinimumSize = new System.Drawing.Size(832, 514);
            this.Name = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Webix.Chart chart1;
        private ComboBox comboBoxChartType;
    }
}
