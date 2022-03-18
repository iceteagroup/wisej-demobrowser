using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DateRangePicker : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public DateRangePicker()
		{
			InitializeComponent();

			this.dateRangePicker1.Instance.change += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
			this.dateRangePicker1.Instance.select += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
			this.dateRangePicker1.Instance.navigated += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
		}

		private void dateRangePicker1_WidgetEvent(object sender, WidgetEventArgs e)
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

			this.dateRangePicker1.Options.format = comboBoxFormat.Text;
			this.dateRangePicker1.Options.startDate = dateTimePickerEnd.Value.ToShortDateString();
			this.dateRangePicker1.Options.startDate = dateTimePickerStart.Value.ToShortDateString();


			this.dateRangePicker1.Update();
        }
    }
}
