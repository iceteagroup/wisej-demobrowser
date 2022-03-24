using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ColorPicker : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public ColorPicker()
		{
			InitializeComponent();

			this.colorPicker1.Instance.onChange += new WidgetEventHandler(colorPicker1_WidgetEvent);
		}

		private async void colorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var color = await this.colorPicker1.Instance.getValueAsync();
			AlertBox.Show($"Color: {color}");
		}

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
			var value = await this.colorPicker1.Instance.getValueAsync();

			this.colorPicker1.Options.mode = this.comboBoxMode.Text;
			this.colorPicker1.Options.inline = this.checkBoxInline.Checked;
			this.panelColorValue.BackColor = ColorTranslator.FromHtml($"{value}");
			this.colorPicker1.Options.showButtons = this.checkBoxShowButton.Checked;
			
			this.colorPicker1.Update();
        }
    }
}
