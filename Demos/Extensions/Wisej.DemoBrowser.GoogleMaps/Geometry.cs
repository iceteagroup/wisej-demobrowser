using System;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class Geometry : GoogleMapBase
	{
		private LatLng latLng1 = new LatLng() { Lat = 40.714, Lng = -74.006 };
		private LatLng latLng2 = new LatLng() { Lat = 48.857, Lng = 2.352 };

		public Geometry()
		{
			InitializeComponent();
		}

		private void Geometry_Load(object sender, EventArgs e)
		{
			this.googleMap1.AddMarker("Marker 1", latLng1);
			this.googleMap1.AddMarker("Marker 2", latLng2);
		}

		private void googleMap1_Appear(object sender, EventArgs e)
		{
			AddPolyline(Color.Blue, 1.0, 3, false);
			AddPolyline(Color.Red, 1.0, 3, true);
		}

		/// <summary>
		/// Adds a new google.maps.Polyline to the map.
		/// </summary>
		/// <param name="strokeColor"></param>
		/// <param name="strokeOpacity"></param>
		/// <param name="strokeWeight"></param>
		/// <param name="geodesic"></param>
		private void AddPolyline(Color strokeColor, double strokeOpacity, int strokeWeight, bool geodesic)
		{
			var configuration = new
			{
				path = new[] { latLng1.ToJSON(), latLng2.ToJSON() },
				strokeColor,
				strokeOpacity,
				strokeWeight,
				geodesic
			};

			this.googleMap1.Eval($@"
				debugger;
				var poly = new google.maps.Polyline({configuration.ToJSON()});
				poly.setMap(this.widget);
			");
		}
	}
}
