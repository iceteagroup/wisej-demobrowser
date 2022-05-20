using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igHierarchicalGrid : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igHierarchicalGrid()
		{
			InitializeComponent();

			this.igHierarchicalGrid1.Instance.onCellClick += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent); 
			this.igHierarchicalGrid1.Instance.onRowCollapsed += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent);
			this.igHierarchicalGrid1.Instance.onCellRightClick += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent);
		}

		private void igHierarchicalGrid_Load(object sender, EventArgs e)
		{
			var data = File.ReadAllText(Application.MapPath("Data/Hierarchical/data.json"));
			var json = JSON.Parse(data);

			this.igHierarchicalGrid1.Options.dataSource = json;
			this.igHierarchicalGrid1.Options.dataSourceType = "json";
			this.igHierarchicalGrid1.Options.responseDataKey = "results";
			this.igHierarchicalGrid1.Options.autoGenerateColumns = false;
			this.igHierarchicalGrid1.Options.autofitLastColumn = false;
			this.igHierarchicalGrid1.Options.primaryKey = "EmployeeID";
			this.igHierarchicalGrid1.Options.caption = "Sales Data";

			this.igHierarchicalGrid1.Options.columns = new dynamic[]
			{
				new { key = "EmployeeID", headerText = "Employee ID", dataType = "number", width = "0%", hidden = true },
				new { key = "LastName", headerText = "Last Name", dataType = "string", width = "20%" },
				new { key = "FirstName", headerText = "First Name", dataType = "string", width = "20%" },
				new { key = "Title", headerText = "Title", dataType = "string", width = "20%" },
				new { key = "City", headerText = "City", dataType = "string", width = "15%" },
				new { key = "IsUSA", headerText = "In USA", unbound = true, dataType = "bool", width = "15%", format = "checkbox" },
				new { key = "Region", headerText = "Region", dataType = "string", width = "10%" },
				new { key = "Country", headerText = "Country", dataType = "string", width = "0%", hidden = true }
			};
			this.igHierarchicalGrid1.Options.autoGenerateLayouts = false;
			this.igHierarchicalGrid1.Options.columnLayouts = new dynamic[]
			{
				new {
					key = "Orders",
					autoGenerateColumns = false,
					autofitLastColumn = false,
					primaryKey = "OrderID",
					width = "100%",
					columns = new dynamic[]
					{
						new { key = "OrderID", headerText = "Order ID", dataType = "number", width = "0%", hidden = true },
						new { key = "CustomerID", headerText = "Customer ID", dataType = "string", width = "15%" },
						new { key = "Freight", headerText = "Freight", dataType = "number", format = "0.00", width = "15%" },
						new { key = "FreightExpence", headerText = "Freight Expense", unbound = true, dataType = "number", format = "0.00", width = "20%", formula = "CalculateFreightExpence" },
						new { key = "ShipName", headerText = "Ship Name", dataType = "string", width = "25%" },
						new { key = "ShipCity", headerText = "Ship City", dataType = "string", width = "15%" },
					},
					features = new dynamic[]
					{
						new {
							name = "Responsive",
							enableVerticalRendering = false,
							columnSettings = new[]
							{
								new {
									columnKey = "Freight",
									classes = "ui-hidden-phone"
								},
								new {
									columnKey = "CustomerID",
									classes = "ui-hidden-phone"

								},
								new {
									columnKey = "ShipName",
									classes = "ui-hidden-phone"

								}
							}
						},
						new {
							name = "Paging",
							type = "local",
							pageSize = 5

						}
					}
				}
			};
		}

		private void igHierarchicalGrid_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igHierarchicalGrid1.Instance.addItem(new
			{
				OrderID = 102554,
				CustomerID = "FISH",
				EmployeeID = 1,
				OrderDate = "1996-07-18T00:00:00",
				RequiredDate = "1996-08-15T00:00:00",
				ShippedDate = "1996-07-24T00:00:00",
				ShipVia = 1,
				Freight = "456.5100",
				ShipName = "Fish Erman",
				ShipAddress = "123 Cherry St",
				ShipCity = "Chicago",
				ShipRegion = "",
				ShipPostalCode = "44444",
				ShipCountry = "United States"
			});
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igHierarchicalGrid1.Options.caption = this.textBoxCaption.Text;
			this.igHierarchicalGrid1.Options.enableHoverStyles = this.checkBoxHoverStyles.Checked;
			this.igHierarchicalGrid1.Options.expandCollapseAnimations = this.checkBoxAnimations.Checked;
			this.igHierarchicalGrid1.Options.alternateRowStyles = this.checkBoxAlternateRowStyles.Checked;

			this.igHierarchicalGrid1.Update();
		}
	}
}
