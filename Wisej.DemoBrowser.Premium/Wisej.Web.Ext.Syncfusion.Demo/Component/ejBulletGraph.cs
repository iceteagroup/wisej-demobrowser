using System;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejBulletGraph : TestBase
	{
		public ejBulletGraph()
		{
			InitializeComponent();

			this.ejBulletGraph1.Instance.onClick += new WidgetEventHandler(ejBulletGraph1_WidgetEvent);
			this.ejBulletGraph1.Instance.onRightClick += new WidgetEventHandler(ejBulletGraph1_WidgetEvent);
		}

		private void ejBulletGraph_Load(object sender, EventArgs e)
		{
			//ejBulletGraph1
			this.ejBulletGraph1.Options.value = 8;
			this.ejBulletGraph1.Options.comparativeMeasureValue = 5;
			this.ejBulletGraph1.Options.qualitativeRangeSize = 32;
			this.ejBulletGraph1.Options.quantitativeScaleLength = 475;
			this.ejBulletGraph1.Options.flowDirection = "Forward";
			this.ejBulletGraph1.Options.quantitativeScaleSettings = new
			{
				location = new
				{
					x = 110,
					y = 10
				},
				minimum = 0,
				maximum = 10,
				interval = 1,
				minorTicksPerInterval = 4,
				majorTickSettings = new
				{
					size = 13,
					width = 1,
					stroke = "gray"
				},
				minorTickSettings = new
				{
					size = 5,
					width = 1,
					stroke = "gray"
				},
				tickPosition = "Far",
				labelSettings = new
				{
					position = "Below",
					offset = 14,
					size = 10
				},
				featuredMeasureSettings = new
				{
					width = 6
				},
				comparativeMeasureSettings = new
				{
					width = 5
				}
			};
			this.ejBulletGraph1.Options.qualitativeRanges = new object[]
			{
				new {rangeEnd = 4.3}, new {rangeEnd = 7.3}, new {rangeEnd = 10}
			};
			this.ejBulletGraph1.Options.captionSettings = new
			{
				textAngle = 0,
				location = new
				{
					x = 17,
					y = 20
				},
				text = "Revenue YTD",
				font = new
				{
					color = "",
					fontFamily = "Segoe UI",
					fontStyle = 0,
					size = "12px",
					fontWeight = 0,
					opacity = 1
				},
				subTitle = new
				{
					textAngle = 0,
					text = "$ in Thousands",
					location = new
					{
						x = 10,
						y = 35
					},
					font = new
					{
						color = "",
						fontFamily = "Segoe UI",
						fontStyle = 0,
						size = "12px",
						fontWeight = 0,
						opacity = 1
					}
				}
			};

			//ejBulletGraph2
			this.ejBulletGraph2.Options.qualitativeRangeSize = 32;
			this.ejBulletGraph2.Options.quantitativeScaleLength = 475;
			this.ejBulletGraph2.Options.quantitativeScaleSettings = new
			{
				location = new
				{
					x = 110,
					y = 10
				},
				minimum = -10,
				maximum = 10,
				interval = 2,
				minorTicksPerInterval = 4,
				majorTickSettings = new
				{
					size = 13,
					width = 1
				},
				minorTickSettings = new
				{
					size = 5,
					width = 1
				},
				labelSettings = new
				{
					offset = 14,
					size = 10,
					labelSuffix = " %"
				},
				featuredMeasureSettings = new
				{
					width = 6
				},
				comparativeMeasureSettings = new
				{
					width = 5
				},
				featureMeasures = new object[]
				{
					new {value = 8, comparativeMeasureValue = 6.7}
				}
			};
			this.ejBulletGraph2.Options.qualitativeRanges = new object[]
			{
				new
				{
					rangeEnd = -4, rangeStroke = "#61a301"
				},
				new
				{
					rangeEnd = 3, rangeStroke = "#fcda21"
				},
				new
				{
					rangeEnd = 10, rangeStroke = "#d61e3f"
				}
			};
			this.ejBulletGraph2.Options.captionSettings = new
			{
				textAngle = 0,
				location = new
				{
					x = 60,
					y = 25
				},
				text = "Profit",
				font = new
				{
					color = "",
					fontFamily = "Segoe UI",
					fontStyle = 0,
					size = "13px",
					fontWeight = 0,
					opacity = 1
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejBulletGraph1.Options.value = this.numericUpDownVal.Value;
			this.ejBulletGraph1.Options.comparativeMeasureValue = this.numericUpDownCompMeasureVal.Value;

			this.ejBulletGraph1.Update();
		}

		private void ejBulletGraph1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}