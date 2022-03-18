using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDateRangePicker : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDateRangePicker()
		{
			InitializeComponent();

			this.ejDateRangePicker1.Instance.open += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
			this.ejDateRangePicker1.Instance.close += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
			this.ejDateRangePicker1.Instance.select += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
			this.ejDateRangePicker1.Instance.change += new WidgetEventHandler(ejDateRangePicker1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDateRangePicker1.Options.value = $"{DateTime.Parse(this.textBoxStartDay.Text).ToShortDateString()} - {DateTime.Parse(this.textBoxEndDay.Text).ToShortDateString()}";
			this.ejDateRangePicker1.Options.allowEdit = this.checkBox1.Checked;
			this.ejDateRangePicker1.Options.enableTimePicker = this.checkBox2.Checked;

			this.ejDateRangePicker1.Update();
		}

		private void ejDateRangePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
