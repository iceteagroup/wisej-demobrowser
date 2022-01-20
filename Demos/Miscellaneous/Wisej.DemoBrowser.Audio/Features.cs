using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Audio
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void audioDefault_VolumeChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Volume Level {this.audioDefault.Volume}");
		}

		private void audioDefault_Playing(object sender, EventArgs e)
		{
			AlertBox.Show("Audio Playing");
		}

		private void audioDefault_Paused(object sender, EventArgs e)
		{
			AlertBox.Show("Audio Paused", icon: MessageBoxIcon.Hand);
		}
	}
}
