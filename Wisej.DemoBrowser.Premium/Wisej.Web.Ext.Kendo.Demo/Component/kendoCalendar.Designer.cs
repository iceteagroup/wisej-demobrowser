namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoCalendar
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
			this.kendoCalendar1 = new Wisej.Web.Ext.Kendo.kendoCalendar();
			this.dateTimePickerMax = new Wisej.Web.DateTimePicker();
			this.dateTimePickerMin = new Wisej.Web.DateTimePicker();
			this.checkBoxWeekNumber = new Wisej.Web.CheckBox();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoCalendar1);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/calendar/index";
			// 
			// linkApi
			// 
			this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/calendar";
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/scheduling/calendar/overview";
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBoxWeekNumber);
			this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMin);
			this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMax);
			// 
			// kendoCalendar1
			// 
			this.kendoCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
			this.kendoCalendar1.Location = new System.Drawing.Point(204, 96);
			this.kendoCalendar1.Name = "kendoCalendar1";
			this.kendoCalendar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"componentType\":\"modern\"}")));
			this.kendoCalendar1.Size = new System.Drawing.Size(480, 384);
			this.kendoCalendar1.TabIndex = 0;
			this.kendoCalendar1.Text = "kendoCalendar1";
			// 
			// dateTimePickerMax
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.dateTimePickerMax, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.dateTimePickerMax, true);
			this.dateTimePickerMax.LabelText = "Maximum Date";
			this.dateTimePickerMax.Location = new System.Drawing.Point(3, 122);
			this.dateTimePickerMax.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.dateTimePickerMax.Name = "dateTimePickerMax";
			this.dateTimePickerMax.Size = new System.Drawing.Size(212, 57);
			this.dateTimePickerMax.TabIndex = 2;
			this.dateTimePickerMax.Value = new System.DateTime(2022, 5, 9, 11, 49, 14, 536);
			// 
			// dateTimePickerMin
			// 
			this.flowLayoutPanelProperties.SetFillWeight(this.dateTimePickerMin, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.dateTimePickerMin, true);
			this.dateTimePickerMin.LabelText = "Minimum Date";
			this.dateTimePickerMin.Location = new System.Drawing.Point(3, 46);
			this.dateTimePickerMin.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.dateTimePickerMin.Name = "dateTimePickerMin";
			this.dateTimePickerMin.Size = new System.Drawing.Size(212, 57);
			this.dateTimePickerMin.TabIndex = 1;
			this.dateTimePickerMin.Value = new System.DateTime(2022, 5, 9, 11, 49, 15, 372);
			// 
			// checkBoxWeekNumber
			// 
			this.checkBoxWeekNumber.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxWeekNumber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBoxWeekNumber, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBoxWeekNumber, true);
			this.checkBoxWeekNumber.Location = new System.Drawing.Point(3, 3);
			this.checkBoxWeekNumber.Name = "checkBoxWeekNumber";
			this.checkBoxWeekNumber.Size = new System.Drawing.Size(212, 24);
			this.checkBoxWeekNumber.TabIndex = 3;
			this.checkBoxWeekNumber.Text = "Week Number";
			// 
			// kendoCalendar
			// 
			this.Name = "kendoCalendar";
			this.Load += new System.EventHandler(this.kendoCalendar_Load);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			this.flowLayoutPanelProperties.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Kendo.kendoCalendar kendoCalendar1;
        private DateTimePicker dateTimePickerMin;
        private DateTimePicker dateTimePickerMax;
        private CheckBox checkBoxWeekNumber;
    }
}
