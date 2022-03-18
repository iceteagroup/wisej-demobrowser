using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Diagram : TestBase
	{
		public Diagram()
		{
			InitializeComponent();

			this.diagram1.Instance.click += new WidgetEventHandler(diagram1_WidgetEvent);
		}

		private void diagram1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
