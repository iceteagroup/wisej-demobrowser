using System;
using System.IO;
using System.Net;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoSpreadsheet : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoSpreadsheet()
		{
			InitializeComponent();

			this.kendoSpreadsheet1.Instance.select += new WidgetEventHandler(kendoSpreadsheet1_WidgetEvent);
			this.kendoSpreadsheet1.Instance.change += new WidgetEventHandler(kendoSpreadsheet1_WidgetEvent);
		}

		private void kendoSpreadsheet1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoSpreadsheet1.Instance.saveAsExcel();
		}

		private void kendoSpreadsheet1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["export"])
			{
				case "pdf":
				case "excel":
					SaveFile(e.Request.Form["fileName"], e.Request.Form["contentType"], e.Request.Form["base64"]);
					break;

				default:
					break;

			}

			e.Response.StatusCode = (int)HttpStatusCode.NotModified;
		}

		private void SaveFile(string fileName, string contentType, string base64Data)
		{
			AlertBox.Show($"Received {fileName} on the server.");

			var data = Convert.FromBase64String(base64Data);

			using (var ms = new MemoryStream(data))
			{
				Application.Download(ms, fileName);
			}
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoSpreadsheet1.Instance.saveAsPDF();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoSpreadsheet1.Options.sheetsbar = this.checkBox1.Checked;
			this.kendoSpreadsheet1.Options.headerHeight = this.numericUpDown1.Value;
			this.kendoSpreadsheet1.Options.headerWidth = this.numericUpDown2.Value;

			this.kendoSpreadsheet1.Update();
		}
	}
}
