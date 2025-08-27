using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxCircularGauge : TestBase
	{
		public dxCircularGauge()
		{
			InitializeComponent();
		}

		private void dxCircularGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxCircularGauge1.Instance.value((int)this.numericUpDown1.Value);
			this.dxCircularGauge1.Options.scale = new
            {
				label = new
                {
					visible = this.checkBox1.Checked
				},
				tickInterval = this.trackBar1.Value
			};
			this.dxCircularGauge1.Options.geometry = new {
				startAngle = this.numericUpDown2.Value,
				endAngle = this.numericUpDown3.Value
			};

			this.dxCircularGauge1.Update();
		}

		private void dxCircularGauge_Load(object sender, EventArgs e)
		{
		
			this.dxCircularGauge1.Options = new
			{
				containerBackgroundColor = "blue",
				scale = new
				{
					startValue = 50,
					endValue = 150,
					tickInterval = 10,
					label = new
					{
						useRangeColors = true
					}
				},
				rangeContainer = new
                {
					ranges = buildRanges(),
					palette = "pastel"
                },
				title = new
                {
					text = "Temperature of the Liquid in the Boiler",
					font = new
                    {
						size = 28
                    }
				},
				export = new
                {
					enabled = true
                },
				value = 100,
				tooltip = new
                {
					enabled = true,
					font = new
                    {
						color = "#DCD0FF",
						size = 40
                    }
                }
			};

			this.dxCircularGauge1.Update();
		}

		private object buildRanges()
		{
			var ranges = new object[] {
				new { startValue = 50, endValue = 90 },
				new { startValue = 90, endValue = 130 },
				new { startValue = 130, endValue = 150 }
			};

			return ranges;
		}
	}
}
