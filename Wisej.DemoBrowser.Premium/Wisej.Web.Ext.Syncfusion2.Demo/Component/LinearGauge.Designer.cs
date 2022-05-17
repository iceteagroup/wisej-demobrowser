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
            this.numericUpDownMinorType = new Wisej.Web.NumericUpDown();
            this.comboBoxOrientation = new Wisej.Web.ComboBox();
            this.comboBoxContainerType = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajorTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinorType)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/linear-gauge/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
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
            this.flowLayoutPanel1.Controls.Add(this.numericUpDownMinorType);
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
            this.linearGauge1.Size = new System.Drawing.Size(1073, 542);
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
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 60);
            this.numericUpDown1.TabIndex = 1;
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
            1,
            0,
            0,
            0});
            // 
            // numericUpDownMinorType
            // 
            this.numericUpDownMinorType.AutoSize = false;
            this.flowLayoutPanel1.SetFillWeight(this.numericUpDownMinorType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownMinorType, true);
            this.numericUpDownMinorType.Label.Padding = new Wisej.Web.Padding(0, 0, 0, 2);
            this.numericUpDownMinorType.Label.Size = 50;
            this.numericUpDownMinorType.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownMinorType.LabelText = "Minor Tick";
            this.numericUpDownMinorType.Location = new System.Drawing.Point(112, 3);
            this.numericUpDownMinorType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinorType.Name = "numericUpDownMinorType";
            this.numericUpDownMinorType.Size = new System.Drawing.Size(103, 60);
            this.numericUpDownMinorType.TabIndex = 4;
            this.numericUpDownMinorType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxOrientation
            // 
            this.comboBoxOrientation.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxOrientation, 1);
            this.comboBoxOrientation.Items.AddRange(new object[] {
            "Vertical",
            "Horizontal"});
            this.comboBoxOrientation.LabelText = "Orientation";
            this.comboBoxOrientation.Location = new System.Drawing.Point(3, 161);
            this.comboBoxOrientation.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxOrientation.Name = "comboBoxOrientation";
            this.comboBoxOrientation.Size = new System.Drawing.Size(103, 57);
            this.comboBoxOrientation.TabIndex = 5;
            // 
            // comboBoxContainerType
            // 
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxContainerType, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxContainerType, true);
            this.comboBoxContainerType.Items.AddRange(new object[] {
            "Thermometer",
            "Normal",
            "RoundedRectangle"});
            this.comboBoxContainerType.LabelText = "Contain Type";
            this.comboBoxContainerType.Location = new System.Drawing.Point(112, 161);
            this.comboBoxContainerType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxContainerType.Name = "comboBoxContainerType";
            this.comboBoxContainerType.Size = new System.Drawing.Size(103, 57);
            this.comboBoxContainerType.TabIndex = 6;
            // 
            // LinearGauge
            // 
            this.Name = "LinearGauge";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMajorTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinorType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.LinearGauge linearGauge1;
		private NumericUpDown numericUpDown1;
        private ComboBox comboBoxContainerType;
        private ComboBox comboBoxOrientation;
        private NumericUpDown numericUpDownMinorType;
        private NumericUpDown numericUpDownMajorTick;
    }
}
