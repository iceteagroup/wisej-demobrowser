using Syncfusion.EJ.Export;
using System;
using System.Data;
using System.Linq;
using System.Web;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPivotClient : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
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
			// TODO: Wisej 3.
			//var pivotClientExport = new PivotClientExport();
			//pivotClientExport.ExportPivotClient("myPivotClient", webRequestEvent.Request.Form[0], webRequestEvent.Response);
		}

		private DataTable GenerateDataSource()
		{
			// table setup.
			var dt = new DataTable();

			dt.Columns.Add("amount", typeof(decimal));
			dt.Columns.Add("country", typeof(string));
			dt.Columns.Add("date", typeof(string));
			dt.Columns.Add("product", typeof(string));
			dt.Columns.Add("quantity", typeof(int));
			dt.Columns.Add("state", typeof(string));

			// adding rows.

			// ca.
			dt.Rows.Add(100, "Canada", "FY 2005", "Bike", 2, "Alberta");
			dt.Rows.Add(200, "Canada", "FY 2006", "Van", 3, "British Columbia");
			dt.Rows.Add(300, "Canada", "FY 2007", "Car", 4, "Brunswick");
			dt.Rows.Add(150, "Canada", "FY 2008", "Bike", 3, "Manitoba");
			dt.Rows.Add(200, "Canada", "FY 2006", "Car", 4, "Ontario");
			dt.Rows.Add(100, "Canada", "FY 2007", "Van", 1, "Quebec");

			// fr.
			dt.Rows.Add(200, "France", "FY 2005", "Bike", 2, "Charente-Maritime");
			dt.Rows.Add(250, "France", "FY 2006", "Van", 4, "Essonne");
			dt.Rows.Add(300, "France", "FY 2007", "Car", 3, "Garonne (Haute)");
			dt.Rows.Add(150, "France", "FY 2008", "Van", 2, "Gers");

			// de.
			dt.Rows.Add(200, "Germany", "FY 2006", "Van", 3, "Bayern");
			dt.Rows.Add(250, "Germany", "FY 2007", "Car", 3, "Bradenburg");
			dt.Rows.Add(150, "Germany", "FY 2008", "Car", 4, "Hamburg");
			dt.Rows.Add(200, "Germany", "FY 2008", "Bike", 4, "Hessen");
			dt.Rows.Add(150, "Germany", "FY 2007", "Van", 3, "Nordrhein-Westfalen");
			dt.Rows.Add(100, "Germany", "FY 2005", "Bike", 2, "Saarland");

			// uk.
			dt.Rows.Add(150, "United Kingdom", "FY 2008", "Bike", 5, "England");

			// us.
			dt.Rows.Add(250, "United States", "FY 2007", "Car", 4, "Alabama");
			dt.Rows.Add(200, "United States", "FY 2005", "Van", 4, "California");
			dt.Rows.Add(100, "United States", "FY 2006", "Bike", 2, "Colorado");
			dt.Rows.Add(150, "United States", "FY 2008", "Car", 3, "New Mexico");
			dt.Rows.Add(200, "United States", "FY 2005", "Bike", 4, "New York");
			dt.Rows.Add(250, "United States", "FY 2008", "Car", 3, "North Carolina");
			dt.Rows.Add(300, "United States", "FY 2007", "Van", 4, "South Carolina");

			return dt;
		}

		private void ejPivotClient_Load(object sender, EventArgs e)
		{
			// apply data source.
			this.ejPivotClient1.Options.dataSource = new
			{
				data = GenerateDataSource(),
				// apply rows.
				rows = new[]
				{
					new { fieldName = "country", fieldCaption = "Country" },
					new { fieldName = "state", fieldCaption = "State" },
					new { fieldName = "date", fieldCaption = "Date" },
				},
				// specify the columns to show.
				columns = new[]
				{
					new { fieldName = "product", fieldCaption = "Product" }
				},
				// specify the data you want to visualize.
				values = new[]
				{
					new { fieldName = "amount", fieldCaption = "Amount" }
				}
			};

			// apply title.
			this.ejPivotClient1.Options.title = "Relational Browser";

			// apply splitter.
			this.ejPivotClient1.Options.enableSplitter = true;

			// apply member editor sorting.
			this.ejPivotClient1.Options.enableMemberEditorSorting = true;

			// force update the JS client widget with the new configuration.
			this.ejPivotClient1.Update();
		}
	}
}
