using System;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS3;
using Wisej.DemoBrowser.Common.Views;
using System.Drawing;
using Wisej.DemoBrowser.Common.Components;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.SalesDashboard.Components.Charts.Items.BarChartItemView
{
    [CustomName("Sales Chart Info")]
    [AddToTreeView(false)]
    public partial class BarChartItem : DashboardItemView
    {
        public BarChartItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var tabControl = (TabControl)this.Parent;
            //var tabPage = new TabPage("Yeheehe");
            //tabControl.TabPages.Add(tabPage);
        }
    }
}
