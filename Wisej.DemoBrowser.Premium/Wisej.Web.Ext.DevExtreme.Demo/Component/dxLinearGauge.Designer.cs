namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxLinearGauge
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
			this.dxLinearGauge1 = new Wisej.Web.Ext.DevExtreme.dxLinearGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.textBox1 = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/LinearGauge/Visual_Elements" +
    "/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xLinearGauge/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Size = new System.Drawing.Size(250, 462);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 381);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxLinearGauge1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Gauges/ScaleCustomTickInterva" +
    "l/jQuery/Light/";
			// 
			// dxLinearGauge1
			// 
			this.dxLinearGauge1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxLinearGauge1.Location = new System.Drawing.Point(208, 202);
			this.dxLinearGauge1.Name = "dxLinearGauge1";
			this.dxLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"rangeContainer\":{\"backgroundColor\":\"#8FBC8F\"}}")));
			this.dxLinearGauge1.Size = new System.Drawing.Size(673, 155);
			this.dxLinearGauge1.TabIndex = 0;
			this.dxLinearGauge1.Text = "dxLinearGauge1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.LabelText = "Animation Duration";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 207);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            1000,
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
			this.checkBox1.Location = new System.Drawing.Point(28, 36);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Animation Enabled";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.LabelText = "Value";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 294);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown2.TabIndex = 14;
			// 
			// textBox1
			// 
			this.textBox1.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBox1.LabelText = "Background Color";
			this.textBox1.Location = new System.Drawing.Point(28, 120);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 53);
			this.textBox1.TabIndex = 15;
			this.textBox1.Text = "#8FBC8F";
			// 
			// dxLinearGauge
			// 
			this.Name = "dxLinearGauge";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxLinearGauge dxLinearGauge1;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox1;
		private TextBox textBox1;
	}
}
