using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTreeView : TestBase
	{
		public ejTreeView()
		{
			InitializeComponent();

			this.ejTreeView1.Instance.onNodeClick += new WidgetEventHandler(ejTreeView1_WidgetEvent);
			this.ejTreeView1.Instance.onNodeCollapse += new WidgetEventHandler(ejTreeView1_WidgetEvent);
		}

		private void ejTreeView_Load(object sender, EventArgs e)
		{
			this.ejTreeView1.Options.fields = new
			{
				id = "id",
				text = "text",
				parentId = "parent",
				dataSource = new object[]
				{
					new
					{
						id = 1, text = "Item 1",
						expanded = true, nodeProperty = new
						{
							@class = "textBlue",
							value = "Item 1"
						}
					},
					new
					{
						id = 2,
						text = "Wisej.com",
						linkProperty = new
						{
							@class = "textUnderline",
							href = "http://www.Wisej.com",
							target = "_blank"
						}
					},
					new
					{
						id = 3,
						text = "Item 3",
						selected = true,
						spriteImage = "mailicon sprite-calendar"
					},
					new
					{
						id = 4,
						text = "Item 4",
						@checked = true,
						imageProperty = new
						{
							width = 20,
							height = 20
						},
						imageUrl = "http://cdn.syncfusion.com/13.3.0.7/js/web/flat-azure/images/ajax-loader.gif"
					},
					new
					{
						id = 5,
						parent = 1,
						text = "Item 1.1"
					},
					new
					{
						id = 6,
						parent = 1,
						text = "Item 1.2"
					},
					new
					{
						id = 7,
						parent = 1,
						text = "Item 1.3"
					},
					new
					{
						id = 8,
						parent = 3,
						text = "Item 3.1"
					},
					new
					{
						id = 9,
						parent = 3,
						text = "Item 3.2"
					},
					new
					{
						id = 10,
						parent = 5,
						text = "Item 1.1.1"
					}
				},
				isChecked = "checked",
				selected = "selected",
				spriteCssClass = "spriteImage",
				imageUrl = "imageUrl",
				htmlAttribute = "nodeProperty",
				linkAttribute = "linkProperty",
				imageAttribute = "imageProperty"
			};
		}

		private void ejTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGetCheckedNodes_Click(object sender, EventArgs e)
		{
			var checkedNodes = await this.ejTreeView1.Instance.getCheckedNodesAsync();

			AlertBox.Show(JSON.Stringify(checkedNodes));
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeView1.Options.autoCheck = this.checkBox1.Checked;
			this.ejTreeView1.Options.showCheckbox = this.checkBox2.Checked;
			this.ejTreeView1.Options.allowDragAndDrop = this.checkBox3.Checked;
			this.ejTreeView1.Options.allowEditing = this.checkBox4.Checked;
			this.ejTreeView1.Options.allowKeyboardNavigation = this.checkBox5.Checked;
			this.ejTreeView1.Options.allowMultiSelection = this.checkBox6.Checked;

			this.ejTreeView1.Update();
		}
	}
}