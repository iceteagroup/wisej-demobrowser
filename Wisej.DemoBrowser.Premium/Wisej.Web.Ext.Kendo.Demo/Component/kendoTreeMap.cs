using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeMap : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTreeMap()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (this.checkedListBoxColors.CheckedItems.Count > 0)
				this.kendoTreeMap1.Options.colors = this.checkedListBoxColors.CheckedItems;
			
			this.kendoTreeMap1.Options.type = this.comboBoxType.SelectedItem.ToString()?.ToLower();

			this.kendoTreeMap1.Update();
		}
	}
}
