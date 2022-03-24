using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDataChartFinancial : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igDataChartFinancial()
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

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDataChart1.Options.defaultInteraction = this.comboBox1.SelectedItem;
			this.igDataChart1.Options.dragModifier = this.comboBox2.SelectedItem;
			this.igDataChart1.Options.gridMode = this.comboBox3.SelectedItem;

			this.igDataChart1.Update();
		}
	}
}
