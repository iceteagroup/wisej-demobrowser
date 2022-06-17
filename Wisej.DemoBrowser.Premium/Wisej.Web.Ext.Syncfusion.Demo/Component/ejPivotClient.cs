using Syncfusion.EJ.Export;
using System;
using System.Data;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPivotClient : TestBase
	{
		public ejPivotClient()
		{
			InitializeComponent();

			this.ejPivotClient1.Instance.onCellEdit += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Instance.onSaveReport += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Instance.onAfterExport += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Instance.onCellSelection += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
			this.ejPivotClient1.Instance.onCellDoubleClick += new WidgetEventHandler(ejPivotClient1_WidgetEvent);
		}

		private void ejPivotClient_Load(object sender, EventArgs e)
		{
			this.ejPivotClient1.Options.dataSource = new
			{
				data = GetDataSource(),
				rows = new[]
				{
					new {fieldName = "Country", fieldCaption = "Country"},
					new {fieldName = "State", fieldCaption = "State"},
					new {fieldName = "Date", fieldCaption = "Date"}
				},
				columns = new[]
				{
					new {fieldName = "Product", fieldCaption = "Product"}
				},
				values = new[]
				{
					new {fieldName = "Amount", fieldCaption = "Amount"}
				}
			};

			this.ejPivotClient1.Options.enableSplitter = false;
			this.ejPivotClient1.Options.title = "Relational Browser";
			this.ejPivotClient1.Options.enableMemberEditorSorting = true;

			this.ejPivotClient1.Update();
		}

		private void ejPivotClient1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPivotClient1.Options.chartType = this.comboBox1.Text.ToLower();
			this.ejPivotClient1.Options.enableCellClick = this.checkBox1.Checked;
			this.ejPivotClient1.Options.enableSplitter = this.checkBox2.Checked;

			this.ejPivotClient1.Update();
		}

		private void ejPivotClient1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.Url.Segments.Last())
			{
				case "Export":
					ExportPivotClientData(e);
					break;

				default:
					break;
			}
		}

		private void ExportPivotClientData(WebRequestEventArgs webRequestEvent)
		{
			// TODO = Wisej 3.
			//var pivotClientExport = new PivotClientExport();
			//pivotClientExport.ExportPivotClient("myPivotClient", webRequestEvent.Request.Form[0], webRequestEvent.Response);
		}

		private dynamic GetDataSource()
		{
			return new[]
			{
				new
				{
					Amount = 100, Country = "Canada", Date = "FY 2005", Product = "Bike", Quantity = 2,
					State = "Alberta"
				},
				new
				{
					Amount = 200, Country = "Canada", Date = "FY 2006", Product = "Van", Quantity = 3,
					State = "British Columbia"
				},
				new
				{
					Amount = 300, Country = "Canada", Date = "FY 2007", Product = "Car", Quantity = 4,
					State = "Brunswick"
				},
				new
				{
					Amount = 150, Country = "Canada", Date = "FY 2008", Product = "Bike", Quantity = 3,
					State = "Manitoba"
				},
				new
				{
					Amount = 200, Country = "Canada", Date = "FY 2006", Product = "Car", Quantity = 4, State = "Ontario"
				},
				new
				{
					Amount = 100, Country = "Canada", Date = "FY 2007", Product = "Van", Quantity = 1, State = "Quebec"
				},
				new
				{
					Amount = 200, Country = "France", Date = "FY 2005", Product = "Bike", Quantity = 2,
					State = "Charente-Maritime"
				},
				new
				{
					Amount = 250, Country = "France", Date = "FY 2006", Product = "Van", Quantity = 4, State = "Essonne"
				},
				new
				{
					Amount = 300, Country = "France", Date = "FY 2007", Product = "Car", Quantity = 3,
					State = "Garonne (Haute)"
				},
				new {Amount = 150, Country = "France", Date = "FY 2008", Product = "Van", Quantity = 2, State = "Gers"},
				new
				{
					Amount = 200, Country = "Germany", Date = "FY 2006", Product = "Van", Quantity = 3, State = "Bayern"
				},
				new
				{
					Amount = 250, Country = "Germany", Date = "FY 2007", Product = "Car", Quantity = 3,
					State = "Brandenburg"
				},
				new
				{
					Amount = 150, Country = "Germany", Date = "FY 2008", Product = "Car", Quantity = 4,
					State = "Hamburg"
				},
				new
				{
					Amount = 200, Country = "Germany", Date = "FY 2008", Product = "Bike", Quantity = 4,
					State = "Hessen"
				},
				new
				{
					Amount = 150, Country = "Germany", Date = "FY 2007", Product = "Van", Quantity = 3,
					State = "Nordrhein-Westfalen"
				},
				new
				{
					Amount = 100, Country = "Germany", Date = "FY 2005", Product = "Bike", Quantity = 2,
					State = "Saarland"
				},
				new
				{
					Amount = 150, Country = "United Kingdom", Date = "FY 2008", Product = "Bike", Quantity = 5,
					State = "England"
				},
				new
				{
					Amount = 250, Country = "United States", Date = "FY 2007", Product = "Car", Quantity = 4,
					State = "Alabama"
				},
				new
				{
					Amount = 200, Country = "United States", Date = "FY 2005", Product = "Van", Quantity = 4,
					State = "California"
				},
				new
				{
					Amount = 100, Country = "United States", Date = "FY 2006", Product = "Bike", Quantity = 2,
					State = "Colorado"
				},
				new
				{
					Amount = 150, Country = "United States", Date = "FY 2008", Product = "Car", Quantity = 3,
					State = "New Mexico"
				},
				new
				{
					Amount = 200, Country = "United States", Date = "FY 2005", Product = "Bike", Quantity = 4,
					State = "New York"
				},
				new
				{
					Amount = 250, Country = "United States", Date = "FY 2008", Product = "Car", Quantity = 3,
					State = "North Carolina"
				},
				new
				{
					Amount = 300, Country = "United States", Date = "FY 2007", Product = "Van", Quantity = 4,
					State = "South Carolina"
				}
			};
		}
	}
}