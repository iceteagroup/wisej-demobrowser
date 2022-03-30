using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDropDownList : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDropDownList()
		{
			InitializeComponent();

			this.ejDropDownList1.Instance.onChange += new WidgetEventHandler(ejDropDownList_WidgetEvent);
		}

		private void ejDropDownList_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$@"<b>{e.Type}</b><br/>
				{e.Data}",
				MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Update(this.ejDropDownList1);
			Update(this.ejDropDownList2);
		}

		private void Update(Wisej.Web.Ext.Syncfusion.ejDropDownList ejList)
		{
			ejList.Options.allowVirtualScrolling = this.checkBox1.Checked;
			ejList.Options.caseSensitiveSearch = this.checkBox2.Checked;
			ejList.Options.enableIncrementalSearch = this.checkBox3.Checked;
			ejList.Options.enableFilterSearch = this.checkBox4.Checked;
			ejList.Options.enableSorting = this.checkBox5.Checked;
			ejList.Options.showCheckbox = this.checkBox6.Checked;

			ejList.Update();
		}
	}
}
