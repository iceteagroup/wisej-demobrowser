using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TreeMap : TestBase
	{
		public TreeMap()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.treeMap1.Options.renderDirection = this.comboBoxRenderDirection.Text;
			this.treeMap1.Options.useGroupingSeparator = this.checkBoxGroupingSeparator.Checked;

			this.treeMap1.Update();
        }

		private void treeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
