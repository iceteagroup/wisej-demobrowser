using System;
using System.ComponentModel;
using Wisej.Core;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igMap : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igMap()
		{
			InitializeComponent();

			this.igMap1.Instance.onSeriesMouseLeftButtonUp += new WidgetEventHandler(igMap_WidgetEvent);
		}

		private void igMap_Load(object sender, EventArgs e)
		{
			igMap1.Options.series = new dynamic[]
			{
				new
				{
					type = "geographicSymbol", name = "worldCities", dataSource = new dynamic[]
					{
						new {Name = "London", Country = "England", latitude = 51.5, longitude = 0.12},
						new {Name = "Berlin", Country = "Germany", latitude = 52.5, longitude = 13.33},
						new {Name = "Moscow", Country = "Russia", latitude = 55.75, longitude = 37.51},
						new {Name = "Sydney", Country = "Australia", latitude = -33.83, longitude = 151.2},
						new {Name = "Tokyo", Country = "Japan", latitude = 35.6895, longitude = 139.6917},
						new {Name = "Seoul", Country = "South Korea", latitude = 37.5665, longitude = 126.978},
						new {Name = "Delhi", Country = "India", latitude = 28.6353, longitude = 77.225},
						new {Name = "Mumbai", Country = "India", latitude = 19.0177, longitude = 72.8562},
						new {Name = "Manila", Country = "Philippines", latitude = 14.601, longitude = 120.9762},
						new {Name = "Shanghai", Country = "China", latitude = 31.2244, longitude = 121.4759},
						new {Name = "Mexico City", Country = "Mexico", latitude = 19.427, longitude = -99.1276},
						new {Name = "New York", Country = "United States", latitude = 40.7561, longitude = -73.987},
						new {Name = "Sao Paulo", Country = "Brasil", latitude = -23.5489, longitude = -46.6388},
						new
						{
							Name = "Los Angeles", Country = "United States", latitude = 34.0522, longitude = -118.2434
						},
						new {Name = "Sofia", Country = "Bulgaria", latitude = 42.697845, longitude = 23.321925}
					},
					latitudeMemberPath = "latitude", longitudeMemberPath = "longitude", markerType = "automatic",
					markerCollisionAvoidance = "fade", markerOutline = "#b51c1c", markerBrush = "#b51c1c",
					showTooltip = true, tooltipTemplate = "tooltipTemplate"
				}
			};
		}
		private void igMap_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igMap1.Instance.insertItem(new
			{
				latitude = this.numericUpDown1.Value,
				longitude = this.numericUpDown2.Value,
				name = textBox1.Text,
				country = textBox2.Text
			}, 0, "worldCities");
		}
	}
}
