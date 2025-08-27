using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
    public partial class Syncfusion : DemoView
    {
        public Syncfusion()
        {
            InitializeComponent();
        }

        private void Syncfusion_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/Syncfusion");
        }
    }
}
