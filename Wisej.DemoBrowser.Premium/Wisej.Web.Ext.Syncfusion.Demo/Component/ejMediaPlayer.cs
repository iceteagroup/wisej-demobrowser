using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejMediaPlayer : TestBase
	{
		private bool isMute = false;

		public ejMediaPlayer()
		{
			InitializeComponent();

			this.ejMediaPlayer1.Instance.onRepeat += new WidgetEventHandler(ejMediaPlayer1_WidgetEvent);
			this.ejMediaPlayer1.Instance.onPlaying += new WidgetEventHandler(ejMediaPlayer1_WidgetEvent);
			this.ejMediaPlayer1.Instance.onActionBegin += new WidgetEventHandler(ejMediaPlayer1_WidgetEvent);
		}

		private void ejMediaPlayer_Load(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Options.showPlaylist = true;
			this.ejMediaPlayer1.Options.renderMode = "basic";
			this.ejMediaPlayer1.Options.playlistTitle = "Wisej";
			this.ejMediaPlayer1.Options.source = new object[]
			{
				new
				{
					url = "https://www.youtube.com/watch?v=BfA_wIqjF_8",
					author = "iceteagroup",
					title = "HelloWorld",
					posterUrl = "Images/MediaPlayer/mqdefault.jpg"
				},
				new
				{
					url = "https://www.youtube.com/watch?v=qp6cQOQFHWk",
					author = "iceteagroup",
					title = "Responsive Properties",
					posterUrl = "Images/MediaPlayer/mqdefault.jpg"
				},
				new
				{
					url = "https://www.youtube.com/watch?v=5SzoJZF6rdQ",
					author = "iceteagroup",
					title = "Live Theme Builder",
					posterUrl = "Images/MediaPlayer/mqdefault.jpg"
				},
				new
				{
					url = "https://www.youtube.com/watch?v=lqTszFkviRg",
					posterUrl = "Images/MediaPlayer/mqdefault.jpg",
					author = "iceteagroup",
					title = "Tools Everywhere"
				}
			};
		}
		private void buttonMute_Click(object sender, EventArgs e)
		{
			if (this.isMute)
			{
				this.ejMediaPlayer1.Instance.unmute();
				this.isMute = false;
			}
			else
			{
				this.ejMediaPlayer1.Instance.mute();
				this.isMute = true;
			}
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Instance.play();
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Instance.pause();
		}

		private void buttonFullScreen_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Instance.makeFullScreen();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Instance.next();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Instance.stop();
		}

		private void ejMediaPlayer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejMediaPlayer1.Options.renderMode = this.comboBoxRenderMode.Text.ToLower();

			this.ejMediaPlayer1.Update();
		}
	}
}