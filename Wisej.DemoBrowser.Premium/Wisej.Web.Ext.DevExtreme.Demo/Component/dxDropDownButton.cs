using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxDropDownButton : TestBase
	{
		public dxDropDownButton()
		{
			InitializeComponent();
			this.dxDropDownButton1.Instance.onButtonClick += new WidgetEventHandler(dxDropDownButton1_WidgetEvent);
		}

		private void dxDropDownButton1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxDropDownButton1.Options.splitButton = this.checkBox1.Checked;
			this.dxDropDownButton1.Options.showArrowIcon = this.checkBox2.Checked;
			this.dxDropDownButton1.Options.focusStateEnabled = this.checkBox3.Checked;
			this.dxDropDownButton1.Options.hoverStateEnabled = this.checkBox4.Checked;
			this.dxDropDownButton1.Options.useSelectMode = this.checkBox5.Checked;

			this.dxDropDownButton1.Update();
		}
	}
}
