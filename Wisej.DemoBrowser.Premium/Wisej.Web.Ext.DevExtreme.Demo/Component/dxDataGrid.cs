using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxDataGrid : TestBase
	{
		public dxDataGrid()
		{
			InitializeComponent();

			this.dxDataGrid1.Instance.onCellClick += new WidgetEventHandler(dxDataGrid1_WidgetEvent);
		}

		private void dxDataGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxDataGrid1.Options.cellHintEnabled = this.checkBox4.Checked;
			this.dxDataGrid1.Options.columnAutoWidth = this.checkBox5.Checked;
			this.dxDataGrid1.Options.searchPanel.visible = this.checkBox6.Checked;
			this.dxDataGrid1.Options.allowColumnResizing = this.checkBox2.Checked;
			this.dxDataGrid1.Options.allowColumnReordering = this.checkBox1.Checked;
			this.dxDataGrid1.Options.autoNavigateToFocusedRow = this.checkBox3.Checked;

			this.dxDataGrid1.Update();
		}

		private void buttonExport_Click(object sender, EventArgs e)
			=> this.dxDataGrid1.Instance.exportToExcel(false);

		private void dxDataGrid_Load(object sender, EventArgs e)
			=> this.dxDataGrid1.Options.dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/DataGrid/data.json")));
	}
}
