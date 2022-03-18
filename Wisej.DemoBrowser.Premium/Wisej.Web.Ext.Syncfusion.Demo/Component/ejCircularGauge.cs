using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejCircularGauge : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejCircularGauge()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejCircularGauge1.Value = 
				Convert.ToInt32(this.numericUpDownVal.Value);

			var scales = this.ejCircularGauge1.Options.scales;
			for (var i = 0; i < scales.Length; i++)
			{
				scales[i].showTicks = this.checkBoxShowTicks.Checked;
			}

			var ranges = scales[0].ranges;
			for (var i = 0; i < ranges.Length; i++)
			{
				ranges[i].distanceFromScale = this.trackBarDistanceFromScale.Value;
				ranges[i].size = this.trackBarSize.Value;
			}

			this.ejCircularGauge1.Update();
		}	
	}
}
