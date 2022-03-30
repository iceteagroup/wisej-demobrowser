using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDataChartIndicator : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igDataChartIndicator()
		{
			InitializeComponent();

			this.igDataChart1.Instance.onAxisRangeChanged += new WidgetEventHandler(igDataChart_WidgetEvent);
		}

		private void igDataChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igDataChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igDataChart1.Update();
		}

		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Call("exportImageData");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Instance.addItem(new {
				Index = 51,
				Date = "5/7/2013",
				Open = 25.72,
				High = 35.89,
				Low = 25.22,
				Close = 25.44,
				Volume = 49547075
			});
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Options.isSquare = this.checkBox1.Checked;
			this.igDataChart1.Options.isHorizontalZoomEnabled = this.checkBox2.Checked;
			this.igDataChart1.Options.highlightingTransitionDuration = this.numericUpDown1.Value;

			this.igDataChart1.Update();
		}
	}
}
