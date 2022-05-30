namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoArcGauge
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
			this.textBox1 = new Wisej.Web.TextBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.button1 = new Wisej.Web.Button();
			this.kendoArcGauge1 = new Wisej.Web.Ext.Kendo.kendoArcGauge();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoArcGauge1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/arc-gauge/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/arcgauge";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/gauges/arcgauge/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.textBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanelProperties.Controls.Add(this.numericUpDown2);
			this.flowLayoutPanelProperties.Controls.Add(this.button1);
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.textBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBox1, true);
			this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBox1.Label.Size = 50;
			this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBox1.LabelText = "Color";
			this.textBox1.Location = new System.Drawing.Point(3, 60);
			this.textBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(212, 60);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "#EA7000";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 139);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.AutoSize = false;
			this.numericUpDown2.DecimalPlaces = 2;
			this.flowLayoutPanelProperties.SetFillWeight(this.numericUpDown2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.numericUpDown2, true);
			this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
			this.numericUpDown2.Label.Size = 50;
			this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown2.LabelText = "Opacity";
			this.numericUpDown2.Location = new System.Drawing.Point(3, 218);
			this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Transitions";
			// 
			// button1
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.button1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.button1, true);
			this.button1.Location = new System.Drawing.Point(3, 297);
			this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(212, 40);
			this.button1.TabIndex = 5;
			this.button1.Text = "Start Task";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// kendoArcGauge1
			// 
			this.kendoArcGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.kendoArcGauge1.Location = new System.Drawing.Point(76, 38);
			this.kendoArcGauge1.Name = "kendoArcGauge1";
			this.kendoArcGauge1.Size = new System.Drawing.Size(737, 501);
			this.kendoArcGauge1.TabIndex = 0;
			this.kendoArcGauge1.Text = "kendoArcGauge1";
			// 
			// kendoArcGauge
			// 
			this.Name = "kendoArcGauge";
			this.Load += new System.EventHandler(this.kendoArcGauge_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoArcGauge kendoArcGauge1;
		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox1;
		private Button button1;
	}
}
