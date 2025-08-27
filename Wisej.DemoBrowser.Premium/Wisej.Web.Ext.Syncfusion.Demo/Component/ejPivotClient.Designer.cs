﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejPivotClient
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
			Wisej.Web.Ext.Syncfusion.ejBase.WidgetEventHandler widgetEventHandler1 = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetEventHandler();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.ejPivotClient1 = new Wisej.Web.Ext.Syncfusion.ejPivotClient();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/pivotclient/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 3;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(639, 24);
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pivotclient/Relational/DefaultFu" +
    "nctionalities";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejpivotclient";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPivotClient1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.comboBox1);
			// 
			// comboBox1
			// 
			this.comboBox1.AutoSize = false;
			this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanelProperties.SetFillWeight(this.comboBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.comboBox1, true);
			this.comboBox1.Items.AddRange(new object[] {
            "Line",
            "Spline",
            "Column",
            "Area",
            "SplineArea",
            "StepLine",
            "StepArea",
            "Pie",
            "Bar",
            "StackingArea",
            "StackingColumn",
            "StackingBar",
            "Pyramid",
            "Funnel",
            "Doughnut",
            "Scatter",
            "Bubble"});
			this.comboBox1.Label.Size = 50;
			this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBox1.LabelText = "Chart Type";
			this.comboBox1.Location = new System.Drawing.Point(3, 101);
			this.comboBox1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(212, 60);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.Text = "Line";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 30);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Enable Cell Click";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 52);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 30);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Enable Splitter";
			// 
			// ejPivotClient1
			// 
			this.ejPivotClient1.Dock = Wisej.Web.DockStyle.Fill;
			this.ejPivotClient1.Location = new System.Drawing.Point(8, 8);
			this.ejPivotClient1.Name = "ejPivotClient1";
			this.ejPivotClient1.Size = new System.Drawing.Size(872, 560);
			this.ejPivotClient1.TabIndex = 0;
			this.ejPivotClient1.Text = "ejPivotClient1";
			widgetEventHandler1.Name = "renderSuccess";
			widgetEventHandler1.Source = "this._pivotChart.model.load = \"loadTheme\";";
			this.ejPivotClient1.WidgetEvents = new Wisej.Web.Ext.Syncfusion.ejBase.WidgetEventHandler[] {
        widgetEventHandler1};
			this.ejPivotClient1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejPivotClient1_WebRequest);
			// 
			// ejPivotClient
			// 
			this.Name = "ejPivotClient";
			this.Load += new System.EventHandler(this.ejPivotClient_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejPivotClient ejPivotClient1;
		private ComboBox comboBox1;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
	}
}
