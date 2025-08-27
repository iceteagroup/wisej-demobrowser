using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TreeMap : TestBase
	{
		public TreeMap()
		{
			InitializeComponent();
		}

		private void TreeMap_Load(object sender, EventArgs e)
		{
			this.treeMap1.Options.tooltipSettings = new
			{
				visible = true
			};
			this.treeMap1.Options.dataSource = new object[]
			{
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Brazil",
					Count = 25
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Colombia",
					Count = 12
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Argentina",
					Count = 9
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Ecuador",
					Count = 7
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Chile",
					Count = 6
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Peru",
					Count = 3
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Venezuela",
					Count = 3
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Bolivia",
					Count = 2
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Paraguay",
					Count = 2
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Uruguay",
					Count = 2
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Falkland Islands",
					Count = 1
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "French Guiana",
					Count = 1
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Guyana",
					Count = 1
				},
				new
				{
					Title = "State wise International Airport count in South America",
					State = "Suriname",
					Count = 1
				}
			};
			this.treeMap1.Options.legendSettings = new
			{
				visible = true,
				position = "Top",
				shape = "Rectangle"
			};
			this.treeMap1.Options.weightValuePath = "Count";
			this.treeMap1.Options.equalColorValuePath = "Count";
			this.treeMap1.Options.leafItemSettings = new
			{
				showLabels = true,
				labelPath = "State",
				labelPosition = "Center",
				labelStyle = new
				{
					color = "white"
				},
				colorMapping = new object[]
				{
					new
					{
						value = 25, color = "#634D6F"
					},
					new
					{
						value = 12, color = "#B34D6D"
					},
					new
					{
						value = 9, color = "#557C5C"
					},
					new
					{
						value = 7, color = "#44537F"
					},
					new
					{
						value = 6, color = "#637392"
					},
					new
					{
						value = 3, color = "#7C754D"
					},
					new
					{
						value = 2, color = "#2E7A64"
					},
					new
					{
						value = 1, color = "#95659A"
					}
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.treeMap1.Options.renderDirection = this.comboBoxRenderDirection.Text;

			this.treeMap1.Update();
		}

		private void treeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}