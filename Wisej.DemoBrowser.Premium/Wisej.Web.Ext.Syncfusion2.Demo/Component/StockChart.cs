using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class StockChart : TestBase
	{
		public StockChart()
		{
			InitializeComponent();
		}

		private void StockChart_Load(object sender, EventArgs e)
		{
			this.stockChart1.Options.title = "AAPL Stock Price";
			this.stockChart1.Options.series = new[]
			{
				new 
				{
					type = "Candle",
					dataSource = GetData()
				}
			};
		}

		private dynamic GetData()
        {
			var text = File.ReadAllText(Application.MapPath("Data/Stocks/data.json"));
			return JSON.Parse(text).chartData;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.stockChart1.Options.isTransposed = this.checkBoxIsTransposed.Checked;
			this.stockChart1.Options.isMultiSelect = this.checkBoxMultiSelect.Checked;
			this.stockChart1.Options.enableRtl = this.checkBoxIsSelecEnableRtl.Checked;

			this.stockChart1.Update();
        }
    }
}
