using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.SplitButton
{
	public partial class Features : DemoView
	{
		private int _count = 0;

		public Features()
		{
			InitializeComponent();
		}

		private void splitButtonCities_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Clicked Button");
		}

		private void splitButtonRepeat_Click(object sender, EventArgs e)
		{
			this.splitButtonRepeat.Text = $"Repeat ({++_count})";
		}

        private void splitButton_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
        {
			AlertBox.Show($"Selected Item: {e.Item.Text}");
        }
    }
}
