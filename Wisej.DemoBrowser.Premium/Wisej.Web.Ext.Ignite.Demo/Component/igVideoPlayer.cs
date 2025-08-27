using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igVideoPlayer : TestBase
	{
		public igVideoPlayer()
		{
			InitializeComponent();

			this.igVideoPlayer1.Instance.onPaused += new WidgetEventHandler(igVideoPlayer_WidgetEvent);
			this.igVideoPlayer1.Instance.onPlaying += new WidgetEventHandler(igVideoPlayer_WidgetEvent);
		}

		private void igVideoPlayer_Load(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Options.sources = new string[]
			{
				"https://dl.infragistics.com/pg/2011-1/web/shared/videoplayer/videos/big_buck_bunny.mp4",
				"https://dl.infragistics.com/pg/2011-1/web/shared/videoplayer/videos/big_buck_bunny.webm",
				"https://dl.infragistics.com/pg/2011-1/web/shared/videoplayer/videos/big_buck_bunny.ogv"
			};
			this.igVideoPlayer1.Options.posterUrl =
				"https://www.igniteui.com/images/samples/video-player/big-buck-bunny.png";
			this.igVideoPlayer1.Options.title = "Big Buck Bunny";
			this.igVideoPlayer1.Options.muted = false;
			this.igVideoPlayer1.Options.autohide = false;
			this.igVideoPlayer1.Options.bookmarks = new dynamic[]
			{
				new {title = "River", description = "River", time = 13},
				new {title = "Big Buck Bunny Appears", description = "Big Buck Bunny Appears", time = 33}
			};
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Instance.play();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Instance.pause();
		}

		private void igVideoPlayer_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Options.autohide = this.checkBoxAutoHide.Checked;
			this.igVideoPlayer1.Options.autoplay = this.checkBoxAutoPlay.Checked;
			this.igVideoPlayer1.Options.showSeekTime = this.checkBoxShowSeekTime.Checked;
			this.igVideoPlayer1.Options.browserControls = this.checkBoxBrowserControls.Checked;

			this.igVideoPlayer1.Recreate();
		}
	}
}