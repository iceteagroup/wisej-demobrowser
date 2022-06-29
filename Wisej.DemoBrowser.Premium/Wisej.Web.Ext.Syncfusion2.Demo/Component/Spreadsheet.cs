using Syncfusion.EJ2.Spreadsheet;
using System;
using System.IO;
using System.Linq;
using Wisej.Core;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Spreadsheet : TestBase
	{
		private const string DEFAULT_DOCUMENT = "area_chart.xlsx";

		public Spreadsheet()
		{
			InitializeComponent();

			this.spreadsheet1.Instance.onCellSave += new WidgetEventHandler(spreadsheet1_cellSave);
		}

		private void Spreadsheet_Load(object sender, EventArgs e)
		{
			var postback = this.spreadsheet1.GetServiceURL();

			// widget configuration.
			this.spreadsheet1.Options.openUrl = $"{postback}?action=open";

			// populate sample spreadsheets.
			var samples = Directory.GetFiles(Application.MapPath("Data/Spreadsheet"))
									.Select(x => Path.GetFileName(x)).ToArray();

			this.comboBoxDocument.DataSource = samples;
			this.comboBoxDocument.SelectedItem = DEFAULT_DOCUMENT;
		}

		private void OpenSpreadsheetFromPath(string path)
		{
			using (var fs = new FileStream(path, FileMode.Open))
			{
				var spreadsheet = new SpreadsheetFileBase(fs, Path.GetFileName(path));
				var json = GetSpreadsheetJSON(spreadsheet);

				this.spreadsheet1.Instance.openFromJson(new { file = json });
			}
		}

		/// <summary>
		/// Opens the spreadsheet at the given path.
		/// </summary>
		/// <param name="filePath">The excel file.</param>
		private string GetSpreadsheetJSON(SpreadsheetFileBase file)
		{
			var open = new OpenRequest();

			open.File = new[] { file };

			return Workbook.Open(open);	
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.spreadsheet1.Options.showRibbon = this.checkBoxRibbon.Checked;
			this.spreadsheet1.Options.allowDelete = this.checkBoxAllowDelete.Checked;
			this.spreadsheet1.Options.showFormulaBar = this.checkBoxFormularBar.Checked;
			this.spreadsheet1.Options.activeSheetIndex = (int) this.numericUpDownActiveSheetIndex.Value;
		
			this.spreadsheet1.Update();
		}

		private void spreadsheet1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request["action"])
			{
				case "open":
					var postedFile = e.Request.Files[0];
					var fileName = e.Request["fileName"];
					e.Response.Write(GetSpreadsheetJSON(new SpreadsheetFileBase(postedFile.InputStream, fileName)));
					break;
			}
		}

		private void spreadsheet1_cellSave(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void comboBoxDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
			var newFile = (string)this.comboBoxDocument.SelectedItem;
			OpenSpreadsheetFromPath(Application.MapPath($"Data/Spreadsheet/{newFile}"));
		}
    }
}