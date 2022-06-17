namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
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
            this.calendar1 = new Wisej.Web.Ext.Syncfusion2.Calendar();
            this.dateTimePickerStart = new Wisej.Web.DateTimePicker();
            this.dateTimePickerEnd = new Wisej.Web.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/calendar/es5-getting-started/" +
    "";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/calendar/overview/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.calendar1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerStart);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePickerEnd);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/calendar/default.html";
            // 
            // calendar1
            // 
            this.calendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.calendar1.Location = new System.Drawing.Point(274, 129);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(341, 318);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.dateTimePickerStart, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.dateTimePickerStart, true);
            this.dateTimePickerStart.LabelText = "Start Date";
            this.dateTimePickerStart.Location = new System.Drawing.Point(3, 3);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel1.SetFillWeight(this.dateTimePickerEnd, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.dateTimePickerEnd, true);
            this.dateTimePickerEnd.LabelText = "End Date";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(3, 79);
            this.dateTimePickerEnd.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(212, 57);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // Calendar
            // 
            this.Name = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.Calendar calendar1;
        private Web.DateTimePicker dateTimePickerStart;
        private Web.DateTimePicker dateTimePickerEnd;
    }
}
