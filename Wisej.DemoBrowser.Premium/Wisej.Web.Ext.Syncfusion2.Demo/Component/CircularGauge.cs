using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class CircularGauge : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public CircularGauge()
		{
			InitializeComponent();

			this.circularGauge1.Instance.onDragStart += new WidgetEventHandler(circularGauge1_WidgetEvent);
			this.circularGauge1.Instance.onDragEnd += new WidgetEventHandler(circularGauge1_WidgetEvent);
		}

		private void circularGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.circularGauge1.Instance.setPointerValue(0, 0, this.numericUpDownValue.Value);
		}
	}
}
