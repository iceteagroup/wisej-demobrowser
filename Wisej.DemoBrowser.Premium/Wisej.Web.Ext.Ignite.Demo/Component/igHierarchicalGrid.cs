using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igHierarchicalGrid : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igHierarchicalGrid()
		{
			InitializeComponent();

			this.igHierarchicalGrid1.Instance.cellClick += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent); 
			this.igHierarchicalGrid1.Instance.rowCollapsed += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent);
			this.igHierarchicalGrid1.Instance.cellRightClick += new WidgetEventHandler(igHierarchicalGrid_WidgetEvent);
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
			this.igHierarchicalGrid1.AddItem(new
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
			this.igHierarchicalGrid1.Options.enableHoverStyles = this.checkBox1.Checked;
			this.igHierarchicalGrid1.Options.alternateRowStyles = this.checkBox2.Checked;
			this.igHierarchicalGrid1.Options.expandCollapseAnimations = this.checkBox3.Checked;
			this.igHierarchicalGrid1.Options.fixedFooters = this.checkBox4.Checked;
			this.igHierarchicalGrid1.Options.fixedHeaders = this.checkBox5.Checked;

			this.igHierarchicalGrid1.Update();
		}
	}
}
