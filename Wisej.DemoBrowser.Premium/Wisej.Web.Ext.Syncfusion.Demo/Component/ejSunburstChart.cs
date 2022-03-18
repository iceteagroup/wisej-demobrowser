using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSunburstChart : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejSunburstChart()
		{
			InitializeComponent();

			this.ejSunburstChart1.Instance.click += new WidgetEventHandler(ejSunburstChart1_WidgetEvent);
			this.ejSunburstChart1.Instance.legendItemClick += new WidgetEventHandler(ejSunburstChart1_WidgetEvent);
		}

		private void ejSunburstChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSunburstChart1.Options.legend = new {
				visible = this.checkBox1.Checked,
				position = this.comboBox1.SelectedItem.ToString().ToLower()
			};
			this.ejSunburstChart1.Options.startAngle = this.numericUpDown1.Value;
			this.ejSunburstChart1.Options.endAngle = this.numericUpDown2.Value;
			this.ejSunburstChart1.Options.radius = this.numericUpDown3.Value;
			this.ejSunburstChart1.Options.innerRadius = this.numericUpDown4.Value;

			this.ejSunburstChart1.Update();
		}
	}
}
