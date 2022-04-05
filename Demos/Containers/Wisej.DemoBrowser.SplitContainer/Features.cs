using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.SplitContainer
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void panelDesigner_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Move;
		}

		private void panelDesigner_DragDrop(object sender, DragEventArgs e)
		{
			var node = (TreeNode) e.Data.GetData(typeof(TreeNode));
			Type type = typeof(TreeNode).Assembly.GetType($"Wisej.Web.{node.Text}");

			AddControl(type, e.Location);
		}

		private void AddControl(Type type, Point location)
		{
			var control = (Control)Activator.CreateInstance(type);

			control.Movable = true;
			control.AutoSize = false;
			control.Text = type.Name;
			control.Location = this.panelDesigner.PointToClient(location);
			control.ResizableEdges = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

			this.panelDesigner.Controls.Add(control);

			this.textBoxOutput.Text += $"Added a {type.Name}\r\n";
		}

        private void treeViewControls_NodeDrag(object sender, TreeViewNodeDragEventArgs e)
        {
			if (e.Node == null)
			{
				AlertBox.Show("Select an item from the TreeView first.");
				return;
			}

			this.treeViewControls.DoDragDrop(e.Node, DragDropEffects.Move);
		}
    }
}