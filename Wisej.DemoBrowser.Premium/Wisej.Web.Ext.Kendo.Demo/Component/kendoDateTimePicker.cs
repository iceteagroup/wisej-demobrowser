using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDateTimePicker : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoDateTimePicker()
		{
			InitializeComponent();

			this.kendoDateTimePicker1.Instance.onChange += new WidgetEventHandler(kendoDateTimePicker1_WidgetEvent);
		}

		private void kendoDateTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
