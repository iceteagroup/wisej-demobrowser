using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Chart : ViewBase
	{
		public Chart()
		{
			InitializeComponent();
		}

		private void chart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
