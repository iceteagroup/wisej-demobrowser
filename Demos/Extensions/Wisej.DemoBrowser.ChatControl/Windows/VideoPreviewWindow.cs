using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl.Windows
{
	public partial class VideoPreviewWindow : Form, IWisejHandler
	{

		public Stream Stream;

		public VideoPreviewWindow()
		{
			InitializeComponent();
		}

		public VideoPreviewWindow(string title, Stream stream)
		{
			InitializeComponent();

			this.Text = title;
			this.Stream = stream;
			this.video1.SourceURL = this.GetPostbackURL();
		}

		#region IWisejHandler Implementation

		bool IWisejHandler.Compress => true;

		void IWisejHandler.ProcessRequest(HttpContext context)
		{
			this.Stream.Position = 0;

			context.Response.ContentType = "video/mp4";
			
			this.Stream.CopyTo(context.Response.OutputStream);
		}

		#endregion

	}
}
