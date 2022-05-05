using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igTreeGrid : TestBase
	{
		public igTreeGrid()
		{
			InitializeComponent();

			this.igTreeGrid1.Instance.onCellClick += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTreeGrid1.Instance.onCellRightClick += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			this.igTreeGrid1.Instance.dataSourceObject(data);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await this.igTreeGrid1.EvalAsync("this.widget.options.dataSource");

			using (var ms = new MemoryStream())
            {
				using (var sw = new StreamWriter(ms))
                {
					sw.Write(JSON.Stringify(data));
					sw.Flush();

					ms.Position = 0;
					Application.Download(ms, "igTreeGrid.json");
				}
			}
		}

		private void igTree_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
				this.igTreeGrid1.Options.features = new[] {
					new { name = "Paging", mode = "allLevels", pageSize = 13 }
				};
			else
				this.igTreeGrid1.Options.features = new { };
			
			this.igTreeGrid1.Options.showHeader = this.checkBox3.Checked;
			this.igTreeGrid1.Options.enableHoverStyles = this.checkBox4.Checked;

			this.igTreeGrid1.Update();
		}
	}
}
