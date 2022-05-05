using System;
using System.Drawing;
using System.IO;
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

			LoadImage(e.Files[0]);
		}

		private void pictureBox_DragDrop(object sender, DragEventArgs e)
		{
			this.pictureBox.BackColor = Color.Transparent;

			var file = e.Files?[0];
			if (file == null)
				return;

			var extension = Path.GetExtension(file.FileName);
			switch (extension)
			{
				case ".png":
				case ".jpg":
				case ".jpeg":
					LoadImage(file);
					break;

				default:
					AlertBox.Show("The file must be a PNG or JPEG.");
					return;
			}
		}

		private void pictureBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
			e.AllowedFileTypes = "image/png";
			
			this.pictureBox.BackColor = Color.White;
		}

		private void pictureBox_DragLeave(object sender, EventArgs e)
		{
			this.pictureBox.BackColor = Color.Transparent;
		}

		private void LoadImage(HttpPostedFile file)
        {
			this.labelChoose.Hide();
			this.uploadImage.Value = file.FileName;
			this.pictureBox.Image = Image.FromStream(file.InputStream);
		}
	}
}
