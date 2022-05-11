using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoStepper : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoStepper()
		{
			InitializeComponent();

			this.kendoStepper1.Instance.onSelect += new WidgetEventHandler(kendoStepper1_WidgetEvent);
		}

		private void kendoStepper1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private async void buttonAddStep_Click(object sender, EventArgs e)
        {
			await this.kendoStepper1.Instance.insertAtAsync(0, new { label = this.textBoxStepName.Text });
		}
    }
}
