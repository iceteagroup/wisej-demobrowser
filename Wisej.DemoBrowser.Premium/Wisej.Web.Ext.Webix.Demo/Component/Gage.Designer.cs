namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Gage
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
            this.gage1 = new Wisej.Web.Ext.Webix.Gage();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__filter.html";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#gage";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.gage.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.gage1);
            // 
            // gage1
            // 
            this.gage1.Anchor = Wisej.Web.AnchorStyles.None;
            this.gage1.Location = new System.Drawing.Point(294, 79);
            this.gage1.Name = "gage1";
            this.gage1.Size = new System.Drawing.Size(500, 400);
            this.gage1.TabIndex = 0;
            this.gage1.Text = "gage1";
            // 
            // Gage
            // 
            this.Name = "Gage";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Gage gage1;
	}
}
