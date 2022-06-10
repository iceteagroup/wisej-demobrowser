using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ListView : TestBase
	{
		public ListView()
		{
			InitializeComponent();

			this.listView1.Instance.onSelect += new WidgetEventHandler(listView1_select);
		}

		private void ListView_Load(object sender, EventArgs e)
		{
			this.listView1.Options.dataSource = new object[]
			{
				new
				{
					text = "Artwork",
					id = "01"
				},
				new
				{
					text = "Abstract",
					id = "02"
				},
				new
				{
					text = "Modern Painting",
					id = "03"
				},
				new
				{
					text = "Ceramics",
					id = "04"
				},
				new
				{
					text = "Animation Art",
					id = "05"
				},
				new
				{
					text = "Oil Painting",
					id = "06"
				}
			};
			this.listView1.Options.headerTitle = "Simple title";
		}

		private void listView1_select(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.listView1.Options.sortOrder = this.comboBoxSortOrder.Text;
			this.listView1.Options.checkBoxPosition = this.comboBoxPosition.Text;
			this.listView1.Options.showHeader = this.checkBoxHeader.Checked;
			this.listView1.Options.showCheckBox = this.checkBoxShowCheckBox.Checked;

			this.listView1.Update();
		}

		private void checkBoxShowCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.comboBoxPosition.Enabled = this.checkBoxShowCheckBox.Checked;
		}
	}
}