using System;
using System.ComponentModel;
using Wisej.Design;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
    public partial class ChartsGroup : UserControl
    {
        public ChartsGroup()
        {
            InitializeComponent();
        }
		private ChartType _chartType1;
		private ChartType _chartType2;
		private ChartType _chartType3;


		[DesignerActionList]
		[DefaultValue(ChartType.Line)]
		[RefreshProperties(RefreshProperties.All)]
		[Description("Returns or sets the chart type for chart 1.")]
		public ChartType ChartType1
		{
			get { return this._chartType1; }
			set
			{
				if (this._chartType1 != value)
				{
					this._chartType1 = value;

					// change the options to match the chart type.
					this.chartJS31.ChartType = this._chartType1;

					this.chartJS31.Update();
				}
			}
		}

		[DesignerActionList]
		[DefaultValue(ChartType.Line)]
		[RefreshProperties(RefreshProperties.All)]
		[Description("Returns or sets the chart type for chart 3.")]
		public ChartType ChartType2
		{
			get { return this._chartType2; }
			set
			{
				if (this._chartType2 != value)
				{
					this._chartType2 = value;

					// change the options to match the chart type.
					this.chartJS32.ChartType = this._chartType2;

					this.chartJS32.Update();
				}
			}
		}

		[DesignerActionList]
		[DefaultValue(ChartType.Line)]
		[RefreshProperties(RefreshProperties.All)]
		[Description("Returns or sets the chart type for chart 3.")]
		public ChartType ChartType3
		{
			get { return this._chartType3; }
			set
			{
				if (this._chartType3 != value)
				{
					this._chartType3 = value;

					// change the options to match the chart type.
					this.chartJS33.ChartType = this._chartType3;

					this.chartJS33.Update();
				}
			}
		}



		//private Options CreateOptions(ChartJS3 chart)
		//{
		//	switch (chart.ChartType)
		//	{
		//		case ChartType.Line:
		//			return new LineOptions(chart, chart.Options);
		//		case ChartType.Bar:
		//		case ChartType.HorizontalBar:
		//			return new BarOptions(chart, chart.Options);
		//		case ChartType.Pie:
		//			return new PieOptions(chart, chart.Options);
		//		case ChartType.PolarArea:
		//			return new PolarAreaOptions(chart, chart.Options);
		//		case ChartType.Doughnut:
		//			return new DoughnutOptions(chart, chart.Options);
		//		case ChartType.Radar:
		//			return new RadarOptions(chart, chart.Options);
		//		case ChartType.Bubble:
		//			return new BubbleOptions(chart, chart.Options);
		//		case ChartType.Scatter:
		//			return new ScatterOptions(chart, chart.Options);

		//		default:
		//			throw new InvalidOperationException("Unknown chart type.");
		//	}

		//}

		
	}
}
