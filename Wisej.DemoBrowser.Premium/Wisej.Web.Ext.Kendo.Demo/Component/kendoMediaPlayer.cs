using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMediaPlayer : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMediaPlayer()
		{
			InitializeComponent();

			this.kendoMediaPlayer1.Instance.onEnd += new WidgetEventHandler(kendoMediaPlayer1_WidgetEvent);
			this.kendoMediaPlayer1.Instance.onPlay += new WidgetEventHandler(kendoMediaPlayer1_WidgetEvent);
			this.kendoMediaPlayer1.Instance.onPause += new WidgetEventHandler(kendoMediaPlayer1_WidgetEvent);
		}

		private void kendoMediaPlayer_Load(object sender, EventArgs e)
		{
			this.kendoMediaPlayer1.Options.autoPlay = "false";

			this.kendoMediaPlayer1.Options.navigatable = "true";

			this.kendoMediaPlayer1.Options.media = new
			{
				title = "Hello, World!",
				source = "https://www.youtube.com/watch?v=BfA_wIqjF_8",
			};

		}
		private void kendoMediaPlayer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonUpdate_Click(object sender, EventArgs e)
		{

			await this.kendoMediaPlayer1.Instance.muteAsync(this.checkBoxMute.Checked);

			if(!this.checkBoxMute.Checked)
				await this.kendoMediaPlayer1.Instance.volumeAsync(this.numericUpDownVolume.Value);

			this.kendoMediaPlayer1.Update();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			this.kendoMediaPlayer1.Instance.play();
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			this.kendoMediaPlayer1.Instance.pause();
		}
	}
}
