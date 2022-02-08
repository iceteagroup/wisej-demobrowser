using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.NavigationBar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void navigationBar1_SelectedItemChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Selected {this.navigationBar1.SelectedItem.Text}");
		}

		private void checkBoxCompact_CheckedChanged(object sender, EventArgs e)
		{
			this.navigationBar1.CompactView = this.checkBoxCompact.Checked;
		}
	}
}
