using System;
using System.IO;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoScheduler : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoScheduler()
		{
			InitializeComponent();

			this.kendoScheduler1.Instance.add += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.cancel += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.change += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.edit += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			this.kendoScheduler1.Instance.save += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
		}

		private void kendoScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{

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
			response.AddHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.OutputStream.Write(bytes, 0, bytes.Length);
		}
	}
}
