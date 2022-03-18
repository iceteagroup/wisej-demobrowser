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
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoMultiViewCalendar1);
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
            // kendoMultiViewCalendar1
            // 
            this.kendoMultiViewCalendar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoMultiViewCalendar1.Location = new System.Drawing.Point(196, 96);
            this.kendoMultiViewCalendar1.Name = "kendoMultiViewCalendar1";
            this.kendoMultiViewCalendar1.Size = new System.Drawing.Size(697, 367);
            this.kendoMultiViewCalendar1.TabIndex = 0;
            this.kendoMultiViewCalendar1.Text = "kendoMultiViewCalendar1";
            // 
            // kendoMultiViewCalendar
            // 
            this.Name = "kendoMultiViewCalendar";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoMultiViewCalendar kendoMultiViewCalendar1;
	}
}
