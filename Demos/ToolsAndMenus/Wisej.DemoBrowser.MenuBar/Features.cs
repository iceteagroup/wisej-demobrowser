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
			if (e.MenuItem.RadioCheck)
				e.MenuItem.Checked = !e.MenuItem.Checked;
		}
	}
}
