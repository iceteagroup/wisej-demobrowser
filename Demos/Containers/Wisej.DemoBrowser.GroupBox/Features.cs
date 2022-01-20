using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.GroupBox
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void grpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (grpCheckBox.Checked)
            {
                AlertBox.Show("Groupbox enabled");
                return;
            }
            AlertBox.Show("Groupbox disabled");
        }
    }
}
