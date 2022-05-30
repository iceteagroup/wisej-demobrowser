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

		private void kendoMultiViewCalendar_Load(object sender, EventArgs e)
		{
			this.dateTimePickerMaxDate.Value = DateTime.Now.AddYears(100);
			this.dateTimePickerMinDate.Value = DateTime.Now.AddYears(-100);
		}

		private async void kendoMultiViewCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "change":
					// see: https://docs.telerik.com/kendo-ui/api/javascript/ui/multiviewcalendar.
					var date = await this.kendoMultiViewCalendar1.Instance.valueAsync();
					AlertBox.Show(date.ToString());
					break;

				default:
					AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);
					break;
			}

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonUpdate_Click(object sender, EventArgs e)
		{
			await this.kendoMultiViewCalendar1.Instance.minAsync(dateTimePickerMinDate.Value);
			await this.kendoMultiViewCalendar1.Instance.maxAsync(dateTimePickerMaxDate.Value);

			this.kendoMultiViewCalendar1.Update();
		}
	}
}
