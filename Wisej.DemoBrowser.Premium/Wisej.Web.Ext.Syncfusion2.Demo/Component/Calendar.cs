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

		private void calendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (DateTime.Compare(this.dateTimePickerEnd.Value, this.dateTimePickerStart.Value) <= 0)
			{
				AlertBox.Show($"End Date must be later than Start date",
							MessageBoxIcon.Warning);

				Application.Play(MessageBoxIcon.Warning);
				return;
			}

			this.calendar1.Options.max = this.dateTimePickerEnd.Value.ToShortDateString();
			this.calendar1.Options.min = this.dateTimePickerStart.Value.ToShortDateString();

			this.calendar1.Update();
		}
	}
}