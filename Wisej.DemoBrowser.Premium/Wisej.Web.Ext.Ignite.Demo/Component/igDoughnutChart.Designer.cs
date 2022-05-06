namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igDoughnutChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igDoughnutChart));
            Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
            this.igDoughnutChart1 = new Wisej.Web.Ext.Ignite.igDoughnutChart();
            this.textBox1 = new Wisej.Web.TextBox();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.buttonAddItem = new Wisej.Web.Button();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.igDoughnutChart1);
            this.panel.TabIndex = 7;
            // 
            // linkDemo
            // 
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://www.igniteui.com/doughnut-chart/overview";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.igdoughnutchart";
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "http://www.igniteui.com/help/igdoughnutchart-overview";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            // 
            // igDoughnutChart1
            // 
            this.igDoughnutChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.igDoughnutChart1.Location = new System.Drawing.Point(23, 19);
            this.igDoughnutChart1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.igDoughnutChart1.Name = "igDoughnutChart1";
            this.igDoughnutChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igDoughnutChart1.Options"))));
            this.igDoughnutChart1.Size = new System.Drawing.Size(1043, 519);
            this.igDoughnutChart1.TabIndex = 0;
            this.igDoughnutChart1.Text = "igDoughnutChart1";
            widgetFunction1.Name = "formatLabel";
            widgetFunction1.Source = "var context = arguments[0];\r\n\r\nreturn context.itemLabel + \" (\" + context.item.pop" +
    "1990 + \")\";\r\n        ";
            this.igDoughnutChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.textBox1.LabelText = "Country Name";
            this.textBox1.Location = new System.Drawing.Point(9, 25);
            this.textBox1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 57);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Canada";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.numericUpDown1.LabelText = "Population";
            this.numericUpDown1.Location = new System.Drawing.Point(9, 96);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 57);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddItem);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.SetFillWeight(this.groupBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.groupBox2, true);
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 211);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "Add Country";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonAddItem.Location = new System.Drawing.Point(9, 164);
            this.buttonAddItem.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(195, 40);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Add";
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Checked = true;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 8);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Slice Selection";
            // 
            // numericUpDown2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.LabelText = "Inner Extent";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 57);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 8, 3, 3);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // igDoughnutChart
            // 
            this.MinimumSize = new System.Drawing.Size(914, 710);
            this.Name = "igDoughnutChart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Ignite.igDoughnutChart igDoughnutChart1;
		private NumericUpDown numericUpDown1;
		private TextBox textBox1;
		private GroupBox groupBox2;
		private Button buttonAddItem;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox2;
	}
}
