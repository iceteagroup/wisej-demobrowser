using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class BulletChart : TestBase
	{
		public BulletChart()
		{
			InitializeComponent();

			this.bulletChart1.Instance.onBulletChartMouseClick += new WidgetEventHandler(bulletChart1_WidgetEvent);
		}

		private void BulletChart_Load(object sender, EventArgs e)
		{
			this.bulletChart1.Options.tooltip = new
			{
				enable = true
			};

			this.bulletChart1.Options.dataSource[0].value = this.numericUpDownValue.Value;
			this.bulletChart1.Options.dataSource[0].target = this.numericUpDownTarget.Value;

			this.bulletChart1.Options.valueField = "value";
			this.bulletChart1.Options.targetField = "target";
			this.bulletChart1.Options.animation = new
			{
				enable = false
			};
			this.bulletChart1.Options.ranges = new object[]
			{
				new {end = 150}, new {end = 250}, new {end = 300}
			};
			this.bulletChart1.Options.minimum = 0;
			this.bulletChart1.Options.maximum = 300;
			this.bulletChart1.Options.interval = 50;
			this.bulletChart1.Options.title = "Revenue";
			this.bulletChart1.Options.labelFormat = "${value}K";
			this.bulletChart1.Options.subtitle = "U.S. $";
		}
		private void bulletChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.bulletChart1.Options.dataSource[0].target = this.numericUpDownTarget.Value;
			this.bulletChart1.Options.dataSource[0].value = this.numericUpDownValue.Value;
			this.bulletChart1.Update();
		}
	}
}