using Syncfusion.EJ2.Spreadsheet;
using System;
using System.IO;
using System.Linq;
using System.Web;
using Wisej.Core;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Spreadsheet : TestBase
	{
		public Spreadsheet()
		{
			InitializeComponent();

			this.spreadsheet1.Instance.onCellSave += new WidgetEventHandler(spreadsheet1_cellSave);
		}

        private void spreadsheet1_cellSave(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
										MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void Spreadsheet_Load(object sender, EventArgs e)
		{
			this.spreadsheet1.Options.allowOpen = true;
			this.spreadsheet1.Options.openUrl = ((Widget)this.spreadsheet1).GetPostbackURL() + "&action=load";

			var defaultFile = "column_chart.xlsx";
			this.spreadsheet1.Instance.openFromJson(new
			{
				file = ProcessFile(defaultFile)
			});

			var samples = Directory.GetFiles(Application.MapPath("Data/Spreadsheet"))
				.Select(x => Path.GetFileName(x)).ToArray();

			this.comboBox1.DataSource = samples;
			this.comboBox1.SelectedItem = defaultFile;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// update the first sheet.
			this.spreadsheet1.Eval(@"
				this.widget.sheets[0].showHeaders = false;
				this.widget.refresh();
			");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var filePath = "Data/Spreadsheet/Sample2.xlsx";
			this.spreadsheet1.Instance.openFromJson(new
			{
				file = ProcessFile(filePath)
			});
		}

		private void spreadsheet1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.Params["action"])
			{
				case "load":
						e.Response.Write(ProcessFile(e.Request.Files[0]));
					break;

				case "fetch":
					var fileName = e.Request.Params["fileName"];
					e.Response.WriteFile(Application.MapPath($"Data/Spreadsheet/{fileName}.xlsx"));
					break;

				default:
					break;
			}
		}

        /// <summary>
        /// Processes the given file (path) and returns the JSON configuration.
        /// </summary>
        /// <param name="filePath">The excel file.</param>
        /// <returns>The JSON configuration of the file.</returns>
        private string ProcessFile(string filePath)
		{
			var fileName = Path.GetFileNameWithoutExtension(filePath);
			var service = ((Widget)this.spreadsheet1).GetServiceURL();
			var postback = $"{Application.StartupUrl}{service}?action=fetch&fileName={fileName}";

			var open = new OpenRequest();
			open.File = new[] { postback };
			return Workbook.Open(open);
		}

		/// <summary>
		/// Processes the given file and returns the JSON configuration.
		/// </summary>
		/// <param name="file">The uploaded file.</param>
		/// <returns>The JSON configuration of the file.</returns>
		private string ProcessFile(HttpPostedFile file)
		{
			var open = new OpenRequest();
			open.File = new[] { new HttpPostedFileWrapper(file) };
			return Workbook.Open(open);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var newDataSource = (string)this.comboBox1.SelectedItem;
			this.spreadsheet1.Instance.openFromJson(new
			{
				file = ProcessFile(newDataSource)
			});

			this.spreadsheet1.Options.showRibbon = this.checkBoxRibbon.Checked;
			this.spreadsheet1.Options.showFormulaBar = this.checkBoxFormularBar.Checked;
			this.spreadsheet1.Options.activeSheetIndex = (int)this.numericUpDownActiveSheetIndex.Value;

			this.spreadsheet1.Update();
		}
	}
}
