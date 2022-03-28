using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiSelect : TestBase
	{
		public kendoMultiSelect()
		{
			InitializeComponent();

			this.kendoMultiSelect1.Instance.onSelect += new WidgetEventHandler(kendoMultiSelect1_WidgetEvent);
		}

		private void kendoMultiSelect1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
