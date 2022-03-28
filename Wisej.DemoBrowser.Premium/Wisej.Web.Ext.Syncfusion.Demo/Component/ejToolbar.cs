using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejToolbar : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejToolbar()
		{
			InitializeComponent();

			this.ejToolbar1.Instance.onClick += new WidgetEventHandler(ejToolbar1_WidgetEvent);
			this.ejToolbar1.Instance.onItemHover += new WidgetEventHandler(ejToolbar1_WidgetEvent);
		}

		private void ejToolbar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejToolbar1.Options.enableSeparator = this.checkBox1.Checked;
			this.ejToolbar1.Options.showRoundedCorner = this.checkBox2.Checked;

			this.ejToolbar1.Update();
		}
	}
}
