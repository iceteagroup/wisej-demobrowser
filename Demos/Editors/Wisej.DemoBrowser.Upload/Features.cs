using System;
using System.Drawing;
using System.IO;
using System.Web;
using Wisej.Core;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Upload
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void uploadImage_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 0)
				return;

			var image = Image.FromStream(e.Files[0].InputStream);
			this.pictureBox.Image = image;

			AlertBox.Show("Loaded Image");
			Application.Update(this);
		}

		private void uploadVideo_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 0)
				return;

			AlertBox.Show("Processing Video");
			Application.Update(this);

			using (var stream = new MemoryStream())
			{
				e.Files[0].InputStream.CopyTo(stream);

				var bytes = stream.ToArray();
				var base64String = $"data:video/mp4;base64,{Convert.ToBase64String(bytes)}";

				this.video.SourceURL = base64String;
			}

			AlertBox.Show("Loaded Video");
			Application.Update(this);
		}

		private void uploadAudio_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 0)
				return;

			using (var stream = new MemoryStream())
			{
				e.Files[0].InputStream.CopyTo(stream);

				var bytes = stream.ToArray();
				var base64String = $"data:audio/mp3;base64,{Convert.ToBase64String(bytes)}";

				this.audio.SourceURL = base64String;
			}

			AlertBox.Show("Loaded Audio");
			Application.Update(this);
		}

		private void upload_Progress(object sender, UploadProgressEventArgs e)
		{
			var progress = (float)e.Loaded / (float)e.Total * 100F;

			this.progressBar.Text = $"{progress}%";
			this.progressBar.Value = (int)progress;
		}
	}
}
