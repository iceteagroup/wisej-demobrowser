namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Dashboard
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
			this.dashboard1 = new Wisej.Web.Ext.Webix.Dashboard();
			this.SuspendLayout();
			// 
			// dashboard1
			// 
			this.dashboard1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dashboard1.Location = new System.Drawing.Point(515, 38);
			this.dashboard1.Name = "dashboard1";
			this.dashboard1.Size = new System.Drawing.Size(500, 400);
			this.dashboard1.TabIndex = 0;
			this.dashboard1.Text = "dashboard1";
			// 
			// Dashboard
			// 
			this.Controls.Add(this.dashboard1);
			this.Name = "Dashboard";
			this.Controls.SetChildIndex(this.dashboard1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.Dashboard dashboard1;
	}
}
