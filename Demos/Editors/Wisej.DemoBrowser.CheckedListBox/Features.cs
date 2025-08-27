using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.CheckedListBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void checkedListBoxDefaultCities_SelectedIndexChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Selected {this.checkedListBoxDefaultCities.SelectedItem}", icon: MessageBoxIcon.Warning);
		}

		private void checkedListBoxDefaultCities_AfterItemCheck(object sender, ItemCheckEventArgs e)
		{
			var item = this.checkedListBoxDefaultCities.Items[e.Index];
			AlertBox.Show($"Check state for {item}: {e.NewValue}");
		}
	}
}
