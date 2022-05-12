namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxCircularGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxCircularGauge));
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.dxCircularGauge1 = new Wisej.Web.Ext.DevExtreme.dxCircularGauge();
			this.label4 = new Wisej.Web.Label();
			this.panel1 = new Wisej.Web.Panel();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/CircularGauge";
			// 
			// groupBox1
			// 
			this.groupBox1.Size = new System.Drawing.Size(250, 494);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(16, 426);
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Gauges/PaletteForRanges/jQuer" +
    "y/Light/";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xCircularGauge/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxCircularGauge1);
			this.panel.Size = new System.Drawing.Size(579, 494);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBox1);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown3);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 372);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Show Labels";
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.trackBar1.Location = new System.Drawing.Point(5, 25);
			this.trackBar1.Maximum = 30;
			this.trackBar1.Minimum = 5;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(204, 34);
			this.trackBar1.SmallChange = 5;
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Value = 10;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 147);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// dxCircularGauge1
			// 
			this.dxCircularGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxCircularGauge1.Location = new System.Drawing.Point(81, 29);
			this.dxCircularGauge1.Name = "dxCircularGauge1";
			this.dxCircularGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxCircularGauge1.Options"))));
			this.dxCircularGauge1.Size = new System.Drawing.Size(414, 434);
			this.dxCircularGauge1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tick Interval";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.trackBar1);
			this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.panel1, true);
			this.panel1.Location = new System.Drawing.Point(3, 60);
			this.panel1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(212, 68);
			this.panel1.TabIndex = 1;
			this.panel1.TabStop = true;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
			this.numericUpDown2.Label.Size = 50;
			this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown2.LabelText = "Start Angle";
			this.numericUpDown2.Location = new System.Drawing.Point(3, 226);
			this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown3, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown3, true);
			this.numericUpDown3.Label.Size = 50;
			this.numericUpDown3.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown3.LabelText = "End Angle";
			this.numericUpDown3.Location = new System.Drawing.Point(3, 305);
			this.numericUpDown3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown3.TabIndex = 4;
			this.numericUpDown3.Value = new decimal(new int[] {
            315,
            0,
            0,
            0});
			// 
			// dxCircularGauge
			// 
			this.MinimumSize = new System.Drawing.Size(988, 684);
			this.Name = "dxCircularGauge";
			this.Size = new System.Drawing.Size(988, 684);
			this.Load += new System.EventHandler(this.dxCircularGauge_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CheckBox checkBox1;
		private TrackBar trackBar1;
		private NumericUpDown numericUpDown1;
		private DevExtreme.dxCircularGauge dxCircularGauge1;
		private Label label4;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private Panel panel1;
	}
}
