﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejDateRangePicker
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
			this.ejDateRangePicker1 = new Wisej.Web.Ext.Syncfusion.ejDateRangePicker();
			this.textBoxStartDay = new Wisej.Web.TextBox();
			this.textBoxEndDay = new Wisej.Web.TextBox();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/daterangepicker/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 4;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Size = new System.Drawing.Size(546, 24);
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/daterangepicker/defaultfunctiona" +
    "lities";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejdaterangepicker";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejDateRangePicker1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.textBoxStartDay);
			this.flowLayoutPanelProperties.Controls.Add(this.textBoxEndDay);
			// 
			// ejDateRangePicker1
			// 
			this.ejDateRangePicker1.Anchor = Wisej.Web.AnchorStyles.None;
			this.ejDateRangePicker1.Location = new System.Drawing.Point(294, 271);
			this.ejDateRangePicker1.Name = "ejDateRangePicker1";
			this.ejDateRangePicker1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":null}")));
			this.ejDateRangePicker1.Size = new System.Drawing.Size(300, 35);
			this.ejDateRangePicker1.TabIndex = 0;
			// 
			// textBoxStartDay
			// 
			this.textBoxStartDay.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.textBoxStartDay, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxStartDay, true);
			this.textBoxStartDay.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBoxStartDay.Label.Size = 50;
			this.textBoxStartDay.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxStartDay.LabelText = "Start Date";
			this.textBoxStartDay.Location = new System.Drawing.Point(3, 103);
			this.textBoxStartDay.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxStartDay.Name = "textBoxStartDay";
			this.textBoxStartDay.Size = new System.Drawing.Size(212, 60);
			this.textBoxStartDay.TabIndex = 2;
			this.textBoxStartDay.Text = "2020-01-01";
			this.textBoxStartDay.Watermark = "Select date...";
			// 
			// textBoxEndDay
			// 
			this.textBoxEndDay.AutoSize = false;
			this.flowLayoutPanelProperties.SetFillWeight(this.textBoxEndDay, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxEndDay, true);
			this.textBoxEndDay.InputType.Type = Wisej.Web.TextBoxType.Date;
			this.textBoxEndDay.Label.Size = 50;
			this.textBoxEndDay.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.textBoxEndDay.LabelText = "End Date";
			this.textBoxEndDay.Location = new System.Drawing.Point(3, 182);
			this.textBoxEndDay.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxEndDay.Name = "textBoxEndDay";
			this.textBoxEndDay.Size = new System.Drawing.Size(212, 60);
			this.textBoxEndDay.TabIndex = 3;
			this.textBoxEndDay.Text = "2020-01-15";
			this.textBoxEndDay.Watermark = "Select date...";
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
			this.checkBox1.Size = new System.Drawing.Size(212, 31);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Allow Edit";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 53);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 31);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Enable Time Picker";
			// 
			// ejDateRangePicker
			// 
			this.Name = "ejDateRangePicker";
			this.Load += new System.EventHandler(this.ejDateRangePicker_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejDateRangePicker ejDateRangePicker1;
		private TextBox textBoxEndDay;
		private TextBox textBoxStartDay;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
