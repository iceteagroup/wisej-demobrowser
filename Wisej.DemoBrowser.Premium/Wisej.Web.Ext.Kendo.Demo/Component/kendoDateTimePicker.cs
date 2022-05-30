using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDateTimePicker : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoDateTimePicker()
		{
			InitializeComponent();

			this.kendoDateTimePicker1.Instance.onChange += new WidgetEventHandler(kendoDateTimePicker1_WidgetEvent);
		}

		private void kendoDateTimePicker_Load(object sender, EventArgs e)
		{
			this.kendoDateTimePicker1.Value = DateTime.Now;

			this.dateTimePickerMin.Value = DateTime.Now.AddYears(-1);
			this.dateTimePickerMin.Value = DateTime.Now.AddYears(1);
		}

		private async void kendoDateTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var data = e.Data;

			if (e.Type == "change")
				data = await this.kendoDateTimePicker1.Instance.valueAsync();

			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if(this.dateTimePickerMax.Value <= this.dateTimePickerMin.Value)
			{
				AlertBox.Show("Max date must be greather than Min date",MessageBoxIcon.Error);
				Application.Play(MessageBoxIcon.Error);
				return;
			}

			this.kendoDateTimePicker1.Options.min = this.dateTimePickerMin.Value;
			this.kendoDateTimePicker1.Options.max = this.dateTimePickerMax.Value;
			this.kendoDateTimePicker1.Options.interval = this.numericUpDownInterval.Value;

			this.kendoDateTimePicker1.Update();
		}
	}
}
