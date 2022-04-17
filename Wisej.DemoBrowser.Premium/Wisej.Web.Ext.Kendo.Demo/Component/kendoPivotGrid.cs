using System;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoPivotGrid : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoPivotGrid()
		{
			InitializeComponent();

			this.kendoPivotGrid1.Instance.onExpandMember += new WidgetEventHandler(kendoPivotGrid1_WidgetEvent);
		}

		private void kendoPivotGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Instance.saveAsExcel();
		}

		private void kendoPivotGrid1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					this.ExportDocument(e.Response, e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
		}

		private void ExportDocument(HttpResponse response, string base64Data, string fileName)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.OutputStream.Write(bytes, 0, bytes.Length);
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Instance.saveAsPDF();
		}
	}
}
