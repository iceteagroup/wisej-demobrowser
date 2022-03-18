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
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.calendar1);
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
            // Calendar
            // 
            this.Name = "Calendar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Calendar calendar1;
	}
}
