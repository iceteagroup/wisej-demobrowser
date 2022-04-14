namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoMultiViewCalendar
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
            this.kendoMultiViewCalendar1 = new Wisej.Web.Ext.Kendo.kendoMultiViewCalendar();
            this.dateTimePickerMaxDate = new Wisej.Web.DateTimePicker();
            this.dateTimePickerMinDate = new Wisej.Web.DateTimePicker();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoMultiViewCalendar1);
            this.panel.Size = new System.Drawing.Size(707, 389);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(250, 389);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(16, 321);
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/multiviewcalendar/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/multiviewcalendar";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/scheduling/multiviewcalendar/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMinDate);
            this.flowLayoutPanelProperties.Controls.Add(this.dateTimePickerMaxDate);
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 263);
            // 
            // kendoMultiViewCalendar1
            // 
            this.kendoMultiViewCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoMultiViewCalendar1.Location = new System.Drawing.Point(4, 10);
            this.kendoMultiViewCalendar1.Name = "kendoMultiViewCalendar1";
            this.kendoMultiViewCalendar1.Size = new System.Drawing.Size(697, 367);
            this.kendoMultiViewCalendar1.TabIndex = 0;
            this.kendoMultiViewCalendar1.Text = "kendoMultiViewCalendar1";
            // 
            // dateTimePickerMaxDate
            // 
            this.dateTimePickerMaxDate.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePickerMaxDate.LabelText = "Max date";
            this.dateTimePickerMaxDate.Location = new System.Drawing.Point(3, 70);
            this.dateTimePickerMaxDate.Margin = new Wisej.Web.Padding(3, 5, 3, 3);
            this.dateTimePickerMaxDate.Name = "dateTimePickerMaxDate";
            this.dateTimePickerMaxDate.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerMaxDate.TabIndex = 1;
            this.dateTimePickerMaxDate.Value = new System.DateTime(2022, 4, 9, 20, 25, 11, 683);
            // 
            // dateTimePickerMinDate
            // 
            this.dateTimePickerMinDate.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dateTimePickerMinDate.LabelText = "Min date";
            this.dateTimePickerMinDate.Location = new System.Drawing.Point(3, 5);
            this.dateTimePickerMinDate.Margin = new Wisej.Web.Padding(3, 5, 3, 3);
            this.dateTimePickerMinDate.Name = "dateTimePickerMinDate";
            this.dateTimePickerMinDate.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerMinDate.TabIndex = 2;
            this.dateTimePickerMinDate.Value = new System.DateTime(2022, 4, 9, 20, 25, 11, 683);
            // 
            // kendoMultiViewCalendar
            // 
            this.MinimumSize = new System.Drawing.Size(1116, 579);
            this.Name = "kendoMultiViewCalendar";
            this.Size = new System.Drawing.Size(1116, 579);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoMultiViewCalendar kendoMultiViewCalendar1;
        private DateTimePicker dateTimePickerMaxDate;
        private DateTimePicker dateTimePickerMinDate;
    }
}
