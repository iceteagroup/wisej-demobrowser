using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoCalendar : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoCalendar()
		{
			InitializeComponent();

			this.kendoCalendar1.Instance.onChange += new WidgetEventHandler(kendoCalendar1_WidgetEvent);
			this.kendoCalendar1.Instance.onNavigate += new WidgetEventHandler(kendoCalendar1_WidgetEvent);
		}

		private void kendoCalendar_Load(object sender, EventArgs e)
		{
			this.dateTimePickerMin.Value = DateTime.Now.AddYears(-1);
			this.dateTimePickerMax.Value = DateTime.Now.AddYears(1);
		}

		private async void kendoCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var data = e.Data;

			if (e.Type == "change")
				data = await this.kendoCalendar1.Instance.valueAsync();

			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoCalendar1.Options.min = this.dateTimePickerMin.Value;
			this.kendoCalendar1.Options.max = this.dateTimePickerMax.Value;
			this.kendoCalendar1.Options.weekNumber = this.checkBoxWeekNumber.Checked;
		}
    }
}
