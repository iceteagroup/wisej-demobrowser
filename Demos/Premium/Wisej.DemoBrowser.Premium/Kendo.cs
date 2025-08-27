using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
    public partial class Kendo : DemoView
    {
        public Kendo()
        {
            InitializeComponent();
        }

        private void Kendo_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/Kendo");
        }
    }
}
