using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class RangeNavigator : TestBase
	{
		public RangeNavigator()
		{
			InitializeComponent();
		}

		private void RangeNavigator_Load(object sender, EventArgs e)
		{
			this.rangeNavigator1.Options.valueType = "DateTime";
			this.rangeNavigator1.Options.value = new object[]
			{
				"2017-08-31T08:00:00.000",
				"2018-01-31T07:00:00.000"
			};
			this.rangeNavigator1.Options.labelFormat = "MMM-yy";
			this.rangeNavigator1.Options.series = new object[]
			{
				new
				{
					dataSource = new object[]
					{
						new
						{
							x = "2017-05-01",
							y = 1402.08
						},
						new
						{
							x = "2017-05-02",
							y = 1443.68
						},
						new
						{
							x = "2017-05-03",
							y = 1492
						},
						new
						{
							x = "2017-05-04",
							y = 1515.63
						},
						new
						{
							x = "2017-05-05",
							y = 1512.21
						},
						new
						{
							x = "2017-05-06",
							y = 1548.29
						},
						new
						{
							x = "2017-05-07",
							y = 1555.47
						},
						new
						{
							x = "2017-05-08",
							y = 1639.32
						},
						new
						{
							x = "2017-05-09",
							y = 1706.93
						},
						new
						{
							x = "2017-05-10",
							y = 1756.8
						},
						new
						{
							x = "2017-05-11",
							y = 1807.37
						},
						new
						{
							x = "2017-05-12",
							y = 1676.99
						},
						new
						{
							x = "2017-05-13",
							y = 1759.96
						},
						new
						{
							x = "2017-05-14",
							y = 1772.42
						},
						new
						{
							x = "2017-05-15",
							y = 1697.38
						},
						new
						{
							x = "2017-05-16",
							y = 1718.2
						},
						new
						{
							x = "2017-05-17",
							y = 1802.16
						},
						new
						{
							x = "2017-05-18",
							y = 1887.33
						},
						new
						{
							x = "2017-05-19",
							y = 1968.1
						},
						new
						{
							x = "2017-05-20",
							y = 2051.73
						},
						new
						{
							x = "2017-05-21",
							y = 2055.62
						},
						new
						{
							x = "2017-05-22",
							y = 2139.03
						},
						new
						{
							x = "2017-05-23",
							y = 2291.48
						}
					},
					xName = "x",
					yName = "y",
					type = "Area",
					width = 2
				}
			};
		}
	}
}