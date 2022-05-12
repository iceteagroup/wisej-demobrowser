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
			var dataUrl = await this.kendoSparkline1.ExportPDFAsync();
			var base64 = dataUrl.Replace("data:application/pdf;base64,", "");
			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
				Application.Download(ms, "kendoStockChart.pdf");
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			var theme = this.comboBoxTheme.SelectedItem;

			var sparklinesClimate = this.panelClimate.Controls.Where(c => c is Kendo.kendoSparkline);
			var sparklinesTemperature = this.panelTemperature.Controls.Where(c => c is Kendo.kendoSparkline);
			var sparklinesConditioner = this.panelConditioner.Controls.Where(c => c is Kendo.kendoSparkline);
			var sparklines = sparklinesClimate.Union(sparklinesTemperature).Union(sparklinesConditioner);

			foreach (Kendo.kendoSparkline sparkline in sparklines)
            {
				sparkline.Options.theme = theme;
				sparkline.Update();
            }
		}
    }
}
