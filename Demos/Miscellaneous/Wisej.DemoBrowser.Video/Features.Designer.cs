namespace Wisej.DemoBrowser.Video
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
            this.videoDefault = new Wisej.Web.Video();
            this.SuspendLayout();
            // 
            // videoDefault
            // 
            this.videoDefault.AutoPlay = true;
            this.videoDefault.Dock = Wisej.Web.DockStyle.Fill;
            this.videoDefault.Location = new System.Drawing.Point(16, 16);
            this.videoDefault.Muted = true;
            this.videoDefault.Name = "videoDefault";
            this.videoDefault.ObjectFit = Wisej.Web.ObjectFit.Cover;
            this.videoDefault.Size = new System.Drawing.Size(1390, 442);
            this.videoDefault.SourceURL = "Media/sample.mp4";
            this.videoDefault.TabIndex = 0;
            this.videoDefault.Volume = 0D;
            this.videoDefault.VolumeChanged += new System.EventHandler(this.videoDefault_VolumeChanged);
            this.videoDefault.Paused += new System.EventHandler(this.videoDefault_Paused);
            this.videoDefault.Playing += new System.EventHandler(this.videoDefault_Playing);
            // 
            // Features
            // 
            this.Controls.Add(this.videoDefault);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(16);
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Video videoDefault;
	}
}
