using System;
using System.IO;
using System.Net;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoGantt : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoGantt()
		{
			InitializeComponent();

			this.kendoGantt1.Instance.onAdd += new WidgetEventHandler(kendoGantt1_WidgetEvent);
			this.kendoGantt1.Instance.onChange += new WidgetEventHandler(kendoGantt1_WidgetEvent);
		}

		private void kendoGantt_Load(object sender, EventArgs e)
		{
			this.kendoGantt1.Options.pdf = new
			{
				forceProxy = true,
				proxyURL = $"{this.kendoGantt1.GetServiceURL()}"
			};
		}

		private void kendoGantt1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoGantt1.Options.snap = this.checkBox3.Checked;
			this.kendoGantt1.Options.selectable = this.checkBox1.Checked;
			this.kendoGantt1.Options.navigatable = this.checkBox2.Checked;
			this.kendoGantt1.Options.showWorkDays = this.checkBox4.Checked;
			this.kendoGantt1.Options.showWorkHours = this.checkBox5.Checked;
			this.kendoGantt1.Options.rowHeight = this.numericUpDown1.Value;

			this.kendoGantt1.Update();
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			var pdf = this.kendoGantt1.Instance.saveAsPDF();
		}

		private void kendoGantt1_WebRequest(object sender, WebRequestEventArgs e)
		{
			// receive file on server.
			var contentType = e.Request["contentType"];
			var fileName = e.Request["fileName"];
			var base64 = e.Request["base64"];

			// download to client.
			e.Response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");
			e.Response.ContentType = contentType;

			var bytes = Convert.FromBase64String(base64);
			e.Response.BinaryWrite(bytes);
		}
    }
}
