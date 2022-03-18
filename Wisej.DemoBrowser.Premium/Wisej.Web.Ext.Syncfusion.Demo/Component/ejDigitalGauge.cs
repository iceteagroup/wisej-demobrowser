using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDigitalGauge : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDigitalGauge()
		{
			InitializeComponent();

			this.ejDigitalGauge1.Instance.click += new WidgetEventHandler(ejDigitalGauge1_WidgetEvent);
			this.ejDigitalGauge1.Instance.rightClick += new WidgetEventHandler(ejDigitalGauge1_WidgetEvent);
			this.ejDigitalGauge1.Instance.doubleClick += new WidgetEventHandler(ejDigitalGauge1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDigitalGauge1.Instance.setValue(0,this.textBox1.Text);
			this.ejDigitalGauge1.Options.items[0].segmentSettings.spacing = this.trackBarSegmentSpacing.Value;
			this.ejDigitalGauge1.Options.items[0].characterSettings.spacing = this.trackBarCharSpacing.Value;

			this.ejDigitalGauge1.Update();
		}

		private void ejDigitalGauge1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
