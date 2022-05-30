namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoMap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoMap));
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.kendoMap1 = new Wisej.Web.Ext.Kendo.kendoMap();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoMap1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/map/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/map";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/diagrams-and-maps/map/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown2);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown3);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 38);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Pannable";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 60);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 38);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "Wrap Around";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 117);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 38);
			this.checkBox3.TabIndex = 8;
			this.checkBox3.Text = "Zoomable";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Min Zoom";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 174);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown1.TabIndex = 11;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown2, true);
			this.numericUpDown2.Label.Size = 50;
			this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown2.LabelText = "Max Zoom";
			this.numericUpDown2.Location = new System.Drawing.Point(3, 253);
			this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown2.TabIndex = 12;
			this.numericUpDown2.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown3, true);
			this.numericUpDown3.Label.Size = 50;
			this.numericUpDown3.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown3.LabelText = "Zoom";
			this.numericUpDown3.Location = new System.Drawing.Point(3, 332);
			this.numericUpDown3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
			this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown3.TabIndex = 13;
			this.numericUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// kendoMap1
			// 
			this.kendoMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoMap1.Location = new System.Drawing.Point(26, 36);
			this.kendoMap1.Name = "kendoMap1";
			this.kendoMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoMap1.Options"))));
			this.kendoMap1.Size = new System.Drawing.Size(836, 504);
			this.kendoMap1.TabIndex = 0;
			this.kendoMap1.Text = "kendoMap1";
			// 
			// kendoMap
			// 
			this.Name = "kendoMap";
			this.Size = new System.Drawing.Size(1299, 720);
			this.Load += new System.EventHandler(this.kendoMap_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoMap kendoMap1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
	}
}
