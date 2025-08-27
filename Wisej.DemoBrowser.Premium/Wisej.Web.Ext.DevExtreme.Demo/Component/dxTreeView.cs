using System;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTreeView : TestBase
	{
		public dxTreeView()
		{
			InitializeComponent();

			this.dxTreeView1.Instance.onItemClick += new WidgetEventHandler(dxTreeView1_WidgetEvent);
			this.dxTreeView1.Instance.onSelectionChanged += new WidgetEventHandler(dxTreeView1_WidgetEvent);
		}

		private void dxTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTreeView1.Options.expandNodesRecursive = this.checkBox4.Checked;
			this.dxTreeView1.Options.hoverStateEnabled = this.checkBox5.Checked;
			this.dxTreeView1.Options.searchEnabled = this.checkBox6.Checked;
			this.dxTreeView1.Options.selectByClick = this.checkBox7.Checked;
			this.dxTreeView1.Options.scrollDirection = this.comboBox1.SelectedItem;
			this.dxTreeView1.Options.showCheckBoxesMode = this.comboBox2.SelectedItem;

			this.dxTreeView1.Update();
		}

        private void dxTreeView_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;

			this.dxTreeView1.Options = new
			{
				dataStructure = "plain",
				parentIdExpr = "categoryId",
				keyExpr = "ID",
				displayExpr = "name",
				items = new object[]
                {
                    new {
                        ID =  "1",
                        name = "Stores",
                        expanded = true
                    },
                    new {
                        ID =  "1_1",
                        categoryId = "1",
                        name = "Super Mart of the West",
                        expanded = true
                    },
                    new {
                        ID =  "1_1_1",
                        categoryId = "1_1",
                        name = "Video Players"
                    },
                    new {
                        ID =  "1_1_1_1",
                        categoryId = "1_1_1",
                        name = "HD Video Player",
                        icon = "Data/TreeView/1.png",
                        price = 220
                    },
                    new {
                        ID =  "1_1_1_2",
                        categoryId = "1_1_1",
                        name = "SuperHD Video Player",
                        icon = "Data/TreeView/2.png",
                        price = 270
                    },
                    new {
                        ID =  "1_1_2",
                        categoryId = "1_1",
                        name = "Televisions",
                        expanded = true
                    },
                    new {
                        ID =  "1_1_2_1",
                        categoryId = "1_1_2",
                        name = "SuperLCD 42",
                        icon = "Data/TreeView/7.png",
                        price = 1200
                    },
                    new {
                        ID =  "1_1_2_2",
                        categoryId = "1_1_2",
                        name = "SuperLED 42",
                        icon = "Data/TreeView/5.png",
                        price = 1450
                    },
                    new {
                        ID =  "1_1_2_3",
                        categoryId = "1_1_2",
                        name = "SuperLED 50",
                        icon = "Data/TreeView/4.png",
                        price = 1600
                    },
                    new {
                        ID =  "1_1_2_4",
                        categoryId = "1_1_2",
                        name = "SuperLCD 55",
                        icon = "Data/TreeView/6.png",
                        price = 1750
                    },
                    new {
                        ID =  "1_1_2_5",
                        categoryId = "1_1_2",
                        name = "SuperLCD 70",
                        icon = "Data/TreeView/9.png",
                        price = 4000
                    },
                    new {
                        ID =  "1_1_3",
                        categoryId = "1_1",
                        name = "Monitors"
                    },
                    new {
                        ID =  "1_1_3_1",
                        categoryId = "1_1_3",
                        name = "19\""
                    },
                    new {
                        ID =  "1_1_3_1_1",
                        categoryId = "1_1_3_1",
                        name = "DesktopLCD 19",
                        icon = "Data/TreeView/10.png",
                        price = 160
                    },
                    new {
                        ID =  "1_1_4",
                        categoryId = "1_1",
                        name = "Projectors"
                    },
                    new {
                        ID =  "1_1_4_1",
                        categoryId = "1_1_4",
                        name = "Projector Plus",
                        icon = "Data/TreeView/14.png",
                        price = 550
                    },
                    new {
                        ID =  "1_1_4_2",
                        categoryId = "1_1_4",
                        name = "Projector PlusHD",
                        icon = "Data/TreeView/15.png",
                        price = 750
                    }
                }
			};

			this.dxTreeView1.Update();
		}
	}
}
