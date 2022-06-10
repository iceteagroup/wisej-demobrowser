using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class PivotView : TestBase
	{
		public PivotView()
		{
			InitializeComponent();
		}

		private void PivotView_Load(object sender, EventArgs e)
		{
			this.pivotView1.Options.dataSourceSettings = new
			{
				dataSource = new object[]
				{
					new
					{
						Sold = 31, Amount = 52824, Country = "France",
						Products = "Mountain Bikes",
						Year = "FY 2015",
						Quarter = "Q1"
					},
					new
					{
						Sold = 51, Amount = 86904, Country = "France",
						Products = "Mountain Bikes",
						Year = "FY 2015",
						Quarter = "Q2"
					},
					new
					{
						Sold = 90, Amount = 153360, Country = "France",
						Products = "Mountain Bikes",
						Year = "FY 2015",
						Quarter = "Q3"
					},
					new
					{
						Sold = 25, Amount = 42600, Country = "France",
						Products = "Mountain Bikes",
						Year = "FY 2015",
						Quarter = "Q4"
					},
					new
					{
						Sold = 27, Amount = 46008, Country = "France",
						Products = "Mountain Bikes",
						Year = "FY 2016",
						Quarter = "Q1"
					}
				},
				expandAll = false,
				enableSorting = true,
				columns = new object[]
				{
					new
					{
						name = "Year",
						caption = "Production Year"
					},
					new
					{
						name = "Quarter"
					}
				},
				values = new object[]
				{
					new
					{
						name = "Sold",
						caption = "Units Sold"
					},
					new
					{
						name = "Amount",
						caption = "Sold Amount"
					}
				},
				rows = new object[]
				{
					new
					{
						name = "Products"
					}
				},
				filters = new object[]
				{
					new
					{
						name = "Country"
					}
				},
				formatSettings = new object[]
				{
					new
					{
						name = "Amount",
						format = "C0"
					}
				}
			};
			this.pivotView1.Options.groupingBarSettings = new
			{
				showFilterIcon = true,
				showSortIcon = true,
				showRemoveIcon = true,
				showValueTypeIcon = true
			};
			this.pivotView1.Options.showFieldList = true;
			this.pivotView1.Options.showGroupingBar = true;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.pivotView1.Options.groupingBarSettings.showSortIcon = this.checkBoxSortIcon.Checked;
			this.pivotView1.Options.groupingBarSettings.showFilterIcon = this.checkBoxFilterIcon.Checked;
			this.pivotView1.Options.groupingBarSettings.showRemoveIcon = this.checkBoxRemoveIcon.Checked;
			this.pivotView1.Options.groupingBarSettings.showValueTypeIcon = this.checkBoxValueTypeIcon.Checked;

			//for force refresh
			this.pivotView1.Instance.refresh();

			this.pivotView1.Update();
		}
	}
}