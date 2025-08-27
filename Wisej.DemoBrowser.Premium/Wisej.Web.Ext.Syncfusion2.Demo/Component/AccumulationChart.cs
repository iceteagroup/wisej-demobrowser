using System;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class AccumulationChart : TestBase
	{
		public AccumulationChart()
		{
			InitializeComponent();

			this.accumulationChart1.WiredEvents = new[] { "chartMouseClick" };
			this.accumulationChart1.Instance.chartMouseClick += new WidgetEventHandler(accumulationChart1_WidgetEvent);
		}

		private void AccumulationChart_Load(object sender, EventArgs e)
		{
			SetAccumulationChartSeries();
		}
		private void accumulationChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void SetAccumulationChartSeries()
		{
			var series = new
			{
				dataSource = new object[]
				{
					new
					{
						x = "Jan",
						y = 3
					},
					new
					{
						x = "Feb",
						y = 3.5
					},
					new
					{
						x = "Mar",
						y = 7
					},
					new
					{
						x = "Apr",
						y = 13.5
					},
					new
					{
						x = "May",
						y = 19
					},
					new
					{
						x = "Jun",
						y = 23.5
					},
					new
					{
						x = "Jul",
						y = 26
					},
					new
					{
						x = "Aug",
						y = 25
					},
					new
					{
						x = "Sep",
						y = 21
					},
					new
					{
						x = "Oct",
						y = 15
					}
				},
				xName = "x",
				yName = "y",
				startAngle = 0,
				endAngle = this.trackBarPieAngle.Value,
				innerRadius = "10%",
				explode = true,
				explodeOffset = "50%",
				explodeIndex = this.trackBarExplodeIndex.Value,
				radius = $"{this.numericUpDownExplodeOffset.Value}%"
			};

			this.accumulationChart1.Options.series = new object[1]
			{
				series
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.accumulationChart1.Options.title = this.textBoxTitle.Text;
			this.accumulationChart1.Options.subTitle = this.textBoxSubTitle.Text;

			SetAccumulationChartSeries();

			this.accumulationChart1.Update();
		}
	}
}
