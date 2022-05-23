using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TimePicker : TestBase
	{
		public TimePicker()
		{
			InitializeComponent();

			this.timePicker1.Instance.onChange += new WidgetEventHandler(timePicker1_WidgetEvent);
		}

		private void timePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.timePicker1.Options.format = this.comboBoxHourFormat.Text;
			this.timePicker1.Options.max = DateTime.Parse(this.textBoxMaximum.Text);
			this.timePicker1.Options.min = DateTime.Parse(this.textBoxMinimum.Text);
			this.timePicker1.Options.openOnFocus = this.checkBoxOpenOnFocus.Checked;

			this.timePicker1.Update();
        }
    }
}
