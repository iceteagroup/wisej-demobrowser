using System;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxTreeView : TestBase
	{
		public dxTreeView()
		{
			InitializeComponent();

			this.dxTreeView1.Instance.onItemClick += new WidgetEventHandler(dxTreeView1_WidgetEvent);
			this.dxTreeView1.Instance.onSelectionChanged += new WidgetEventHandler(dxTreeView1_WidgetEvent);
		}

		private void dxTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxTreeView1.Options.allowExpandAll = this.checkBox1.Checked;
			this.dxTreeView1.Options.expandAllEnabled = this.checkBox3.Checked;
			this.dxTreeView1.Options.expandNodesRecursive = this.checkBox4.Checked;
			this.dxTreeView1.Options.hoverStateEnabled = this.checkBox5.Checked;
			this.dxTreeView1.Options.searchEnabled = this.checkBox6.Checked;
			this.dxTreeView1.Options.selectByClick = this.checkBox7.Checked;
			this.dxTreeView1.Options.scrollDirection = this.comboBox1.SelectedItem;
			this.dxTreeView1.Options.showCheckBoxesMode = this.comboBox2.SelectedItem;

			this.dxTreeView1.Update();
		}
	}
}
