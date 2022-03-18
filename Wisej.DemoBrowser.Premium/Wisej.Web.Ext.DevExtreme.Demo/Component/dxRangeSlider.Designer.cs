namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxRangeSlider
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
			this.dxRangeSlider1 = new Wisej.Web.Ext.DevExtreme.dxRangeSlider();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.textBox1 = new Wisej.Web.TextBox();
			this.textBox2 = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/RangeSlider/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxRangeSlider/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Size = new System.Drawing.Size(250, 490);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 409);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxRangeSlider1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/RangeSlider/Overview/jQuery/L" +
    "ight/";
			// 
			// dxRangeSlider1
			// 
			this.dxRangeSlider1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxRangeSlider1.Location = new System.Drawing.Point(294, 250);
			this.dxRangeSlider1.Name = "dxRangeSlider1";
			this.dxRangeSlider1.Size = new System.Drawing.Size(500, 59);
			this.dxRangeSlider1.TabIndex = 0;
			this.dxRangeSlider1.Text = "dxRangeSlider1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.LabelText = "Start";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 157);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.LabelText = "End";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 220);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown2.TabIndex = 2;
			this.numericUpDown2.Value = new decimal(new int[] {
            60,
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
			this.checkBox1.Location = new System.Drawing.Point(28, 37);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 25;
			this.checkBox1.Text = "Is Valid";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.Location = new System.Drawing.Point(28, 97);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 26;
			this.checkBox2.Text = "Show Range";
			// 
			// textBox1
			// 
			this.textBox1.LabelText = "Start Name";
			this.textBox1.Location = new System.Drawing.Point(28, 283);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(195, 53);
			this.textBox1.TabIndex = 27;
			// 
			// textBox2
			// 
			this.textBox2.LabelText = "End Name";
			this.textBox2.Location = new System.Drawing.Point(28, 346);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(195, 53);
			this.textBox2.TabIndex = 28;
			// 
			// dxRangeSlider
			// 
			this.Name = "dxRangeSlider";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxRangeSlider dxRangeSlider1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private TextBox textBox2;
		private TextBox textBox1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
