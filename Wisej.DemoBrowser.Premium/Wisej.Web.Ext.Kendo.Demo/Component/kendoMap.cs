using System;
using System.Windows.Forms;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMap : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMap()
		{
			InitializeComponent();

			this.kendoMap1.Instance.onMarkerClick += new WidgetEventHandler(kendoMap1_WidgetEvent);
		}

		private void kendoMap_Load(object sender, EventArgs e)
		{
			this.kendoMap1.Options.center = new[] { 30.268107, -97.744821 };
			this.kendoMap1.Options.zoom = 3;

			this.kendoMap1.Options.layers = new dynamic[]
			{
				new
				{
					type = "tile",
					subdomains = new [] {"a","b","c"},
					urlTemplate = "https://#= subdomain #.tile.openstreetmap.org/#= zoom #/#= x #/#= y #.png",
					attribution = "&copy; <a href='https://osm.org/copyright'>OpenStreetMap contributors</a>"
				}
			};

			this.kendoMap1.Options.markers = new dynamic[]
			{
				new
				{
					location = new [] {30.268107, -97.744821},
					shape = "pinTarget", tooltip = new
					{
						content = "Austin, TX"
					}
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoMap1.Options.pannable = this.checkBox1.Checked;
			this.kendoMap1.Options.wraparound = this.checkBox2.Checked;
			this.kendoMap1.Options.zoomable = this.checkBox3.Checked;
			this.kendoMap1.Options.minZoom = this.numericUpDown1.Value;
			this.kendoMap1.Options.maxZoom = this.numericUpDown2.Value;
			this.kendoMap1.Options.zoom = this.numericUpDown3.Value;

			this.kendoMap1.Update();
		}

		private void kendoMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(e.Data.marker.options.ToJSON());
			Application.Play(MessageBoxIcon.Information);
		}

		
	}
}
