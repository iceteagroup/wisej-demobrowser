using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDrawer : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoDrawer()
		{
			InitializeComponent();

			this.kendoDrawer1.Instance.hide += new WidgetEventHandler(kendoDrawer1_WidgetEvent);
			this.kendoDrawer1.Instance.show += new WidgetEventHandler(kendoDrawer1_WidgetEvent);
			this.kendoDrawer1.Instance.itemClick += new WidgetEventHandler(kendoDrawer1_WidgetEvent);
		}

		private void kendoDrawer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonShow_Click(object sender, EventArgs e)
		{
			this.kendoDrawer1.Eval("this.widget.show()");
		}

		private void buttonHide_Click(object sender, EventArgs e)
		{
			this.kendoDrawer1.Eval("this.widget.hide()");
		}
	}
}
