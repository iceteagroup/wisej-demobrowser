using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class SplitButton : TestBase
	{
		public SplitButton()
		{
			InitializeComponent();

			this.splitButton1.Instance.onClick += new WidgetEventHandler(splitButton1_WidgetEvent);
			this.splitButton1.Instance.onSelect += new WidgetEventHandler(splitButton1_WidgetEvent);
		}

		private void splitButton1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.splitButton1.Options.disabled = this.checkBoxDisabled.Checked;

			this.splitButton1.Update();
        }
    }
}
