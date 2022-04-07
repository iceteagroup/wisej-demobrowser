namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Calendar
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
            this.calendar1 = new Wisej.Web.Ext.Webix.Calendar();
            this.checkBoxSkipEmptyWeeks = new Wisej.Web.CheckBox();
            this.checkBoxWeekHeader = new Wisej.Web.CheckBox();
            this.checkBoxWeekNumber = new Wisej.Web.CheckBox();
            this.dateTimePickerMinDate = new Wisej.Web.DateTimePicker();
            this.dateTimePickerMaxDate = new Wisej.Web.DateTimePicker();
            this.checkBoxTimePicker = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__calendar.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#calendar";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.calendar.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.calendar1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxSkipEmptyWeeks);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxWeekHeader);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxWeekNumber);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerMinDate);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerMaxDate);
            // 
            // calendar1
            // 
            this.calendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.calendar1.Location = new System.Drawing.Point(294, 79);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(500, 400);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            // 
            // checkBoxSkipEmptyWeeks
            // 
            this.checkBoxSkipEmptyWeeks.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxSkipEmptyWeeks.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSkipEmptyWeeks.AutoSize = false;
            this.checkBoxSkipEmptyWeeks.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSkipEmptyWeeks.Location = new System.Drawing.Point(3, 41);
            this.checkBoxSkipEmptyWeeks.Name = "checkBoxSkipEmptyWeeks";
            this.checkBoxSkipEmptyWeeks.Size = new System.Drawing.Size(212, 32);
            this.checkBoxSkipEmptyWeeks.TabIndex = 0;
            this.checkBoxSkipEmptyWeeks.Text = "Skip empty week";
            // 
            // checkBoxWeekHeader
            // 
            this.checkBoxWeekHeader.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxWeekHeader.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxWeekHeader.AutoSize = false;
            this.checkBoxWeekHeader.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWeekHeader.Location = new System.Drawing.Point(3, 79);
            this.checkBoxWeekHeader.Name = "checkBoxWeekHeader";
            this.checkBoxWeekHeader.Size = new System.Drawing.Size(212, 32);
            this.checkBoxWeekHeader.TabIndex = 1;
            this.checkBoxWeekHeader.Text = "Week header";
            // 
            // checkBoxWeekNumber
            // 
            this.checkBoxWeekNumber.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxWeekNumber.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxWeekNumber.AutoSize = false;
            this.checkBoxWeekNumber.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxWeekNumber.Location = new System.Drawing.Point(3, 117);
            this.checkBoxWeekNumber.Name = "checkBoxWeekNumber";
            this.checkBoxWeekNumber.Size = new System.Drawing.Size(212, 32);
            this.checkBoxWeekNumber.TabIndex = 2;
            this.checkBoxWeekNumber.Text = "Week number";
            // 
            // dateTimePickerMinDate
            // 
            this.dateTimePickerMinDate.LabelText = "Min date";
            this.dateTimePickerMinDate.Location = new System.Drawing.Point(3, 155);
            this.dateTimePickerMinDate.Name = "dateTimePickerMinDate";
            this.dateTimePickerMinDate.Size = new System.Drawing.Size(212, 46);
            this.dateTimePickerMinDate.TabIndex = 5;
            this.dateTimePickerMinDate.Value = new System.DateTime(2022, 3, 31, 23, 48, 18, 519);
            // 
            // dateTimePickerMaxDate
            // 
            this.dateTimePickerMaxDate.LabelText = "Max date";
            this.dateTimePickerMaxDate.Location = new System.Drawing.Point(3, 207);
            this.dateTimePickerMaxDate.Name = "dateTimePickerMaxDate";
            this.dateTimePickerMaxDate.Size = new System.Drawing.Size(212, 46);
            this.dateTimePickerMaxDate.TabIndex = 6;
            this.dateTimePickerMaxDate.Value = new System.DateTime(2022, 3, 31, 23, 48, 21, 962);
            // 
            // checkBoxTimePicker
            // 
            this.checkBoxTimePicker.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxTimePicker.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxTimePicker.AutoSize = false;
            this.checkBoxTimePicker.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTimePicker.Location = new System.Drawing.Point(3, 3);
            this.checkBoxTimePicker.Name = "checkBoxTimePicker";
            this.checkBoxTimePicker.Size = new System.Drawing.Size(212, 32);
            this.checkBoxTimePicker.TabIndex = 7;
            this.checkBoxTimePicker.Text = "Time picker";
            // 
            // Calendar
            // 
            this.Name = "Calendar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Calendar calendar1;
        private CheckBox checkBoxSkipEmptyWeeks;
        private CheckBox checkBoxWeekHeader;
        private CheckBox checkBoxWeekNumber;
        private DateTimePicker dateTimePickerMinDate;
        private DateTimePicker dateTimePickerMaxDate;
        private CheckBox checkBoxTimePicker;
    }
}
