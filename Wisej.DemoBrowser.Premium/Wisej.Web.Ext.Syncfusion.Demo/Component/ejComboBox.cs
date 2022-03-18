using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejComboBox : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejComboBox()
		{
			InitializeComponent();

			this.ejComboBox1.Instance.open += new WidgetEventHandler(ejComboBox1_WidgetEvent);
			this.ejComboBox1.Instance.select += new WidgetEventHandler(ejComboBox1_WidgetEvent);
			this.ejComboBox1.Instance.customValueSpecifier += new WidgetEventHandler(ejComboBox1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejComboBox1.Options.autofill = this.checkBoxAutofill.Checked;
			this.ejComboBox1.Options.showClearButton = this.checkBoxShowClearButton.Checked;

			this.ejComboBox1.Update();
		}

		private void ejComboBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
