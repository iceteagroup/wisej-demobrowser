using System;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoChart : TestBase
	{
		public kendoChart()
		{
			InitializeComponent();

			this.kendoChart1.Instance.onLegendItemClick += new WidgetEventHandler(kendoChart1_WidgetEvent);
			this.kendoChart1.Instance.onSeriesClick += new WidgetEventHandler(kendoChart1_WidgetEvent);
			this.kendoChart1.Instance.onSelect += new WidgetEventHandler(kendoChart1_WidgetEvent);
		}

		private void kendoChart_Load(object sender, EventArgs e)
		{
		}

		private void kendoChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var base64 = "";
			var format = this.comboBox1.SelectedItem.ToString().ToLower();
			switch (format)
			{
				case "svg":
					base64 = await this.kendoChart1.Instance.exportSVGAsync();
					break;
				case "png":
					base64 = await this.kendoChart1.Instance.exportImageAsync();
					break;
				case "pdf":
					base64 = await this.kendoChart1.Instance.exportPDFAsync();
					break;
			}

			ProcessFile(base64, $"kendoChart.{format}");
		}

		private void ProcessFile(string base64Data, string fileName)
		{
			if (string.IsNullOrEmpty(base64Data))
				return;

			var base64 = base64Data.Split(new[] { ',' })[1];
			var bytes = Convert.FromBase64String(base64);
			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, fileName);
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoChart1.Options.transitions = this.checkBox1.Checked;
			this.kendoChart1.Options.pannable = this.checkBox2.Checked;
			this.kendoChart1.Options.categoryAxis.labels.visible = this.checkBox3.Checked;

			this.kendoChart1.Update();
		}
	}
}
