using System;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class Features : GoogleMapBase
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.googleMap1.AddMarker("Rockefeller Center", "45 Rockefeller Plaza, New York, NY 10111");
		}
	}
}
