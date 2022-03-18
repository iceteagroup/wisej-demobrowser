using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Grid : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public Grid()
		{
			InitializeComponent();

			this.grid1.Instance.recordClick += new WidgetEventHandler(grid1_WidgetEvent);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.grid1.Options.gridLines = this.comboBoxGridLine.Text;
			this.grid1.Options.allowGrouping = this.checkBoxGrouping.Checked;
			this.grid1.Options.allowResizing = this.checkBoxResizing.Checked;
			this.grid1.Options.allowFiltering = this.checkBoxFiltering.Checked;
			this.grid1.Options.allowReordering = this.checkBoxReordering.Checked;

			this.grid1.Update();
        }

		private void grid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
