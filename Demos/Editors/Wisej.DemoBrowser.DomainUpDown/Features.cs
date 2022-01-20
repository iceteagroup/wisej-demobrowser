using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.DomainUpDown
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void domainUpDownDefault_SelectedItemChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Selected Item {this.domainUpDownDefault.SelectedItem}");
		}
	}
}
