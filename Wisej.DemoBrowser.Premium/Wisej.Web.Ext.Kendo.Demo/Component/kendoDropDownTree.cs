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

		private void kendoDropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxTagMode.SelectedIndex = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoDropDownTree1.Options.checkboxes = this.checkBoxCheckBoxes.Checked;
			
			if(this.checkBoxCheckBoxes.Checked)
				this.kendoDropDownTree1.Options.checkAll = this.checkBoxCheckAll.Checked;

			this.kendoDropDownTree1.Options.tagMode = this.comboBoxTagMode.SelectedText?.ToLower();

			this.kendoDropDownTree1.Update();
        }

        private void checkBoxCheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
			this.checkBoxCheckAll.Enabled = this.checkBoxCheckBoxes.Checked;
        }
    }
}
