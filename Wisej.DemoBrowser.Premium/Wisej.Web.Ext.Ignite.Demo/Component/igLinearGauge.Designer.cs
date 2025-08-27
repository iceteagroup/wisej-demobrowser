﻿namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igLinearGauge
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
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igLinearGauge));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.igLinearGauge1 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.label4 = new Wisej.Web.Label();
			this.label5 = new Wisej.Web.Label();
			this.label6 = new Wisej.Web.Label();
			this.label7 = new Wisej.Web.Label();
			this.label8 = new Wisej.Web.Label();
			this.igLinearGauge2 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.igLinearGauge3 = new Wisej.Web.Ext.Ignite.igLinearGauge();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.numericUpDown3 = new Wisej.Web.NumericUpDown();
			this.numericUpDown4 = new Wisej.Web.NumericUpDown();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 7;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igLinearGauge3);
			this.panel.Controls.Add(this.igLinearGauge2);
			this.panel.Controls.Add(this.label8);
			this.panel.Controls.Add(this.label7);
			this.panel.Controls.Add(this.label6);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igLinearGauge1);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/linear-gauge/overview";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "http://www.igniteui.com/help/api/2019.2/ui.igLinearGauge";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/iglineargauge-overview";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBox1);
			this.flowLayoutPanel1.Controls.Add(this.checkBox2);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown3);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown4);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
			// 
			// igLinearGauge1
			// 
			this.igLinearGauge1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge1.IsNeedleDraggingEnabled = true;
			this.igLinearGauge1.Location = new System.Drawing.Point(23, 143);
			this.igLinearGauge1.Name = "igLinearGauge1";
			this.igLinearGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge1.Options"))));
			this.igLinearGauge1.Size = new System.Drawing.Size(843, 60);
			this.igLinearGauge1.TabIndex = 2;
			this.igLinearGauge1.Value = 40D;
			widgetFunction3.Name = "formatLabel";
			widgetFunction3.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction3};
			// 
			// label4
			// 
			this.label4.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(25, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Healthy Eating";
			// 
			// label5
			// 
			this.label5.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 22);
			this.label5.TabIndex = 1;
			this.label5.Text = "Fat";
			// 
			// label6
			// 
			this.label6.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(115, 22);
			this.label6.TabIndex = 3;
			this.label6.Text = "Carbohydrates";
			// 
			// label7
			// 
			this.label7.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(23, 354);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 22);
			this.label7.TabIndex = 5;
			this.label7.Text = "Protein";
			// 
			// label8
			// 
			this.label8.Anchor = Wisej.Web.AnchorStyles.None;
			this.label8.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.label8.Location = new System.Drawing.Point(270, 455);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(349, 38);
			this.label8.TabIndex = 7;
			this.label8.Text = "Total calories intake ratio between fat, carbohydrates and protein, where middle " +
    "ranges are healthy ratios and the target values - ideally set goals.";
			// 
			// igLinearGauge2
			// 
			this.igLinearGauge2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge2.Location = new System.Drawing.Point(23, 257);
			this.igLinearGauge2.Name = "igLinearGauge2";
			this.igLinearGauge2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge2.Options"))));
			this.igLinearGauge2.Size = new System.Drawing.Size(843, 60);
			this.igLinearGauge2.TabIndex = 4;
			this.igLinearGauge2.Value = 35D;
			widgetFunction2.Name = "formatLabel";
			widgetFunction2.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge2.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction2};
			// 
			// igLinearGauge3
			// 
			this.igLinearGauge3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.igLinearGauge3.Location = new System.Drawing.Point(23, 376);
			this.igLinearGauge3.Name = "igLinearGauge3";
			this.igLinearGauge3.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igLinearGauge3.Options"))));
			this.igLinearGauge3.Size = new System.Drawing.Size(843, 60);
			this.igLinearGauge3.TabIndex = 6;
			this.igLinearGauge3.Value = 25D;
			widgetFunction1.Name = "formatLabel";
			widgetFunction1.Source = "var evt = arguments[0];\r\nvar ui  = arguments[1];\r\n\r\nui.label += \"%\";";
			this.igLinearGauge3.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// numericUpDown1
			// 
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.LabelText = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 306);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown1.TabIndex = 6;
			this.numericUpDown1.Value = new decimal(new int[] {
            40,
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
			this.flowLayoutPanel1.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 29);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Needle Dragging";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 45);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Scale Inverted";
			// 
			// numericUpDown2
			// 
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown2, true);
			this.numericUpDown2.LabelText = "Minor Tick Count";
			this.numericUpDown2.Location = new System.Drawing.Point(3, 96);
			this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.DecimalPlaces = 2;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown3, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown3, true);
			this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown3.LabelText = "Scale Inner Extent";
			this.numericUpDown3.Location = new System.Drawing.Point(3, 166);
			this.numericUpDown3.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.numericUpDown3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown3.TabIndex = 4;
			this.numericUpDown3.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
			// 
			// numericUpDown4
			// 
			this.numericUpDown4.DecimalPlaces = 2;
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown4, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown4, true);
			this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown4.LabelText = "Scale Outer Extent";
			this.numericUpDown4.Location = new System.Drawing.Point(3, 236);
			this.numericUpDown4.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
			this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown4.TabIndex = 5;
			this.numericUpDown4.Value = new decimal(new int[] {
            65,
            0,
            0,
            131072});
			// 
			// igLinearGauge
			// 
			this.Name = "igLinearGauge";
			this.Load += new System.EventHandler(this.igLinearGauge_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Ignite.igLinearGauge igLinearGauge1;
		private Ignite.igLinearGauge igLinearGauge3;
		private Ignite.igLinearGauge igLinearGauge2;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private NumericUpDown numericUpDown4;
		private NumericUpDown numericUpDown3;
	}
}
