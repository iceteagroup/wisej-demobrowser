using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TreeView
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void treeViewDefault_AfterSelect(object sender, TreeViewEventArgs e)
		{
			AlertBox.Show($"Selected {this.treeView1.SelectedNode.Text}");
		}

		private void treeView4_BeforeCheck(object sender, TreeViewCancelEventArgs e)
		{
			AlertBox.Show($"Toggling Check State for {e.Node.Text}");
		}
	}
}
