﻿using System;
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.countUp1.Value = (int)this.numericUpDownValue.Value;
        }
    }
}
