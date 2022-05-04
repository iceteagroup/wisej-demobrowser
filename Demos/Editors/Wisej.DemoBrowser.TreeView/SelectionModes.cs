using System;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TreeView
{
	public partial class SelectionModes : DemoView
	{
		public SelectionModes()
		{
			InitializeComponent();
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Nodes?.Length > 0)
            {
				var titles = e.Nodes.Select((n) => n.Text);
				AlertBox.Show($"<b>Values:</b><br>{string.Join("<br>", titles)}");
			}
		}
	}
}
