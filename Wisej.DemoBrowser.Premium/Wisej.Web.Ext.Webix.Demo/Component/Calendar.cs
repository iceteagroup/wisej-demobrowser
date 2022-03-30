using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Calendar : Wisej.Web.Ext.Webix.Demo.Component.ViewBase
	{
		public Calendar()
		{
			InitializeComponent();

			this.calendar1.Instance.onAfterDateSelect += new WidgetEventHandler(calendar1_WidgetEvent);
		}

		private void calendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
