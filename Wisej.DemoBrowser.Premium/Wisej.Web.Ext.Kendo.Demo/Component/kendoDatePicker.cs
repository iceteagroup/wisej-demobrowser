using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDatePicker : TestBase
	{
		public kendoDatePicker()
		{
			InitializeComponent();

			this.kendoDatePicker1.Instance.onChange += new WidgetEventHandler(kendoDatePicker1_WidgetEvent);
		}

		private void kendoDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
