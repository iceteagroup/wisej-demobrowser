using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxSwitch : TestBase
	{
		public dxSwitch()
		{
			InitializeComponent();

			this.dxSwitch1.Instance.onValueChanged += new WidgetEventHandler(dxSwitch1_WidgetEvent);
		}

		private void dxSwitch1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dxSwitch1.Options.value = this.checkBoxValue.Checked;
			this.dxSwitch1.Options.isValid = this.checkBoxIsValid.Checked;

			this.dxSwitch1.Update();
        }

        private void dxSwitch_Load(object sender, EventArgs e)
        {
			this.dxSwitch1.Options = new
			{
				switchedOnText = "on",
				switchedOffText = "off",
				isValid = false
			};

			this.dxSwitch1.Update();
        }
    }
}
