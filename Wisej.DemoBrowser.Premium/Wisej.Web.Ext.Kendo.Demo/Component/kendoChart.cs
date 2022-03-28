using System;
using System.IO;
using System.Net;
using System.Web;
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

		private void kendoChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			var format = this.comboBox1.SelectedItem.ToString();
			switch (format)
			{
				case "SVG":
				case "PNG":
					// see wisej implementation in kendoChart.js.
					this.kendoChart1.Call("exportImageData", format);
					break;
				
				case "PDF":
					this.kendoChart1.Instance.exportPDF();
					break;
			}
		}

		private void kendoChart1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					HandleFile(e.Response, e.Request.Form["contentType"], e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
		}

		private void HandleFile(HttpResponse response, string contentType, string base64Data, string fileName)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AddHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.OutputStream.Write(bytes, 0, bytes.Length);
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
