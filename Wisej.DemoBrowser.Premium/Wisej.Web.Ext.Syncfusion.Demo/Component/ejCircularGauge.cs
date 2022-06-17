using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejCircularGauge : TestBase
	{
		public ejCircularGauge()
		{
			InitializeComponent();
		}

		private void ejCircularGauge_Load(object sender, EventArgs e)
		{
			this.ejCircularGauge1.Options.isResponsive = true;
			this.ejCircularGauge1.Options.backgroundColor = "transparent";
			this.ejCircularGauge1.Options.load = "loadGaugeTheme";

			SetCircularGaugeScales();
		}

		private void SetCircularGaugeScales()
		{
			var rangeCollection = new object[]
			{
				new {distanceFromScale = -30, startValue = 0, endValue = 70, size = this.trackBarSize.Value}, new
				{
					distanceFromScale = this.trackBarDistanceFromScale.Value, startValue = 70, endValue = 110,
					backgroundColor = "#fc0606",
					border = new
					{
						color = "#fc0606"
					}
				},
				new
				{
					distanceFromScale = -30, startValue = 110, endValue = 120, backgroundColor = "#f5b43f",
					border = new
					{
						color = "#f5b43f"
					}
				}
			};

			var scales = new object[]
			{
				new
				{
					showRanges = true, startAngle = 122, sweepAngle = 296, radius = 130, showScaleBar = true, size = 1,
					maximum = 120, majorIntervalValue = 20, minorIntervalValue = 10, border = new
					{
						width = 0.5
					},
					pointers = new object[]
					{
						new
						{
							value = 50, showBackNeedle = true, backNeedleLength = 20, length = 95, width = 7,
							pointerCap = new
							{
								radius = 12
							}
						}
					},
					ticks = new object[]
					{
						new
						{
							type = "major",
							distanceFromScale = 2, height = 16, width = 1, color = "#8c8c8c"
						},
						new
						{
							type = "minor",
							height = 8, width = 1, distanceFromScale = 2, color = "#8c8c8c"
						}
					},
					labels = new object[]
					{
						new
						{
							color = "#8c8c8c"
						}
					},
					ranges = rangeCollection,
					showTicks = this.checkBoxShowTicks.Checked
				}
			};
			this.ejCircularGauge1.Options.scales = scales;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejCircularGauge1.Value = Convert.ToInt32(this.numericUpDownVal.Value);

			SetCircularGaugeScales();

			this.ejCircularGauge1.Update();
		}
	}
}