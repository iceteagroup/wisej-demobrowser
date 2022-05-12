namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	partial class dxPieChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxPieChart));
            this.dxPieChart1 = new Wisej.Web.Ext.DevExtreme.dxPieChart();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.comboBox3 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/PieChart/Series/Overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/Pie/jQuery/Light/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xPieChart/";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.dxPieChart1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox3);
            // 
            // dxPieChart1
            // 
            this.dxPieChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxPieChart1.Location = new System.Drawing.Point(135, 20);
            this.dxPieChart1.Name = "dxPieChart1";
            this.dxPieChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxPieChart1.Options"))));
            this.dxPieChart1.Size = new System.Drawing.Size(619, 537);
            this.dxPieChart1.TabIndex = 0;
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
            this.numericUpDown1.DecimalPlaces = 2;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.LabelText = "Diameter";
            this.numericUpDown1.Location = new System.Drawing.Point(3, 60);
            this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.LabelText = "Inner Radius";
            this.numericUpDown2.Location = new System.Drawing.Point(3, 136);
            this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.Items.AddRange(new object[] {
            "Bright",
            "Harmony Light",
            "Ocean",
            "Pastel",
            "Soft",
            "Soft Pastel",
            "Vintage",
            "Violet",
            "Carmine",
            "Dark Moon",
            "Dark Violet",
            "Green Mist",
            "Soft Blue",
            "Material",
            "Office"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Palette";
            this.comboBox1.Location = new System.Drawing.Point(3, 212);
            this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 60);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "Material";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoSize = false;
            this.comboBox3.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBox3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBox3, true);
            this.comboBox3.Items.AddRange(new object[] {
            "clockwise",
            "anticlockwise"});
            this.comboBox3.Label.Size = 50;
            this.comboBox3.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox3.LabelText = "Segments Direction";
            this.comboBox3.Location = new System.Drawing.Point(3, 291);
            this.comboBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(212, 60);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.Text = "clockwise";
            // 
            // dxPieChart
            // 
            this.AutoScroll = true;
            this.Name = "dxPieChart";
            this.Load += new System.EventHandler(this.dxPieChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExtreme.dxPieChart dxPieChart1;
		private NumericUpDown numericUpDown1;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown2;
		private ComboBox comboBox1;
		private ComboBox comboBox3;
	}
}
