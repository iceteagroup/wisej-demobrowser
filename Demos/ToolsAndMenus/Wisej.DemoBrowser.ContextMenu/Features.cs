using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ContextMenu
{
	public partial class Features : DemoView
	{
		private string[] wordBank = new string[] { "Edit", "Help", "View", "Rename" };
		public Features()
		{
			InitializeComponent();
		}

		private void contextMenuButton_Popup(object sender, EventArgs e)
		{
			AlertBox.Show("Context Menu Showing");
		}

		private void contextMenuButton_Collapse(object sender, EventArgs e)
		{
			AlertBox.Show("Context Menu Collapsed");
		}

		private void contextMenuButton_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			AlertBox.Show($"Clicked {e.MenuItem.Text}");
		}

		private void contextMenuChecked_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			var check = e.MenuItem.Checked;
			AlertBox.Show($"{e.MenuItem.Text}: {check}");
		}

		private void contextMenuNested_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			AlertBox.Show($"Clicked {e.MenuItem.Text}");
		}
	}
}
