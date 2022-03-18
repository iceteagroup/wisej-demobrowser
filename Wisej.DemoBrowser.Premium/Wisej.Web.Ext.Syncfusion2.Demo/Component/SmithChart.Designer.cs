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
            this.comboBoxShaprType = new Wisej.Web.ComboBox();
            this.checkBoxLegendVisibility = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/smithchart/es5-getting-starte" +
    "d/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/smithchart/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLegendVisibility);
            this.groupBox1.Controls.Add(this.comboBoxShaprType);
            this.groupBox1.Controls.Add(this.checkBoxMarkerVisible);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxMarkerVisible, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxShaprType, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxLegendVisibility, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.smithChart1);
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
            this.smithChart1.Size = new System.Drawing.Size(1073, 542);
            this.smithChart1.TabIndex = 0;
            this.smithChart1.Text = "smithChart1";
            // 
            // checkBoxMarkerVisible
            // 
            this.checkBoxMarkerVisible.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMarkerVisible.Checked = true;
            this.checkBoxMarkerVisible.Location = new System.Drawing.Point(19, 28);
            this.checkBoxMarkerVisible.Name = "checkBoxMarkerVisible";
            this.checkBoxMarkerVisible.Size = new System.Drawing.Size(135, 24);
            this.checkBoxMarkerVisible.TabIndex = 1;
            this.checkBoxMarkerVisible.Text = "Marker Visible";
            this.checkBoxMarkerVisible.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxShaprType
            // 
            this.comboBoxShaprType.Items.AddRange(new object[] {
            "Circle",
            "Rectangle"});
            this.comboBoxShaprType.LabelText = "Shape Type";
            this.comboBoxShaprType.Location = new System.Drawing.Point(19, 86);
            this.comboBoxShaprType.Name = "comboBoxShaprType";
            this.comboBoxShaprType.Size = new System.Drawing.Size(215, 42);
            this.comboBoxShaprType.TabIndex = 2;
            // 
            // checkBoxLegendVisibility
            // 
            this.checkBoxLegendVisibility.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxLegendVisibility.Checked = true;
            this.checkBoxLegendVisibility.Location = new System.Drawing.Point(19, 59);
            this.checkBoxLegendVisibility.Name = "checkBoxLegendVisibility";
            this.checkBoxLegendVisibility.Size = new System.Drawing.Size(144, 24);
            this.checkBoxLegendVisibility.TabIndex = 3;
            this.checkBoxLegendVisibility.Text = "Legend visibility";
            // 
            // SmithChart
            // 
            this.Name = "SmithChart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.SmithChart smithChart1;
        private CheckBox checkBoxMarkerVisible;
        private CheckBox checkBoxLegendVisibility;
        private ComboBox comboBoxShaprType;
    }
}