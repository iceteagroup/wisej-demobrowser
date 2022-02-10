using System;
using System.IO;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.GoogleMaps;
using static Wisej.Web.Widget;

namespace Wisej.DemoBrowser.GoogleMaps
{
	public partial class Tilt : DemoView
	{
		public Tilt()
		{
			InitializeComponent();
		}

		private void Tilt_Load(object sender, EventArgs e)
		{
			var api = File.ReadAllText(Application.MapPath("GoogleMapsAPIKey.txt"));

			this.googleMap1.ApiKey = api;
			GoogleMap.Version = "beta";
		}

		private void buttonLeft_Click(object sender, EventArgs e)
		{
			AdjustMap("rotate", 20);
		}

		private void buttonRight_Click(object sender, EventArgs e)
		{
			AdjustMap("rotate", -20);
		}

		private void buttonUp_Click(object sender, EventArgs e)
		{
			AdjustMap("tilt", -20);
		}

		private void buttonDown_Click(object sender, EventArgs e)
		{
			AdjustMap("tilt", 20);
		}

		private void AdjustMap(string mode, int amount)
		{
			switch (mode)
			{
				case "tilt":
					this.googleMap1.Instance.getTilt((Action<dynamic>)((tilt) =>
					{
						this.googleMap1.Instance.setTilt(tilt + amount);
					}));
					break;

				case "rotate":
					this.googleMap1.Instance.getHeading((Action<dynamic>)((heading) =>
					{
						this.googleMap1.Instance.setHeading(heading + amount);
					}));
					break;

				default:
					break;
			}
		}
	}
}
