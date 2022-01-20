using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
	[CustomName("Visitors Chart Info")]
    [AddToTreeView(false)]
    public partial class LineChartExample : UserControl
    {

        public LineChartExample()
        {
            InitializeComponent();
        }

        private void LineChartExample_Load(object sender, EventArgs e)
        {
            FillDataSet();
        }


        private void FillDataSet()
        {

            LineDataSet dataSet = new LineDataSet();
            dataSet.Label = "Visitors";
            dataSet.BackgroundColor = Color.FromArgb(255, 40, 115, 245);
            CreateRandomData(dataSet, 12, 3500);
            this.chartLineExample.DataSets.Add(dataSet);
        }

        private void CreateRandomData(DataSet dataSet, int count, int maxValue)
        {
            var data = new object[count];
            Random random = new Random();
            for (int i = 0; i < count; i++)
                data[i] = random.Next(maxValue);

            dataSet.Data = data;
        }
    }
}
