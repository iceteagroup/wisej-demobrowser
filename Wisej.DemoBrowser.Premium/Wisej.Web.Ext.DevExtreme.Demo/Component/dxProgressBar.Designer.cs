namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxProgressBar
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
			this.dxProgressBar1 = new Wisej.Web.Ext.DevExtreme.dxProgressBar();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxProgressBar1);
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/ProgressBar/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxProgressBar/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.numericUpDown3);
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Size = new System.Drawing.Size(250, 405);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown3, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 320);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/ProgressBar/Overview/jQuery/L" +
    "ight/";
			// 
			// dxProgressBar1
			// 
			this.dxProgressBar1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxProgressBar1.Location = new System.Drawing.Point(369, 262);
			this.dxProgressBar1.Name = "dxProgressBar1";
			this.dxProgressBar1.Size = new System.Drawing.Size(350, 35);
			this.dxProgressBar1.TabIndex = 0;
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
			this.checkBox1.TabIndex = 23;
			this.checkBox1.Text = "Is Valid";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.LabelText = "Maximum";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 146);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown1.TabIndex = 24;
			this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.LabelText = "Minimum";
			this.numericUpDown2.Location = new System.Drawing.Point(28, 204);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown2.TabIndex = 25;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.LabelText = "Value";
			this.numericUpDown3.Location = new System.Drawing.Point(28, 262);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(195, 53);
			this.numericUpDown3.TabIndex = 26;
			this.numericUpDown3.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.Location = new System.Drawing.Point(28, 91);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 27;
			this.checkBox2.Text = "Show Status";
			// 
			// dxProgressBar
			// 
			this.Name = "dxProgressBar";
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxProgressBar dxProgressBar1;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown3;
		private CheckBox checkBox2;
	}
}
