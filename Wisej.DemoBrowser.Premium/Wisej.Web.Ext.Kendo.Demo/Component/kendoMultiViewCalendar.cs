using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiViewCalendar : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMultiViewCalendar()
		{
			InitializeComponent();

			this.kendoMultiViewCalendar1.Instance.change += new WidgetEventHandler(kendoMultiViewCalendar1_WidgetEvent);
			this.kendoMultiViewCalendar1.Instance.navigate += new WidgetEventHandler(kendoMultiViewCalendar1_WidgetEvent);
		}

		private void kendoMultiViewCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
