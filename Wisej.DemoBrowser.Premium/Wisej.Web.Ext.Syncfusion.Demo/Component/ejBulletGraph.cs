using System;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejBulletGraph : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejBulletGraph()
		{
			InitializeComponent();

			ejBulletGraph1.Instance.click += new WidgetEventHandler(ejBulletGraph1_WidgetEvent);
			ejBulletGraph1.Instance.rightClick += new WidgetEventHandler(ejBulletGraph1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejBulletGraph1.Options.value = numericUpDownVal.Value;
			this.ejBulletGraph1.Options.comparativeMeasureValue = numericUpDownCompMeasureVal.Value;

			ejBulletGraph1.Update();
		}

		private void ejBulletGraph1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
