using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ListBox : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public ListBox()
		{
			InitializeComponent();

			this.listBox1.Instance.onChange += new WidgetEventHandler(listBox1_change);
		}

        private void listBox1_change(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
											MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.listBox1.Options.sortOrder = this.comboBoxSortOrder.Text;
			this.listBox1.Options.filterType = this.comboBoxFilterType.Text;
			this.listBox1.Options.allowFiltering = this.checkBoxFiltering.Checked;
			this.listBox1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;

			// For force enabling of filtering
			this.listBox1.Instance.refresh();

			this.listBox1.Update();
        }

        private void checkBoxFiltering_CheckedChanged(object sender, EventArgs e) =>
			this.comboBoxFilterType.Enabled = this.checkBoxFiltering.Checked;

    }
}
