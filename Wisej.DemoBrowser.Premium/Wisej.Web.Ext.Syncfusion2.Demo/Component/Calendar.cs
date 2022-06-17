using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Calendar : TestBase
	{
		public Calendar()
		{
			InitializeComponent();

			this.calendar1.Instance.onChange += new WidgetEventHandler(calendar1_WidgetEvent);
			this.calendar1.Instance.onNavigated += new WidgetEventHandler(calendar1_WidgetEvent);
		}

		private void Calendar_Load(object sender, EventArgs e)
		{
			this.dateTimePickerEnd.Value = DateTime.Now.AddYears(1);
			this.dateTimePickerStart.Value = DateTime.Now.AddYears(-1);
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
			this.calendar1.Options.max = this.dateTimePickerEnd.Value.ToShortDateString();
			this.calendar1.Options.min = this.dateTimePickerStart.Value.ToShortDateString();

			this.calendar1.Update();
		}
    }
}