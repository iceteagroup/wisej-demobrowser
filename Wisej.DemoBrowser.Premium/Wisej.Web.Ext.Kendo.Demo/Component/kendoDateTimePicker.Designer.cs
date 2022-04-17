﻿namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoDateTimePicker
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
            this.kendoDateTimePicker1 = new Wisej.Web.Ext.Kendo.kendoDateTimePicker();
            this.dateTimePickerMin = new Wisej.Web.DateTimePicker();
            this.dateTimePickerMax = new Wisej.Web.DateTimePicker();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoDateTimePicker1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/datetimepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/datetimepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/datetimepicker/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMin);
            this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMax);
            // 
            // kendoDateTimePicker1
            // 
            this.kendoDateTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoDateTimePicker1.Location = new System.Drawing.Point(394, 259);
            this.kendoDateTimePicker1.Name = "kendoDateTimePicker1";
            this.kendoDateTimePicker1.Size = new System.Drawing.Size(300, 40);
            this.kendoDateTimePicker1.TabIndex = 0;
            this.kendoDateTimePicker1.Text = "kendoDateTimePicker1";
            // 
            // dateTimePickerMin
            // 
            this.dateTimePickerMin.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePickerMin.LabelText = "Min";
            this.dateTimePickerMin.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerMin.Name = "dateTimePickerMin";
            this.dateTimePickerMin.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerMin.TabIndex = 0;
            this.dateTimePickerMin.Value = new System.DateTime(2022, 4, 11, 20, 18, 35, 660);
            // 
            // dateTimePickerMax
            // 
            this.dateTimePickerMax.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePickerMax.LabelText = "Max";
            this.dateTimePickerMax.Location = new System.Drawing.Point(3, 66);
            this.dateTimePickerMax.Name = "dateTimePickerMax";
            this.dateTimePickerMax.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerMax.TabIndex = 1;
            this.dateTimePickerMax.Value = new System.DateTime(2022, 4, 11, 20, 18, 35, 660);
            // 
            // kendoDateTimePicker
            // 
            this.MinimumSize = new System.Drawing.Size(721, 467);
            this.Name = "kendoDateTimePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoDateTimePicker kendoDateTimePicker1;
        private DateTimePicker dateTimePickerMin;
        private DateTimePicker dateTimePickerMax;
    }
}
