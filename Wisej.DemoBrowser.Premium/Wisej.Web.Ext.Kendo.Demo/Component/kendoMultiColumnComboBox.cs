using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiColumnComboBox : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMultiColumnComboBox()
		{
			InitializeComponent();

			this.kendoMultiColumnComboBox1.Instance.onSelect += new WidgetEventHandler(kendoMultiColumnComboBox1_WidgetEvent);
		}

		private void kendoMultiColumnComboBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoMultiColumnComboBox1.Options.clearButton = this.checkBox1.Checked;
			this.kendoMultiColumnComboBox1.Options.ignoreCase = this.checkBox2.Checked;
			this.kendoMultiColumnComboBox1.Options.suggest = this.checkBox3.Checked;
			this.kendoMultiColumnComboBox1.Options.syncValueAndText = this.checkBox4.Checked;
			this.kendoMultiColumnComboBox1.Instance.value(this.textBox1.Text);

			this.kendoMultiColumnComboBox1.Update();
		}
	}
}
