namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejSunburstChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejSunburstChart));
            this.ejSunburstChart1 = new Wisej.Web.Ext.Syncfusion.ejSunburstChart();
            this.numericUpDown1 = new Wisej.Web.NumericUpDown();
            this.numericUpDown2 = new Wisej.Web.NumericUpDown();
            this.numericUpDown3 = new Wisej.Web.NumericUpDown();
            this.numericUpDown4 = new Wisej.Web.NumericUpDown();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/sunburstchart/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Size = new System.Drawing.Size(250, 601);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown2, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown3, 0);
            this.groupBox1.Controls.SetChildIndex(this.numericUpDown4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 527);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(488, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/sunburst/Default";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejsunburstchart";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejSunburstChart1);
            this.panel.Size = new System.Drawing.Size(1091, 601);
            this.panel.TabIndex = 7;
            // 
            // ejSunburstChart1
            // 
            this.ejSunburstChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.ejSunburstChart1.Location = new System.Drawing.Point(8, 8);
            this.ejSunburstChart1.Name = "ejSunburstChart1";
            this.ejSunburstChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejSunburstChart1.Options"))));
            this.ejSunburstChart1.Size = new System.Drawing.Size(1073, 583);
            this.ejSunburstChart1.TabIndex = 0;
            this.ejSunburstChart1.Text = "ejSunburstChart1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = false;
            this.numericUpDown1.Label.Size = 50;
            this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown1.LabelText = "Start Angle";
            this.numericUpDown1.Location = new System.Drawing.Point(28, 186);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AutoSize = false;
            this.numericUpDown2.Label.Size = 50;
            this.numericUpDown2.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown2.LabelText = "End Angle";
            this.numericUpDown2.Location = new System.Drawing.Point(28, 272);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.AutoSize = false;
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown3.Label.Size = 50;
            this.numericUpDown3.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown3.LabelText = "Radius";
            this.numericUpDown3.Location = new System.Drawing.Point(28, 358);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown3.TabIndex = 4;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.AutoSize = false;
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown4.Label.Size = 50;
            this.numericUpDown4.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.numericUpDown4.LabelText = "Inner Radius";
            this.numericUpDown4.Location = new System.Drawing.Point(28, 444);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(195, 60);
            this.numericUpDown4.TabIndex = 5;
            this.numericUpDown4.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
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
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Legend Visible";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Legend Position";
            this.comboBox1.Location = new System.Drawing.Point(28, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Top";
            // 
            // ejSunburstChart
            // 
            this.Name = "ejSunburstChart";
            this.Size = new System.Drawing.Size(1500, 791);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSunburstChart ejSunburstChart1;
		private NumericUpDown numericUpDown4;
		private NumericUpDown numericUpDown3;
		private NumericUpDown numericUpDown2;
		private NumericUpDown numericUpDown1;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
	}
}
