namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igFinancialChart
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
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igFinancialChart));
            this.igFinancialChart1 = new Wisej.Web.Ext.Ignite.igFinancialChart();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBox2 = new Wisej.Web.ComboBox();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igFinancialChart1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/financial-chart/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igfinancialchart";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/financial-chart-overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            // 
            // igFinancialChart1
            // 
            this.igFinancialChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igFinancialChart1.Location = new System.Drawing.Point(19, 23);
            this.igFinancialChart1.Name = "igFinancialChart1";
            this.igFinancialChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"chartType\":\"candle\",\"zoomSliderType\":\"candle\",\"transitionDuration\":250}")));
            this.igFinancialChart1.Size = new System.Drawing.Size(1050, 512);
            this.igFinancialChart1.TabIndex = 0;
            this.igFinancialChart1.Text = "igFinancialChart1";
            widgetFunction1.Name = "loadTheData";
            widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
            this.igFinancialChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "auto",
            "bar",
            "candle",
            "column",
            "line"});
            this.comboBox1.LabelText = "Chart Type";
            this.comboBox1.Location = new System.Drawing.Point(3, 187);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 57);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "auto";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox2, true);
            this.comboBox2.Items.AddRange(new object[] {
            "none",
            "linearFit",
            "quadraticFit",
            "cubicFit",
            "quarticFit",
            "quinticFit",
            "logarithmicFit",
            "exponentialFit",
            "powerLawFit",
            "simpleAverage",
            "exponentialAverage",
            "modifiedAverage",
            "cumulativeAverage",
            "weightedAverage"});
            this.comboBox2.LabelText = "Trend Line Type";
            this.comboBox2.Location = new System.Drawing.Point(3, 255);
            this.comboBox2.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 57);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "none";
            // 
            // button1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.Location = new System.Drawing.Point(3, 323);
            this.button1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add new Item";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.button2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button2, true);
            this.button2.Location = new System.Drawing.Point(3, 369);
            this.button2.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Start Task";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
            this.checkBox1.Location = new System.Drawing.Point(3, 64);
            this.checkBox1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 63);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Animate Series When Axis Range Changes";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 50);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Crosshairs Snap to Data";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 138);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 38);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Toolbar Visible";
            // 
            // igFinancialChart
            // 
            this.MinimumSize = new System.Drawing.Size(850, 735);
            this.Name = "igFinancialChart";
            this.Load += new System.EventHandler(this.igFinancialChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igFinancialChart igFinancialChart1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private Button button1;
		private Button button2;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
