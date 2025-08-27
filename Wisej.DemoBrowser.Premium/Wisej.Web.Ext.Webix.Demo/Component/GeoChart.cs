using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class GeoChart : ViewBase
	{
		public GeoChart()
		{
			InitializeComponent();
		}

        private void GeoChart_Load(object sender, EventArgs e)
        {
			geoChart1.Options.id = "map";
			geoChart1.Options.data = new dynamic[]
			{
				new
				{
					id = 1,
					country = "Germany",
					area = 200
				},new
				{
					id = 2,
					country = "United States",
					area = 400
				},new
				{
					id = 3,
					country = "Brazil",
					area = 1000
				},new
				{
					id = 4,
					country = "Canada",
					area = 500
				},new
				{
					id = 5,
					country = "France",
					area = 650
				},new
				{
					id = 6,
					country = "RU",
					area = 1180
				},
			};
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.geoChart1.Options.removeMissed = this.checkBoxRemoveMissed.Checked;

			this.geoChart1.Update();
		}
    }
}
