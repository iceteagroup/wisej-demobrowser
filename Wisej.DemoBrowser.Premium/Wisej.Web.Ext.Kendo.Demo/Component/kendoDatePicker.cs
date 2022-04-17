using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDatePicker : TestBase
	{
		private readonly string[] _possibilities;
		public kendoDatePicker()
		{
			InitializeComponent();

			_possibilities = new string[7]
			{
				"mo","tu","we","th","fr","sa","su"
			};

			this.kendoDatePicker1.Instance.onChange += new WidgetEventHandler(kendoDatePicker1_WidgetEvent);
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

			this.kendoDatePicker1.Update();
		}
    }
}
