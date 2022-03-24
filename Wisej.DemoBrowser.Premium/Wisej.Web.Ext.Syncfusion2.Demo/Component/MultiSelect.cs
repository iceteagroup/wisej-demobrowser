using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class MultiSelect : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public MultiSelect()
		{
			InitializeComponent();

			this.multiSelect1.Instance.onSelect += new WidgetEventHandler(multiSelect1_select);
			this.multiSelect1.Instance.onRemoved += new WidgetEventHandler(multiSelect1_removed);
		}

        private void multiSelect1_removed(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
															   MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void multiSelect1_select(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
												   MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.multiSelect1.Options.mode = this.comboBoxMode.Text;
			this.multiSelect1.Options.openOnClick = this.checkBoxCustomValue.Checked;
			this.multiSelect1.Options.changeOnBlur = this.checkBoxChangeOnBlur.Checked;
			this.multiSelect1.Options.showClearButton = this.checkBoxClearButton.Checked;
			this.multiSelect1.Options.allowCustomValue = this.checkBoxCustomValue.Checked;
			this.multiSelect1.Options.showDropDownIcon = this.checkBoxDropDownIcon.Checked;
			this.multiSelect1.Options.closePopupOnSelect = this.checkBoxCustomValue.Checked;
			this.multiSelect1.Options.hideSelectedItem = this.checkBoxHideSelectedItem.Checked;

			this.multiSelect1.Update();
        }
    }
}
