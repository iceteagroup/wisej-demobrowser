using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Premium
{
	public partial class Features : DemoView
	{
		private string BASE_URL = "http://demo.wisej.com/";

		public Features()
		{
			InitializeComponent();
		}

		private void panelDevExtreme_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}DevExtreme");
		}

		private void panelKendo_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Kendo");
		}

		private void panelEJ1_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Syncfusion");
		}

		private void panelEJ2_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Syncfusion2");
		}

		private void panelIgnite_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Ignite");
		}
	}
}
