using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Pannellum
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }
        private void pannellum_WidgetEvent(object sender, WidgetEventArgs e)
        {
            if (e.Type == "hotspot")
                AlertBox.Show(e.Data.text);
        }
    }
}
