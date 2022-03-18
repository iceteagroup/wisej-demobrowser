using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxMenu : TestBase
	{
		public dxMenu()
		{
			InitializeComponent();
		}

		private void dxMenu1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxMenu1.Options.adaptivityEnabled = this.checkBox1.Checked;
			this.dxMenu1.Options.hideSubmenuOnMouseLeave = this.checkBox2.Checked;
			this.dxMenu1.Options.selectByClick = this.checkBox3.Checked;
			this.dxMenu1.Options.rtlEnabled = this.checkBox4.Checked;
			this.dxMenu1.Options.selectionMode = this.comboBox1.SelectedItem;
			this.dxMenu1.Options.submenuDirection = this.comboBox2.SelectedItem;

			this.dxMenu1.Update();
		}
	}
}
