using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoCalendar : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoCalendar()
		{
			InitializeComponent();

			this.kendoCalendar1.Instance.change += new WidgetEventHandler(kendoCalendar1_WidgetEvent);
			this.kendoCalendar1.Instance.navigate += new WidgetEventHandler(kendoCalendar1_WidgetEvent);
		}

		private void kendoCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
