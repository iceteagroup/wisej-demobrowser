using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class ColorSelect : ViewBase
	{
		public ColorSelect()
		{
			InitializeComponent();

			this.colorSelect1.Instance.onChange += new WidgetEventHandler(colorSelect1_WidgetEvent);
		}

		private void colorSelect1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.colorSelect1.Options.borderless = this.checkBoxBorderless.Checked;

			this.colorSelect1.Update();
        }
    }
}
