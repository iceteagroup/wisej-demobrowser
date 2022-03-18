using System;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoFileManager : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoFileManager()
		{
			InitializeComponent();

			this.kendoFileManager1.Instance.open += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.select += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.execute += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.navigate += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
		}

		private void kendoFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
