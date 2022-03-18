using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxMap : TestBase
	{
		public dxMap()
		{
			InitializeComponent();
		}

		private void dxMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxMap1.Options.center = new
			{
				lat = this.numericUpDown1.Value,
				lon = this.numericUpDown2.Value
			};
			this.dxMap1.Options.autoAdjust = this.checkBox1.Checked;
			this.dxMap1.Options.controls = this.checkBox2.Checked;
			this.dxMap1.Options.provider = this.comboBox2.SelectedItem;
			this.dxMap1.Options.type = this.comboBox1.SelectedItem;
			this.dxMap1.Options.zoom = this.numericUpDown3.Value;

			this.dxMap1.Update();
		}
	}
}
