using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igQRCodeBarcode : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igQRCodeBarcode()
		{
			InitializeComponent();
		}

		private void igQRCodeBarcode_Load(object sender, EventArgs e)
		{
			this.igQRCodeBarcode1.Options.data = "1234567890";
			this.igQRCodeBarcode1.Options.encodingMode = "numeric";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length > 0) { this.igQRCodeBarcode1.Options.data = this.textBox1.Text; }
			this.igQRCodeBarcode1.Options.encodingMode = this.comboBox1.SelectedItem;

			this.igQRCodeBarcode1.Update();
		}
	}
}
