using System;
using System.IO;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxPolarChart : TestBase
	{
		public dxPolarChart()
		{
			InitializeComponent();

			this.dxPolarChart1.Instance.onPointClick += new WidgetEventHandler(dxPolarChart1_WidgetEvent);
			this.dxPolarChart1.Instance.onSeriesSelectionChanged += new WidgetEventHandler(dxPolarChart1_WidgetEvent);
		}

		private void dxPolarChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxPolarChart1.Options.animation = new
			{
				duration = this.numericUpDown1.Value,
				enabled = this.checkBox1.Checked
			};
			this.dxPolarChart1.Options.negativesAsZeroes = this.checkBox2.Checked;
			this.dxPolarChart1.Options.useSpiderWeb = this.checkBox3.Checked;
			this.dxPolarChart1.Options.commonAxisSettings = new
			{
				inverted = this.checkBox4.Checked
			};

			this.dxPolarChart1.Update();
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.dxPolarChart1.Instance.svgAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(Regex.Unescape(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "polarChart.html");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}
	}
}
