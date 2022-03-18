using System;
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
			this.stockChart1.Options.series[0].dataSource = new[]
			{
				new
				{
					x = DateTime.Now,
					open = 85.9757,
					high = 90.6657,
					low = 85.7685,
					close = 90.5257,
					volume = 660187068
				}
			};
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.stockChart1.Options.isSelect = this.checkBoxIsSelect.Checked;
			this.stockChart1.Options.isTransposed = this.checkBoxIsTranspoed.Checked;

			this.stockChart1.Update();
        }
    }
}
