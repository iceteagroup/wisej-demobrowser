using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxDiagram : TestBase
	{
		public dxDiagram()
		{
			InitializeComponent();

			this.dxDiagram1.Instance.onItemClick += new WidgetEventHandler(dxDiagram1_WidgetEvent);
		}

		private void dxDiagram1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var units = new String[] { "in", "cm", "px" };
			this.dxDiagram1.Options.units = units[this.comboBox1.SelectedIndex].ToLower();
			this.dxDiagram1.Options.simpleView = this.checkBox2.Checked;
			this.dxDiagram1.Options.snapToGrid = this.checkBox1.Checked;
			this.dxDiagram1.Options.showGrid = this.checkBox3.Checked;

			this.dxDiagram1.Update();
		}
	}
}
