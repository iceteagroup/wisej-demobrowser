using System.Linq;
using Wisej.Web.Ext.GoogleMaps;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public static class LatLngHelper
	{
		/// <summary>
		/// Extension method to get the corresponding LatLng JavaScript constructor string.
		/// </summary>
		/// <param name="latLng"></param>
		/// <returns></returns>
		public static string ToJavaScriptString(this LatLng latLng)
		{
			return $"new google.maps.LatLng({latLng.Lat}, {latLng.Lng})";
		}

		/// <summary>
		/// Extension method to get the corresponding LatLng Array JavaScript string.
		/// </summary>
		/// <param name="latLngs"></param>
		/// <returns></returns>
		public static string ToJavaScriptArray(this LatLng[] latLngs)
		{
			return $"[{string.Join(", ", latLngs.Select((latLng) => latLng.ToJavaScriptString()).ToArray())}]";
		}

		/// <summary>
		/// Overrides the default ToJSON() functionality.
		/// </summary>
		/// <param name="latLng"></param>
		/// <returns></returns>
		public static object ToJSON(this LatLng latLng)
		{
			return new
			{
				lat = latLng.Lat,
				lng = latLng.Lng,
			};
		}
	}
}
