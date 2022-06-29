using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
    public partial class DevExtreme : DemoView
    {
        public DevExtreme()
        {
            InitializeComponent();
        }

        private void DevExtreme_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/DevExtreme");
        }
    }
}
