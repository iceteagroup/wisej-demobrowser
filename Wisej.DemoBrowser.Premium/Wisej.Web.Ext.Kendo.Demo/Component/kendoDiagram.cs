using System;
using System.IO;
using System.Net;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDiagram : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoDiagram()
		{
			InitializeComponent();

			this.kendoDiagram1.Instance.click += new WidgetEventHandler(kendoDiagram1_WidgetEvent);
		}

		private void kendoDiagram1_WidgetEvent(object sender, WidgetEventArgs e)
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
				case "PDF":
					break;

				case "SVG":
					break;

				case "PNG":
					break;
			}
		}

		private void kendoDiagram1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					ExportDocument(e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
			e.Response.StatusCode = (int)HttpStatusCode.NotModified;
		}

		private void ExportDocument(string base64, string fileName)
		{
			AlertBox.Show($"Received the file {fileName} on the server.");

			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, fileName);
			}
		}
	}
}
