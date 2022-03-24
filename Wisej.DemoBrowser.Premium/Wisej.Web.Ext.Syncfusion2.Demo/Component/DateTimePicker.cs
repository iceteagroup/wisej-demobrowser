using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DateTimePicker : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DateTimePicker()
		{
			InitializeComponent();

			this.dateTimePicker1.Instance.onChange += new WidgetEventHandler(dateTimePicker1_WidgetEvent);
			this.dateTimePicker1.Instance.onNavigated += new WidgetEventHandler(dateTimePicker1_WidgetEvent);
		}

		private void dateTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			if (DateTime.Compare(dateTimePickerEnd.Value, dateTimePickerStart.Value) <= 0)
			{
				AlertBox.Show($"End Date must be later than Start date",
					MessageBoxIcon.Warning);

				Application.Play(MessageBoxIcon.Warning);
				return;
			}

			this.dateTimePicker1.Options.format = comboBoxFormat.Text;
			this.dateTimePicker1.Options.startDate = dateTimePickerEnd.Value.ToShortDateString();
			this.dateTimePicker1.Options.startDate = dateTimePickerStart.Value.ToShortDateString();


			this.dateTimePicker1.Update();
		}
    }
}
