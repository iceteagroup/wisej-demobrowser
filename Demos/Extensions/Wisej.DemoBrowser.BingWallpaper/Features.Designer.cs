namespace Wisej.DemoBrowser.BingWallpaper
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
            this.components = new System.ComponentModel.Container();
            this.bingWallpaper1 = new Wisej.Web.Ext.BingWallpaper.BingWallpaper(this.components);
            this.panelWallpaper = new Wisej.Web.Panel();
            this.SuspendLayout();
            // 
            // bingWallpaper1
            // 
            this.bingWallpaper1.Control = this.panelWallpaper;
            this.bingWallpaper1.RotationInterval = 5000;
            // 
            // panelWallpaper
            // 
            this.panelWallpaper.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panelWallpaper.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panelWallpaper.Location = new System.Drawing.Point(220, 31);
            this.panelWallpaper.Name = "panelWallpaper";
            this.panelWallpaper.Size = new System.Drawing.Size(352, 293);
            this.panelWallpaper.TabIndex = 0;
            this.panelWallpaper.TabStop = true;
            // 
            // Features
            // 
            this.Controls.Add(this.panelWallpaper);
            this.MinimumSize = new System.Drawing.Size(792, 354);
            this.Name = "Features";
            this.Size = new System.Drawing.Size(792, 354);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Ext.BingWallpaper.BingWallpaper bingWallpaper1;
		private Web.Panel panelWallpaper;
	}
}
