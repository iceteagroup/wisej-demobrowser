using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
    public partial class Ignite : DemoView
    {
        public Ignite()
        {
            InitializeComponent();
        }

        private void Ignite_Load(object sender, EventArgs e)
        {
            Application.Navigate($"/Ignite");
        }
    }
}
