using System;
using System.IO;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoSparkline : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoSparkline()
		{
			InitializeComponent();

			this.kendoSparkline1.Instance.onSeriesClick += new WidgetEventHandler(kendoSparkline1_WidgetEvent);
			this.kendoSparkline1.Instance.onPlotAreaClick += new WidgetEventHandler(kendoSparkline1_WidgetEvent);
			this.kendoSparkline1.Instance.onAxisLabelClick += new WidgetEventHandler(kendoSparkline1_WidgetEvent);
		}

		private void kendoSparkline_Load(object sender, EventArgs e)
		{
			//kendoSparkline1 
			this.kendoSparkline1.Options.data = new object[]
				{936,968,1025,999,998,1014,1017,1010,1010,1007,1004,988,990,988,987,995,946,954,991,984,974,956,986,936,955,1021,1013,1005,958,953,952,940,937,980,966,965,928,916,910,980,};

			//kendoSparkline2
			this.kendoSparkline2.Options.type = "column";

			this.kendoSparkline2.Options.data = new object[]
				{16,17,18,19,20,21,21,22,23,22,20,18,17,17,16,16,17,18,19,20,21,22,23,25,24,24,22,22,23,22,22,21,16,15,15,16,19,20,20,21,};

			this.kendoSparkline2.Options.tooltip = new
			{
				format = "{0} &deg;C",
			};

		}
		private void kendoSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonImage_Click(object sender, EventArgs e)
		{
			var dataUrl = await this.kendoSparkline1.Instance.imageDataURLAsync();
			var base64 = dataUrl.Replace("data:image/png;base64,", "");
			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
				Application.Download(ms, "kendoSparkline.png");
		}

		private async void buttonPDF_Click(object sender, EventArgs e)
		{
			var dataUrl = await this.kendoSparkline1.Instance.exportPDFAsync();
			var base64 = dataUrl.Replace("data:application/pdf;base64,", "");
			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
				Application.Download(ms, "kendoSparkline.pdf");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var theme = this.comboBoxTheme.SelectedItem;

			var sparklinesClimate = this.panelClimate.Controls.Where(c => c is Kendo.kendoSparkline);
			var sparklinesTemperature = this.panelTemperature.Controls.Where(c => c is Kendo.kendoSparkline);
			var sparklines = sparklinesClimate.Union(sparklinesTemperature);

			foreach (Kendo.kendoSparkline sparkline in sparklines)
			{
				sparkline.Options.theme = theme;
				sparkline.Update();
			}
		}
	}
}
