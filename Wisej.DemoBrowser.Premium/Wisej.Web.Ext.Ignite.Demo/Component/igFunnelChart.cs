using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igFunnelChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igFunnelChart()
		{
			InitializeComponent();

			this.igFunnelChart1.Instance.sliceClicked += new WidgetEventHandler(igFunnelChart1_WidgetEvent);
		}

		private void igFunnelChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igFunnelChart1.Options.transitionDuration = this.numericUpDown1.Value;
			this.igFunnelChart1.Options.useBezierCurve = this.checkBox2.Checked;
			this.igFunnelChart1.Options.funnelSliceDisplay = this.comboBox1.SelectedItem;
			this.igFunnelChart1.Options.isInverted = this.checkBox3.Checked;
			this.igFunnelChart1.Options.bottomEdgeWidth = this.numericUpDown2.Value;

			this.igFunnelChart1.Update();
		}
	}
}
