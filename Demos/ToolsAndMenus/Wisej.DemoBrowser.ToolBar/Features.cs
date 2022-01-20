using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ToolBar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void toolBarDefault_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			AlertBox.Show($"Clicked {e.Button.Text}");
		}

		private void contextMenuDropDown_MenuItemClicked(object sender, MenuItemEventArgs e)
		{
			AlertBox.Show($"Clicked {e.MenuItem.Text}");
		}
	}
}
