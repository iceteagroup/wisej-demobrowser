namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Sidebar
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
            this.sidebar1 = new Wisej.Web.Ext.Webix.Sidebar();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.sidebar1);
            // 
            // sidebar1
            // 
            this.sidebar1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.sidebar1.Location = new System.Drawing.Point(437, 79);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(215, 400);
            this.sidebar1.TabIndex = 0;
            this.sidebar1.Text = "sidebar1";
            // 
            // Sidebar
            // 
            this.Name = "Sidebar";
            this.Load += new System.EventHandler(this.Sidebar_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Sidebar sidebar1;
	}
}
