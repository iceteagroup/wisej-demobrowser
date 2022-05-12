namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxPolarChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxPolarChart));
            this.dxPolarChart1 = new Wisej.Web.Ext.DevExtreme.dxPolarChart();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.buttonExport = new Wisej.Web.Button();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/PolarChart/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/ContinuousData/jQuery/" +
    "Light/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xPolarChart/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxPolarChart1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.Controls.Add(this.checkBox4);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.buttonExport);
            // 
            // dxPolarChart1
            // 
            this.dxPolarChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxPolarChart1.Location = new System.Drawing.Point(34, 17);
            this.dxPolarChart1.Name = "dxPolarChart1";
            this.dxPolarChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxPolarChart1.Options"))));
            this.dxPolarChart1.Size = new System.Drawing.Size(821, 525);
            this.dxPolarChart1.TabIndex = 0;
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
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Animation Enabled";
            // 
            // numericUpDown1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.LabelText = "Animation Duration";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 231);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
            this.checkBox2.Location = new System.Drawing.Point(3, 60);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 38);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Negatives as Zeroes";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox3, true);
            this.checkBox3.Location = new System.Drawing.Point(3, 117);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(212, 38);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Use Spider Web";
            // 
            // buttonExport
            // 
            this.buttonExport.Display = Wisej.Web.Display.Icon;
            this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/google-drive-image.svg";
            this.buttonExport.Location = new System.Drawing.Point(3, 307);
            this.buttonExport.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(42, 42);
            this.buttonExport.TabIndex = 21;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBox4, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBox4, true);
            this.checkBox4.Location = new System.Drawing.Point(3, 174);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(212, 38);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "Inverted Axis";
            // 
            // dxPolarChart
            // 
            this.Name = "dxPolarChart";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxPolarChart dxPolarChart1;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox1;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private Button buttonExport;
		private CheckBox checkBox4;
	}
}
