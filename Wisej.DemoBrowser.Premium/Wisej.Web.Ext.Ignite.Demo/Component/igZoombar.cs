using System;
using System.Threading;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igZoombar : TestBase
	{
		private Ignite.igZoombar igZoombar1;

		public igZoombar()
		{
			InitializeComponent();
		}
		
		private void igZoombar_Load(object sender, EventArgs e)
		{
			this.igDataChart1.Options.axes = new object[]
			{
				new
				{
					name = "xAxis",
					type = "categoryDateTimeX",
					dataSource = new object[]
					{
						new
						{
							Index = 0, Open = 1000, High = 1025.25, Low = 970.25, Close = 1025, Volume = 1982.25,
							Date = "2010-01-02T12:00:00.000",
							DateString = "1/2/2010",
							Category = "", Change = 25, ChangePerCent = 2.5
						},
						new
						{
							Index = 1, Open = 1025, High = 1062.25, Low = 1006.25, Close = 1057, Volume = 1981.5,
							Date = "2010-01-03T12:00:00.000",
							DateString = "1/3/2010",
							Category = "", Change = 32, ChangePerCent = 3.1219512195122
						},
						new
						{
							Index = 2, Open = 1057, High = 1078.5, Low = 1019, Close = 1058, Volume = 1963.25,
							Date = "2010-01-04T12:00:00.000",
							DateString = "1/4/2010",
							Category = "", Change = 1, ChangePerCent = 0.0946073793755913
						},
						new
						{
							Index = 3, Open = 1058, High = 1079.75, Low = 1027.5, Close = 1072, Volume = 1986.25,
							Date = "2010-01-05T12:00:00.000",
							DateString = "1/5/2010",
							Category = "", Change = 14, ChangePerCent = 1.32325141776938
						},
						new
						{
							Index = 4, Open = 1072, High = 1098, Low = 1048, Close = 1056, Volume = 1972,
							Date = "2010-01-06T12:00:00.000",
							DateString = "1/6/2010",
							Category = "", Change = -16, ChangePerCent = -1.49253731343284
						},
						new
						{
							Index = 5, Open = 1056, High = 1072.5, Low = 1026.75, Close = 1043, Volume = 1969,
							Date = "2010-01-07T12:00:00.000",
							DateString = "1/7/2010",
							Category = "", Change = -13, ChangePerCent = -1.23106060606061
						},
						new
						{
							Index = 6, Open = 1043, High = 1062.5, Low = 1024.25, Close = 1029, Volume = 1956.75,
							Date = "2010-01-08T12:00:00.000",
							DateString = "1/8/2010",
							Category = "", Change = -14, ChangePerCent = -1.34228187919463
						},
						new
						{
							Index = 7, Open = 1029, High = 1063.5, Low = 999.5, Close = 1011, Volume = 1967,
							Date = "2010-01-09T12:00:00.000",
							DateString = "1/9/2010",
							Category = "", Change = -18, ChangePerCent = -1.74927113702624
						},
						new
						{
							Index = 8, Open = 1011, High = 1037.75, Low = 996, Close = 1027, Volume = 1995,
							Date = "2010-01-10T12:00:00.000",
							DateString = "1/10/2010",
							Category = "", Change = 16, ChangePerCent = 1.58259149357072
						},
						new
						{
							Index = 9, Open = 1027, High = 1062, Low = 997, Close = 1026, Volume = 1969.75,
							Date = "2010-01-11T12:00:00.000",
							DateString = "1/11/2010",
							Category = "", Change = -1, ChangePerCent = -0.0973709834469328
						},
						new
						{
							Index = 10, Open = 1026, High = 1041.5, Low = 998.5, Close = 1006, Volume = 1958.25,
							Date = "2010-01-12T12:00:00.000",
							DateString = "1/12/2010",
							Category = "", Change = -20, ChangePerCent = -1.94931773879142
						},
						new
						{
							Index = 11, Open = 1006, High = 1035.25, Low = 978.5, Close = 1018, Volume = 1947.75,
							Date = "2010-01-13T12:00:00.000",
							DateString = "1/13/2010",
							Category = "", Change = 12, ChangePerCent = 1.19284294234592
						},
						new
						{
							Index = 12, Open = 1018, High = 1035.75, Low = 990, Close = 1020, Volume = 1946,
							Date = "2010-01-14T12:00:00.000",
							DateString = "1/14/2010",
							Category = "", Change = 2, ChangePerCent = 0.196463654223969
						},
						new
						{
							Index = 13, Open = 1020, High = 1050, Low = 1003.25, Close = 1049, Volume = 1940.5,
							Date = "2010-01-15T12:00:00.000",
							DateString = "1/15/2010",
							Category = "", Change = 29, ChangePerCent = 2.84313725490196
						}
					},
					dateTimeMemberPath = "Date",
					labelVisibility = "visible"
				},
				new
				{
					name = "yAxis",
					type = "numericY"
				}
			};
			this.igDataChart1.Options.series = new object[]
			{
				new
				{
					name = "series1",
					dataSource = new object[]
					{
						new
						{
							Index = 0, Open = 1000, High = 1025.25, Low = 970.25, Close = 1025, Volume = 1982.25,
							Date = "2010-01-02T12:00:00.000",
							DateString = "1/2/2010",
							Category = "", Change = 25, ChangePerCent = 2.5
						},
						new
						{
							Index = 1, Open = 1025, High = 1062.25, Low = 1006.25, Close = 1057, Volume = 1981.5,
							Date = "2010-01-03T12:00:00.000",
							DateString = "1/3/2010",
							Category = "", Change = 32, ChangePerCent = 3.1219512195122
						},
						new
						{
							Index = 2, Open = 1057, High = 1078.5, Low = 1019, Close = 1058, Volume = 1963.25,
							Date = "2010-01-04T12:00:00.000",
							DateString = "1/4/2010",
							Category = "", Change = 1, ChangePerCent = 0.0946073793755913
						},
						new
						{
							Index = 3, Open = 1058, High = 1079.75, Low = 1027.5, Close = 1072, Volume = 1986.25,
							Date = "2010-01-05T12:00:00.000",
							DateString = "1/5/2010",
							Category = "", Change = 14, ChangePerCent = 1.32325141776938
						},
						new
						{
							Index = 4, Open = 1072, High = 1098, Low = 1048, Close = 1056, Volume = 1972,
							Date = "2010-01-06T12:00:00.000",
							DateString = "1/6/2010",
							Category = "", Change = -16, ChangePerCent = -1.49253731343284
						},
						new
						{
							Index = 5, Open = 1056, High = 1072.5, Low = 1026.75, Close = 1043, Volume = 1969,
							Date = "2010-01-07T12:00:00.000",
							DateString = "1/7/2010",
							Category = "", Change = -13, ChangePerCent = -1.23106060606061
						},
						new
						{
							Index = 6, Open = 1043, High = 1062.5, Low = 1024.25, Close = 1029, Volume = 1956.75,
							Date = "2010-01-08T12:00:00.000",
							DateString = "1/8/2010",
							Category = "", Change = -14, ChangePerCent = -1.34228187919463
						},
						new
						{
							Index = 7, Open = 1029, High = 1063.5, Low = 999.5, Close = 1011, Volume = 1967,
							Date = "2010-01-09T12:00:00.000",
							DateString = "1/9/2010",
							Category = "", Change = -18, ChangePerCent = -1.74927113702624
						},
						new
						{
							Index = 8, Open = 1011, High = 1037.75, Low = 996, Close = 1027, Volume = 1995,
							Date = "2010-01-10T12:00:00.000",
							DateString = "1/10/2010",
							Category = "", Change = 16, ChangePerCent = 1.58259149357072
						},
						new
						{
							Index = 9, Open = 1027, High = 1062, Low = 997, Close = 1026, Volume = 1969.75,
							Date = "2010-01-11T12:00:00.000",
							DateString = "1/11/2010",
							Category = "", Change = -1, ChangePerCent = -0.0973709834469328
						},
						new
						{
							Index = 10, Open = 1026, High = 1041.5, Low = 998.5, Close = 1006, Volume = 1958.25,
							Date = "2010-01-12T12:00:00.000",
							DateString = "1/12/2010",
							Category = "", Change = -20, ChangePerCent = -1.94931773879142
						},
						new
						{
							Index = 11, Open = 1006, High = 1035.25, Low = 978.5, Close = 1018, Volume = 1947.75,
							Date = "2010-01-13T12:00:00.000",
							DateString = "1/13/2010",
							Category = "", Change = 12, ChangePerCent = 1.19284294234592
						},
						new
						{
							Index = 12, Open = 1018, High = 1035.75, Low = 990, Close = 1020, Volume = 1946,
							Date = "2010-01-14T12:00:00.000",
							DateString = "1/14/2010",
							Category = "", Change = 2, ChangePerCent = 0.196463654223969
						},
						new
						{
							Index = 13, Open = 1020, High = 1050, Low = 1003.25, Close = 1049, Volume = 1940.5,
							Date = "2010-01-15T12:00:00.000",
							DateString = "1/15/2010",
							Category = "", Change = 29, ChangePerCent = 2.84313725490196
						}
					},
					title = "Price Series",
					type = "financial",
					isTransitionInEnabled = true, displayType = "ohlc",
					xAxis = "xAxis",
					yAxis = "yAxis",
					openMemberPath = "Open",
					highMemberPath = "High",
					lowMemberPath = "Low",
					showTooltip = false, closeMemberPath = "Close",
					thickness = 2, trendLineBrush = "rgba(68, 172, 214, .8)",
					trendLineThickness = 5, trendLineType = "exponentialAverage",
					negativeBrush = "rgba(198, 45, 54, .8)"
				},
				new
				{
					name = "series2",
					dataSource = new object[]
					{
						new
						{
							Index = 0, Open = 1000, High = 1021.5, Low = 963.75, Close = 1020, Volume = 1989,
							Date = "2010-01-02T12:00:00.000",
							DateString = "1/2/2010",
							Category = "", Change = 20, ChangePerCent = 2
						},
						new
						{
							Index = 1, Open = 1020, High = 1044, Low = 988.5, Close = 1029, Volume = 1980,
							Date = "2010-01-03T12:00:00.000",
							DateString = "1/3/2010",
							Category = "", Change = 9, ChangePerCent = 0.882352941176471
						},
						new
						{
							Index = 2, Open = 1029, High = 1055.5, Low = 1001, Close = 1043, Volume = 1984.75,
							Date = "2010-01-04T12:00:00.000",
							DateString = "1/4/2010",
							Category = "", Change = 14, ChangePerCent = 1.36054421768707
						},
						new
						{
							Index = 3, Open = 1043, High = 1075, Low = 1025, Close = 1054, Volume = 1972,
							Date = "2010-01-05T12:00:00.000",
							DateString = "1/5/2010",
							Category = "", Change = 11, ChangePerCent = 1.05465004793864
						},
						new
						{
							Index = 4, Open = 1054, High = 1081.25, Low = 1034.75, Close = 1044, Volume = 1991.75,
							Date = "2010-01-06T12:00:00.000",
							DateString = "1/6/2010",
							Category = "", Change = -10, ChangePerCent = -0.94876660341556
						},
						new
						{
							Index = 5, Open = 1044, High = 1056.25, Low = 1025, Close = 1048, Volume = 2014,
							Date = "2010-01-07T12:00:00.000",
							DateString = "1/7/2010",
							Category = "", Change = 4, ChangePerCent = 0.383141762452107
						},
						new
						{
							Index = 6, Open = 1048, High = 1067.75, Low = 1009.75, Close = 1026, Volume = 2020,
							Date = "2010-01-08T12:00:00.000",
							DateString = "1/8/2010",
							Category = "", Change = -22, ChangePerCent = -2.09923664122137
						},
						new
						{
							Index = 7, Open = 1026, High = 1048, Low = 996.5, Close = 1014, Volume = 2017.5,
							Date = "2010-01-09T12:00:00.000",
							DateString = "1/9/2010",
							Category = "", Change = -12, ChangePerCent = -1.16959064327485
						},
						new
						{
							Index = 8, Open = 1014, High = 1032, Low = 980.5, Close = 1022, Volume = 2011.75,
							Date = "2010-01-10T12:00:00.000",
							DateString = "1/10/2010",
							Category = "", Change = 8, ChangePerCent = 0.788954635108481
						},
						new
						{
							Index = 9, Open = 1022, High = 1050.25, Low = 989.5, Close = 1036, Volume = 2013,
							Date = "2010-01-11T12:00:00.000",
							DateString = "1/11/2010",
							Category = "", Change = 14, ChangePerCent = 1.36986301369863
						},
						new
						{
							Index = 10, Open = 1036, High = 1054.25, Low = 1021.25, Close = 1044, Volume = 2005.75,
							Date = "2010-01-12T12:00:00.000",
							DateString = "1/12/2010",
							Category = "", Change = 8, ChangePerCent = 0.772200772200772
						},
						new
						{
							Index = 11, Open = 1044, High = 1062.5, Low = 1012.75, Close = 1024, Volume = 2024.25,
							Date = "2010-01-13T12:00:00.000",
							DateString = "1/13/2010",
							Category = "", Change = -20, ChangePerCent = -1.91570881226054
						},
						new
						{
							Index = 12, Open = 1024, High = 1049.25, Low = 1001.25, Close = 1006, Volume = 2020,
							Date = "2010-01-14T12:00:00.000",
							DateString = "1/14/2010",
							Category = "", Change = -18, ChangePerCent = -1.7578125
						},
						new
						{
							Index = 13, Open = 1006, High = 1013.75, Low = 983.5, Close = 1007, Volume = 2011.75,
							Date = "2010-01-15T12:00:00.000",
							DateString = "1/15/2010",
							Category = "", Change = 1, ChangePerCent = 0.099403578528827
						},
						new
						{
							Index = 14, Open = 1007, High = 1034.25, Low = 986.75, Close = 1027, Volume = 1986.25,
							Date = "2010-01-16T12:00:00.000",
							DateString = "1/16/2010",
							Category = "", Change = 20, ChangePerCent = 1.98609731876862
						},
						new
						{
							Index = 15, Open = 1027, High = 1048, Low = 995, Close = 996, Volume = 1969.75,
							Date = "2010-01-17T12:00:00.000",
							DateString = "1/17/2010",
							Category = "", Change = -31, ChangePerCent = -3.01850048685492
						},
						new
						{
							Index = 16, Open = 996, High = 1020, Low = 976.75, Close = 976, Volume = 1945.25,
							Date = "2010-01-18T12:00:00.000",
							DateString = "1/18/2010",
							Category = "", Change = -20, ChangePerCent = -2.00803212851406
						},
						new
						{
							Index = 17, Open = 976, High = 999.5, Low = 955.75, Close = 979, Volume = 1938.75,
							Date = "2010-01-19T12:00:00.000",
							DateString = "1/19/2010",
							Category = "", Change = 3, ChangePerCent = 0.307377049180328
						}
					},
					title = "Price Series",
					type = "financial",
					isTransitionInEnabled = true, xAxis = "xAxis",
					yAxis = "yAxis",
					openMemberPath = "Open",
					highMemberPath = "High",
					lowMemberPath = "Low",
					closeMemberPath = "Close",
					thickness = 2, showTooltip = false, trendLineBrush = "rgba(73, 73, 73, .8)",
					trendLineThickness = 5, trendLineType = "exponentialAverage",
					negativeBrush = "rgba(198, 45, 54, .8)",
					displayType = "ohlc"
				}
			};
			this.igDataChart1.Options.horizontalZoomable = true;
			this.igDataChart1.Options.verticalZoomable = false;
			this.igDataChart1.Options.windowResponse = "immediate";

			this.igZoombar1 = new Ignite.igZoombar(new { target = $"#id_{this.igDataChart1.Handle}_container" });
			this.igZoombar1.Dock = DockStyle.Fill;
			this.igZoombar1.Load += IgZoombar1_Load;

			this.panel1.Controls.Add(this.igZoombar1);
		}

		private void IgZoombar1_Load(object sender, EventArgs e)
		{
			this.igZoombar1.Options.zoomWindowMoveDistance = this.numericUpDown1.Value;
			this.igZoombar1.Options.zoomWindowMinWidth = this.numericUpDown2.Value;
			this.igZoombar1.Options.windowPanDuration = this.numericUpDown3.Value;

			this.igZoombar1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igZoombar1.Options.zoomWindowMoveDistance = this.numericUpDown1.Value;
			this.igZoombar1.Options.zoomWindowMinWidth = this.numericUpDown2.Value;
			this.igZoombar1.Options.windowPanDuration = this.numericUpDown3.Value;

			this.igZoombar1.Update();
		}
	}
}