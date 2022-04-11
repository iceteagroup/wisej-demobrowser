using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiViewCalendar : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMultiViewCalendar()
		{
			InitializeComponent();

			this.kendoMultiViewCalendar1.Instance.onChange += new WidgetEventHandler(kendoMultiViewCalendar1_WidgetEvent);
			this.kendoMultiViewCalendar1.Instance.onNavigate += new WidgetEventHandler(kendoMultiViewCalendar1_WidgetEvent);
		}

		private void kendoMultiViewCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
			if(this.dateTimePickerMaxDate.Value <= this.dateTimePickerMinDate.Value)
            {
				AlertBox.Show("Max date must be greather than min date",
					MessageBoxIcon.Error);

				Application.Play(MessageBoxIcon.Error);

				return;
            }
			await this.kendoMultiViewCalendar1.Instance.minAsync(dateTimePickerMinDate.Value);
			await this.kendoMultiViewCalendar1.Instance.maxAsync(dateTimePickerMaxDate.Value);

			this.kendoMultiViewCalendar1.Update();
        }
    }
}
