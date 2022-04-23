using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ProgressCircle
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
			this.comboBoxLineCap.SelectedIndex = 0;
		}

		private void checkBoxFill_CheckedChanged(object sender, EventArgs e)
		{
			this.progressCircle1.FillCircle = this.checkBoxFill.Checked;
		}

		private void checkBoxShowValue_CheckedChanged(object sender, EventArgs e)
		{
			this.progressCircle1.ShowValue = this.checkBoxShowValue.Checked;
		}

		private void comboBoxLineCap_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cap = this.comboBoxLineCap.SelectedItem.ToString();
			this.progressCircle1.LineCap = (CanvasLineCap)Enum.Parse(typeof(CanvasLineCap), cap);
		}

		private void trackBarProgress_ValueChanged(object sender, EventArgs e)
		{
			this.progressCircle1.Value = this.trackBarProgress.Value;
		}
	}
}
