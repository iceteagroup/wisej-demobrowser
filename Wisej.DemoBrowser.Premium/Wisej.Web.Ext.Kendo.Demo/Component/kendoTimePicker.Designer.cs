namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoTimePicker
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
            this.kendoTimePicker1 = new Wisej.Web.Ext.Kendo.kendoTimePicker();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoTimePicker1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/timepicker/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/timepicker";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/editors/timepicker/overview";
            // 
            // kendoTimePicker1
            // 
            this.kendoTimePicker1.Anchor = Wisej.Web.AnchorStyles.None;
            this.kendoTimePicker1.Location = new System.Drawing.Point(394, 259);
            this.kendoTimePicker1.Name = "kendoTimePicker1";
            this.kendoTimePicker1.Size = new System.Drawing.Size(300, 40);
            this.kendoTimePicker1.TabIndex = 0;
            this.kendoTimePicker1.Text = "kendoTimePicker1";
            // 
            // kendoTimePicker
            // 
            this.Name = "kendoTimePicker";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoTimePicker kendoTimePicker1;
	}
}
