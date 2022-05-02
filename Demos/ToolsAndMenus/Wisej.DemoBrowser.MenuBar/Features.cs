using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.MenuBar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void menuBarDefault_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			AlertBox.Show($"Clicked {e.MenuItem.Text.Trim('&')}");
		}

		private void menuBarRadio_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			if (!e.MenuItem.RadioCheck)
				return;

			if (checkedMenuItem != null)
				checkedMenuItem.Checked = false;

			this.checkedMenuItem = e.MenuItem;

			this.menuItemFavoriteColor.IconSource = $"icon-preview?color={e.MenuItem.Text}";
		}
		private MenuItem checkedMenuItem;

        private void menuBarTypes_MenuItemClicked(object sender, MenuItemEventArgs e)
        {
			if (!e.MenuItem.IsParent)
				e.MenuItem.Checked = !e.MenuItem.Checked;
		}
    }
}
