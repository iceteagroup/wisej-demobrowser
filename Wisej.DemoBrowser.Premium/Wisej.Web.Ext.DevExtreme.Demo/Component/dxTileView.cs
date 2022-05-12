using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTileView : TestBase
	{
		public dxTileView()
		{
			InitializeComponent();

			this.dxTileView1.Instance.onItemClick += new WidgetEventHandler(dxTileView1_WidgetEvent);
		}

		private void dxTileView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTileView1.Options.itemMargin = this.numericUpDownItemMargin.Value;
			this.dxTileView1.Options.baseItemWidth = this.numericUpDownBaseItemWidth.Value;
			this.dxTileView1.Options.baseItemHeight = this.numericUpDownBaseItemHeight.Value;

			this.dxTileView1.Update();
		}
    }
}
