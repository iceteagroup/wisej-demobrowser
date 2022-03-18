using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTreeView : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejTreeView()
		{
			InitializeComponent();

			this.ejTreeView1.Instance.nodeClick += new WidgetEventHandler(ejTreeView1_WidgetEvent);
			this.ejTreeView1.Instance.nodeCollapse += new WidgetEventHandler(ejTreeView1_WidgetEvent);
		}

		private void ejTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGetCheckedNodes_Click(object sender, EventArgs e)
		{
			var checkedNodes = await this.ejTreeView1.Instance.getCheckedNodesAsync();

			AlertBox.Show(JSON.Stringify(checkedNodes));
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeView1.Options.autoCheck = this.checkBox1.Checked;
			this.ejTreeView1.Options.showCheckbox = this.checkBox2.Checked;
			this.ejTreeView1.Options.allowDragAndDrop = this.checkBox3.Checked;
			this.ejTreeView1.Options.allowEditing = this.checkBox4.Checked;
			this.ejTreeView1.Options.allowKeyboardNavigation = this.checkBox5.Checked;
			this.ejTreeView1.Options.allowMultiSelection = this.checkBox6.Checked;

			this.ejTreeView1.Update();
		}
	}
}
