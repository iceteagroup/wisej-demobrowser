namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class LinearGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearGauge));
			this.linearGauge1 = new Wisej.Web.Ext.Syncfusion2.LinearGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDownMajorTick = new Wisej.Web.NumericUpDown();
			this.numericUpDownMinorTick = new Wisej.Web.NumericUpDown();
			this.comboBoxOrientation = new Wisej.Web.ComboBox();
			this.comboBoxContainerType = new Wisej.Web.ComboBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajorTick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinorTick)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/linear-gauge/es5-getting-star" +
    "ted/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/linear-gauge/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.linearGauge1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.numericUpDownMajorTick);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDownMinorTick);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxOrientation);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxContainerType);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/linear-gauge/default.html";
			// 
			// linearGauge1
			// 
			this.linearGauge1.Dock = Wisej.Web.DockStyle.Fill;
			this.linearGauge1.Location = new System.Drawing.Point(8, 8);
			this.linearGauge1.Name = "linearGauge1";
			this.linearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("linearGauge1.Options"))));
			this.linearGauge1.Size = new System.Drawing.Size(872, 560);
			this.linearGauge1.TabIndex = 0;
			this.linearGauge1.Text = "linearGauge1";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 82);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
			// 
			// numericUpDownMajorTick
			// 
			this.numericUpDownMajorTick.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDownMajorTick, 1);
			this.numericUpDownMajorTick.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
			this.numericUpDownMajorTick.Label.Size = 50;
			this.numericUpDownMajorTick.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownMajorTick.LabelText = "Major Tick";
			this.numericUpDownMajorTick.Location = new System.Drawing.Point(3, 3);
			this.numericUpDownMajorTick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownMajorTick.Name = "numericUpDownMajorTick";
			this.numericUpDownMajorTick.Size = new System.Drawing.Size(103, 60);
			this.numericUpDownMajorTick.TabIndex = 3;
			this.numericUpDownMajorTick.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// numericUpDownMinorTick
			// 
			this.numericUpDownMinorTick.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDownMinorTick, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownMinorTick, true);
			this.numericUpDownMinorTick.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
			this.numericUpDownMinorTick.Label.Size = 50;
			this.numericUpDownMinorTick.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDownMinorTick.LabelText = "Minor Tick";
			this.numericUpDownMinorTick.Location = new System.Drawing.Point(112, 3);
			this.numericUpDownMinorTick.Name = "numericUpDownMinorTick";
			this.numericUpDownMinorTick.Size = new System.Drawing.Size(103, 60);
			this.numericUpDownMinorTick.TabIndex = 4;
			this.numericUpDownMinorTick.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// comboBoxOrientation
			// 
			this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxOrientation, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxOrientation, true);
			this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
			this.comboBoxOrientation.LabelText = "Orientation";
			this.comboBoxOrientation.Location = new System.Drawing.Point(3, 161);
			this.comboBoxOrientation.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxOrientation.Name = "comboBoxOrientation";
			this.comboBoxOrientation.Size = new System.Drawing.Size(212, 51);
			this.comboBoxOrientation.TabIndex = 5;
			this.comboBoxOrientation.Text = "Vertical";
			// 
			// comboBoxContainerType
			// 
			this.comboBoxContainerType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxContainerType, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxContainerType, true);
			this.comboBoxContainerType.Items.AddRange(new object[] {
            "Thermometer",
            "Normal",
            "RoundedRectangle"});
			this.comboBoxContainerType.LabelText = "Container Type";
			this.comboBoxContainerType.Location = new System.Drawing.Point(3, 231);
			this.comboBoxContainerType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxContainerType.Name = "comboBoxContainerType";
			this.comboBoxContainerType.Size = new System.Drawing.Size(212, 51);
			this.comboBoxContainerType.TabIndex = 6;
			this.comboBoxContainerType.Text = "Thermometer";
			// 
			// LinearGauge
			// 
			this.Name = "LinearGauge";
			this.Load += new System.EventHandler(this.LinearGauge_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajorTick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinorTick)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.LinearGauge linearGauge1;
		private NumericUpDown numericUpDown1;
        private ComboBox comboBoxContainerType;
        private ComboBox comboBoxOrientation;
        private NumericUpDown numericUpDownMinorTick;
        private NumericUpDown numericUpDownMajorTick;
    }
}
