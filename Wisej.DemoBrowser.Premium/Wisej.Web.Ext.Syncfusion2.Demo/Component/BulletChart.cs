using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class BulletChart : TestBase
	{
		public BulletChart()
		{
			InitializeComponent();

			this.bulletChart1.Instance.bulletChartMouseClick += new WidgetEventHandler(bulletChart1_WidgetEvent);
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
