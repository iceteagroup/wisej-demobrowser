using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
    public partial class Syncfusion2 : DemoView
    {
        public Syncfusion2()
        {
            InitializeComponent();
        }

        private void Syncfusion2_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/Syncfusion2");
        }
    }
}
