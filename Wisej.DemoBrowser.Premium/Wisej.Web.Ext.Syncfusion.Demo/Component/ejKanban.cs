using System;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejKanban : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejKanban()
		{
			InitializeComponent();

			this.ejKanban1.Instance.onCardDrop += new WidgetEventHandler(ejKanban1_WidgetEvent);
			this.ejKanban1.Instance.onCardClick += new WidgetEventHandler(ejKanban1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejKanban1.Options.selectionType = this.comboBox1.Text;
			this.ejKanban1.Options.allowDragAndDrop = this.checkBox1.Checked;
			this.ejKanban1.Options.allowTitle = this.checkBox2.Checked;
			this.ejKanban1.Options.allowSearching = this.checkBox3.Checked;
			this.ejKanban1.Options.allowFiltering = this.checkBox4.Checked;
			this.ejKanban1.Options.allowPrinting = this.checkBox5.Checked;

			this.ejKanban1.Update();
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejKanban1.Instance.dataSource(JSON.Parse(json));
				}
			}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejKanban1.Instance.optionAsync("dataSource");
			var json = Wisej.Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "kanban.json");
		}

		private async void buttonGetVisibleColumnNames_Click(object sender, EventArgs e)
		{
			var visibleNames = await this.ejKanban1.Instance.getVisibleColumnNamesAsync();

			AlertBox.Show(Wisej.Core.WisejSerializer.Serialize(visibleNames));
		}

		private void ejKanban1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
