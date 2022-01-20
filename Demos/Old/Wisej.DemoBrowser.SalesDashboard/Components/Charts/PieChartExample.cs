using System;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
	[CustomName("Overview Chart Info")]
    [AddToTreeView(false)]
    public partial class PieChartExample : UserControl
    {
        Random random = new Random();
        public PieChartExample()
        {
            InitializeComponent();
        }

        private void PieChartExample_Load(object sender, EventArgs e)
        {
            var chartData = ChartData.GetChartData();
            var dataSet = new PieDataSet();
            dataSet.Label = "Overview";
            this.chartJS31.Labels = chartData.Select(item => item.Label).ToArray();
            dataSet.Data = chartData.Select(item => item.Value).Cast<object>().ToArray();
            dataSet.BackgroundColor = new System.Drawing.Color[dataSet.Data.Length];
            //Random background chart colors
            for (int i = 0; i < dataSet.Data.Length; i++)
            {
                System.Drawing.Color color = System.Drawing.Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
                dataSet.BackgroundColor.SetValue(color, i);
            }

            this.chartJS31.DataSets.Add(dataSet);

        }
    }

    internal class ChartData
    {
        private string _label;
        private double _value;

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }
        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public static System.Collections.Generic.List<ChartData> GetChartData()
        {
            System.Collections.Generic.List<ChartData> chartData = new System.Collections.Generic.List<ChartData>();
            chartData.Add(new ChartData { Label = "Convertion Rate",Value = 60 });
            chartData.Add(new ChartData { Label = "Registration Rate",Value = 30 });
            chartData.Add(new ChartData { Label = "Sales Rate",Value = 10 });
            return chartData;
        }
    }
}
