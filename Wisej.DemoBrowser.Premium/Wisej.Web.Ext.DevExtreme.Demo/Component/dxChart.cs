using System;
using System.IO;
using static Wisej.Web.Widget;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxChart : TestBase
	{
		public dxChart()
		{
			InitializeComponent();

			this.dxChart1.Instance.onPointClick += new WidgetEventHandler(dxChart1_WidgetEvent);
			this.dxChart1.Instance.onLegendClick += new WidgetEventHandler(dxChart1_WidgetEvent);
		}

		private void dxChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.dxChart1.Options.dataSource = data;

			this.dxChart1.Update();
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.dxChart1.CallAsync("getDataSourceItems");

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "chartData.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxChart1.Options.adjustOnZoom = this.checkBox1.Checked;
			this.dxChart1.Options.autoHidePointtMarkers = this.checkBox2.Checked;
			this.dxChart1.Options.zoomAndPan = new {
				allowMouseWheel = true,
				allowTouchGestures = this.checkBox3.Checked,
				dragToZoom = this.checkBox4.Checked,
				dragBoxStyle = new {
					color = "#ff0000",
					opacity = 0.3
				},
				panKey = this.comboBox1.SelectedItem,
				valueAxis = "both"
			};
		}
	}
}
