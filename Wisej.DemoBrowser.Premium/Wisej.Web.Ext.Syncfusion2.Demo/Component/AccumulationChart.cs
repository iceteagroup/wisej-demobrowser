using System;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class AccumulationChart : TestBase
	{
		public AccumulationChart()
		{
			InitializeComponent();

			this.accumulationChart1.WiredEvents = new[] { "chartMouseClick" };
			this.accumulationChart1.Instance.chartMouseClick += new WidgetEventHandler(accumulationChart1_WidgetEvent);
		}

		private void accumulationChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.accumulationChart1.Options.title = this.textBoxTitle.Text;
			this.accumulationChart1.Options.subTitle = this.textBoxSubTitle.Text;

			this.accumulationChart1.Options.series[0].endAngle = this.trackBarPieAngle.Value;
			this.accumulationChart1.Options.series[0].startAngle = this.trackBarPieAngle.Value;
			this.accumulationChart1.Options.series[0].explodeIndex = this.trackBarExplodeIndex.Value;
			this.accumulationChart1.Options.series[0].explodeOffset = $"{this.numericUpDownExplodeRadius.Value}%";

			this.accumulationChart1.Options.series[0].radius = $"{numericUpDownOuterRadius.Value}%";

			this.accumulationChart1.Update();
		}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
