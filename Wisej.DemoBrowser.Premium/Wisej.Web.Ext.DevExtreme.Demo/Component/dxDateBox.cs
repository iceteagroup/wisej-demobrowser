using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxDateBox : TestBase
	{
		public dxDateBox()
		{
			InitializeComponent();

			this.dxDateBox1.Instance.onValueChanged += new WidgetEventHandler(dxDateBox1_WidgetEvent);
		}

		private void dxDateBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxDateBox1.Options.type = this.comboBox2.SelectedItem;
			this.dxDateBox1.Options.showAnalogClock = this.checkBox4.Checked;
			this.dxDateBox1.Options.acceptCustomValue = this.checkBox1.Checked;
			this.dxDateBox1.Options.stylingMode = this.comboBoxStylingMode.SelectedItem;

			this.dxDateBox1.Update();
		}

        private void dxDateBox_Load(object sender, EventArgs e)
        {
			this.comboBox2.SelectedIndex = 0; 
			this.comboBoxStylingMode.SelectedIndex = 0;
        }
    }
}
