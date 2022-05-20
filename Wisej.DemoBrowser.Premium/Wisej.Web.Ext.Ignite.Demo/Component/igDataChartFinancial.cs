using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDataChartFinancial : TestBase
	{
		public igDataChartFinancial()
		{
			InitializeComponent();

			igDataChart1.Instance.onAxisRangeChanged += new WidgetEventHandler(igDataChart_WidgetEvent);
		}

		private void igDataChartFinancial_Load(object sender, EventArgs e)
		{
			igDataChart1.Options.title = "Microsoft Stock (MSFT)";
			igDataChart1.Options.subtitle = "Data over two months";


			igDataChart1.Options.dataSource = new dynamic[]
			{
				new
				{
					Index = 1, Date = "7/18/2013", Open = 35.72, High = 35.89, Low = 35.22, Close = 35.44,
					Volume = 49547075
				},
				new
				{
					Index = 2, Date = "7/17/2013", Open = 36.34, High = 36.39, Low = 35.49, Close = 35.74,
					Volume = 37289320
				},
				new
				{
					Index = 3, Date = "7/16/2013", Open = 36.01, High = 36.43, Low = 35.96, Close = 36.27,
					Volume = 36378681
				},
				new
				{
					Index = 4, Date = "7/15/2013", Open = 35.66, High = 36.22, Low = 35.58, Close = 36.17,
					Volume = 34145645
				},
				new
				{
					Index = 5, Date = "7/12/2013", Open = 35.58, High = 35.73, Low = 35.28, Close = 35.67,
					Volume = 35502638
				},
				new
				{
					Index = 6, Date = "7/11/2013", Open = 35, High = 35.77, Low = 34.9, Close = 35.68,
					Volume = 53638234
				},
				new
				{
					Index = 7, Date = "7/10/2013", Open = 34.34, High = 34.81, Low = 34.32, Close = 34.7,
					Volume = 29658734
				},
				new
				{
					Index = 8, Date = "7/9/2013", Open = 34.58, High = 34.6, Low = 34.14, Close = 34.35,
					Volume = 25320908
				},
				new
				{
					Index = 9, Date = "7/8/2013", Open = 34.35, High = 34.59, Low = 33.98, Close = 34.32,
					Volume = 32398742
				},
				new
				{
					Index = 10, Date = "7/5/2013", Open = 34.09, High = 34.24, Low = 33.58, Close = 34.21,
					Volume = 26085981
				},
				new
				{
					Index = 11, Date = "7/3/2013", Open = 33.66, High = 34.37, Low = 33.6, Close = 34.01,
					Volume = 15994380
				},
				new
				{
					Index = 12, Date = "7/2/2013", Open = 34.41, High = 34.44, Low = 33.63, Close = 33.94,
					Volume = 37634572
				},
				new
				{
					Index = 13, Date = "7/1/2013", Open = 34.75, High = 34.99, Low = 34.33, Close = 34.36,
					Volume = 31064000
				},
				new
				{
					Index = 14, Date = "6/28/2013", Open = 34.38, High = 34.79, Low = 34.34, Close = 34.54,
					Volume = 65548196
				},
				new
				{
					Index = 15, Date = "6/27/2013", Open = 34.52, High = 34.78, Low = 34.5, Close = 34.62,
					Volume = 28993542
				},
				new
				{
					Index = 16, Date = "6/26/2013", Open = 34.12, High = 34.48, Low = 33.89, Close = 34.35,
					Volume = 48667834
				},
				new
				{
					Index = 17, Date = "6/25/2013", Open = 34.08, High = 34.38, Low = 33.46, Close = 33.67,
					Volume = 44073348
				},
				new
				{
					Index = 18, Date = "6/24/2013", Open = 32.94, High = 34.2, Low = 32.57, Close = 33.72,
					Volume = 56113708
				},
				new
				{
					Index = 19, Date = "6/21/2013", Open = 33.66, High = 33.73, Low = 33.05, Close = 33.26,
					Volume = 85338395
				},
				new
				{
					Index = 20, Date = "6/20/2013", Open = 34.26, High = 34.33, Low = 33.37, Close = 33.49,
					Volume = 54496758
				},
				new
				{
					Index = 21, Date = "6/19/2013", Open = 34.96, High = 35.09, Low = 34.59, Close = 34.59,
					Volume = 30820208
				},
				new
				{
					Index = 22, Date = "6/18/2013", Open = 34.97, High = 35.17, Low = 34.9, Close = 34.98,
					Volume = 28622929
				},
				new
				{
					Index = 23, Date = "6/17/2013", Open = 34.69, High = 35.16, Low = 34.63, Close = 35,
					Volume = 49672492
				},
				new
				{
					Index = 24, Date = "6/14/2013", Open = 34.55, High = 34.69, Low = 34.25, Close = 34.4,
					Volume = 53116371
				},
				new
				{
					Index = 25, Date = "6/13/2013", Open = 34.99, High = 35.02, Low = 34.59, Close = 34.72,
					Volume = 45654803
				},
				new
				{
					Index = 26, Date = "6/12/2013", Open = 35.14, High = 35.27, Low = 34.85, Close = 35,
					Volume = 37373032
				},
				new
				{
					Index = 27, Date = "6/11/2013", Open = 35.05, High = 35.18, Low = 34.68, Close = 34.84,
					Volume = 39350316
				},
				new
				{
					Index = 28, Date = "6/10/2013", Open = 35.51, High = 35.65, Low = 35.14, Close = 35.47,
					Volume = 35995223
				},
				new
				{
					Index = 29, Date = "6/7/2013", Open = 35.25, High = 35.78, Low = 35.06, Close = 35.67,
					Volume = 40762249
				},
				new
				{
					Index = 30, Date = "6/6/2013", Open = 34.84, High = 35.11, Low = 34.49, Close = 34.96,
					Volume = 37627133
				},
				new
				{
					Index = 31, Date = "6/5/2013", Open = 34.6, High = 34.89, Low = 34.43, Close = 34.78,
					Volume = 46032657
				},
				new
				{
					Index = 32, Date = "6/4/2013", Open = 35.62, High = 35.74, Low = 34.77, Close = 34.99,
					Volume = 65538438
				},
				new
				{
					Index = 33, Date = "6/3/2013", Open = 34.92, High = 35.63, Low = 34.83, Close = 35.59,
					Volume = 51256272
				},
				new
				{
					Index = 34, Date = "5/31/2013", Open = 34.82, High = 35.28, Low = 34.79, Close = 34.9,
					Volume = 56167723
				},
				new
				{
					Index = 35, Date = "5/30/2013", Open = 34.85, High = 35.25, Low = 34.81, Close = 35.03,
					Volume = 51133616
				},
				new
				{
					Index = 36, Date = "5/29/2013", Open = 34.74, High = 35.02, Low = 34.57, Close = 34.88,
					Volume = 38419848
				},
				new
				{
					Index = 37, Date = "5/28/2013", Open = 34.42, High = 35.18, Low = 34.41, Close = 35.02,
					Volume = 48218180
				},
				new
				{
					Index = 38, Date = "5/24/2013", Open = 33.92, High = 34.28, Low = 33.9, Close = 34.27,
					Volume = 33175804
				},
				new
				{
					Index = 39, Date = "5/23/2013", Open = 34.23, High = 34.55, Low = 33.9, Close = 34.15,
					Volume = 51113510
				},
				new
				{
					Index = 40, Date = "5/22/2013", Open = 34.79, High = 34.84, Low = 34.36, Close = 34.61,
					Volume = 65892481
				},
				new
				{
					Index = 41, Date = "5/21/2013", Open = 35.1, High = 35.27, Low = 34.72, Close = 34.85,
					Volume = 48705362
				},
				new
				{
					Index = 42, Date = "5/20/2013", Open = 34.73, High = 35.1, Low = 34.68, Close = 35.08,
					Volume = 54025227
				},
				new
				{
					Index = 43, Date = "5/17/2013", Open = 34.13, High = 34.87, Low = 34.1, Close = 34.87,
					Volume = 60674267
				},
				new
				{
					Index = 44, Date = "5/16/2013", Open = 33.64, High = 34.15, Low = 33.55, Close = 34.08,
					Volume = 59384283
				},
				new
				{
					Index = 45, Date = "5/15/2013", Open = 33.45, High = 33.9, Low = 33.43, Close = 33.84,
					Volume = 46309506
				},
				new
				{
					Index = 46, Date = "5/14/2013", Open = 32.86, High = 33.53, Low = 32.8, Close = 33.53,
					Volume = 56874005
				},
				new
				{
					Index = 47, Date = "5/13/2013", Open = 32.61, High = 33.07, Low = 32.55, Close = 33.03,
					Volume = 36036347
				},
				new
				{
					Index = 48, Date = "5/10/2013", Open = 32.67, High = 32.72, Low = 32.32, Close = 32.69,
					Volume = 36396524
				},
				new
				{
					Index = 49, Date = "5/9/2013", Open = 32.85, High = 33, Low = 32.59, Close = 32.66,
					Volume = 46417802
				},
				new
				{
					Index = 50, Date = "5/8/2013", Open = 33.07, High = 33.24, Low = 32.65, Close = 32.99,
					Volume = 51595643
				}
			};

			igDataChart1.Options.axes = new dynamic[]
			{
				new {type = "categoryX", label = "Date", name = "xAxis", interval = 10, title = "Date"},
				new {type = "numericY", name = "yAxis", title = "Price"}
			};

			igDataChart1.Options.series = new dynamic[]
			{
				new
				{
					type = "financial", isTransitionInEnabled = true, closeMemberPath = "Close",
					highMemberPath = "High", lowMemberPath = "Low", openMemberPath = "Open",
					volumeMemberPath = "Volume", xAxis = "xAxis", yAxis = "yAxis", name = "priceSeries",
					title = "Price Data"
				}
			};

			this.igDataChart1.Options.isVerticalZoomEnabled = true;
			this.igDataChart1.Options.isHorizontalZoomEnabled = true;
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
			igDataChart1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			igDataChart1.Update();
		}

		private void buttonExportImage_Click(object sender, EventArgs e)
		{
			igDataChart1.Call("exportImageData");
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			igDataChart1.Options.defaultInteraction = comboBox1.SelectedItem;
			igDataChart1.Options.dragModifier = comboBox2.SelectedItem;
			igDataChart1.Options.gridMode = comboBox3.SelectedItem;

			igDataChart1.Update();
		}
	}
}