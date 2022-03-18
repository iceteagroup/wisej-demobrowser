using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoBarcode : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoBarcode()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoBarcode1.Options.checksum = this.checkBox1.Checked;
			this.kendoBarcode1.Instance.value(this.textBox1.Text);
			this.kendoBarcode1.Options.type = this.comboBox1.SelectedItem;

			this.kendoBarcode1.Update();
		}
	}
}
