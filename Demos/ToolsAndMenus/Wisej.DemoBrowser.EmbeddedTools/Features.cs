using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.EmbeddedTools
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Tool_Click(object sender, ToolClickEventArgs e)
        {
            AlertBox.Show("Tool Clicked");
        }
    }
}
