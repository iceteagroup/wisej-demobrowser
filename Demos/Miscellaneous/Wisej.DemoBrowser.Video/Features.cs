using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Video
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void videoDefault_Paused(object sender, EventArgs e)
		{
			AlertBox.Show("Video Paused", icon: MessageBoxIcon.Hand);
		}

		private void videoDefault_VolumeChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Volume Level: {this.videoDefault.Volume}");
		}

		private void videoDefault_Playing(object sender, EventArgs e)
		{
			AlertBox.Show("Video Playing");
		}
	}
}
