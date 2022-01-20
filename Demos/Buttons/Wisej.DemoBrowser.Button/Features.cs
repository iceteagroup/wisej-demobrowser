using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Button
{
	public partial class Features : DemoView
	{
		private int _clickCount = 0;

		public Features()
		{
			InitializeComponent();
		}

		private void buttonAlertBox_Click(object sender, System.EventArgs e)
		{
			AlertBox.Show("Hello, World!");
		}

		private void buttonMessageBox_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Hello, World!");
		}

		private void buttonToast_Click(object sender, System.EventArgs e)
		{
			new Toast("Hello, World!").Show();
		}

		private async void buttonNativeAlert_Click(object sender, System.EventArgs e)
		{
			await Application.AlertAsync("Hello, World!");
		}

		private void buttonRepeat_Click(object sender, System.EventArgs e)
		{
			this.buttonRepeat.Text = $"Repeat ({++this._clickCount})";
		}
	}
}
