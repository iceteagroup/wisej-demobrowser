using System;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DropDownTree : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DropDownTree()
		{
			InitializeComponent();

			this.dropDownTree1.Instance.onChange += new WidgetEventHandler(dropDownTree1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dropDownTree1.Options.placeholder = this.textBoxPlaceholder.Text;
			this.dropDownTree1.Options["readonly"] = this.checkBoxReadOnly.Checked;
			this.dropDownTree1.Options.allowFiltering = this.checkBoxFiltering.Checked;
			this.dropDownTree1.Options.allowMultiSelection = this.checkBoxMultiSelection.Checked;
		   
			this.dropDownTree1.Update();
		}

		private void dropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
