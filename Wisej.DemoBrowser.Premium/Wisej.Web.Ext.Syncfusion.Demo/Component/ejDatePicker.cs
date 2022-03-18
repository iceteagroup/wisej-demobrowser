using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDatePicker : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDatePicker()
		{
			InitializeComponent();

			this.ejDatePicker1.Instance.open += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Instance.close += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Instance.select += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
			this.ejDatePicker1.Instance.change += new WidgetEventHandler(ejDatePicker1_WidgetEvent);
		}

		private void ejDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejDatePicker1.Options.enableStrictMode = this.checkBox1.Checked;
			this.ejDatePicker1.Options.showOtherMonths = this.checkBox2.Checked;
			this.ejDatePicker1.Options.allowDrillDown = this.checkBox3.Checked;
			this.ejDatePicker1.Options.displayInline = this.checkBox4.Checked;
			this.ejDatePicker1.Options.showDisabledRange = this.checkBox5.Checked;
			this.ejDatePicker1.Options.showFooter = this.checkBox6.Checked;

			this.ejDatePicker1.Update();
		}
	}
}
