using System;
using System.IO;
using Wisej.Core;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
    public partial class kendoGrid : TestBase
	{
		public kendoGrid()
		{
			InitializeComponent();

			this.kendoGrid1.Instance.onEdit += new WidgetEventHandler(kendoGrid1_WidgetEvent);
			this.kendoGrid1.Instance.onNavigate += new WidgetEventHandler(kendoGrid1_WidgetEvent);
		}

		private void kendoGrid_Load(object sender, EventArgs e)
		{
			this.kendoGrid1.Options.editable = true;
			this.kendoGrid1.Options.toolbar = new[] { "Save" };
			this.kendoGrid1.Options.columns = new dynamic[]
			{
				"ProductName",
				new { field = "UnitPrice", title = "Unit Price", format = "{0:c}", width = "130px" },
				new { field = "UnitsInStock", title = "Units In Stock", width = "130px" },
				new { field = "Discontinued", width = "130px" }
			};
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoGrid1.Instance.saveAsPDF();
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoGrid1.Instance.saveAsExcel();
		}

		private void kendoGrid1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					// prepare for download.
					this.ExportDocument(e.Request.Form["base64"], e.Request.Form["fileName"], e.Response);
					break;
			}
		}

		private void ExportDocument(string base64Data, string fileName, HttpResponse response)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.OutputStream.Write(bytes, 0, bytes.Length);
		}

		private void kendoGrid1_DataRead(object sender, KendoGridDataReadEventArgs e)
		{
			var json = File.ReadAllText(Application.MapPath("Data/Grid/ProductDetails.json"));
			e.Response.ContentType = "application/json";
			e.Response.Write(json);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoGrid1.Options.mobile = this.checkBox2.Checked;
			this.kendoGrid1.Options.allowCopy = this.checkBox1.Checked;
			this.kendoGrid1.Options.navigatable = this.checkBox3.Checked;
			this.kendoGrid1.Options.persistSelection = this.checkBox4.Checked;

			this.kendoGrid1.Update();
		}

		private void kendoGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void kendoGrid1_DataUpdate(object sender, KendoGridDataUpdateEventArgs e)
        {
        }
    }
}
