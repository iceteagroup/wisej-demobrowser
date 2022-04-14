using System;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoScheduler : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoScheduler()
		{
			InitializeComponent();

			this.kendoScheduler1.Instance.onAdd += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.onCancel += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.onChange += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.onEdit += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.onSave += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
		}

		private void kendoScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoScheduler1.Instance.saveAsPDF();
		}

		private void kendoScheduler1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					// do whatever you want with the file.
					HandleFile(e.Response, e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;

			}
		}

		private void HandleFile(HttpResponse response, string base64Data, string fileName)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.OutputStream.Write(bytes, 0, bytes.Length);
		}
	}
}
