using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igPivotView : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igPivotView()
		{
			InitializeComponent();
			this.igPivotView1.Call("loadTheData");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igPivotView1.Options.pivotGridOptions.allowSorting = this.checkBox2.Checked;
			this.igPivotView1.Options.pivotGridOptions.compactColumnHeaders = this.checkBox3.Checked;
			this.igPivotView1.Options.pivotGridOptions.gridOptions.alternateRowStyles = this.checkBox1.Checked;
			this.igPivotView1.Options.pivotGridOptions.gridOptions.fixedHeaders = this.checkBox4.Checked;
			this.igPivotView1.Options.pivotGridOptions.hideColumnsDropArea = this.checkBox5.Checked;
			this.igPivotView1.Options.pivotGridPanel.collapsible = this.checkBox6.Checked;

			this.igPivotView1.Update();
			this.igPivotView1.Call("loadTheData");
		}
	}
}
