using System.Drawing;
using System.IO;
using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl.Windows
{
	public partial class ImagePreviewWindow : Form
	{
		public ImagePreviewWindow()
		{
			InitializeComponent();
		}

		public ImagePreviewWindow(string title, Stream stream)
		{
			InitializeComponent();

			this.Text = title;
			this.pictureBox1.Image = Image.FromStream(stream);
		}
	}
}
