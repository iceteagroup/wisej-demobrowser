using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejListBox : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejListBox()
		{
			InitializeComponent();

			this.ejListBox1.Instance.select += new WidgetEventHandler(ejListBox1_WidgetEvent);
			this.ejListBox1.Instance.unselect += new WidgetEventHandler(ejListBox1_WidgetEvent);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejListBox1.Options.dataSource = JSON.Parse(json);

					this.ejListBox1.Update();
				}
			}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejListBox1.Instance.optionAsync("dataSource");
			var json = Wisej.Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "listbox.json");
		}

		private void ejListBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejListBox1.Options.virtualScrollMode = this.comboBox1.Text.ToLower();
			this.ejListBox1.Options.allowDrag = this.checkBox1.Checked;
			this.ejListBox1.Options.allowDrop = this.checkBox2.Checked;
			this.ejListBox1.Options.allowMultiSelection = this.checkBox3.Checked;
			this.ejListBox1.Options.showCheckbox = this.checkBox4.Checked;
			this.ejListBox1.Options.enableIncrementalSearch = this.checkBox5.Checked;

			this.ejListBox1.Update();
		}
	}
}
