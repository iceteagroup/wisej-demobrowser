using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejGrid : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejGrid()
		{
			InitializeComponent();

			this.ejGrid1.Instance.onCellSave += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onBatchSave += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onRowSelected += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onCellSelected += new WidgetEventHandler(ejGrid1_WidgetEvent);
			this.ejGrid1.Instance.onToolbarClick += new WidgetEventHandler(ejGrid1_WidgetEvent);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejGrid1.Instance.dataSource(JSON.Parse(json));
				}
			}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejGrid1.Instance.optionAsync("dataSource");
			var json = Wisej.Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "grid.json");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejGrid1.Options.editSettings.allowEditing = this.checkBox1.Checked;
			this.ejGrid1.Options.allowCellMerging = this.checkBox2.Checked;
			this.ejGrid1.Options.allowGrouping = this.checkBox3.Checked;
			this.ejGrid1.Options.allowKeyboardNavigation = this.checkBox4.Checked;
			this.ejGrid1.Options.allowFiltering = this.checkBox5.Checked;
			this.ejGrid1.Options.allowSorting = this.checkBox6.Checked;
			this.ejGrid1.Options.allowMultiSorting = this.checkBox7.Checked;

			this.ejGrid1.Update();
		}

		private void ejGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
