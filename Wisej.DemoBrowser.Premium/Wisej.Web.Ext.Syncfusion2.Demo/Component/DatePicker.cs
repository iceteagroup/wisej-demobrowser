using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DatePicker : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DatePicker()
		{
			InitializeComponent();

			this.datePicker1.Instance.change += new WidgetEventHandler(datePicker1_WidgetEvent);
			this.datePicker1.Instance.navigated += new WidgetEventHandler(datePicker1_WidgetEvent);
		}

		private void datePicker1_WidgetEvent(object sender, WidgetEventArgs e)
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

			this.datePicker1.Options.format = comboBoxFormat.Text;
			this.datePicker1.Options.max = dateTimePickerEnd.Value.ToShortDateString();
			this.datePicker1.Options.min = dateTimePickerStart.Value.ToShortDateString();
			
			this.datePicker1.Update();
        }
    }
}
