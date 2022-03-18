using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejHeatMap : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejHeatMap()
		{
			InitializeComponent();

			this.ejHeatMap1.Instance.cellSelected += new WidgetEventHandler(ejHeatMap1_WidgetEvent);
		}

		private void ejHeatMap1_Appear(object sender, EventArgs e)
		{
			// Isn't working (need to link the ejHeatMap with the ejHeatMapLegend
			this.ejHeatMap1.Options.legendCollection = new [] { $"id_{this.ejHeatMapLegend1.Handle}_container" };

			this.ejHeatMap1.Update();
		}

		private void ejHeatMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
