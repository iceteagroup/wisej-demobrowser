using System;
using System.Drawing;
using System.IO;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl.Controls
{
	/// <summary>
	/// A simple message control for displaying files.
	/// </summary>
	public partial class FileMessageControl : Control
	{

		#region Properties

		public Stream Stream;

		public string FilePath;

		public string ContentType;

		#endregion

		#region Constructors

		public FileMessageControl() 
		{ 
			InitializeComponent();
		}

		public FileMessageControl(Stream file, string filePath, string contentType="")
		{
			InitializeComponent();

			this.Stream = file;
			this.FilePath = filePath;
			this.ContentType = contentType;
			this.labelFileName.Text = $"{Path.GetFileName(filePath)} ({FormatFileSize(file.Length)})";

			TryLoadImagePreview();
		}

		#endregion

		#region Event Handlers

		private void contextMenu1_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			if (e.MenuItem.Text == "Download")
			{
				this.Stream.Position = 0;
				Application.Download(this.Stream, this.labelFileName.Text);
			}
		}

		#endregion

		#region Methods

		private void TryLoadImagePreview()
		{
			var extension = Path.GetExtension(this.FilePath);
			switch (extension)
			{
				case ".png":
				case ".jpg":
				case ".jpeg":
				case ".gif":
					this.pictureBox1.SizeMode = PictureBoxSizeMode.Cover;
					this.pictureBox1.Image = Image.FromStream(this.Stream);
					break;

				case ".xls":
				case ".xlsx":
					this.pictureBox1.ImageSource = "file-excel";
					break;

				case ".doc":
				case ".docx":
					this.pictureBox1.ImageSource = "file-word";
					break;

				case ".ppt":
				case ".pptx":
					this.pictureBox1.ImageSource = "file-powerpoint";
					break;

				case ".pdf":
					this.pictureBox1.ImageSource = "file-pdf";
					break;

				default:
					break;
			}
		}

		public string FormatFileSize(long bytes)
		{
			var scale = 1024;
			string[] orders = { "GB", "MB", "KB", "Bytes" };
			var max = (long)Math.Pow(scale, orders.Length - 1);

			foreach (var order in orders)
			{
				if (bytes > max)
					return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

				max /= scale;
			}
			return "0 Bytes";
		}

		#endregion

		private void FileMessageControl_Click(object sender, EventArgs e)
		{
		}
	}
}
