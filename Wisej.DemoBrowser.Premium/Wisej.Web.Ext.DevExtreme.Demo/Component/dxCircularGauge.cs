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
			this.dxCircularGauge1.Options.scale.label.visible = this.checkBox1.Checked;
			this.dxCircularGauge1.Options.scale.tickInterval = this.trackBar1.Value;
			this.dxCircularGauge1.Options.geometry = new {
				startAngle = this.numericUpDown2.Value,
				endAngle = this.numericUpDown3.Value
			};

			this.dxCircularGauge1.Update();
		}

		private void dxCircularGauge_Load(object sender, EventArgs e)
		{
			this.dxCircularGauge1.Options.containerBackgroundColor = "blue";

			this.dxCircularGauge1.Options.rangeContainer.ranges = buildRanges();
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

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var svgData = await this.dxCircularGauge1.Instance.svgAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(Regex.Unescape(svgData));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "circularGauge.svg");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}
	}
}
