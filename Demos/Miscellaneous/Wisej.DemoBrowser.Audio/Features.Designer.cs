namespace Wisej.DemoBrowser.Audio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
            this.audioDefault = new Wisej.Web.Audio();
            this.SuspendLayout();
            // 
            // audioDefault
            // 
            this.audioDefault.Anchor = Wisej.Web.AnchorStyles.None;
            this.audioDefault.Location = new System.Drawing.Point(544, 210);
            this.audioDefault.Name = "audioDefault";
            this.audioDefault.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("audioDefault.ResponsiveProfiles"))));
            this.audioDefault.Size = new System.Drawing.Size(334, 55);
            this.audioDefault.SourceURL = "Media/sample.mp3";
            this.audioDefault.TabIndex = 0;
            this.audioDefault.Volume = 0.5D;
            this.audioDefault.VolumeChanged += new System.EventHandler(this.audioDefault_VolumeChanged);
            this.audioDefault.Paused += new System.EventHandler(this.audioDefault_Paused);
            this.audioDefault.Playing += new System.EventHandler(this.audioDefault_Playing);
            // 
            // Features
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.audioDefault);
            this.Name = "Features";
            this.ResumeLayout(false);

		}

		#endregion

		private Web.Audio audioDefault;
	}
}
