using System;
using System.ComponentModel;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.Common.Components;
using Wisej.DemoBrowser.Dashboards.Sales.Components.Items.PieChartItemView;
using Wisej.DemoBrowser.Dashboards.Sales.Views.Items.LineChartItemView;
using Wisej.DemoBrowser.SalesDashboard.Components.Charts.Items.BarChartItemView;
using Wisej.DemoBrowser.SalesDashboard.Components.Items.BarChartItemView;
using Wisej.Web;

namespace Wisej.DemoBrowser.SalesDashboard.Views
{
    [AddToTreeView(true)]
    [CustomName("Sales Dashboard")]
    [ImageSource("https://powerbicdn.azureedge.net/mediahandler/blog/legacymedia/4645.dashboard2.png")]
    [Description("A Sales dashboard made with Wisej extensions and controls")]
    public partial class DashboardMain : DashboardView
    {
        public DashboardMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void DashboardMain_Load(object sender, EventArgs e)
        {
            this.lineChartItem1.button1.Click += MoreInfo_Click;
            this.barChartItem1.button1.Click += MoreInfo_Click;
            this.pieChartItem1.button1.Click += MoreInfo_Click;
        }

        private void MoreInfo_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var name = GetCustomAttributeValue(button.Parent.GetType());
            switch (button.Parent)
            {
                case LineChartItem item:
                    {
                        break;
                    }

                case BarChartItem item:
                    {
                        var infoTab = new TabPage(name);
                        infoTab.AutoScroll = true;
                        infoTab.ScrollBars = ScrollBars.Hidden;
                        infoTab.ShowCloseButton = true;
                        infoTab.Controls.Add(new BarChartItemInfo() { Dock = DockStyle.Fill });
                        this.tabControl1.TabPages.Add(infoTab);
                        this.tabControl1.SelectTab(infoTab);
                        break;
                    }
                case PieChartItem item:
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private string GetCustomAttributeValue(Type type)
        {
            if (CustomNameAttribute.DisplayCustomName(type).Equals(string.Empty))
            {
                return type.Name;
            }
            else
            {
                return CustomNameAttribute.DisplayCustomName(type);
            }
        }
    }
}
