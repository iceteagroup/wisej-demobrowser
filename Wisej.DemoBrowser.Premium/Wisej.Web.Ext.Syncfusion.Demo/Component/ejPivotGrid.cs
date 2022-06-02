using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPivotGrid : TestBase
	{
		public ejPivotGrid()
		{
			InitializeComponent();

			this.ejPivotGrid1.Instance.onCellEdit += new WidgetEventHandler(ejPivotGrid1_WidgetEvent);
			this.ejPivotGrid1.Instance.onCellClick += new WidgetEventHandler(ejPivotGrid1_WidgetEvent);
		}

		private void ejPivotGrid_Load(object sender, EventArgs e)
		{
			this.ejPivotGrid1.Options.dataSource = new
			{
				data = new object[]
				{
					new
					{
						amount = 100, country = "Canada",
						date = "FY 2005",
						product = "Bike",
						quantity = 2, state = "Alberta"
					},
					new
					{
						amount = 200, country = "Canada",
						date = "FY 2006",
						product = "Van",
						quantity = 3, state = "British Columbia"
					},
					new
					{
						amount = 300, country = "Canada",
						date = "FY 2007",
						product = "Car",
						quantity = 4, state = "Brunswick"
					},
					new
					{
						amount = 150, country = "Canada",
						date = "FY 2008",
						product = "Bike",
						quantity = 3, state = "Manitoba"
					},
					new
					{
						amount = 200, country = "Canada",
						date = "FY 2006",
						product = "Car",
						quantity = 4, state = "Ontario"
					},
					new
					{
						amount = 100, country = "Canada",
						date = "FY 2007",
						product = "Van",
						quantity = 1, state = "Quebec"
					},
					new
					{
						amount = 200, country = "France",
						date = "FY 2005",
						product = "Bike",
						quantity = 2, state = "Charente-Maritime"
					},
					new
					{
						amount = 250, country = "France",
						date = "FY 2006",
						product = "Van",
						quantity = 4, state = "Essonne"
					},
					new
					{
						amount = 300, country = "France",
						date = "FY 2007",
						product = "Car",
						quantity = 3, state = "Garonne (Haute)"
					},
					new
					{
						amount = 150, country = "France",
						date = "FY 2008",
						product = "Van",
						quantity = 2, state = "Gers"
					},
					new
					{
						amount = 200, country = "Germany",
						date = "FY 2006",
						product = "Van",
						quantity = 3, state = "Bayern"
					},
					new
					{
						amount = 250, country = "Germany",
						date = "FY 2007",
						product = "Car",
						quantity = 3, state = "Brandenburg"
					},
					new
					{
						amount = 150, country = "Germany",
						date = "FY 2008",
						product = "Car",
						quantity = 4, state = "Hamburg"
					},
					new
					{
						amount = 200, country = "Germany",
						date = "FY 2008",
						product = "Bike",
						quantity = 4, state = "Hessen"
					},
					new
					{
						amount = 150, country = "Germany",
						date = "FY 2007",
						product = "Van",
						quantity = 3, state = "Nordrhein-Westfalen"
					},
					new
					{
						amount = 100, country = "Germany",
						date = "FY 2005",
						product = "Bike",
						quantity = 2, state = "Saarland"
					},
					new
					{
						amount = 150, country = "United Kingdom",
						date = "FY 2008",
						product = "Bike",
						quantity = 5, state = "England"
					},
					new
					{
						amount = 250, country = "United States",
						date = "FY 2007",
						product = "Car",
						quantity = 4, state = "Alabama"
					},
					new
					{
						amount = 200, country = "United States",
						date = "FY 2005",
						product = "Van",
						quantity = 4, state = "California"
					},
					new
					{
						amount = 100, country = "United States",
						date = "FY 2006",
						product = "Bike",
						quantity = 2, state = "Colorado"
					},
					new
					{
						amount = 150, country = "United States",
						date = "FY 2008",
						product = "Car",
						quantity = 3, state = "New Mexico"
					},
					new
					{
						amount = 200, country = "United States",
						date = "FY 2005",
						product = "Bike",
						quantity = 4, state = "New York"
					},
					new
					{
						amount = 250, country = "United States",
						date = "FY 2008",
						product = "Car",
						quantity = 3, state = "North Carolina"
					},
					new
					{
						amount = 300, country = "United States",
						date = "FY 2007",
						product = "Van",
						quantity = 4, state = "South Carolina"
					}
				},
				rows = new object[]
				{
					new
					{
						fieldName = "country",
						fieldCaption = "Country"
					},
					new
					{
						fieldName = "state",
						fieldCaption = "State"
					}
				},
				columns = new object[]
				{
					new
					{
						fieldName = "product",
						fieldCaption = "Product"
					}
				},
				values = new object[]
				{
					new
					{
						fieldName = "amount",
						fieldCaption = "Amount"
					},
					new
					{
						fieldName = "quantity",
						fieldCaption = "Quantity"
					}
				}
			};
			this.ejPivotGrid1.Options.isResponsive = true;
			this.ejPivotGrid1.Options.headerSettings = new
			{
				showRowItems = true,
				showColumnItems = true
			};
		}
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPivotGrid1.Options.enableCellClick = this.checkBox1.Checked;
			this.ejPivotGrid1.Options.enableColumnGrandTotal = this.checkBox4.Checked;
			this.ejPivotGrid1.Options.headerSettings.showRowItems = this.checkBox2.Checked;
			this.ejPivotGrid1.Options.headerSettings.showColumnItems = this.checkBoxShow3.Checked;

			this.ejPivotGrid1.Update();
		}

		private void ejPivotGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejPivotGrid1.Instance.setJSONRecords(JSON.Stringify(json));

					this.ejPivotGrid1.Update();
				}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejPivotGrid1.Instance.getJSONRecordsAsync();
			var json = Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "pivotgrid.json");
		}
	}
}