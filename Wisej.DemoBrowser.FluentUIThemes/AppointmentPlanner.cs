using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.FluentUIThemes
{
    public partial class AppointmentPlanner : DemoView
    {
        public AppointmentPlanner()
        {
            InitializeComponent();
        }

        private void Ignite_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/Ignite");
        }
    }
}
