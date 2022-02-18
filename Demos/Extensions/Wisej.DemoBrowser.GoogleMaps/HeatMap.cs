using System;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class HeatMap : GoogleMapBase
	{
		public HeatMap()
		{
			InitializeComponent();
		}

		private void googleMap1_Appear(object sender, EventArgs e)
		{
			LoadMapData(GetData());
		}

		/// <summary>
		/// Initializes the heatmap.
		/// </summary>
		public void LoadMapData(LatLng[] data)
		{
			this.googleMap1.Eval($@"
				var heatmap = new google.maps.visualization.HeatmapLayer({{ data: {data.ToJavaScriptArray()}}});
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
