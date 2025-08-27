﻿namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class SmithChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmithChart));
			this.smithChart1 = new Wisej.Web.Ext.Syncfusion2.SmithChart();
			this.checkBoxMarkerVisible = new Wisej.Web.CheckBox();
			this.comboBoxShapeType = new Wisej.Web.ComboBox();
			this.checkBoxLegendVisibility = new Wisej.Web.CheckBox();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/smithchart/es5-getting-starte" +
    "d/";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/smithchart/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.smithChart1);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxMarkerVisible);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxLegendVisibility);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxShapeType);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/smith-chart/default.html";
			// 
			// smithChart1
			// 
			this.smithChart1.Dock = Wisej.Web.DockStyle.Fill;
			this.smithChart1.Location = new System.Drawing.Point(8, 8);
			this.smithChart1.Name = "smithChart1";
			this.smithChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("smithChart1.Options"))));
			this.smithChart1.Size = new System.Drawing.Size(872, 560);
			this.smithChart1.TabIndex = 0;
			this.smithChart1.Text = "smithChart1";
			// 
			// checkBoxMarkerVisible
			// 
			this.checkBoxMarkerVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxMarkerVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxMarkerVisible.Checked = true;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxMarkerVisible, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMarkerVisible, true);
			this.checkBoxMarkerVisible.Location = new System.Drawing.Point(3, 73);
			this.checkBoxMarkerVisible.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxMarkerVisible.Name = "checkBoxMarkerVisible";
			this.checkBoxMarkerVisible.Size = new System.Drawing.Size(212, 24);
			this.checkBoxMarkerVisible.TabIndex = 1;
			this.checkBoxMarkerVisible.Text = "Marker Visible";
			this.checkBoxMarkerVisible.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// comboBoxShapeType
			// 
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxShapeType, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.comboBoxShapeType, true);
			this.comboBoxShapeType.Items.AddRange(new object[] {
            "Circle",
            "Rectangle"});
			this.comboBoxShapeType.LabelText = "Shape Type";
			this.comboBoxShapeType.Location = new System.Drawing.Point(3, 159);
			this.comboBoxShapeType.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBoxShapeType.Name = "comboBoxShapeType";
			this.comboBoxShapeType.Size = new System.Drawing.Size(212, 51);
			this.comboBoxShapeType.TabIndex = 2;
			// 
			// checkBoxLegendVisibility
			// 
			this.checkBoxLegendVisibility.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxLegendVisibility.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxLegendVisibility.Checked = true;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxLegendVisibility, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxLegendVisibility, true);
			this.checkBoxLegendVisibility.Location = new System.Drawing.Point(3, 116);
			this.checkBoxLegendVisibility.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBoxLegendVisibility.Name = "checkBoxLegendVisibility";
			this.checkBoxLegendVisibility.Size = new System.Drawing.Size(212, 24);
			this.checkBoxLegendVisibility.TabIndex = 3;
			this.checkBoxLegendVisibility.Text = "Legend Visibility";
			// 
			// textBoxTitle
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxTitle, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxTitle, true);
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(212, 51);
			this.textBoxTitle.TabIndex = 4;
			this.textBoxTitle.Text = "Transmission";
			// 
			// SmithChart
			// 
			this.Name = "SmithChart";
			this.Load += new System.EventHandler(this.SmithChart_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.SmithChart smithChart1;
        private CheckBox checkBoxMarkerVisible;
        private CheckBox checkBoxLegendVisibility;
        private ComboBox comboBoxShapeType;
        private TextBox textBoxTitle;
    }
}
