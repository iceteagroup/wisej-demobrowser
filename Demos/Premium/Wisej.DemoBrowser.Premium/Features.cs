using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void panelDevExtreme_Click(object sender, EventArgs e)
		{
			Application.Navigate($"/DevExtreme");
		}

		private void panelKendo_Click(object sender, EventArgs e)
		{
			Application.Navigate($"/Kendo");
		}

		private void panelEJ1_Click(object sender, EventArgs e)
		{
			Application.Navigate($"/Syncfusion");
		}

		private void panelEJ2_Click(object sender, EventArgs e)
		{
			Application.Navigate($"/Syncfusion2");
		}

		private void panelIgnite_Click(object sender, EventArgs e)
		{
			Application.Navigate($"/Ignite");
		}

		private void panelDashboard_Click(object sender, EventArgs e)
		{
			Application.Navigate("/DxDashboard");
		}
	}
}
