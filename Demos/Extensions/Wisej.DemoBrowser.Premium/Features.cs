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

		private void buttonKendo_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Kendo");
		}

		private void buttonDevExtreme_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}DevExtreme");
		}

		private void buttonEJ1_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Syncfusion");
		}

		private void buttonEJ2_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Syncfusion2");
		}

		private void buttonIgniteUI_Click(object sender, EventArgs e)
		{
			Application.Navigate($"{BASE_URL}Ignite");
		}
	}
}
