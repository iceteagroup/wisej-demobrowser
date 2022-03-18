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
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/calendar/es5-getting-started/" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/calendar/overview/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerStart);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePickerStart, 0);
            this.groupBox1.Controls.SetChildIndex(this.dateTimePickerEnd, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.calendar1);
            this.panel.Size = new System.Drawing.Size(509, 384);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/calendar/default.html";
            // 
            // calendar1
            // 
            this.calendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.calendar1.Location = new System.Drawing.Point(83, 32);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(341, 318);
            this.calendar1.TabIndex = 0;
            this.calendar1.Text = "calendar1";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.LabelText = "Start Date";
            this.dateTimePickerStart.Location = new System.Drawing.Point(23, 44);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 53);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.LabelText = "End Date";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(23, 125);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 53);
            this.dateTimePickerEnd.TabIndex = 2;
            this.dateTimePickerEnd.Value = new System.DateTime(2022, 1, 17, 20, 36, 40, 363);
            // 
            // Calendar
            // 
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(918, 574);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Calendar calendar1;
        private Web.DateTimePicker dateTimePickerStart;
        private Web.DateTimePicker dateTimePickerEnd;
    }
}
