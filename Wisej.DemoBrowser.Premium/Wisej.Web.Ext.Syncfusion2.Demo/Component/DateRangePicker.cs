using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DateRangePicker : TestBase
	{
		public DateRangePicker()
		{
			InitializeComponent();

			this.dateRangePicker1.Instance.onChange += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
			this.dateRangePicker1.Instance.onSelect += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
			this.dateRangePicker1.Instance.onNavigated += new WidgetEventHandler(dateRangePicker1_WidgetEvent);
		}

		private void DateRangePicker_Load(object sender, EventArgs e)
		{
			this.dateRangePicker1.Options.format = "dd/MMM/yy hh:mm a";

			this.dateTimePickerStart.Value = DateTime.Now.AddYears(-1);
			this.dateTimePickerEnd.Value = DateTime.Now.AddYears(1);
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
			this.dateRangePicker1.Options.format = this.comboBoxFormat.Text;
			this.dateRangePicker1.Options.startDate = this.dateTimePickerEnd.Value.ToShortDateString();
			this.dateRangePicker1.Options.startDate = this.dateTimePickerStart.Value.ToShortDateString();


			this.dateRangePicker1.Update();
		}
	}
}