using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using static Wisej.Web.Ext.Camera.Camera;

namespace Wisej.DemoBrowser.Camera
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void checkBoxAudio_CheckedChanged(object sender, EventArgs e)
		{
			this.camera1.Audio = this.checkBoxAudio.Checked;
		}

		private void checkBoxVideo_CheckedChanged(object sender, EventArgs e)
		{
			this.camera1.Video = this.checkBoxVideo.Checked;
		}

		private void comboBoxFacingMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			var mode = (string)this.comboBoxFacingMode.SelectedItem;
			this.camera1.FacingMode = (VideoFacingMode)Enum.Parse(typeof(VideoFacingMode), mode);
		}

		private void comboBoxObjectFit_SelectedIndexChanged(object sender, EventArgs e)
		{
			var fit = (string)this.comboBoxObjectFit.SelectedItem;
			this.camera1.ObjectFit = (ObjectFit)Enum.Parse(typeof(ObjectFit), fit);
		}
	}
}
