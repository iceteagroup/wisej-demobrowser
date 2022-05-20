using System;
using System.IO;
using static Wisej.Web.Widget;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxChart : TestBase
	{
		public dxChart()
		{
			InitializeComponent();

			this.dxChart1.Instance.onPointClick += new WidgetEventHandler(dxChart1_WidgetEvent);
			this.dxChart1.Instance.onLegendClick += new WidgetEventHandler(dxChart1_WidgetEvent);
		}

		private void dxChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.dxChart1.Options.dataSource = data;

			this.dxChart1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxChart1.Options.adjustOnZoom = this.checkBox1.Checked;
			this.dxChart1.Options.autoHidePointtMarkers = this.checkBox2.Checked;
			this.dxChart1.Options.zoomAndPan = new {
				allowMouseWheel = true,
				dragToZoom = this.checkBox4.Checked,
				dragBoxStyle = new {
					color = "#ff0000",
					opacity = 0.3
				},
				panKey = this.comboBox1.SelectedItem,
				valueAxis = "both"
			};
			this.dxChart1.Options.commonSeriesSettings = new
			{
				argumentField = "country",
				type = this.comboBoxChartType.SelectedItem.ToString()
			};
		}

        private void dxChart_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBoxChartType.SelectedIndex = 0;
			
			var dataSource = new object[]
			{
				new
				{
					country = "USA",
					hydro = 59.5,
					oil = 937.6,
					gas = 582,
					coal = 564.3,
					nuclear = 187.9

				},
				new
				{
					country = "China",
					hydro = 74.2,
					oil = 308.6,
					gas = 35.1,
					coal = 956.9,
					nuclear = 11.3

				},
				new
				{
					country = "Russia",
					hydro = 40,
					oil = 128.5,
					gas = 361.8,
					coal = 105,
					nuclear = 32.4

				},
				new
				{
					country = "Japan",
					hydro = 22.6,
					oil = 241.5,
					gas = 64.9,
					coal = 120.8,
					nuclear = 64.8

				},
				new
				{
					country = "India",
					hydro = 19,
					oil = 119.3,
					gas = 28.9,
					coal = 204.8,
					nuclear = 3.8

				},
				new
				{
					country = "Germany",
					hydro = 6.1,
					oil = 123.6,
					gas = 77.3,
					coal = 85.7,
					nuclear = 37.8

				}
			};
			var series = new object[]
			{
				new
				{
					valueField = "hydro",
					name = "Hydro-electric"
				},
				new
				{
					valueField = "oil",
					name = "Oil"
				},
				new
				{
					valueField = "gas",
					name = "Gas"
				},
				new
				{
					valueField = "coal",
					name = "Coal"
				},
				new
				{
					valueField = "nuclear",
					name = "Nuclear"
				}
			};


			this.dxChart1.Options = new
			{
				palette = "Violet",
				dataSource = dataSource,
				commonSeriesSettings = new
				{
					argumentField = "country",
					type = "area"
				},
				margin = new
				{
					bottom = 20
				},
				argumentAxis = new
				{
					valueMarginsEnabled = false,
					discreteAxisDivisionMode = "crossLabels",
					grid = new
					{
						visible = true
					}
					
				},
				series = series,
				legend = new
				{
					verticalAlignment = "bottom",
					horizontalAlignment = "center",
					itemTextPosition = "bottom"
				},
				title = new
				{
					text = "Energy Consumption in 2004",
					subtitle = new
					{
						text = "(Millions of Tons, Oil Equivalent)",
					}
				},
				export = new
				{
					enabled = true
				},
				tooltip = new
				{
					enabled = true
				},
			};

			this.dxChart1.Update();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
