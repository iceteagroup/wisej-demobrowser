using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoSparkline : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoSparkline()
		{
			InitializeComponent();

			this.kendoSparkline1.Instance.onSeriesClick += new WidgetEventHandler(kendoSparkline1_WidgetEvent);
			this.kendoSparkline1.Instance.onPlotAreaClick += new WidgetEventHandler(kendoSparkline1_WidgetEvent);
			this.kendoSparkline1.Instance.onAxisLabelClick += new WidgetEventHandler(kendoSparkline1_WidgetEvent);
		}

		private void kendoSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
