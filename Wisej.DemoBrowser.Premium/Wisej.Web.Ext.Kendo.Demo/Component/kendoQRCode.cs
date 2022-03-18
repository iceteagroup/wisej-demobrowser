using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoQRCode : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoQRCode()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoQRCode1.Instance.value(this.textBox1.Text);
			this.kendoQRCode1.Options.color = this.textBox2.Text;

			this.kendoQRCode1.Update();
		}
	}
}
