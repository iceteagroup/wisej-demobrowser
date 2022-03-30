using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDoughnutChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igDoughnutChart()
		{
			InitializeComponent();

			this.igDoughnutChart1.Instance.onSliceClick += new WidgetEventHandler(igDoughnutChart_WidgetEvent);
		}

		private void igDoughnutChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igDoughnutChart1.Options.series[0].dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igDoughnutChart1.Update();
		}

		private async void buttonExportData_Click(object sender, EventArgs e)
		{
			var data = await this.igDoughnutChart1.Instance.getDataAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					// getData returns an array with one element: the array of elements
					sw.Write(JSON.Stringify(data[0]));
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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDoughnutChart1.Options.allowSliceExplosion = this.checkBox1.Checked;
			this.igDoughnutChart1.Options.allowSliceSelection = this.checkBox2.Checked;
			this.igDoughnutChart1.Options.innerExtent = this.numericUpDown2.Value;
		
			this.igDoughnutChart1.Update();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Inserts a new item to the beginning of the dataSource
			this.igDoughnutChart1.AddItem(new { countryName = this.textBox1.Text, pop1990 = this.numericUpDown1.Value }, 0);
		}
	}
}
