using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDropDownTree : TestBase
	{
		public ejDropDownTree()
		{
			InitializeComponent();

			this.ejDropDownTree1.Instance.onChange += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
			this.ejDropDownTree1.Instance.onCheckChange += new WidgetEventHandler(ejDropDownTree1_WidgetEvent);
		}

		private void ejDropDownTree_Load(object sender, EventArgs e)
		{
			this.ejDropDownTree1.Options.showCheckbox = true;
			this.ejDropDownTree1.Options.enableFilterSearch = true;
			this.ejDropDownTree1.Options.treeViewSettings = new
			{
				fields = new
				{
					id = "id",
					parentId = "pid",
					text = "name",
					hasChild = "hasChild",
					dataSource = new object[]
					{
						new
						{
							id = 1, name = "Discover Music",
							hasChild = true, expanded = true
						},
						new
						{
							id = 2, pid = 1, name = "Hot Singles"
						},
						new
						{
							id = 3, pid = 1, name = "Rising Artists"
						},
						new
						{
							id = 4, pid = 1, name = "Live Music"
						},
						new
						{
							id = 6, pid = 1, name = "Best of 2013 So Far"
						},
						new
						{
							id = 7, name = "Sales and Events",
							hasChild = true, expanded = true
						},
						new
						{
							id = 8, pid = 7, name = "100 Albums - $5 Each"
						},
						new
						{
							id = 9, pid = 7, name = "Hip-Hop and R&B Sale"
						},
						new
						{
							id = 10, pid = 7, name = "CD Deals"
						},
						new
						{
							id = 11, name = "Categories",
							hasChild = true
						},
						new
						{
							id = 12, pid = 11, name = "Songs"
						},
						new
						{
							id = 13, pid = 11, name = "Bestselling Albums"
						},
						new
						{
							id = 14, pid = 11, name = "New Releases"
						},
						new
						{
							id = 15, pid = 11, name = "Bestselling Songs"
						},
						new
						{
							id = 16, name = "MP3 Albums",
							hasChild = true
						},
						new
						{
							id = 17, pid = 16, name = "Rock"
						},
						new
						{
							id = 18, pid = 16, name = "Gospel"
						},
						new
						{
							id = 19, pid = 16, name = "Latin Music"
						},
						new
						{
							id = 20, pid = 16, name = "Jazz"
						},
						new
						{
							id = 21, name = "More in Music",
							hasChild = true
						},
						new
						{
							id = 22, pid = 21, name = "Music Trade-In"
						},
						new
						{
							id = 23, pid = 21, name = "Redeem a Gift Card"
						},
						new
						{
							id = 24, pid = 21, name = "Band T-Shirts"
						},
						new
						{
							id = 25, pid = 21, name = "Mobile MVC"
						}
					},
					expanded = "expanded"
				}
			};
			this.ejDropDownTree1.Options.watermarkText = "Please select";
			this.ejDropDownTree1.Options.popupSettings = new
			{
				height = "152px"
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDropDownTree1.Options.showRoundedCorner = this.checkBox1.Checked;
			this.ejDropDownTree1.Options.popupSettings = new
			{
				showPopupOnLoad = this.checkBox2.Checked,
				height = $"{this.numericUpDownPopupHeight.Value}px"
			};

			this.ejDropDownTree1.Update();
		}

		private void ejDropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}