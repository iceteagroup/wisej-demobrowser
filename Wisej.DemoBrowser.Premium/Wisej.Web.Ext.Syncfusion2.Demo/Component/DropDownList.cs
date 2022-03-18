using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DropDownList : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DropDownList()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dropDownList1.Options.sortOrder = this.comboBoxSortOrder.Text;
			if (checkBoxSearchable.Checked)
				this.dropDownList1.Options.filterBarPlaceholder = "Search ...";
			this.dropDownList1.Options.allowFiltering = checkBoxSearchable.Checked;
			this.dropDownList1.Options.dataSource = this.tagTextBoxDataSource.Text.Split(',');

			this.dropDownList1.Update();
        }
    }
}
