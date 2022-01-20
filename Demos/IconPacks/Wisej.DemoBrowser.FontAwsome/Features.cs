using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.FontAwsome
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
			this.fields = typeof(Ext.FontAwesome.Icons).GetFields();
			var imageEntries = fields.Select(item => new ImageListEntry((string)item.GetValue(null))).ToArray();
			
			this.imageListIcons.Images.AddRange(imageEntries);
			this.listViewIcons.VirtualListSize = imageEntries.Length;
		}

		private void listViewIcons_Appear(object sender, EventArgs e)
		{
			this.listViewIcons.ItemSize = new System.Drawing.Size((this.listViewIcons.Width / 10) - 2, 150);
		}

		private void listViewIcons_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			var text = Regex.Replace(this.fields[e.ItemIndex].Name, "([a-z])([A-Z]|[0-9])", "$1 $2");
			e.Item = new ListViewItem(text, e.ItemIndex);
		}

		private void listViewIcons_SelectedIndexChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Selected {this.listViewIcons.SelectedItems[0]}");
		}
	}
}
