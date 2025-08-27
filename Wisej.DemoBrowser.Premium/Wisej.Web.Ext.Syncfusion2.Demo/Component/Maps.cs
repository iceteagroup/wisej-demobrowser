using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Maps : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		private List<object> dataSource = new List<object>();
		public Maps()
		{
			InitializeComponent();

			this.maps1.Instance.onClick += new WidgetEventHandler(maps1_click);
		}

        private void maps1_click(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
												   MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void Maps_Load(object sender, EventArgs e)
		{
			this.maps1.Options.useGroupingSeparator = true;
			this.maps1.Options.format = "n";
			this.maps1.Options.allowPrint = true;


			// load the map's json file.
			var worldText = File.ReadAllText(Application.MapPath("Data/Maps/WorldMap_Countries.json"));
			this.maps1.Options.layers = new[] {
				new
				{
					shapeData = JSON.Parse(worldText),

					// apply cluster settings.
					markerClusterSettings = new {
						allowClustering = true,
						shape = "Image",
						width = 40,
						height = 40,
						imageUrl = "Images/cluster.svg"
					},
					// load markers and configuration.
					markerSettings = new[]
					{
						new
						{
							dataSource = PopulateDataSource(),
							visible = true,
							shape = "Circle",
							fill = Color.White,
							width = 10,
							border = new
							{
								width = 2,
								color = Color.Blue
							},
							tooltipSettings = new 
							{
								format = "City: ${city} <br> Population: ${population}",
								visible = true,
								valuePath = "city"
							},
						}
					}
				},
			};

			// enable zoom.
			this.maps1.Options.zoomSettings = new
			{
				enable = true,
			};

			this.maps1.Update();
		}

		/// <summary>
		/// Generates a data source with a few cities.
		/// </summary>
		/// <returns></returns>
		private object PopulateDataSource()
		{
			return new[] 
			{ 
				new {
					city = "New York City",
					latitude = 40.71427,
					longitude = -74.00597,
					population = "8.39M"
				},
				new {
					city = "Philadelphia",
					latitude = 39.952583,
					longitude = -75.165222,
					population = "1.584M"
				},
				new {
					city = "Los Angeles",
					latitude = 34.052235,
					longitude = -118.243683,
					population = "3.99M"
				},
				new {
					city = "London",
					latitude = 51.508530,
					longitude = -0.076132,
					population = "8.982M"
				},
			};
		}

		private void buttonAddMarker_Click(object sender, EventArgs e)
		{
			// adds a new marker to the map.
			this.maps1.Instance.addMarker(0, new[] 
			{
				new
				{
					dataSource = new[] {
						new {
							city = "My Marker",
							latitude = this.numericUpDownLat.Value,
							longitude = this.numericUpDownLon.Value,
							population = "2.706M"
						},
					},
					visible = true,
					shape = "Circle",
					fill = Color.White,
					width = 10,
					border = new
					{
						width = 2,
						color = Color.Red
					},
					tooltipSettings = new
					{
						format = "City: ${city} <br> Population: ${population}",
						visible = true,
						valuePath = "city"
					}
				}
			});
			this.maps1.Instance.refresh();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.maps1.Update();
		}

        private void buttonPrint_Click(object sender, EventArgs e)
        {
			this.maps1.Instance.print();
        }
    }
}
