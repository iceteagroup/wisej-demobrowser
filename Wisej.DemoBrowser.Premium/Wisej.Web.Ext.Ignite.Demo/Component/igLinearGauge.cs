using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igLinearGauge : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igLinearGauge()
		{
			InitializeComponent();

			this.igLinearGauge1.Instance.onValueChanged += new WidgetEventHandler(igLinearGauge_WidgetEvent);
		}

		private void igLinearGauge_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igLinearGauge1.Value = (double) this.numericUpDown1.Value;
			this.igLinearGauge1.Options.isNeedleDraggingEnabled = this.checkBox1.Checked;
			this.igLinearGauge1.Options.isScaleInverted = this.checkBox2.Checked;
			this.igLinearGauge1.Options.minorTickCount = this.numericUpDown2.Value;
			this.igLinearGauge1.Options.scaleInnerExtent = this.numericUpDown3.Value;
			this.igLinearGauge1.Options.scaleOuterExtent = this.numericUpDown4.Value;

			this.igLinearGauge1.Update();
		}
	}
}
