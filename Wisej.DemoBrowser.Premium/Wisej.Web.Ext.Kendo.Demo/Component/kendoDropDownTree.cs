using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDropDownTree : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoDropDownTree()
		{
			InitializeComponent();

			this.kendoDropDownTree1.Instance.onSelect += new WidgetEventHandler(kendoDropDownTree1_WidgetEvent);
		}

		private void kendoDropDownTree_Load(object sender, EventArgs e)
		{
			this.comboBoxTagMode.SelectedIndex = 0;
		}

		private void kendoDropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoDropDownTree1.AutoSize = this.checkBoxCheckBoxes.Checked;

			this.kendoDropDownTree1.Options.placeholder = this.textBoxPlaceholder.Text;
			this.kendoDropDownTree1.Options.checkboxes = this.checkBoxCheckBoxes.Checked;
			this.kendoDropDownTree1.Options.fillMode = this.comboBoxFillMode.SelectedItem;

			if (this.checkBoxCheckBoxes.Checked)
				this.kendoDropDownTree1.Options.checkAll = this.checkBoxCheckAll.Checked;

			this.kendoDropDownTree1.Options.tagMode = this.comboBoxTagMode.SelectedItem.ToString()?.ToLower();

			this.kendoDropDownTree1.Update();
        }

        private void checkBoxCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
			this.checkBoxCheckAll.Enabled = this.checkBoxCheckBoxes.Checked;
        }
	}
}
