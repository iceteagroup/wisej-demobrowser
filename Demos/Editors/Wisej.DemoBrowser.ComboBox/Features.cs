using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ComboBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			AlertBox.Show($"Selected Index: {this.comboBox1.SelectedIndex}");
        }
    }
}
