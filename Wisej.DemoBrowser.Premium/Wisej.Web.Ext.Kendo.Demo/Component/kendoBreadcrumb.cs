using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoBreadcrumb : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoBreadcrumb()
		{
			InitializeComponent();

			this.kendoBreadcrumb1.Instance.onClick += new WidgetEventHandler(kendoBreadcrumb1_WidgetEvent);
			this.kendoBreadcrumb1.Instance.onChange += new WidgetEventHandler(kendoBreadcrumb1_WidgetEvent);
		}

		private void kendoBreadcrumb1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoBreadcrumb1.Options.editable = this.checkBox1.Checked;
			this.kendoBreadcrumb1.Options.navigational = this.checkBox2.Checked;
			this.kendoBreadcrumb1.Options.gap = this.numericUpDown1.Value;

			this.kendoBreadcrumb1.Update();
		}
	}
}
