using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.Barcode;
using Wisej.Web.Ext.Camera;

namespace Wisej.DemoBrowser.Barcode
{
	public partial class Scanner : DemoView
	{
		BarcodeReader reader = new BarcodeReader();

		public Scanner()
		{
			InitializeComponent();
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

		private void Scanner_Load(object sender, EventArgs e)
		{
			reader.Camera = camera1;
			reader.ScanError += new ScanEventHandler(this.reader_ScanError);
			reader.ScanSuccess += new ScanEventHandler(this.reader_ScanSuccess);

			this.comboBox1.Items.AddRange(Enum.GetNames(typeof(Camera.VideoFacingMode)));
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			camera1.FacingMode = (Camera.VideoFacingMode)this.comboBox1.SelectedIndex;
		}
	}
}
