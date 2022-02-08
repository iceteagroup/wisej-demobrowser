using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.CountUp
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void numericUpDownValue_ValueChanged(object sender, EventArgs e)
		{
			this.countUp1.Value = (float)this.numericUpDownValue.Value;
		}

		private void numericUpDownDuration_ValueChanged(object sender, EventArgs e)
		{
			this.countUp1.Duration = (int)this.numericUpDownDuration.Value;
		}

		private void checkBoxGrouping_CheckedChanged(object sender, EventArgs e)
		{
			this.countUp1.UseGrouping = this.checkBoxGrouping.Checked;
		}

		private void checkBoxEasing_CheckedChanged(object sender, EventArgs e)
		{
			this.countUp1.UseEasing = this.checkBoxEasing.Checked;
		}
	}
}
