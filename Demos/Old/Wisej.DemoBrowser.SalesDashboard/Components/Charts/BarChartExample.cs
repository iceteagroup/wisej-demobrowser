using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
	[CustomName("Sales Chart Info")]
    [AddToTreeView(false)]
    public partial class BarChartExample : UserControl
    {
        Random random = new Random();
        private int maxValue;
        public int MaxValue
        {
            get {
                if (maxValue == 0) maxValue = 3500;
                return maxValue;

            }
            set
            {
                maxValue = value;
                
            }
        }
        public BarChartExample()
        {
            InitializeComponent();
        }

        private void BarChartExample_Load(object sender, EventArgs e)
        {
            
            Color backgroundColor = CreateRandomColor();
            BarDataSet dataSet = new BarDataSet();
            dataSet.Label = "Sales";
            dataSet.BackgroundColor = new Color[] {
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
                            backgroundColor,
            };
            CreateRandomData(dataSet, 12, MaxValue);
            chartBarExample.DataSets.Add(dataSet);
        }

        private void CreateRandomData(DataSet dataSet, int count, int maxValue)
        {
            lock (random)
            {
                var data = new object[count];
                for (int i = 0; i < count; i++)
                    data[i] = random.Next(maxValue);

                dataSet.Data = data;
            }
            
        }

        private Color CreateRandomColor()
        {
            lock (random)
            {
            return Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
            }
        }
    }
}
