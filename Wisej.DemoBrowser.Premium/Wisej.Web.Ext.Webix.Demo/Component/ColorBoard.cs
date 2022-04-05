using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class ColorBoard : ViewBase
	{
		public ColorBoard()
		{
			InitializeComponent();

			this.colorBoard1.Instance.onSelect += new WidgetEventHandler(colorBoard1_WidgetEvent);
		}

		private void colorBoard1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.colorBoard1.Options.type = this.comboBoxType.SelectedText;
			this.colorBoard1.Options.grayScale = this.checkBoxGrayScale.Checked;

			this.colorBoard1.Update();
        }
    }
}
