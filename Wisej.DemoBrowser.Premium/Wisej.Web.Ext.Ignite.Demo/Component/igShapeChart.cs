using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igShapeChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igShapeChart()
		{
			InitializeComponent();

			this.igShapeChart1.Instance.onSeriesPointerUp += new WidgetEventHandler(igShapeChart_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igShapeChart1.Options.title = this.comboBox1.SelectedItem;
			this.igShapeChart1.Options.chartType = this.comboBox1.SelectedItem;
			this.igShapeChart1.Options.crosshairsDisplayMode = this.comboBox2.SelectedItem;
			this.igShapeChart1.Options.isHorizontalZoomEnabled = this.checkBox1.Checked;
			this.igShapeChart1.Options.isVerticalZoomEnabled = this.checkBox2.Checked;

			switch (this.comboBox1.SelectedItem)
			{
				case "highDensity":
					this.igShapeChart1.Call("SetDensityData");
					break;

				case "polygon":
				case "polyline":
					this.igShapeChart1.Call("SetShapeData");
					break;

				default:
					break;

			}

			this.igShapeChart1.Update();
		}

		private void igShapeChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
