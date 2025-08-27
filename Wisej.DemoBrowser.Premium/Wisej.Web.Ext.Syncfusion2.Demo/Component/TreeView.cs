using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TreeView : TestBase
	{
		public TreeView()
		{
			InitializeComponent();

			this.treeView1.Instance.onNodeSelected += new WidgetEventHandler(treeView1_WidgetEvent);
		}

		private void TreeView_Load(object sender, EventArgs e)
		{
			this.treeView1.Options.fields = new
			{
				dataSource = new object[]
				{
					new
					{
						nodeId = "01",
						nodeText = "Music",
						nodeChild = new object[]
						{
							new
							{
								nodeId = "01-01",
								nodeText = "Gouttes.mp3"
							}
						}
					},
					new
					{
						nodeId = "02",
						nodeText = "Videos",
						expanded = true, nodeChild = new object[]
						{
							new
							{
								nodeId = "02-01",
								nodeText = "Naturals.mp4"
							},
							new
							{
								nodeId = "02-02",
								nodeText = "Wild.mpeg"
							}
						}
					},
					new
					{
						nodeId = "03",
						nodeText = "Documents",
						nodeChild = new object[]
						{
							new
							{
								nodeId = "03-01",
								nodeText = "Environment Pollution.docx"
							},
							new
							{
								nodeId = "03-02",
								nodeText = "Global Water, Sanitation, & Hygiene.docx"
							},
							new
							{
								nodeId = "03-03",
								nodeText = "Global Warming.ppt"
							},
							new
							{
								nodeId = "03-04",
								nodeText = "Social Network.pdf"
							},
							new
							{
								nodeId = "03-05",
								nodeText = "Youth Empowerment.pdf"
							}
						}
					}
				},
				id = "nodeId",
				text = "nodeText",
				child = "nodeChild"
			};
		}

		private void treeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.treeView1.Options.allowEditing = this.checkBoxEditing.Checked;
			this.treeView1.Options.expandOn = this.comboBoxExpandOn.SelectedItem;
			this.treeView1.Options.showCheckBox = this.checkBoxShowCheckbox.Checked;
			this.treeView1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;

			this.treeView1.Update();
		}
	}
}