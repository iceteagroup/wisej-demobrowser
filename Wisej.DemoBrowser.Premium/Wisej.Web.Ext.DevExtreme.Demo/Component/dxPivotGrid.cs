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

			this.dxPivotGrid1.Options.dataSource = new
			{
				fields = this.dxPivotGrid1.Options.dataSource.fields,
				store = JSON.Parse(File.ReadAllText(Application.MapPath("Data/PivotGrid/sales.json")))
			};
			this.dxPivotGrid1.Update();
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
			this.dxPivotGrid1.Options.allowExpandAll = this.checkBox1.Checked;
			this.dxPivotGrid1.Options.allowFiltering = this.checkBox2.Checked;
			this.dxPivotGrid1.Options.allowSorting = this.checkBox3.Checked;
			this.dxPivotGrid1.Options.hideEmptySummaryCells = this.checkBox4.Checked;
			this.dxPivotGrid1.Options.showBorder = this.checkBox5.Checked;
			this.dxPivotGrid1.Options.showColumnTotals = this.checkBox7.Checked;
			this.dxPivotGrid1.Options.showRowGrandTotals = this.checkBox8.Checked;
			this.dxPivotGrid1.Options.showRowTotals = this.checkBox9.Checked;

			this.dxPivotGrid1.Update();
		}
	}
}
