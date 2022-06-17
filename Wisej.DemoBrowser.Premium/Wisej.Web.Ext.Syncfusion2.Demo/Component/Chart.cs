using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Chart : TestBase
	{
		public Chart()
		{
			InitializeComponent();

			this.chart1.Instance.onPointClick += new WidgetEventHandler(chart1_WidgetEvent);
			this.chart1.Instance.onLegendClick += new WidgetEventHandler(chart1_WidgetEvent);
		}

		private void Chart_Load(object sender, EventArgs e)
		{
			this.comboBoxChartType.SelectedIndex = 0;

			this.chart1.Options.primaryXAxis = new
			{
				valueType = "Category"
			};
			this.chart1.Options.primaryYAxis = new
			{
				labelFormat = "${value}K"
			};

			this.chart1.Options.series[0].dataSource = new object[]
			{
				new
				{
					month = "Jan",
					sales = 35
				},
				new
				{
					month = "Feb",
					sales = 28
				},
				new
				{
					month = "Mar",
					sales = 34
				},
				new
				{
					month = "Apr",
					sales = 32
				},
				new
				{
					month = "May",
					sales = 40
				},
				new
				{
					month = "Jun",
					sales = 32
				},
				new
				{
					month = "Jul",
					sales = 35
				},
				new
				{
					month = "Aug",
					sales = 55
				},
				new
				{
					month = "Sep",
					sales = 38
				},
				new
				{
					month = "Oct",
					sales = 30
				},
				new
				{
					month = "Nov",
					sales = 25
				},
				new
				{
					month = "Dec",
					sales = 32
				}
			};
			this.chart1.Options.series[0].xName = "month";
			this.chart1.Options.series[0].name = "Sales";
			this.chart1.Options.series[0].yName = "sales";
			this.chart1.Options.series[0].type = this.comboBoxChartType.SelectedItem;
			this.chart1.Options.series[0].marker.dataLabel.visible = true;


			this.chart1.Options.legendSettings = new
			{
				visible = true
			};
			this.chart1.Options.title = "Sales Analysis";
		}

		private void chart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.chart1.Options.series[0].type = this.comboBoxChartType.Text;
			this.chart1.Update();
		}
	}
}