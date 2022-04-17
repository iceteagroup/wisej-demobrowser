using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTimePicker : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTimePicker()
		{
			InitializeComponent();

			this.kendoTimePicker1.Instance.onChange += new WidgetEventHandler(kendoTimePicker1_WidgetEvent);
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

		protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxFillMode.SelectedIndex = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
				if (TimeSpan.Parse(maskedTextBoxMin.Text) > TimeSpan.Parse(maskedTextBoxMax.Text))
				{
					AlertBox.Show(
						$"Max date must be greather than Min date",
						MessageBoxIcon.Error);

					Application.Play(MessageBoxIcon.Error);
					return;
				}
			}
            catch (Exception)
            {
				AlertBox.Show(
						$"Max date or Min date is in incorrect format",
						MessageBoxIcon.Error);

				Application.Play(MessageBoxIcon.Error);
				return;

			}
			

			this.kendoTimePicker1.Options.min = this.maskedTextBoxMin.Text;
			this.kendoTimePicker1.Options.max = this.maskedTextBoxMax.Text;
			this.kendoTimePicker1.Options.fillMode = this.comboBoxFillMode.SelectedItem.ToString();

			this.kendoTimePicker1.Update();
        }
    }
}
