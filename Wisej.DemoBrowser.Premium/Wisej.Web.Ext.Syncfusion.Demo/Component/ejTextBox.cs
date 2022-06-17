using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTextBox : TestBase
	{
		public ejTextBox()
		{
			InitializeComponent();

			this.ejMaskEdit1.Instance.onChange += new WidgetEventHandler(ejTextbox_WidgetEvent);
			this.ejNumericTextbox1.Instance.onChange += new WidgetEventHandler(ejTextbox_WidgetEvent);
			this.ejPercentageTextbox1.Instance.onChange += new WidgetEventHandler(ejTextbox_WidgetEvent);
		}

		private void ejTextBox_Load(object sender, EventArgs e)
		{
			//ejNumericTextBox1
			this.ejNumericTextbox1.Options.name = "numeric";
			this.ejNumericTextbox1.Options.value = "123";
			this.ejNumericTextbox1.Options.minValue = 0;
			this.ejNumericTextbox1.Options.width = "100%";

			//ejPercentageTextbox1
			this.ejPercentageTextbox1.Options.name = "percentage";
			this.ejPercentageTextbox1.Options.value = "11";
			this.ejPercentageTextbox1.Options.minValue = 0;
			this.ejPercentageTextbox1.Options.width = "100%";

			//ejMaskEdit1
			this.ejMaskEdit1.Options.name = "mask";
			this.ejMaskEdit1.Options.inputMode = "Text";
			this.ejMaskEdit1.Options.value = "ejMaskEdit1";
			this.ejMaskEdit1.Options.maskFormat = "99 999-99999";
			this.ejMaskEdit1.Options.width = "100%";
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