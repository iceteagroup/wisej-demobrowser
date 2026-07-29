namespace Wisej.DemoBrowser.MonthCalendar
{
	partial class Features
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
            this.monthCalendar1 = new Wisej.Web.MonthCalendar();
            this.monthCalendar3 = new Wisej.Web.MonthCalendar();
            this.label1 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = Wisej.Web.AnchorStyles.Top;
            this.monthCalendar1.AutoSize = true;
            this.monthCalendar1.Location = new System.Drawing.Point(47, 91);
            this.monthCalendar1.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2022, 1, 15, 0, 0, 0, 0)};
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(246, 227);
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new Wisej.Web.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Anchor = Wisej.Web.AnchorStyles.Top;
            this.monthCalendar3.AutoSize = true;
            this.monthCalendar3.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar3.Location = new System.Drawing.Point(386, 91);
            this.monthCalendar3.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.ShowOtherMonth = false;
            this.monthCalendar3.ShowWeekNumbers = false;
            this.monthCalendar3.Size = new System.Drawing.Size(438, 227);
            this.monthCalendar3.TabIndex = 2;
            this.monthCalendar3.TodayFormat = "MMM dd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calendar Dimensions [2,1]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Default Calendar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Features
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar3);
            this.Controls.Add(this.monthCalendar1);
            this.MinimumSize = new System.Drawing.Size(854, 328);
            this.Name = "Features";
            this.Size = new System.Drawing.Size(989, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.MonthCalendar monthCalendar1;
		private Web.MonthCalendar monthCalendar3;
        private Web.Label label1;
        private Web.Label label2;
    }
}
