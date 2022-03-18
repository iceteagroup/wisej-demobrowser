using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDropDownTree : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoDropDownTree()
		{
			InitializeComponent();

			this.kendoDropDownTree1.Instance.select += new WidgetEventHandler(kendoDropDownTree1_WidgetEvent);
		}

		private void kendoDropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
