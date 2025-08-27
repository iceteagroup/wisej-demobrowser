using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Geolocation
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private async void buttonLocation_Click(object sender, EventArgs e)
		{
			var position = await this.geolocation1.GetCurrentPositionAsync();
			AlertBox.Show(position.ToJSON());
		}
	}
}
