using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo
{
	public partial class ejTreeGrid : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejTreeGrid()
		{
			InitializeComponent();

			this.ejTreeGrid1.Instance.onRecordClick += new WidgetEventHandler(ejTreeGrid1_WidgetEvent);
			this.ejTreeGrid1.Instance.onCellSelected += new WidgetEventHandler(ejTreeGrid1_WidgetEvent);
		}

		private void ejTreeGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGetSelectedCells_Click(object sender, EventArgs e)
		{
			var selectedCells = await this.ejTreeGrid1.Instance.getSelectedCellsAsync();

			AlertBox.Show(selectedCells.ToString());
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeGrid1.Options.allowTextWrap = this.checkBox1.Checked;
			this.ejTreeGrid1.Options.allowSelection = this.checkBox2.Checked;
			this.ejTreeGrid1.Options.allowColumnReordering = this.checkBox3.Checked;
			this.ejTreeGrid1.Options.allowColumnResize = this.checkBox4.Checked;
			this.ejTreeGrid1.Options.allowDragAndDrop = this.checkBox5.Checked;
			this.ejTreeGrid1.Options.allowFiltering = this.checkBox6.Checked;
			this.ejTreeGrid1.Options.allowKeyboardNavigation = this.checkBox7.Checked;

			this.ejTreeGrid1.Update();
		}
	}
}
