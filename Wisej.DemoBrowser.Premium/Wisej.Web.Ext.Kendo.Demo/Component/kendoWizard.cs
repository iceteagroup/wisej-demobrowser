using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoWizard : TestBase
	{
		public kendoWizard()
		{
			InitializeComponent();

			this.kendoWizard1.Instance.onDone += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.onSelect += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.onActivate += new WidgetEventHandler(kendoWizard1_WidgetEvent);
			this.kendoWizard1.Instance.onFormValidateFailed += new WidgetEventHandler(kendoWizard1_WidgetEvent);
		}

		private void kendoWizard1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"{e.Type} {JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information, allowHtml: false);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.kendoWizard1.Instance.previous();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.kendoWizard1.Instance.next();
		}
	}
}
