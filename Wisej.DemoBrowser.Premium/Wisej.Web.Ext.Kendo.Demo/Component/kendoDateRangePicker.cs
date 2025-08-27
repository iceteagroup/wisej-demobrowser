using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDateRangePicker : TestBase
	{
		public kendoDateRangePicker()
		{
			InitializeComponent();

			this.kendoDateRangePicker1.Instance.onChange += new WidgetEventHandler(kendoDateRangePicker1_WidgetEvent);
		}

		private void kendoDateRangePicker_Load(object sender, EventArgs e)
		{
			this.dateTimePickerMin.Value = DateTime.Now.AddYears(-1);
			this.dateTimePickerMax.Value = DateTime.Now.AddYears(1);
		}

		private async void kendoDateRangePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var data = e.Data;

			if (e.Type == "change")
				data = await this.kendoDateRangePicker1.Instance.rangeAsync();

			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.comboBoxDepth.SelectedIndex = 0;
		}
		private async void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (this.dateTimePickerMax.Value <= this.dateTimePickerMin.Value)
			{
				AlertBox.Show("Max date must be greather than Min date", MessageBoxIcon.Error);
				Application.Play(MessageBoxIcon.Error);
				return;
			}

			this.kendoDateRangePicker1.Options.weekNumber = this.checkBoxWeekNumber.Checked;
			this.kendoDateRangePicker1.Options.depth = this.comboBoxDepth.SelectedItem.ToString();

			await this.kendoDateRangePicker1.Instance.minAsync(this.dateTimePickerMin.Value);
			await this.kendoDateRangePicker1.Instance.maxAsync(this.dateTimePickerMax.Value);

			this.kendoDateRangePicker1.Update();
		}
	}
}
