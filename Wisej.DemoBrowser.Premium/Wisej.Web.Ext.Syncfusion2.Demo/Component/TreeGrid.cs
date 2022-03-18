using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TreeGrid : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public TreeGrid()
		{
			InitializeComponent();

			this.treeGrid1.Instance.rowSelected += new WidgetEventHandler(treeGrid1_rowSelected);
		}

		private void treeGrid1_rowSelected(object sender, WidgetEventArgs e)
        {
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
													MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
       
		private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.treeGrid1.Options.allowResizing = this.checkBoxResizing.Checked;
			this.treeGrid1.Options.allowReordering = this.checkBoxReordering.Checked;
			this.treeGrid1.Options.allowRowDragAndDrop = this.checkBoxDragAndDrop.Checked;
			
			this.treeGrid1.Update();
        }
    }
}
