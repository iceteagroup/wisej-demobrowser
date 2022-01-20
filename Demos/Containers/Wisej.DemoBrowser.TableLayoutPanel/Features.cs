using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TableLayoutPanel
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void btnAddRow_Click(object sender, EventArgs e)
		{
			tableLayoutPanel.RowCount += 1;
		}

		private void btnAddColumn_Click(object sender, EventArgs e)
		{
			tableLayoutPanel.ColumnCount += 1;
			var pb = pictureBox1;
			tableLayoutPanel.SetColumn(pb, tableLayoutPanel.ColumnCount);
		}

		private void btnRemoveLastRow_Click(object sender, EventArgs e)
		{
			if (tableLayoutPanel.RowCount >= 1) tableLayoutPanel.RowCount -= 1;
		}

		private void btnRemoveLastColumn_Click(object sender, EventArgs e)
		{
			if (tableLayoutPanel.ColumnCount >= 1) tableLayoutPanel.ColumnCount -= 1;
		}
	}
}