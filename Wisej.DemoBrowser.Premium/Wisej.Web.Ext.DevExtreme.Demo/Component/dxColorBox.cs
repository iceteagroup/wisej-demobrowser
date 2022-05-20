using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxColorBox : TestBase
	{
		public dxColorBox()
		{
			InitializeComponent();

			this.dxColorBox1.Instance.onValueChanged += new WidgetEventHandler(dxColorBox1_WidgetEvent);
		}

		private void dxColorBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxColorBox1.Options.isValid = this.checkBoxValidInput.Checked;
			this.dxColorBox1.Options.showClearButton = this.checkBoxClearButton.Checked;
			this.dxColorBox1.Options.applyValueMode = this.comboBoxValueMode.SelectedItem;
			this.dxColorBox1.Options.acceptCustomValue = this.checkBoxCustomValue.Checked;
			this.dxColorBox1.Options.showDropDownButton = this.checkBoxDropDownButton.Checked;
			this.dxColorBox1.Options.activeStateEnabled = this.checkBoxActiveStateEnabled.Checked;

			this.dxColorBox1.Update();
		}

        private void buttonGetValue_Click(object sender, EventArgs e)
        {
			AlertBox.Show($"Color selected:{this.dxColorBox1.Options.value}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
    }
}
