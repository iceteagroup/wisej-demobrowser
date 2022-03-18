using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTreeMap : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejTreeMap()
		{
			InitializeComponent();

			this.ejTreeMap1.Instance.click += new WidgetEventHandler(ejTreeMap1_WidgetEvent);
			this.ejTreeMap1.Instance.doubleClick += new WidgetEventHandler(ejTreeMap1_WidgetEvent);
		}

		private void ejTreeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeMap1.Options.enableGradient = this.checkBox2.Checked;
			this.ejTreeMap1.Options.highlightOnSelection = this.checkBox3.Checked;
			this.ejTreeMap1.Options.itemsLayoutMode = this.comboBox1.SelectedItem;
			this.ejTreeMap1.Options.groupSelectionMode = this.comboBox2.SelectedItem;

			this.ejTreeMap1.Update();
		}
	}
}
