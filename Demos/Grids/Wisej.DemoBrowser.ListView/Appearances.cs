using System;
using System.Drawing;
using System.Text;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ListView
{
	public partial class Appearances : DemoView
	{
		private const int ItemsCount = 500;

		private static readonly string[] Images =
		{
			"abiword_48.png",
			"bmp.png",
			"disks.png"
		};

		private ColumnHeader[] columns;

		public Appearances()
		{
			InitializeComponent();
		}

		private void VirtualScrolling_Load(object sender, EventArgs e)
		{
			listViewLargeIcons.VirtualListSize = ItemsCount;
			listViewLargeIcons.VirtualMode = true;

			listViewSmallIcons.VirtualListSize = ItemsCount;
			listViewSmallIcons.VirtualMode = true;


			listViewDetails.VirtualListSize = ItemsCount;
			InsertColumns();
			listViewDetails.VirtualMode = true;

			listViewTiles.VirtualListSize = ItemsCount;
			listViewTiles.VirtualMode = true;
		}

		private void listView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			var item = new ListViewItem($"Item {e.ItemIndex}");
			item.SubItems.Add("Sub item " + e.ItemIndex + "-1");
			item.SubItems.Add("Sub item " + e.ItemIndex + "-2");
			if (listViewLargeIcons.View == View.Details && e.ItemIndex % 2 == 0)
				item.BackColor = Color.WhiteSmoke;

			item.ImageIndex = e.ItemIndex % Images.Length;
			e.Item = item;
		}


		private void InsertColumns()
		{
			columns = new ColumnHeader[]
			{
				new ColumnHeader() {Text = "Main column"},
				new ColumnHeader() {Text = "Sub column #1"},
				new ColumnHeader() {Text = "Sub column #2"}
			};

			listViewDetails.Columns.AddRange(columns);
			listViewDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		private void RetrieveSelectionItems(object sender, RetrieveVirtualItemEventArgs e)
		{
			var item = new ListViewItem($"Item {e.ItemIndex}");
			e.Item = item;
		}

        private void listViewLargeIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
			AlertBox.Show($"Selected {this.listViewLargeIcons.Items[listViewLargeIcons.SelectedIndex].Text}");
        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {
			var listView = sender as Wisej.Web.ListView;

			if (listView.SelectedItems == null) return;

			StringBuilder sb = new StringBuilder();

			sb.Append("");

			foreach (var item in listView.SelectedItems)
			{
				sb.Append($"{item.Text} is selected");
				sb.Append("\n");
			}

			AlertBox.Show(sb.ToString());
        }
    }
}