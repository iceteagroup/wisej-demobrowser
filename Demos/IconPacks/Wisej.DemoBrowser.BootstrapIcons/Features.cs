using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.BootstrapIcons
{
	public partial class Features : DemoView
	{
		private FieldInfo[] fields;
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.fields = typeof(Ext.BootstrapIcons.Icons).GetFields();
			var imageEntries = fields.Select(item => new ImageListEntry((string)item.GetValue(null), item.Name)).ToArray();
			imageListIcons.Images.AddRange(imageEntries);
			this.listViewIcons.VirtualListSize = imageEntries.Length;
		}

		private void listViewIcons_Appear(object sender, EventArgs e)
		{
			if (Application.Browser.Device == "Mobile")
			{
				// ScreenSize is different on Android vs. iOS.
				var screenSize = Application.Browser.ScreenSize;
				var screenWidth = Math.Min(screenSize.Width, screenSize.Height);

				this.listViewIcons.ItemSize = new System.Drawing.Size(screenWidth / 3 - 20, 115);
			}
			else
			{
				this.listViewIcons.ItemSize = new System.Drawing.Size((this.listViewIcons.Width / 10) - 2, 115);
			}
		}

		private void listViewIcons_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			var text = Regex.Replace(this.imageListIcons.Images[e.ItemIndex].Name, "([a-z])([A-Z]|[0-9])", "$1 $2");

			e.Item = new ListViewItem(text, e.ItemIndex)
			{
				ToolTipText = imageListIcons.Images[e.ItemIndex].Name
			};
		}

		private void listViewIcons_SelectedIndexChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Selected {this.listViewIcons.SelectedItems[0]}");
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			// Creates an array of ImageListEntries with their names
			ImageListEntry[] filteredList = fields.Where(item => item.Name.IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
								.Select(item => new ImageListEntry((string)item.GetValue(null), item.Name))
								.ToArray();
			listViewIcons.VirtualListSize = filteredList.Length;
			imageListIcons.Images.Clear();
			imageListIcons.Images.AddRange(filteredList);
		}
	}
}
