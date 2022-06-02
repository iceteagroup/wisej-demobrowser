using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDigitalGauge : TestBase
	{
		public ejDigitalGauge()
		{
			InitializeComponent();

			this.ejDigitalGauge1.Instance.onClick += new WidgetEventHandler(ejDigitalGauge1_WidgetEvent);
			this.ejDigitalGauge1.Instance.onRightClick += new WidgetEventHandler(ejDigitalGauge1_WidgetEvent);
			this.ejDigitalGauge1.Instance.onDoubleClick += new WidgetEventHandler(ejDigitalGauge1_WidgetEvent);
		}

		private void ejDigitalGauge_Load(object sender, EventArgs e)
		{
			this.ejDigitalGauge1.Options.isResponsive = true;
			this.ejDigitalGauge1.Options.items = new dynamic[]
			{
				new
				{
					segmentSettings = new
					{
						width = 1,
						spacing = 0,
						color = "#8c8c8c"
					},
					characterSettings = new
					{
						opacity = 0.8,
						spacing = 2
					},
					value = "123456789",
					position = new
					{
						x = 52,
						y = 52
					}
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDigitalGauge1.Instance.setValue(0, this.textBox1.Text);
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