using System;
using System.IO;
using System.Net;
using Wisej.Core;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoSpreadsheet : TestBase
	{
		public kendoSpreadsheet()
		{
			InitializeComponent();

			this.kendoSpreadsheet1.Instance.onSelect += new WidgetEventHandler(kendoSpreadsheet1_WidgetEvent);
			this.kendoSpreadsheet1.Instance.onChange += new WidgetEventHandler(kendoSpreadsheet1_WidgetEvent);
		}

		private void kendoSpreadsheet_Load(object sender, EventArgs e)
		{
			var serviceUrl = this.kendoSpreadsheet1.GetServiceURL();
			this.kendoSpreadsheet1.Options.excel = new
			{
				forceProxy = true,
				proxyURL = $"{serviceUrl}?export=pdf"
			};
			this.kendoSpreadsheet1.Options.pdf = new
			{
				forceProxy = true,
				proxyURL = $"{serviceUrl}?export=pdf"
			};

			using (var fs = new FileStream(Application.MapPath("Data/Spreadsheet/sample.xlsx"), FileMode.Open))
			{
				using (var ms = new MemoryStream())
				{
					fs.CopyTo(ms);
					ms.Position = 0;

					this.kendoSpreadsheet1.FromFile(ms);
				}
			}
		}

		private void kendoSpreadsheet1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
			$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data.range["_ref"])}",
			MessageBoxIcon.Information);
			
			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoSpreadsheet1.Instance.saveAsExcel();
		}

		private void kendoSpreadsheet1_WebRequest(object sender, WebRequestEventArgs e)
		{
			var base64 = e.Request["base64"];
			var fileName = e.Request["fileName"];
			var contentType = e.Request["contentType"];
			var bytes = Convert.FromBase64String(base64);
			
			e.Response.BinaryWrite(bytes);
			e.Response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");

			e.Response.ContentType = contentType;
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

        private async void buttonAddSheet_Click(object sender, EventArgs e)
        {
			await this.kendoSpreadsheet1.Instance.insertSheetAsync();
		}
    }
}
