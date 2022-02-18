using System;
using System.IO;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class GoogleMapBase : DemoView
	{
		public GoogleMapBase()
		{
			InitializeComponent();
		}

		private void GoogleMapBase_Load(object sender, EventArgs e)
		{
			if (DesignMode)
				return;
				
			var api = File.ReadAllText(Application.MapPath("GoogleMapsAPIKey.txt"));
			this.googleMap1.ApiKey = api;

			Web.Ext.GoogleMaps.GoogleMap.Version = "beta";
			Web.Ext.GoogleMaps.GoogleMap.Libraries = "visualization";
		}
	}
}
