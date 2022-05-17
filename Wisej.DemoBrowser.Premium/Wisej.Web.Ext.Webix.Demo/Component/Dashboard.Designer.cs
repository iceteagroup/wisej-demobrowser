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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashboard1 = new Wisej.Web.Ext.Webix.Dashboard();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__dashboard.html";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#dashboard";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.dashboard.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dashboard1);
            // 
            // dashboard1
            // 
            this.dashboard1.Dock = Wisej.Web.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(8, 8);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dashboard1.Options"))));
            this.dashboard1.Size = new System.Drawing.Size(1073, 542);
            this.dashboard1.TabIndex = 0;
            this.dashboard1.Text = "dashboard1";
            // 
            // Dashboard
            // 
            this.MinimumSize = new System.Drawing.Size(1321, 737);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Dashboard dashboard1;
	}
}
