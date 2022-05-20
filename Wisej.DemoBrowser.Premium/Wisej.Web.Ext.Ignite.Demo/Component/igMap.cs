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
						new {Name = "London", Country = "England", Latitude = 51.5, Longitude = 0.12},
						new {Name = "Berlin", Country = "Germany", Latitude = 52.5, Longitude = 13.33},
						new {Name = "Moscow", Country = "Russia", Latitude = 55.75, Longitude = 37.51},
						new {Name = "Sydney", Country = "Australia", Latitude = -33.83, Longitude = 151.2},
						new {Name = "Tokyo", Country = "Japan", Latitude = 35.6895, Longitude = 139.6917},
						new {Name = "Seoul", Country = "South Korea", Latitude = 37.5665, Longitude = 126.978},
						new {Name = "Delhi", Country = "India", Latitude = 28.6353, Longitude = 77.225},
						new {Name = "Mumbai", Country = "India", Latitude = 19.0177, Longitude = 72.8562},
						new {Name = "Manila", Country = "Philippines", Latitude = 14.601, Longitude = 120.9762},
						new {Name = "Shanghai", Country = "China", Latitude = 31.2244, Longitude = 121.4759},
						new {Name = "Mexico City", Country = "Mexico", Latitude = 19.427, Longitude = -99.1276},
						new {Name = "New York", Country = "United States", Latitude = 40.7561, Longitude = -73.987},
						new {Name = "Sao Paulo", Country = "Brasil", Latitude = -23.5489, Longitude = -46.6388},
						new
						{
							Name = "Los Angeles", Country = "United States", Latitude = 34.0522, Longitude = -118.2434
						},
						new {Name = "Sofia", Country = "Bulgaria", Latitude = 42.697845, Longitude = 23.321925}
					},
					latitudeMemberPath = "Latitude", longitudeMemberPath = "Longitude", markerType = "automatic",
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
