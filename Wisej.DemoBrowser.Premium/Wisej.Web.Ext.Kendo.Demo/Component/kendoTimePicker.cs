using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTimePicker : TestBase
	{
		public kendoTimePicker()
		{
			InitializeComponent();

			this.kendoTimePicker1.Instance.onChange += new WidgetEventHandler(kendoTimePicker1_WidgetEvent);
		}

		private void kendoTimePicker_Load(object sender, EventArgs e)
		{
			this.textBoxMinimum.Text = "00:00";
			this.textBoxMaximum.Text = "23:59";
		}

		private async void kendoTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var data = e.Data;

			if (e.Type == "change")
				data = await this.kendoTimePicker1.Instance.valueAsync();

			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kendoTimePicker1.Options.min = this.textBoxMinimum.Text;
			this.kendoTimePicker1.Options.max = this.textBoxMaximum.Text;
			this.kendoTimePicker1.Options.fillMode = this.comboBoxFillMode.SelectedItem.ToString();

			this.kendoTimePicker1.Update();
        }
    }
}
