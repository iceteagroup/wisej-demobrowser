using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.Barcode;

namespace Wisej.DemoBrowser.Barcode
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void comboBoxBarcodeType_SelectedIndexChanged(object sender, EventArgs e)
		{
			var type = this.comboBoxBarcodeType.SelectedItem.ToString();
			this.barcode1.BarcodeType = (BarcodeType)Enum.Parse(typeof(BarcodeType), type);
		}

		private void checkBoxLabel_CheckedChanged(object sender, EventArgs e)
		{
			this.barcode1.ShowLabel = this.checkBoxLabel.Checked;
		}

		private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.barcode1.Text = this.textBoxValue.Text;
		}
	}
}
