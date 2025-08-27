using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TrackBar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void trackBarDefault_ValueChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Value: {this.trackBarDefault.Value}");
		}
	}
}
