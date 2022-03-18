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
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoCalendar1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/calendar/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/calendar";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/scheduling/calendar/overview";
            // 
            // kendoCalendar1
            // 
            this.kendoCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoCalendar1.Location = new System.Drawing.Point(269, 87);
            this.kendoCalendar1.Name = "kendoCalendar1";
            this.kendoCalendar1.Size = new System.Drawing.Size(550, 384);
            this.kendoCalendar1.TabIndex = 0;
            this.kendoCalendar1.Text = "kendoCalendar1";
            // 
            // kendoCalendar
            // 
            this.Name = "kendoCalendar";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoCalendar kendoCalendar1;
	}
}
