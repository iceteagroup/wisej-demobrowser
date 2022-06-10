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
			this.linearGauge1.Options.axes = new object[]
			{
				new
				{
					minimum = 0, maximum = 180, line = new
					{
						width = 0
					},
					majorTicks = new
					{
						interval = 20,
						color = "#9e9e9e"
					},
					minorTicks = new
					{
						color = "#9e9e9e"
					},
					pointers = new object[]
					{
						new
						{
							value = 90, height = 13, width = 13, roundedCornerRadius = 5, type = "Bar",
							color = "#f02828"
						}
					}
				},
				new
				{
					minimum = 0, maximum = 180, line = new
					{
						width = 0
					},
					majorTicks = new
					{
						interval = 20
					},
					opposedPosition = true, pointers = new object[]
					{
						new {width = 0}
					}
				}
			};
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