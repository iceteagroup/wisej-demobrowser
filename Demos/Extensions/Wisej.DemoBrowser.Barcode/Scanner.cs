using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.Barcode;

namespace Wisej.DemoBrowser.Barcode
{
	public partial class Scanner : DemoView
	{
		BarcodeReader reader = new BarcodeReader();

		public Scanner()
		{
			InitializeComponent();

			reader.Camera = camera1;
			reader.ScanError += new ScanEventHandler(this.reader_ScanError);
			reader.ScanSuccess += new ScanEventHandler(this.reader_ScanSuccess);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			reader.ScanImage();
		}

		private void reader_ScanError(object sender, ScanEventArgs e)
		{
			AlertBox.Show("Scan error. Was scan sucessful? "+e.Success);
		}

		private void reader_ScanSuccess(object sender, ScanEventArgs e)
		{
			AlertBox.Show("Scanned. Was scan sucessful ? "+e.Success+" Data: "+e.Data);
		}
	}
}
