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

		private void igShapeChart_Load(object sender, EventArgs e)
		{
			this.igShapeChart1.Options.transitionDuration = 250;
			this.igShapeChart1.Options.xAxisInterval = 20;
			this.igShapeChart1.Options.yAxisInterval = 20;
			this.igShapeChart1.Options.xAxisMinimumValue = 0;
			this.igShapeChart1.Options.yAxisMinimumValue = 0;
			this.igShapeChart1.Options.xAxisMaximumValue = 100;
			this.igShapeChart1.Options.yAxisMaximumValue = 100;
			this.igShapeChart1.Options.xAxisTickLength = 5;
			this.igShapeChart1.Options.yAxisTickLength = 5;
			this.igShapeChart1.Options.xAxisTickStrokeThickness = 1;
			this.igShapeChart1.Options.yAxisTickStrokeThickness = 1;
			this.igShapeChart1.Options.xAxisTickStroke = "gray";
			this.igShapeChart1.Options.yAxisTickStroke = "gray";
			this.igShapeChart1.Options.thickness = 2;
			this.igShapeChart1.Options.isHorizontalZoomEnabled = true;
			this.igShapeChart1.Options.isVerticalZoomEnabled = true;
			this.igShapeChart1.Options.markerTypes = new string[]{"circle"};
			this.igShapeChart1.Options.chartType = "point";
			this.igShapeChart1.Options.title = "point";
			this.igShapeChart1.Options.dataSource = new dynamic[]{new {X = 20, Y = 20, R = 10, Value = 10, },
				new {X = 20, Y = 80, R = 30, Value = 10, },
				new {X = 80, Y = 80, R = 30, Value = 90, },
				new {X = 80, Y = 20, R = 10, Value = 90, },
			};
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
