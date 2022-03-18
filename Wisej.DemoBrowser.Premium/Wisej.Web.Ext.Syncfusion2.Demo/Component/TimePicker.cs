using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TimePicker : TestBase
	{
		public TimePicker()
		{
			InitializeComponent();

			this.timePicker1.Instance.change += new WidgetEventHandler(timePicker1_WidgetEvent);
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
			if(this.numericUpDownTo.Value <= this.numericUpDownFrom.Value)
            {
				AlertBox.Show("Numeric 'To' must be greatter than 'From'",
					MessageBoxIcon.Warning);

				Application.Play(MessageBoxIcon.Warning);
				return;
            }

			this.timePicker1.Options.fromat = this.comboBoxHourFormat.Text;
			this.timePicker1.Options.openOnFocus = this.checkBoxOpenOnFocus.Checked;
			this.timePicker1.Options.max = $"{Convert.ToInt32 (this.numericUpDownTo.Value)}:00";
			this.timePicker1.Options.min = $"{Convert.ToInt32 (this.numericUpDownFrom.Value)}:00";

			this.timePicker1.Update();
        }
    }
}
