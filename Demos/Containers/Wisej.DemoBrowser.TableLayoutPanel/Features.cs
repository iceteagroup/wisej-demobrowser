using System;
using System.Drawing;
using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;

namespace Wisej.DemoBrowser.TableLayoutPanel
{
	public partial class Features : DemoView
	{
		private Random random = new Random();

		public Features()
		{
			InitializeComponent();
		}

		private void FillBarChart()
		{
			string[] labels = new string[30];
			for (int i = 0; i < 30; i++)
			{
				labels[i] = $"Day {i}";
			}

			this.chartJS31.Labels = labels;
			BarDataSet bds = new BarDataSet();
			object[] obj = new object[30];


			var rand = new Random();
			for (int i = 0; i < 30; i++)
			{

				obj[i] = rand.Next(1, 5);
			}

			bds.Data = obj;
			bds.BackgroundColor = new[] { System.Drawing.Color.FromArgb(28, 78, 128) };
			chartJS31.DataSets.Add(bds);

		}

		private void FillManagersCharts(ChartJS3 chart)
		{
			string[] labels = new string[30];
			for (int i = 0; i < 30; i++)
			{
				labels[i] = $"Day {i}";
			}

			chart.Labels = labels;

			LineDataSet bds = new LineDataSet();
			object[] obj = new object[30];


			var rand = new Random();
			for (int i = 0; i < 30; i++)
			{

				obj[i] = rand.Next(1, 5);
			}

			bds.Data = obj;
			bds.BackgroundColor = Color.FromArgb(234, 106, 71);
			chart.DataSets.Add(bds);
		}
		private void Features_Load(object sender, EventArgs e)
		{
			FillBarChart();
			FillManagersCharts(chartJS34);
			FillManagersCharts(chartJS35);

			Application.StartTask(() =>
			{
				for (int i = 0; i < 30; i++)
				{
					Thread.Sleep(2500);

					this.justGage1.Value = random.Next(0, 100);
					this.justGage2.Value = random.Next(0, 100);

					Application.Update(this);
				}
			});
		}
	}
}
