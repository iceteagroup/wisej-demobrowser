using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoStockChart : TestBase
	{
		public kendoStockChart()
		{
			InitializeComponent();

			this.kendoStockChart1.Instance.onPlotAreaClick += new WidgetEventHandler(kendoStockChart1_WidgetEvent);
		}

		private void kendoStockChart_Load(object sender, EventArgs e)
		{
			this.kendoStockChart1.Options.title.text = "The Boeing Company NYSE:BA";
			

			this.kendoStockChart1.Options.dateField = "Date";

			this.kendoStockChart1.Options.series = new object[]
			{
				new
				{
					type = "candlestick",
					openField = "Open",
					highField = "High",
					lowField = "Low",
					closeField = "Close"
				}
			};

			this.kendoStockChart1.Options.categoryAxis = new
			{
				labels = new
				{
					rotation = "auto"
				}
			};

			this.kendoStockChart1.Options.navigator = new
			{
				series = new
				{
					type = "area",
					field = "Close"
				},
				select = new
				{
					from = "2009/02/05",
					to = "2011/10/07"
				},
				categoryAxis = new
				{
					labels = new
					{
						rotation = "auto"
					}
				}
			};


			var serviceUrl = kendoStockChart1.GetServiceURL();
			this.kendoStockChart1.Options.dataSource = new
			{
				transport = new
				{
					read = new
					{
						url = $"./{serviceUrl}?action=load",
						dataType = "json"
					}
				},
				schema = new
				{
					model = new
					{
						fields = new
						{
							Date = new
							{
								type = "date"
							}
						}
					}
				}
			};
		}

		private void kendoStockChart1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request["action"])
			{
				case "load":
					e.Response.Write(File.ReadAllText(Application.MapPath("Data/Stock/Boeing.json")));
					break;
			}
		}

		private void SetStockChartTitle()
		{
			string title = this.textBoxTitle.Text;
			this.kendoStockChart1.Options.title.title = title;
		}
		private void kendoStockChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonExportPDF_Click(object sender, EventArgs e)
		{
			var dataUrl = await this.kendoStockChart1.Instance.exportPDFAsync();
			var base64 = dataUrl.Replace("data:application/pdf;base64,", "");
			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, "kendoStockChart.pdf");
			}
		}

		private async void buttonExportImage_Click(object sender, EventArgs e)
		{
			var dataUrl = await this.kendoStockChart1.Instance.imageDataURLAsync();
			var base64 = dataUrl.Replace("data:image/png;base64,", "");
			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, "kendoStockChart.png");
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoStockChart1.Options.title.text = textBoxTitle.Text;
		}
	}
}