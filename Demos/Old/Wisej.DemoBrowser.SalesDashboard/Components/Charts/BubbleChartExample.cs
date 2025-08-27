using System;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;
namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts
{
    public partial class BubbleChartExample : Wisej.Web.UserControl
    {
        public BubbleChartExample()
        {
            InitializeComponent();
        }

        private void chartJS31_Load(object sender, EventArgs e)
        {
          
        }

        private void BubbleChartExample_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.Label = "Visiting Time";
            dataSet.BackgroundColor = System.Drawing.Color.Red;
            dataSet.Data = new object[]
            {
                150,
                200,
                700,
                332,
                300,
                100
            };
            chartJS31.DataSets.Add(dataSet);
        }
    }
}
