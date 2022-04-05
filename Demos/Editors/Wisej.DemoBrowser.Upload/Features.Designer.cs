namespace Wisej.DemoBrowser.Upload
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
            this.uploadAudio = new Wisej.Web.Upload();
            this.uploadVideo = new Wisej.Web.Upload();
            this.uploadImage = new Wisej.Web.Upload();
            this.audio = new Wisej.Web.Audio();
            this.video = new Wisej.Web.Video();
            this.pictureBox = new Wisej.Web.PictureBox();
            this.progressBar = new Wisej.Web.ProgressBar();
            this.label1 = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadAudio
            // 
            this.uploadAudio.AllowedFileTypes = "audio/mp3";
            this.uploadAudio.Anchor = Wisej.Web.AnchorStyles.None;
            this.uploadAudio.Location = new System.Drawing.Point(996, 400);
            this.uploadAudio.Name = "uploadAudio";
            this.uploadAudio.Size = new System.Drawing.Size(350, 40);
            this.uploadAudio.TabIndex = 1;
            this.uploadAudio.Text = "Upload Audio";
            this.uploadAudio.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadAudio_Uploaded);
            this.uploadAudio.Progress += new Wisej.Web.UploadProgressEventHandler(this.upload_Progress);
            // 
            // uploadVideo
            // 
            this.uploadVideo.AllowedFileTypes = "video/mp4";
            this.uploadVideo.Anchor = Wisej.Web.AnchorStyles.None;
            this.uploadVideo.Location = new System.Drawing.Point(516, 400);
            this.uploadVideo.Name = "uploadVideo";
            this.uploadVideo.Size = new System.Drawing.Size(350, 40);
            this.uploadVideo.TabIndex = 2;
            this.uploadVideo.Text = "Upload Video";
            this.uploadVideo.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadVideo_Uploaded);
            this.uploadVideo.Progress += new Wisej.Web.UploadProgressEventHandler(this.upload_Progress);
            // 
            // uploadImage
            // 
            this.uploadImage.AllowedFileTypes = "image/png,image/jpeg";
            this.uploadImage.Anchor = Wisej.Web.AnchorStyles.None;
            this.uploadImage.Location = new System.Drawing.Point(77, 400);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(350, 40);
            this.uploadImage.TabIndex = 3;
            this.uploadImage.Text = "Upload Image";
            this.uploadImage.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadImage_Uploaded);
            this.uploadImage.Progress += new Wisej.Web.UploadProgressEventHandler(this.upload_Progress);
            // 
            // audio
            // 
            this.audio.Anchor = Wisej.Web.AnchorStyles.None;
            this.audio.Location = new System.Drawing.Point(999, 129);
            this.audio.Name = "audio";
            this.audio.Size = new System.Drawing.Size(347, 257);
            this.audio.TabIndex = 4;
            this.audio.Volume = 0.5D;
            // 
            // video
            // 
            this.video.Anchor = Wisej.Web.AnchorStyles.None;
            this.video.Location = new System.Drawing.Point(516, 129);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(350, 257);
            this.video.TabIndex = 5;
            this.video.Volume = 0.5D;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = Wisej.Web.AnchorStyles.None;
            this.pictureBox.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pictureBox.Location = new System.Drawing.Point(80, 129);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(347, 257);
            this.pictureBox.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar.Location = new System.Drawing.Point(321, 69);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(772, 24);
            this.progressBar.TabIndex = 6;
            this.progressBar.Text = "0%";
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Upload Progress";
            // 
            // Features
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.video);
            this.Controls.Add(this.audio);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.uploadVideo);
            this.Controls.Add(this.uploadAudio);
            this.MinimumSize = new System.Drawing.Size(1305, 320);
            this.Name = "Features";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Upload uploadAudio;
		private Web.Upload uploadVideo;
		private Web.Upload uploadImage;
		private Web.Audio audio;
		private Web.Video video;
		private Web.PictureBox pictureBox;
		private Web.ProgressBar progressBar;
		private Web.Label label1;
	}
}
