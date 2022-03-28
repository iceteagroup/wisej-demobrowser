using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejMaskEdit : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejMaskEdit()
		{
			InitializeComponent();

			this.ejMaskEdit1.Instance.onChange += new WidgetEventHandler(ejMaskEdit1_WidgetEvent);
			this.ejMaskEdit1.Instance.onKeyPress += new WidgetEventHandler(ejMaskEdit1_WidgetEvent);
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
