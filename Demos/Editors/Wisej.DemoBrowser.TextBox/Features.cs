using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TextBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void textBoxDefault_TextChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Text Changed: {this.textBoxDefault.Text}");
		}

		private void textBoxDefault_KeyPress(object sender, KeyPressEventArgs e)
		{
			AlertBox.Show($"Key Press: {e.KeyChar}");
		}
	}
}
