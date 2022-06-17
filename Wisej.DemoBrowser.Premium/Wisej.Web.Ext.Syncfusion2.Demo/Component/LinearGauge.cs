using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class LinearGauge : TestBase
	{
		public LinearGauge()
		{
			InitializeComponent();

			this.linearGauge1.Instance.onValueChange += new WidgetEventHandler(linearGauge1_WidgetEvent);
		}

		private void LinearGauge_Load(object sender, EventArgs e)
		{
			this.linearGauge1.Options.title = "Temperature Measure";
			this.linearGauge1.Options.container = new
			{
				width = 13,
				roundedCornerRadius = 5,
				type = "Thermometer"
			};

			this.linearGauge1.Options.axes[0].minimum = 0;
			this.linearGauge1.Options.axes[0].maximum = 180;
			this.linearGauge1.Options.axes[0].majorTicks.interval = 20;
			this.linearGauge1.Options.axes[0].majorTicks.color = "#9e9e9e";

			this.linearGauge1.Options.axes[0].minorTicks.color = "#9e9e9e";
			this.linearGauge1.Options.axes[0].line.width = 0;

			this.linearGauge1.Options.axes[0].pointers[0].value = 90;
			this.linearGauge1.Options.axes[0].pointers[0].height = 13;
			this.linearGauge1.Options.axes[0].pointers[0].roundedCornerRadius = 5;
			this.linearGauge1.Options.axes[0].pointers[0].type = "Bar";
			this.linearGauge1.Options.axes[0].pointers[0].color = "#f02828";

			this.linearGauge1.Options.axes[1].minimum = 0;
			this.linearGauge1.Options.axes[1].maximum = 180;
			this.linearGauge1.Options.axes[1].majorTicks.interval = 20;

			this.linearGauge1.Options.axes[1].line.width = 0;
			this.linearGauge1.Options.axes[1].opposedPosition = true;

			this.linearGauge1.Options.axes[1].pointers[0].width = 0;
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
			this.linearGauge1.Options.container = new {type = this.comboBoxContainerType.SelectedItem};

			this.linearGauge1.Update();
		}
	}
}