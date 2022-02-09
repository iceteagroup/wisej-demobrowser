using System;
using System.IO;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.googleMap1.ApiKey = File.ReadAllText(Application.MapPath("GoogleMapsAPIKey.txt"));

			this.googleMap1.AddMarker("Rockefeller Center", "45 Rockefeller Plaza, New York, NY 10111");
		}
	}
}
