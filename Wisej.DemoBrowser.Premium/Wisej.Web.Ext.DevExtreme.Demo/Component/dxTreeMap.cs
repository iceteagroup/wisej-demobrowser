using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTreeMap : TestBase
	{
		public dxTreeMap()
		{
			InitializeComponent();

			this.dxTreeMap1.Instance.click += new WidgetEventHandler(dxTreeMap1_WidgetEvent);
		}

		private void dxTreeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTreeMap1.Options.interactWithGroup = this.checkBox1.Checked;
			this.dxTreeMap1.Options.layoutDirection = this.comboBox1.SelectedItem;
			this.dxTreeMap1.Options.colorizer = new
			{
				palette = this.comboBox2.SelectedItem
			};
			this.dxTreeMap1.Options.selectionMode = this.comboBox3.SelectedItem;

			this.dxTreeMap1.Update();
		}
	}
}
