using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxMap : TestBase
	{
		public dxMap()
		{
			InitializeComponent();
		}

		private void dxMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxMap1.Options.center = new
			{
				lat = this.numericUpDown1.Value,
				lon = this.numericUpDown2.Value
			};
			this.dxMap1.Options.autoAdjust = this.checkBox1.Checked;
			this.dxMap1.Options.controls = this.checkBox2.Checked;
			this.dxMap1.Options.type = this.comboBox1.SelectedItem;
			this.dxMap1.Options.zoom = this.numericUpDown3.Value;

			this.dxMap1.Update();
		}

        private void dxMap_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;

			this.dxMap1.Options = new
			{
				zoom = 400,
				center = new
                {
					lat = 40.7507452610147,
					lng = -73.9867428787437
				},
				provider = "google",
				markers = new object[]
                {
					new
                    {
						location = "40.7825, -73.966111"
					},
                    new
                    {
						location = new double[2]{ 40.755833, -73.986389 }
                    },
                    new
                    {
						location = new 
						{
							lat = 40.753889,
							lng = -73.981389,
						}
                    },
                    new
                    {
						location = "Brooklyn Bridge,New York,NY"
					}
                },
				routes = new object[]
                {
					new
                    {
						weight = 6,
						color = "blue",
						opacity = 0.5,
						mode = "",
						locations = new object[]
                        {
							new double[]{ 40.7825, -73.966111 },
							new double[]{ 40.755833, -73.986389 },
							new double[]{ 40.753889, -73.981389 },
							"Brooklyn Bridge,New York,NY",
                        }
					}
                }
			};

			this.dxMap1.Update();
		}
	}
}
