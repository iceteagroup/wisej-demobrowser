using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.NumericUpDown
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void numericUpDownDefault_ValueChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Changed Value: {this.numericUpDownDefault.Value}");
		}
	}
}
