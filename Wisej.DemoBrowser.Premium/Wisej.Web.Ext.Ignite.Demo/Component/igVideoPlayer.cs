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

		private void button1_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Play();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.igVideoPlayer1.Pause();
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
        }
    }
}
