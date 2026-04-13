using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ChartJS4
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Ignite_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/Ignite");
        }
    }
}
