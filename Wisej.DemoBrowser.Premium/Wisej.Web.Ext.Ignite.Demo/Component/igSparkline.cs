using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igSparkline : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igSparkline()
		{
			InitializeComponent();
		}

		private void igSparkline_Load(object sender, EventArgs e)
		{
			this.igSparkline1.Options.dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/Sparkline/data.json")));

			this.igSparkline1.Options.valueMemberPath = "ExtendedPrice";
			this.igSparkline1.Options.tooltipTemplate = "Low:${Low}<br>High:${High}";
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igSparkline1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igSparkline1.Update();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.igSparkline1.Instance.getDataAsync();

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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igSparkline1.Options.displayType = this.comboBox1.SelectedItem;
			this.igSparkline1.Options.lineThickness = this.numericUpDown1.Value;
			this.igSparkline1.Options.trendLineType = this.comboBox2.SelectedItem;

			this.igSparkline1.Update();
		}
	}
}
