using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;
using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSpreadsheet : TestBase
	{
		public ejSpreadsheet()
		{
			InitializeComponent();

			this.ejSpreadsheet1.Instance.onCellClick += new WidgetEventHandler(this.ejSpreadsheet1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSpreadsheet1.Options.showRibbon = this.checkBox1.Checked;
			this.ejSpreadsheet1.Options.allowEditing = this.checkBox2.Checked;
			this.ejSpreadsheet1.Options.allowAutoCellType = this.checkBox3.Checked;
			this.ejSpreadsheet1.Options.allowAutoFill = this.checkBox4.Checked;
			this.ejSpreadsheet1.Options.enablePivotTable = this.checkBox5.Checked;
			this.ejSpreadsheet1.Options.formatSettings = new { 
				allowCellBorder = this.checkBox6.Checked
			};

			this.ejSpreadsheet1.Update();
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				this.ejSpreadsheet1.Instance.loadFromJSON(JSON.Parse(LoadFile(e.Files[0].InputStream)));
			}
		}

		private void ejSpreadsheet1_WebRequest(object sender, WebRequestEventArgs e)
		{
			// load the file?
			if (e.Request.Files.Count == 1) {
				e.Response.Write(LoadFile(e.Request.Files[0].InputStream));
			}
			else
			{
				SaveFile(
					e.Request.Form["fileName"],
					e.Request["format"],
					e.Request["sheetModel"],
					e.Request["sheetData"]);
			}
		}

		private void SaveFile(string fileName, string fileFormat, string sheetModel, string sheetData)
		{
			switch (fileFormat)
			{
				case "xls":
					Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLS);
					break;
				case "xlsx":
					Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLSX);
					break;
				case "pdf":
					Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.PDF);
					break;
				case "csv":
					Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.CSV);
					break;
			}
		}

		private string LoadFile(Stream stream)
		{
			var importRequest = new ImportRequest()
			{
				FileStream = stream,
			};
			return Spreadsheet.Open(importRequest);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.ejSpreadsheet1.Instance.XLExport.export("Excel", "Sample");
		}

		private void ejSpreadsheet1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
