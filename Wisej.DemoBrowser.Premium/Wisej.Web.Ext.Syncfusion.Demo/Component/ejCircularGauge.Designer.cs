namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejCircularGauge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejCircularGauge));
            this.ejCircularGauge1 = new Wisej.Web.Ext.Syncfusion.ejCircularGauge();
            this.numericUpDownVal = new Wisej.Web.NumericUpDown();
            this.trackBarDistanceFromScale = new Wisej.Web.TrackBar();
            this.label4 = new Wisej.Web.Label();
            this.label5 = new Wisej.Web.Label();
            this.trackBarSize = new Wisej.Web.TrackBar();
            this.checkBoxShowTicks = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDistanceFromScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/circulargauge/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxShowTicks);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.trackBarSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.trackBarDistanceFromScale);
            this.groupBox1.Controls.Add(this.numericUpDownVal);
            this.groupBox1.Size = new System.Drawing.Size(250, 472);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDownVal, 0);
            this.groupBox1.Controls.SetChildIndex(this.trackBarDistanceFromScale, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.Controls.SetChildIndex(this.trackBarSize, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxShowTicks, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 391);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(509, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/radialgauge/defaultfunctionaliti" +
    "es";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejcirculargauge";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejCircularGauge1);
            this.panel.TabIndex = 7;
            // 
            // ejCircularGauge1
            // 
            this.ejCircularGauge1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejCircularGauge1.Location = new System.Drawing.Point(8, 8);
            this.ejCircularGauge1.Name = "ejCircularGauge1";
            this.ejCircularGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejCircularGauge1.Options"))));
            this.ejCircularGauge1.Size = new System.Drawing.Size(1073, 542);
            this.ejCircularGauge1.TabIndex = 0;
            this.ejCircularGauge1.Text = "ejCircularGauge1";
            this.ejCircularGauge1.Value = 50;
            // 
            // numericUpDownVal
            // 
            this.numericUpDownVal.AutoSize = false;
            this.numericUpDownVal.Label.Size = 50;
            this.numericUpDownVal.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDownVal.LabelText = "Value";
            this.numericUpDownVal.Location = new System.Drawing.Point(28, 36);
            this.numericUpDownVal.Name = "numericUpDownVal";
            this.numericUpDownVal.Size = new System.Drawing.Size(195, 60);
            this.numericUpDownVal.TabIndex = 0;
            this.numericUpDownVal.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // trackBarDistanceFromScale
            // 
            this.trackBarDistanceFromScale.Location = new System.Drawing.Point(28, 146);
            this.trackBarDistanceFromScale.Maximum = 0;
            this.trackBarDistanceFromScale.Minimum = -30;
            this.trackBarDistanceFromScale.Name = "trackBarDistanceFromScale";
            this.trackBarDistanceFromScale.Size = new System.Drawing.Size(195, 34);
            this.trackBarDistanceFromScale.TabIndex = 2;
            this.trackBarDistanceFromScale.Value = -30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Range Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Range Size";
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(28, 236);
            this.trackBarSize.Maximum = 12;
            this.trackBarSize.Minimum = 2;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(195, 34);
            this.trackBarSize.TabIndex = 4;
            this.trackBarSize.Value = 2;
            // 
            // checkBoxShowTicks
            // 
            this.checkBoxShowTicks.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxShowTicks.AutoSize = false;
            this.checkBoxShowTicks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowTicks.Checked = true;
            this.checkBoxShowTicks.Location = new System.Drawing.Point(28, 309);
            this.checkBoxShowTicks.Name = "checkBoxShowTicks";
            this.checkBoxShowTicks.Size = new System.Drawing.Size(183, 38);
            this.checkBoxShowTicks.TabIndex = 5;
            this.checkBoxShowTicks.Text = "Show Ticks";
            // 
            // ejCircularGauge
            // 
            this.Name = "ejCircularGauge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDistanceFromScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejCircularGauge ejCircularGauge1;
		private NumericUpDown numericUpDownVal;
		private Label label4;
		private TrackBar trackBarDistanceFromScale;
		private Label label5;
		private TrackBar trackBarSize;
		private CheckBox checkBoxShowTicks;
	}
}
