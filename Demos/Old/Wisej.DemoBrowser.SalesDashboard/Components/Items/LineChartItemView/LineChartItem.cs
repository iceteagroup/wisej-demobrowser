using System;
using Wisej.Web;
using Wisej.DemoBrowser.Common.Views;
using Wisej.Web.Ext.ChartJS3;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.Common.Components;
namespace Wisej.DemoBrowser.Dashboards.Sales.Views.Items.LineChartItemView
{
    [CustomName("Visitors Chart Info")]
    [AddToTreeView(false)]
    public partial class LineChartItem : DashboardItemView
    {

        public LineChartItem()
        {
            InitializeComponent();
        }

        private void LineChartExample_Load(object sender, EventArgs e)
        {
            
        }
    }
}
