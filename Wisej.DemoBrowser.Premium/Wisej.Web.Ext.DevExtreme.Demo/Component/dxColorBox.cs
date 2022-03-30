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
			this.dxColorBox1.Options.acceptCustomValue = this.checkBox1.Checked;
			this.dxColorBox1.Options.activeStateEnabled = this.checkBox2.Checked;
			this.dxColorBox1.Options.isValid = this.checkBox3.Checked;
			this.dxColorBox1.Options.showClearButton = this.checkBox4.Checked;
			this.dxColorBox1.Options.showDropDownButton = this.checkBox5.Checked;
			this.dxColorBox1.Options.applyValueMode = this.comboBox1.SelectedItem;

			this.dxColorBox1.Update();
		}
	}
}
