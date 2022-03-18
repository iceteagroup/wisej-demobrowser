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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoArcGauge1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 503);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 422);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/arc-gauge/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/dataviz/ui/arcgauge";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/gauges/arcgauge/overview";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = false;
            this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Color;
            this.textBox1.Label.Size = 50;
            this.textBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.textBox1.LabelText = "Color";
            this.textBox1.Location = new System.Drawing.Point(28, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 60);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "#EA7000";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Value";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 179);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
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
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.numericUpDown2.Label.Size = 50;
            this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown2.LabelText = "Opacity";
            this.numericUpDown2.Location = new System.Drawing.Point(28, 265);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(195, 60);
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
            this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(28, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Transitions";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Task";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kendoArcGauge1
            // 
            this.kendoArcGauge1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoArcGauge1.Location = new System.Drawing.Point(318, 29);
            this.kendoArcGauge1.Name = "kendoArcGauge1";
            this.kendoArcGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":50,\"centerTemplate\":\"<h1>#: value #%</h1>\"}")));
            this.kendoArcGauge1.Size = new System.Drawing.Size(453, 501);
            this.kendoArcGauge1.TabIndex = 0;
            this.kendoArcGauge1.Text = "kendoArcGauge1";
            // 
            // kendoArcGauge
            // 
            this.Name = "kendoArcGauge";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
