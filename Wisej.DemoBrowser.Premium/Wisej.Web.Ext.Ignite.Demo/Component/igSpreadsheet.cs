using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igSpreadsheet : TestBase
	{
		public igSpreadsheet()
		{
			InitializeComponent();

			this.igSpreadsheet1.Instance.onExport += new WidgetEventHandler(igSpreadsheet1_WidgetEvent);
			this.igSpreadsheet1.Instance.onActiveWorksheetChanged += new WidgetEventHandler(igSpreadsheet1_WidgetEvent);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			// Save a temp file
			e.Files[0].SaveAs(Application.MapPath("Data/Spreadsheet/temp.xlsx"));

			// Load the path
			this.igSpreadsheet1.Call("loadWorkbook", "Data/Spreadsheet/temp.xlsx");
		}

		private void igSpreadsheet1_Appear(object sender, EventArgs e)
		{
			this.igSpreadsheet1.Call("loadWorkbook", "Data/Spreadsheet/statistic.xlsx");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igSpreadsheet1.Options.activeCell = this.textBox1.Text;
			this.igSpreadsheet1.Options.zoomLevel = this.numericUpDown1.Value;
			this.igSpreadsheet1.Options.allowAddWorksheet = this.checkBox2.Checked;
			this.igSpreadsheet1.Options.areGridlinesVisible = this.checkBox3.Checked;
			this.igSpreadsheet1.Options.isFormulaBarVisible = this.checkBox1.Checked;
			this.igSpreadsheet1.Options.enterKeyNavigationDirection = this.comboBox1.SelectedItem;

			this.igSpreadsheet1.Update();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			this.igSpreadsheet1.Call("exportWorkbook");
		}

		private void igSpreadsheet1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "export":
					byte[] file = Convert.FromBase64String(e.Data);
					using (MemoryStream stream = new MemoryStream(file))
					{
						stream.Seek(0, SeekOrigin.Begin);
						Application.Download(stream, "myExcel.xlsx");
					}
					break;

				default:

					break;

			}

			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
