using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class PivotView : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public PivotView()
		{
			InitializeComponent();
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
