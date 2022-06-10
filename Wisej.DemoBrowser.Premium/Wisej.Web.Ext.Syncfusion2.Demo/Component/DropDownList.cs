using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DropDownList : TestBase
	{
		public DropDownList()
		{
			InitializeComponent();

			this.dropDownList1.Instance.onChange += new WidgetEventHandler(dropDownList1_WidgetEvent);
		}

		private void DropDownList_Load(object sender, EventArgs e)
		{
			this.dropDownList1.Options.dataSource = new object[]
			{
				"Aberdeen", "Abilene", "Akron", "Albany", "Albuquerque", "Alexandria", "Allentown", "Amarillo",
				"Anaheim", "Anchorage", "Ann Arbor", "Antioch", "Apple Valley", "Appleton", "Arlington", "Arvada",
				"Asheville", "Athens", "Atlanta", "Atlantic City", "Augusta", "Aurora", "Austin", "Bakersfield",
				"Baltimore", "Barnstable", "Baton Rouge", "Beaumont", "Bel Air", "Bellevue", "Berkeley"
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dropDownList1.Options.sortOrder = this.comboBoxSortOrder.Text;
			if (this.checkBoxSearchable.Checked)
				this.dropDownList1.Options.filterBarPlaceholder = "Search ...";
			this.dropDownList1.Options.allowFiltering = this.checkBoxSearchable.Checked;
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