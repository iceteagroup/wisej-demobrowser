using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ListBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void listBoxDefaultCities_SelectedIndexChanged(object sender, EventArgs e)
		{
			new Toast($"Selected {this.listBoxDefaultCities.SelectedItem}")
			{
				BackColor = Color.Crimson
			}.Show();
		}
	}
}
