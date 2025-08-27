using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejMaskEdit : TestBase
	{
		public ejMaskEdit()
		{
			InitializeComponent();

			this.ejMaskEdit1.Instance.onChange += new WidgetEventHandler(ejMaskEdit1_WidgetEvent);
		}

		private void ejMaskEdit_Load(object sender, EventArgs e)
		{
			this.ejMaskEdit1.Options.watermarkText = "Enter password";
			this.ejMaskEdit1.Options.inputMode = "Password";
			this.ejMaskEdit1.Options.value = "ejMaskEdit1";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejMaskEdit1.Options.hidePromptOnLeave = this.checkBox1.Checked;
			this.ejMaskEdit1.Options.showPromptChar = this.checkBox2.Checked;
			this.ejMaskEdit1.Options.inputMode = this.comboBox1.Text;
			this.ejMaskEdit1.Options.customCharacter = this.textBox1.Text;

			this.ejMaskEdit1.Update();
		}

		private void ejMaskEdit1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}