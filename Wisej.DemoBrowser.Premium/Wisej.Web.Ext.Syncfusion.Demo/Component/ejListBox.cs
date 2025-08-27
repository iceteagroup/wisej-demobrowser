using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejListBox : TestBase
	{
		public ejListBox()
		{
			InitializeComponent();

			this.ejListBox1.Instance.onSelect += new WidgetEventHandler(ejListBox1_WidgetEvent);
			this.ejListBox1.Instance.onUnselect += new WidgetEventHandler(ejListBox1_WidgetEvent);
		}

		private void ejListBox_Load(object sender, EventArgs e)
		{
			this.ejListBox1.Options.allowDrag = true;
			this.ejListBox1.Options.allowDrop = true;
			this.ejListBox1.Options.dataSource = new object[]
			{
				new
				{
					bikeId = "bk1",
					bikeName = "Apache RTR"
				},
				new
				{
					bikeId = "bk2",
					bikeName = "CBR 150-R"
				},
				new
				{
					bikeId = "bk3",
					bikeName = "CBZ Xtreme"
				},
				new
				{
					bikeId = "bk4",
					bikeName = "Discover"
				},
				new
				{
					bikeId = "bk5",
					bikeName = "Dazzler"
				},
				new
				{
					bikeId = "bk6",
					bikeName = "Flame"
				},
				new
				{
					bikeId = "bk7",
					bikeName = "Fazer"
				},
				new
				{
					bikeId = "bk8",
					bikeName = "FZ-S"
				},
				new
				{
					bikeId = "bk9",
					bikeName = "Pulsar"
				},
				new
				{
					bikeId = "bk10",
					bikeName = "Shine"
				},
				new
				{
					bikeId = "bk11",
					bikeName = "R15"
				},
				new
				{
					bikeId = "bk12",
					bikeName = "Unicorn"
				}
			};
			this.ejListBox1.Options.fields = new
			{
				id = "bikeId",
				text = "bikeName"
			};
		}
		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejListBox1.Options.dataSource = JSON.Parse(json);

					this.ejListBox1.Update();
				}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejListBox1.Instance.optionAsync("dataSource");
			var json = Core.WisejSerializer.Serialize(data);

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