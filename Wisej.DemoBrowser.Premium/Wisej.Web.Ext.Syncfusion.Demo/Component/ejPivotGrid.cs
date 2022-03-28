using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPivotGrid : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejPivotGrid()
		{
			InitializeComponent();

			this.ejPivotGrid1.Instance.onCellEdit += new WidgetEventHandler(ejPivotGrid1_WidgetEvent);
			this.ejPivotGrid1.Instance.onCellClick += new WidgetEventHandler(ejPivotGrid1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPivotGrid1.Options.enableCellClick = this.checkBox1.Checked;
			this.ejPivotGrid1.Options.enableColumnGrandTotal = this.checkBox4.Checked;
			this.ejPivotGrid1.Options.headerSettings.showRowItems = this.checkBox2.Checked;
			this.ejPivotGrid1.Options.headerSettings.showColumnItems = this.checkBoxShow3.Checked;

			this.ejPivotGrid1.Update();
		}

		private void ejPivotGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejPivotGrid1.Instance.setJSONRecords(JSON.Stringify(json));

					this.ejPivotGrid1.Update();
				}
			}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejPivotGrid1.Instance.getJSONRecordsAsync();
			var json = Wisej.Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "pivotgrid.json");
		}
	}
}
