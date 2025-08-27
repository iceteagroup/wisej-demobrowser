using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class ColorPicker : ViewBase
	{
		public ColorPicker()
		{
			InitializeComponent();

			this.colorPicker1.Instance.onChange += new WidgetEventHandler(colorPicker1_WidgetEvent);
		}

		private void colorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.colorPicker1.Options.clear = this.checkBoxClear.Checked;
			this.colorPicker1.Options.icons = this.checkBoxShowIcon.Checked;
			this.colorPicker1.Options.stringResult = this.checkBoxStringResult.Checked;

			this.colorPicker1.Update();
        }
    }
}
