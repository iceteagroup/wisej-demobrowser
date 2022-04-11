using System;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoFileManager : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoFileManager()
		{
			InitializeComponent();

			this.kendoFileManager1.Instance.onOpen += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.onSelect += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.onExecute += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.onNavigate += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
		}

		private void kendoFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoFileManager1.Options.draggable = this.checkBoxDraggable.Checked;
			this.kendoFileManager1.Options.resizable = this.checkBoxResizable.Checked;

			this.kendoFileManager1.Update();
        }
    }
}
