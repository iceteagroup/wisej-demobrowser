using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Calendar : Wisej.Web.Ext.Webix.Demo.Component.ViewBase
	{
		public Calendar()
		{
			InitializeComponent();

			this.calendar1.Instance.onAfterDateSelect += new WidgetEventHandler(calendar1_WidgetEvent);
		}

		private void calendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			if (this.dateTimePickerMinDate.Value >= this.dateTimePickerMaxDate.Value)
			{
				AlertBox.Show($"Max date must be greater than min date ",
								MessageBoxIcon.Error);

				Application.Play(MessageBoxIcon.Error);
				return;
			}

			this.calendar1.Options.minDate = this.dateTimePickerMinDate.Value;
			this.calendar1.Options.maxDate = this.dateTimePickerMaxDate.Value;
			this.calendar1.Options.timepicker = this.checkBoxTimePicker.Checked;
			this.calendar1.Options.weekHeader = this.checkBoxWeekHeader.Checked;
			this.calendar1.Options.weekNumber = this.checkBoxWeekNumber.Checked;
			this.calendar1.Options.skipEmptyWeeks = this.checkBoxSkipEmptyWeeks.Checked;

			this.calendar1.Update();
        }
    }
}
