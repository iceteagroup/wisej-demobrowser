using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSymbolPalette : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejSymbolPalette()
		{
			InitializeComponent();

			this.ejSymbolPalette1.Instance.selectionChange += new WidgetEventHandler(ejSymbolPalette1_WidgetEvent);
		}

		private void ejDiagram1_Appear(object sender, EventArgs e)
		{
			this.ejSymbolPalette1.Options.diagramId = $"id_{this.ejDiagram1.Handle}_container";
		}

		private void ejSymbolPalette1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSymbolPalette1.Options.allowDrag = this.checkBox2.Checked;
			this.ejSymbolPalette1.Options.showPaletteItemText = this.checkBox1.Checked;
			this.ejSymbolPalette1.Options.previewHeight = this.numericUpDown1.Value;
			this.ejSymbolPalette1.Options.headerHeight = this.numericUpDown2.Value;

			this.ejSymbolPalette1.Update();
		}
	}
}
