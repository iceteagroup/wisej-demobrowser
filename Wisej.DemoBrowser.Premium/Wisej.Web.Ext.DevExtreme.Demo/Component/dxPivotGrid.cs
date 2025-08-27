using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxPivotGrid : TestBase
	{
		public dxPivotGrid()
		{
			InitializeComponent();
		}

		private void dxPivotGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxPivotGrid1.Options.hideEmptySummaryCells = this.checkBox4.Checked;
			this.dxPivotGrid1.Options.showColumnTotals = this.checkBox7.Checked;
			this.dxPivotGrid1.Options.showRowGrandTotals = this.checkBox8.Checked;
			this.dxPivotGrid1.Options.showRowTotals = this.checkBox9.Checked;

			this.dxPivotGrid1.Update();
		}

        private void dxPivotGrid_Load(object sender, EventArgs e)
        {
			this.dxPivotGrid1.Options.dataSource = new
			{
				fields = new object[]
                {
                    new
                    {
						caption = "Region",
						width = 120,
						dataField = "region",
						area = "row"
					},
					new
					{
						caption = "City",
						width = 150,
						dataField = "city",
						area = "row"
					},
					new
					{
						dataField = "date",
						dataType = "date",
						area = "column"
					},
					new
					{
						caption = "Sales",
						dataField = "amount",
						dataType = "number",
						summaryType = "sum",
						format = "currency",
						area = "data"
					},

				},
				store = JSON.Parse(File.ReadAllText(Application.MapPath("Data/PivotGrid/sales.json")))
			};
			this.dxPivotGrid1.Update();

			this.dxPivotGrid1.Update();
        }
    }
}
