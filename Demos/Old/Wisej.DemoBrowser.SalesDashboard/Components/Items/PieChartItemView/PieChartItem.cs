using System;
using Wisej.DemoBrowser.Common.Views;
using Wisej.Web;
using System.Linq;
using Wisej.Web.Ext.ChartJS3;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.Common.Components;
namespace Wisej.DemoBrowser.Dashboards.Sales.Components.Items.PieChartItemView
{
    [CustomName("Overview Chart Info")]
    [AddToTreeView(false)]
    public partial class PieChartItem : DashboardItemView
    {
        Random random = new Random();
        public PieChartItem()
        {
            InitializeComponent();
        }

        private void PieChartExample_Load(object sender, EventArgs e)
        {
            

        }
    }
}
