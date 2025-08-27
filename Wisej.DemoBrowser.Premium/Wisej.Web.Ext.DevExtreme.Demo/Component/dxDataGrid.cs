using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxDataGrid : TestBase
	{
		public dxDataGrid()
		{
			InitializeComponent();

			this.dxDataGrid1.Instance.onCellClick += new WidgetEventHandler(dxDataGrid1_WidgetEvent);
		}

		private void dxDataGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxDataGrid1.Options.cellHintEnabled = this.checkBox4.Checked;
			this.dxDataGrid1.Options.columnAutoWidth = this.checkBox5.Checked;
			this.dxDataGrid1.Options.searchPanel.visible = this.checkBox6.Checked;
			this.dxDataGrid1.Options.allowColumnResizing = this.checkBox2.Checked;
			this.dxDataGrid1.Options.allowColumnReordering = this.checkBox1.Checked;
			this.dxDataGrid1.Options.autoNavigateToFocusedRow = this.checkBox3.Checked;

			this.dxDataGrid1.Update();
		}

		private void buttonExport_Click(object sender, EventArgs e)
			=> this.dxDataGrid1.Instance.exportToExcel(false);

		private void dxDataGrid_Load(object sender, EventArgs e)
		{

			this.dxDataGrid1.Options = new
			{
				paging = new
                {
					pageSize = 10
                },
				pager = new
				{
					showPageSizeSelector = true,
					allowedPageSizes = new int[] {10,25,50,100}
				},
				selection = new
                {
					mode = "single"
                },
				hoverStateEnabled = true,
				remoteOperations = false,
				searchPanel = new
                {
					visible = true,
					highlightCaseSensitive = true
				},
				groupPanel = new
                {
					visible = true
                },
				grouping = new
                {
					autoExpandAll = true
				},
				showBorders = true,
				columns = new object[] {
                    new
                    {
						dataField = "Product",
						groupIndex = 0
                    },
                    new
                    {
						dataField = "Amount",
						caption = "Sale Amount",
						dataType = "number",
						format = "currency",
						alignment = "right"
					},
                    new
                    {
						dataField = "SaleDate",
						dataType = "date"
                    },
					new
					{
						dataField = "Region",
						dataType = "string"
					},
					new
					{
						dataField = "Sector",
						dataType = "string"
					},
					new
					{
						dataField = "Channel",
						dataType = "string"
					},
					new
					{
						dataField = "Customer",
						dataType = "string",
						width = 150
					}
				},
				dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/DataGrid/data.json")))
			};
			this.dxDataGrid1.Update();
		}
	}
}
