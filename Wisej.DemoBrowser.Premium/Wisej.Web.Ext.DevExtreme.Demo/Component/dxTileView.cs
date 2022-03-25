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
			this.dxTileView1.Options.showScrollbar = this.checkBox1.Checked;
			this.dxTileView1.Options.itemMargin = this.numericUpDown1.Value;
			this.dxTileView1.Options.baseItemHeight = this.numericUpDown2.Value;
			this.dxTileView1.Options.baseItemWidth = this.numericUpDown3.Value;
			this.dxTileView1.Options.direction = this.comboBox1.SelectedItem;

			this.dxTileView1.Update();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var scrollPosition = await this.dxTileView1.Instance.scrollPositionAsync();

			AlertBox.Show($"Scroll Position: {scrollPosition}");
		}
	}
}
