using System;
using System.IO;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;
using static Wisej.Web.Widget;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class HeatMap : DemoView
	{
		public HeatMap()
		{
			InitializeComponent();
		}

		private void HeatMap_Load(object sender, EventArgs e)
		{
			var api = File.ReadAllText(Application.MapPath("GoogleMapsAPIKey.txt"));

			this.googleMap1.ApiKey = api;

			// add the visualization library.
			this.googleMap1.Packages.Add(new Package()
			{
				Name = "Visualization",
				Source = $"https://maps.googleapis.com/maps/api/js?key={api}&libraries=visualization"
			});
		}

		private void HeatMap_Appear(object sender, EventArgs e)
		{
			this.googleMap1.Eval($@"
				var heatmap = new google.maps.visualization.HeatmapLayer({{ data: {GetData().ToJavaScriptArray()}}});
				heatmap.setMap(this.widget);
			");
		}

		private LatLng[] GetData()
		{
			return new LatLng[]
					{
						new LatLng { Lat = 37.782, Lng = -122.447 },
						new LatLng { Lat = 37.782, Lng = -122.445 },
						new LatLng { Lat = 37.782, Lng = -122.443 },
						new LatLng { Lat = 37.782, Lng = -122.441 },
						new LatLng { Lat = 37.782, Lng = -122.439 },
						new LatLng { Lat = 37.782, Lng = -122.437 },
						new LatLng { Lat = 37.782, Lng = -122.435 },
						new LatLng { Lat = 37.785, Lng = -122.447 },
						new LatLng { Lat = 37.785, Lng = -122.445 },
						new LatLng { Lat = 37.785, Lng = -122.443 },
						new LatLng { Lat = 37.785, Lng = -122.441 },
						new LatLng { Lat = 37.785, Lng = -122.439 },
						new LatLng { Lat = 37.785, Lng = -122.437 },
						new LatLng { Lat = 37.785, Lng = -122.435 },
					};
		}
	}
}
