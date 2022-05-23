using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class LinearGauge : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public LinearGauge()
		{
			InitializeComponent();

			this.linearGauge1.Instance.onValueChange += new WidgetEventHandler(linearGauge1_WidgetEvent);
		}

		private void linearGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.linearGauge1.Instance.setPointerValue(0, 0, this.numericUpDown1.Value);
			this.linearGauge1.Options.orientation = this.comboBoxOrientation.SelectedItem;
			this.linearGauge1.Options.axes[0].majorTicks.interval = this.numericUpDownMajorTick.Value;
			this.linearGauge1.Options.axes[0].minorTicks.interval = this.numericUpDownMinorTick.Value;
			this.linearGauge1.Options.container = new { type = this.comboBoxContainerType.SelectedItem };

			this.linearGauge1.Update();
		}
    }
}
