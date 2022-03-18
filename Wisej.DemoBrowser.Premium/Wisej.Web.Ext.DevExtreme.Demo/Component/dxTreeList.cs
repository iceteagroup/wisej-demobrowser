using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTreeList : TestBase
	{
		public dxTreeList()
		{
			InitializeComponent();

			this.dxTreeList1.Instance.cellClick += new WidgetEventHandler(dxTreeList1_WidgetEvent);
		}

		private void dxTreeList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTreeList1.Options.allowColumnReordering = this.checkBox1.Checked;
			this.dxTreeList1.Options.allowColumnResizing = this.checkBox2.Checked;
			this.dxTreeList1.Options.autoExpandAll = this.checkBox3.Checked;
			this.dxTreeList1.Options.autoNavigateToFocusedRow = this.checkBox4.Checked;
			this.dxTreeList1.Options.columnChooser = new
			{
				enabled = this.checkBox5.Checked,
				allowSearch = this.checkBox8.Checked
			};
			this.dxTreeList1.Options.columnHidingEnabled = this.checkBox6.Checked;
			this.dxTreeList1.Options.expandNodesOnFiltering = this.checkBox8.Checked;

			this.dxTreeList1.Update();
		}
	}
}
