﻿namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igFunnelChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(igFunnelChart));
			Wisej.Web.Ext.Ignite.igBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.numericUpDown2 = new Wisej.Web.NumericUpDown();
			this.label4 = new Wisej.Web.Label();
			this.igFunnelChart1 = new Wisej.Web.Ext.Ignite.igFunnelChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.TabIndex = 3;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.igFunnelChart1);
			this.panel.Size = new System.Drawing.Size(895, 578);
			this.panel.TabIndex = 7;
			this.panel.Text = " ";
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/funnel-chart/overview";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://www.igniteui.com/help/api/2019.2/ui.igFunnelChart";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/igfunnelchart-overview";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBox2);
			this.flowLayoutPanel1.Controls.Add(this.checkBox3);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown2);
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "uniform",
            "weighted"});
			this.comboBox1.LabelText = "Funnel Slice Display";
			this.comboBox1.Location = new System.Drawing.Point(3, 269);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 57);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "uniform";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 38);
			this.checkBox2.TabIndex = 0;
			this.checkBox2.Text = "Use Bezier Curve";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanel1.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 60);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 38);
			this.checkBox3.TabIndex = 1;
			this.checkBox3.Text = "Inverted";
			// 
			// numericUpDown1
			// 
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDown1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDown1, true);
			this.numericUpDown1.LabelText = "Transition Duration";
			this.numericUpDown1.Location = new System.Drawing.Point(3, 117);
			this.numericUpDown1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
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
			this.numericUpDown2.LabelText = "Bottom Edge Width";
			this.numericUpDown2.Location = new System.Drawing.Point(3, 193);
			this.numericUpDown2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(212, 57);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.Value = new decimal(new int[] {
            35,
            0,
            0,
            131072});
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label4.Location = new System.Drawing.Point(402, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Funnel Chart";
			// 
			// igFunnelChart1
			// 
			this.igFunnelChart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.igFunnelChart1.Location = new System.Drawing.Point(256, 131);
			this.igFunnelChart1.Name = "igFunnelChart1";
			this.igFunnelChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("igFunnelChart1.Options"))));
			this.igFunnelChart1.Size = new System.Drawing.Size(380, 349);
			this.igFunnelChart1.TabIndex = 1;
			this.igFunnelChart1.Text = "igFunnelChart1";
			widgetFunction1.Name = "clickSlice";
			widgetFunction1.Source = "App.MainView.showAlert(arguments[1][\"item\"]);";
			this.igFunnelChart1.WidgetFunctions = new Wisej.Web.Ext.Ignite.igBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// igFunnelChart
			// 
			this.Name = "igFunnelChart";
			this.Load += new System.EventHandler(this.igFunnelChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private CheckBox checkBox2;
		private ComboBox comboBox1;
		private CheckBox checkBox3;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
        private Label label4;
        private Ignite.igFunnelChart igFunnelChart1;
    }
}
