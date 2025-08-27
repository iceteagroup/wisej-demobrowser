namespace Wisej.Web.Ext.Ignite.Demo.Popups
{
	partial class AddRadialGaugeRange
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
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.numericUpDown4 = new Wisej.Web.NumericUpDown();
			this.button1 = new Wisej.Web.Button();
			this.textBox2 = new Wisej.Web.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Label.Text = "Name";
			this.textBox1.Location = new System.Drawing.Point(33, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(226, 42);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "MyRange";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Label.Text = "Start Value";
			this.numericUpDown1.Location = new System.Drawing.Point(33, 139);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(226, 42);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Label.Text = "End Value";
			this.numericUpDown2.Location = new System.Drawing.Point(33, 199);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(226, 42);
			this.numericUpDown2.TabIndex = 2;
			this.numericUpDown2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DecimalPlaces = 2;
			this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown3.Label.Text = "Outer Start Extent";
			this.numericUpDown3.Location = new System.Drawing.Point(33, 259);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(226, 42);
			this.numericUpDown3.TabIndex = 3;
			this.numericUpDown3.Value = new decimal(new int[] {
            55,
            0,
            0,
            131072});
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.DecimalPlaces = 2;
			this.numericUpDown4.Label.Text = "Outer End Extent";
			this.numericUpDown4.Location = new System.Drawing.Point(33, 319);
			this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(226, 42);
			this.numericUpDown4.TabIndex = 4;
			this.numericUpDown4.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(33, 379);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(226, 27);
			this.button1.TabIndex = 5;
			this.button1.Text = "Submit";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBox2.Label.Text = "Brush";
			this.textBox2.Location = new System.Drawing.Point(33, 79);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(226, 42);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "blue";
			// 
			// AddRadialGaugeRange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 432);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numericUpDown4);
			this.Controls.Add(this.numericUpDown3);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.textBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddRadialGaugeRange";
			this.Text = "AddRadialGaugeRange";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox textBox1;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown4;
		private Button button1;
		private TextBox textBox2;
	}
}