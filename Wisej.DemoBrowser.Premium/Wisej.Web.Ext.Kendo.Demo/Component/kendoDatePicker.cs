using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDatePicker : TestBase
	{
		private readonly string[] _possibilities = new string[7] { "mo","tu","we","th","fr","sa","su" };

		public kendoDatePicker()
		{
			InitializeComponent();

			this.kendoDatePicker1.Instance.onChange += new WidgetEventHandler(kendoDatePicker1_WidgetEvent);
		}

		private void kendoDatePicker_Load(object sender, EventArgs e)
		{
			this.kendoDatePicker1.Value = DateTime.Now;

			this.dateTimePickerMin.Value = DateTime.Now.AddYears(-1);
			this.dateTimePickerMax.Value = DateTime.Now.AddYears(1);
		}

		private async void kendoDatePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var data = e.Data;

			if (e.Type == "change")
				data = await this.kendoDatePicker1.Instance.valueAsync();

			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var daysOfWeek = this.flowLayoutPanelProperties.Controls
				.Where(c => c is CheckBox && ((CheckBox)c).Checked)
				.Select(c => c.Text.Substring(0, 2).ToLower()).ToArray();
				
			this.kendoDatePicker1.Options.disableDates = daysOfWeek;

			if(this.dateTimePickerMin.Value < this.dateTimePickerMax.Value)
            {
				this.kendoDatePicker1.Options.min = this.dateTimePickerMin.Value;
				this.kendoDatePicker1.Options.max = this.dateTimePickerMax.Value;
            }

			this.kendoDatePicker1.Update();
		}
	}
}
