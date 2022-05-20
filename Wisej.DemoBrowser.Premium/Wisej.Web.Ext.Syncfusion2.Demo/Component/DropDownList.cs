using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DropDownList : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DropDownList()
		{
			InitializeComponent();

			this.dropDownList1.Instance.onChange += new WidgetEventHandler(dropDownList1_WidgetEvent);
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

		private void dropDownList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
    }
}
