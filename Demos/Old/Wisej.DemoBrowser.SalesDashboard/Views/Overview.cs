using System;
using Wisej.Web;

namespace Wisej.DemoBrowser.SalesDashboard.Views
{
	public partial class Overview : Wisej.DemoBrowser.Common.Views.OverviewView
	{
		public Overview()
		{
			InitializeComponent();
            this.overviewSample1.buttonExplore.Click += ButtonExplore_Click;
		}

        private void ButtonExplore_Click(object sender, EventArgs e)
        {
            var parent = (Panel)this.Parent;
            parent.Controls.Clear();
            parent.Controls.Add(new DashboardMain() { Dock = DockStyle.Fill });
        }
    }
}
