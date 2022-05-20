using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTextBox : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejTextBox()
		{
			InitializeComponent();

			this.ejMaskEdit1.Instance.onChange += new WidgetEventHandler(ejTextbox_WidgetEvent);
			this.ejNumericTextbox1.Instance.onChange += new WidgetEventHandler(ejTextbox_WidgetEvent);
			this.ejPercentageTextbox1.Instance.onChange += new WidgetEventHandler(ejTextbox_WidgetEvent);
		}

		private void ejTextbox_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejNumericTextbox1.Options.showSpinButton = this.checkBox3.Checked;
			this.ejNumericTextbox1.Options.validateOnType = this.checkBox4.Checked;
			this.ejNumericTextbox1.Options.decimalPlaces = this.numericUpDown1.Value;
			this.ejNumericTextbox1.Options.enableStrictMode = this.checkBox2.Checked;
			this.ejNumericTextbox1.Options.showRoundedCorner = this.checkBox1.Checked;

			this.ejNumericTextbox1.Update();
		}
	}
}
