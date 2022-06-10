using System;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ColorPicker : TestBase
	{
		public ColorPicker()
		{
			InitializeComponent();

			this.colorPicker1.Instance.onChange += new WidgetEventHandler(colorPicker1_WidgetEvent);
		}

		private void ColorPicker_Load(object sender, EventArgs e)
		{
			this.colorPicker1.Options.value = "#000000";
			this.colorPicker1.Options.inline = true;
		}

		private async void colorPicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			var color = await this.colorPicker1.Instance.getValueAsync();

			AlertBox.Show($"Color: {color}");
			this.panelColorValue.BackColor = ColorTranslator.FromHtml(color);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.colorPicker1.Options.mode = this.comboBoxMode.Text;
			this.colorPicker1.Options.inline = this.checkBoxInline.Checked;
			this.colorPicker1.Options.showButtons = this.checkBoxShowButton.Checked;

			this.colorPicker1.Update();
		}
	}
}