using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeView : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTreeView()
		{
			InitializeComponent();

			this.kendoTreeView1.Instance.onChange += new WidgetEventHandler(kendoTreeView1_WidgetEvent);
			this.kendoTreeView1.Instance.onCheck += new WidgetEventHandler(kendoTreeView1_WidgetEvent);
			this.kendoTreeView1.Instance.onSelect += new WidgetEventHandler(kendoTreeView1_WidgetEvent);

		}

		private void kendoTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoTreeView1.Options.dragAndDrop = this.checkBoxAllowDragAndDrop.Checked;
			this.kendoTreeView1.Options.checkboxes.checkChildren = this.checkBoxShowcheckboxes.Checked;

			this.kendoTreeView1.Update();
        }
    }
}
