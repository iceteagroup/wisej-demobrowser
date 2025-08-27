using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejListView : TestBase
	{
		public ejListView()
		{
			InitializeComponent();
		}

		private void ejListView_Load(object sender, EventArgs e)
		{
			this.ejListView1.Options.enableCheckMark = true;
			this.ejListView1.Options.dataSource = new object[]
			{
				new
				{
					text = "Hot Singles"
				},
				new
				{
					text = "Rising Artists"
				},
				new
				{
					text = "Live Music"
				},
				new
				{
					text = "Best of 2013 So Far"
				},
				new
				{
					text = "100 Albums - $5 Each"
				},
				new
				{
					text = "Hip-Hop and R&B Sale"
				},
				new
				{
					text = "CD Deals"
				},
				new
				{
					text = "Songs"
				},
				new
				{
					text = "Bestselling Albums"
				},
				new
				{
					text = "New Releases"
				},
				new
				{
					text = "Bestselling Songs"
				},
				new
				{
					text = "Rock"
				},
				new
				{
					text = "Gospel"
				},
				new
				{
					text = "Latin Music"
				},
				new
				{
					text = "Jazz"
				},
				new
				{
					text = "Music Trade-In"
				},
				new
				{
					text = "Redeem a Gift Card"
				},
				new
				{
					text = "Band T-Shirts"
				},
				new
				{
					text = "Web MVC"
				}
			};
		}

		private void buttonAddNewItem_Click(object sender, EventArgs e)
		{
			this.ejListView1.Instance.addItem(new {text = this.textBoxAddNewItem.Text}, 0, "");

			this.ejListView1.Update();
		}

		private async void buttonGetSelectedItems_Click(object sender, EventArgs e)
		{
			var checkedItems = await this.ejListView1.Instance.getCheckedItemsTextAsync();

			AlertBox.Show(Core.WisejSerializer.Serialize(checkedItems));
		}

		private void buttonClearSelected_Click(object sender, EventArgs e)
		{
			this.ejListView1.Instance.unCheckAllItem();

			this.ejListView1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejListView1.Options.enableCheckMark = this.checkBox1.Checked;
			this.ejListView1.Options.enableFiltering = this.checkBox2.Checked;
			this.ejListView1.Options.enableGroupList = this.checkBox3.Checked;

			this.ejListView1.Update();
		}

		private void ejListView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}