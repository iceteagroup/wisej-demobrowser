using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TreeView : TestBase
	{
		public TreeView()
		{
			InitializeComponent();

			this.treeView1.Instance.nodeClicked += new WidgetEventHandler(treeView1_WidgetEvent);
		}

		private void treeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.treeView1.Options.expandOn = this.comboBoxExpandOn.Text;
			this.treeView1.Options.allowEditing = this.checkBoxEditing.Checked;
			this.treeView1.Options.showCheckBox = this.checkBoxShowCheckbox.Checked;
			this.treeView1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;

			this.treeView1.Update();
        }
    }
}
