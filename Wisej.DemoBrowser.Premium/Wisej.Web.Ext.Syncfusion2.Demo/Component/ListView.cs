using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ListView : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public ListView()
		{
			InitializeComponent();

			this.listView1.Instance.select += new WidgetEventHandler(listView1_select);
		}

        private void listView1_select(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
								MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.listView1.Options.sortOrder = this.comboBoxSortOrder.Text;
			this.listView1.Options.checkBoxPosition = this.comboBoxPosition.Text;
			this.listView1.Options.showHeader = this.checkBoxHeader.Checked;
			this.listView1.Options.showCheckBox = this.checkBoxShowCheckBox.Checked;

			this.listView1.Update();
        }

        private void checkBoxShowCheckBox_CheckedChanged(object sender, EventArgs e) =>
            this.comboBoxPosition.Enabled = this.checkBoxShowCheckBox.Checked;
    }
}
