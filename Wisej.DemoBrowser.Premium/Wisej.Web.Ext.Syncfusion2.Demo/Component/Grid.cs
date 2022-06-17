using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Grid : TestBase
	{
		public Grid()
		{
			InitializeComponent();

			this.grid1.Instance.onRecordClick += new WidgetEventHandler(grid1_WidgetEvent);
		}

		private void Grid_Load(object sender, EventArgs e)
		{
			this.grid1.Options.dataSource = new object[]
			{
				new
				{
					OrderID = 10248, CustomerID = "VINET",
					Freight = 32.38, Store = "Store 1",
					OrderDate = "1996-07-03T02:30:00.000"
				},
				new
				{
					OrderID = 10249, CustomerID = "TOMSP",
					Freight = 11.61, Store = "Store 2",
					OrderDate = "1996-07-04T02:30:00.000"
				},
				new
				{
					OrderID = 10250, CustomerID = "HANAR",
					Freight = 65.83, Store = "Store 3",
					OrderDate = "1996-07-07T02:30:00.000"
				},
				new
				{
					OrderID = 10251, CustomerID = "VICTE",
					Freight = 41.34, Store = "Store 1",
					OrderDate = "1996-07-08T02:30:00.000"
				},
				new
				{
					OrderID = 10252, CustomerID = "SUPRD",
					Freight = 51.3, Store = "Store 2",
					OrderDate = "1996-07-07T02:30:00.000"
				},
				new
				{
					OrderID = 10253, CustomerID = "HANAR",
					Freight = 58.17, Store = "Store 3",
					OrderDate = "1996-07-09T02:30:00.000"
				},
				new
				{
					OrderID = 10254, CustomerID = "CHOPS",
					Freight = 22.98, Store = "Store 1",
					OrderDate = "1996-07-10T02:30:00.000"
				},
				new
				{
					OrderID = 10255, CustomerID = "RICSU",
					Freight = 148.33, Store = "Store 2",
					OrderDate = "1996-07-11T02:30:00.000"
				},
				new
				{
					OrderID = 10256, CustomerID = "WELLI",
					Freight = 13.97, Store = "Store 3",
					OrderDate = "1996-07-14T02:30:00.000"
				}
			};
			this.grid1.Options.columns = new object[]
			{
				new
				{
					field = "OrderID",
					headerText = "Order ID",
					textAlign = "Right",
					width = 120, type = "number"
				},
				new
				{
					field = "Store",
					headerText = "Store",
					textAlign = "Right",
					width = 120, type = "string"
				},
				new
				{
					field = "CustomerID",
					width = 140, headerText = "Customer ID",
					type = "string"
				},
				new
				{
					field = "Freight",
					headerText = "Freight",
					textAlign = "Right",
					width = 120, format = "C"
				},
				new
				{
					field = "OrderDate",
					headerText = "Order Date",
					width = 140, format = "yMd"
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.grid1.Options.gridLines = this.comboBoxGridLine.Text;
			this.grid1.Options.allowGrouping = this.checkBoxGrouping.Checked;
			this.grid1.Options.allowResizing = this.checkBoxResizing.Checked;
			this.grid1.Options.allowFiltering = this.checkBoxFiltering.Checked;
			this.grid1.Options.allowReordering = this.checkBoxReordering.Checked;

			this.grid1.Update();
		}

		private void grid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}