using System;
using System.IO;
using System.Text;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igCategoryChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igCategoryChart()
		{
			InitializeComponent();
		}

		private void igCategoryChart_Load(object sender, EventArgs e)
		{

			//igCategoryChart Configuration
			this.igCategoryChart1.Options.title = "Population per Country";
			this.igCategoryChart1.Options.dataSource = new dynamic[]
			{
				new {Year = "1995", China = 1297, India = 920, UnitedStates = 266},
				new {Year = "2005", China = 1216, India = 1090, UnitedStates = 295},
				new {Year = "2010", China = 1271, India = 1131, UnitedStates = 314},
				new {Year = "2015", China = 1361, India = 1251, UnitedStates = 322},
				new {Year = "2020", China = 1381, India = 1341, UnitedStates = 342},
				new {Year = "2025", China = 1394, India = 1466, UnitedStates = 361},
			};
			this.igCategoryChart1.Options.yAxisFormatLabel = "yAxisFormatLabel";
			this.igCategoryChart1.Options.chartType = "auto";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igCategoryChart1.Options.chartType = this.comboBox1.SelectedItem;
			this.igCategoryChart1.Options.isItemHighlightingEnabled = this.checkBox3.Checked;
			this.igCategoryChart1.Options.finalValueAnnotationsVisible = this.checkBox2.Checked;

			this.igCategoryChart1.Update();
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igCategoryChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igCategoryChart1.Update();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.igCategoryChart1.Instance.getDataAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myData.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}
	}
}
