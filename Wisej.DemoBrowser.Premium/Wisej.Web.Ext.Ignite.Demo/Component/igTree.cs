using System;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igTree : TestBase
	{
		public igTree()
		{
			InitializeComponent();

			this.igTree1.Instance.onNodeClick += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTree1.Instance.onNodeExpanded += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTree1.Instance.onNodeCheckstateChanged += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void igTree_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igTree1.Options.checkboxMode = this.comboBox1.SelectedItem;
			this.igTree1.Options.singleBranchExpand = this.checkBox1.Checked;
		
			this.igTree1.Update();
		}
	}
}
