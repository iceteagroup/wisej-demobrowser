using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTreeMap : TestBase
	{
		public dxTreeMap()
		{
			InitializeComponent();

			this.dxTreeMap1.Instance.onClick += new WidgetEventHandler(dxTreeMap1_WidgetEvent);
		}

		private void dxTreeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTreeMap1.Options.interactWithGroup = this.checkBox1.Checked;
			this.dxTreeMap1.Options.layoutDirection = this.comboBox1.SelectedItem;
			this.dxTreeMap1.Options.colorizer = new
			{
				palette = this.comboBox2.SelectedItem
			};

			this.dxTreeMap1.Update();
		}

        private void dxTreeMap_Load(object sender, EventArgs e)
        {
			this.dxTreeMap1.Options = new
			{
				title = "The Most Populated Cities by Continents",
				idField = "id",
				parentField = "parentId",
				onClick = "function (e) { e.node.select(!e.node.isSelected());} ",
				dataSource =  new object[]
                {
                    new {
                        id =  "1",
                        name =  "Africa"
                    },
                    new {
                        id =  "1_1",
                        parentId =  "1",
                        value =  21324000,
                        name =  "Lagos",
                        country =  "Nigeria"
                    },
                    new {
                        id =  "1_2",
                        parentId =  "1",
                        value =  9735000,
                        name =  "Kinshasa",
                        country =  "Democratic Republic of the Congo"
                    },
                    new {
                        id =  "1_3",
                        parentId =  "1",
                        value =  9278441,
                        name =  "Cairo",
                        country =  "Egypt"
                    },
                    new {
                        id =  "2",
                        name =  "Asia"
                    },
                    new {
                        id =  "2_1",
                        parentId =  "2",
                        value =  24256800,
                        name =  "Shanghai",
                        country =  "China"
                    },
                    new {
                        id =  "2_2",
                        parentId =  "2",
                        value =  23500000,
                        name =  "Karachi",
                        country =  "Pakistan"
                    },
                    new {
                        id =  "2_3",
                        parentId =  "2",
                        value =  21516000,
                        name =  "Beijing",
                        country =  "China"
                    },
                    new {
                        id =  "2_4",
                        parentId =  "2",
                        value =  16787941,
                        name =  "Delhi",
                        country =  "India"
                    },
                    new {
                        id =  "2_5",
                        parentId =  "2",
                        value =  15200000,
                        name =  "Tianjin",
                        country =  "China"
                    },
                    new {
                        id =  "3",
                        name =  "Australia"
                    },
                    new {
                        id =  "3_1",
                        parentId =  "3",
                        value =  4840600,
                        name =  "Sydney",
                        country =  "Austraila"
                    },
                    new {
                        id =  "3_2",
                        parentId =  "3",
                        value =  4440000,
                        name =  "Melbourne",
                        country =  "Austraila"
                    },
                    new {
                        id =  "4",
                        name =  "Europe"
                    },
                    new {
                        id =  "4_1",
                        parentId =  "4",
                        value =  14160467,
                        name =  "Istanbul",
                        country =  "Turkey"
                    },
                    new {
                        id =  "4_2",
                        parentId =  "4",
                        value =  12197596,
                        name =  "Moscow",
                        country =  "Russia"
                    },
                    new {
                        id =  "4_3",
                        parentId =  "4",
                        value =  8538689,
                        name =  "London",
                        country =  "United Kingdom"
                    },
                    new {
                        id =  "4_4",
                        parentId =  "4",
                        value =  5191690,
                        name =  "Saint Petersburg",
                        country =  "Russia"
                    },
                    new {
                        id =  "4_5",
                        parentId =  "4",
                        value =  4470800,
                        name =  "Ankara",
                        country =  "Turkey"
                    },
                    new {
                        id =  "4_6",
                        parentId =  "4",
                        value =  3517424,
                        name =  "Berlin",
                        country =  "Germany"
                    },
                    new {
                        id =  "5",
                        name =  "North America"
                    },
                    new {
                        id =  "5_1",
                        parentId =  "5",
                        value =  8874724,
                        name =  "Mexico City",
                        country =  "Mexico"
                    },
                    new {
                        id =  "5_2",
                        parentId =  "5",
                        value =  8550405,
                        name =  "New York City",
                        country =  "United States"
                    },
                    new {
                        id =  "5_3",
                        parentId =  "5",
                        value =  3884307,
                        name =  "Los Angeles",
                        country =  "United States"
                    },
                    new {
                        id =  "5_4",
                        parentId =  "5",
                        value =  2808503,
                        name =  "Toronto",
                        country =  "Canada"
                    },
                    new {
                        id =  "6",
                        name =  "South America"
                    },
                    new {
                        id =  "6_1",
                        parentId =  "6",
                        value =  11895893,
                        name =  "São Paulo",
                        country =  "Brazil"
                    },
                    new {
                        id =  "6_2",
                        parentId =  "6",
                        value =  8693387,
                        name =  "Lima",
                        country =  "Peru"
                    },
                    new {
                        id =  "6_3",
                        parentId =  "6",
                        value =  7776845,
                        name =  "Bogotá",
                        country =  "Colombia"
                    },
                    new {
                        id =  "6_4",
                        parentId =  "6",
                        value =  6429923,
                        name =  "Rio de Janeiro",
                        country =  "Brazil"
                    }
                }
			};

			this.dxTreeMap1.Update();
        }
    }
}
