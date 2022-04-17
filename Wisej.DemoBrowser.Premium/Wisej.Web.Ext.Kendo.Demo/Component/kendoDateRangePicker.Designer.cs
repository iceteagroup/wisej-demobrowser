﻿namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDateRangePicker
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
            this.kendoDateRangePicker1 = new Wisej.Web.Ext.Kendo.kendoDateRangePicker();
            this.dateTimePickerMin = new Wisej.Web.DateTimePicker();
            this.dateTimePickerMax = new Wisej.Web.DateTimePicker();
            this.comboBoxDepth = new Wisej.Web.ComboBox();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDateRangePicker1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/daterangepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/daterangepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/daterangepicker/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.comboBoxDepth);
            this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMin);
            this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMax);
            // 
            // kendoDateRangePicker1
            // 
            this.kendoDateRangePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDateRangePicker1.Location = new System.Drawing.Point(342, 209);
            this.kendoDateRangePicker1.Name = "kendoDateRangePicker1";
            this.kendoDateRangePicker1.Size = new System.Drawing.Size(404, 140);
            this.kendoDateRangePicker1.TabIndex = 0;
            this.kendoDateRangePicker1.Text = "kendoDateRangePicker1";
            // 
            // dateTimePickerMin
            // 
            this.dateTimePickerMin.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePickerMin.LabelText = "Min";
            this.dateTimePickerMin.Location = new System.Drawing.Point(3, 66);
            this.dateTimePickerMin.Name = "dateTimePickerMin";
            this.dateTimePickerMin.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerMin.TabIndex = 2;
            this.dateTimePickerMin.Value = new System.DateTime(2022, 4, 11, 20, 18, 35, 660);
            // 
            // dateTimePickerMax
            // 
            this.dateTimePickerMax.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePickerMax.LabelText = "Max";
            this.dateTimePickerMax.Location = new System.Drawing.Point(3, 129);
            this.dateTimePickerMax.Name = "dateTimePickerMax";
            this.dateTimePickerMax.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerMax.TabIndex = 3;
            this.dateTimePickerMax.Value = new System.DateTime(2022, 4, 11, 20, 18, 35, 660);
            // 
            // comboBoxDepth
            // 
            this.comboBoxDepth.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxDepth.Items.AddRange(new object[] {
            "month",
            "year",
            "decade",
            "century"});
            this.comboBoxDepth.LabelText = "Depth";
            this.comboBoxDepth.Location = new System.Drawing.Point(3, 3);
            this.comboBoxDepth.Name = "comboBoxDepth";
            this.comboBoxDepth.Size = new System.Drawing.Size(212, 57);
            this.comboBoxDepth.TabIndex = 4;
            // 
            // kendoDateRangePicker
            // 
            this.MinimumSize = new System.Drawing.Size(823, 510);
            this.Name = "kendoDateRangePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDateRangePicker kendoDateRangePicker1;
        private DateTimePicker dateTimePickerMin;
        private DateTimePicker dateTimePickerMax;
        private ComboBox comboBoxDepth;
    }
}
