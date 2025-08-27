using System;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;
namespace Wisej.DemoBrowser.SalesDashboard.Components.Items.ChartsGroupView
{
    public partial class ChartsGroupItem : Wisej.DemoBrowser.Common.Components.DashboardItemView
    {
        public ChartsGroupItem()
        {
            InitializeComponent();
        }

        private void ChartsGroupItem_Load(object sender, EventArgs e)
        {
            DoughnutDataSet dataSet1 = new DoughnutDataSet();
            DoughnutDataSet dataSet2 = new DoughnutDataSet();
            DoughnutDataSet dataSet3 = new DoughnutDataSet();
            DoughnutDataSet dataSet4 = new DoughnutDataSet();


            this.chartsGroup1.chartJS31.Labels = new string[]
            {
                "Sales Achieved",
                "Sales Goal"
            };

            this.chartsGroup1.chartJS32.Labels = new string[]
            {
                "New Customer Goal",
                "New Customers"
            };


            dataSet1.BackgroundColor = new System.Drawing.Color[]
            {
                System.Drawing.Color.FromArgb(255,11, 205, 112),
                System.Drawing.Color.Gray
            };

            dataSet1.Data = new object[]
            {
                1000000,
                600000
            };

            dataSet2.BackgroundColor = new System.Drawing.Color[]
            {
                System.Drawing.Color.Red,
                System.Drawing.Color.Gray
            };

            dataSet2.Data = new object[]
            {
                1000000,
                600000
            };

            this.chartsGroup1.chartJS31.DataSets.Add(dataSet1);
            this.chartsGroup1.chartJS32.DataSets.Add(dataSet2);
            this.chartsGroup1.chartJS33.DataSets.Add(dataSet1);

        }
    }
}
