using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.RadioButton
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void RadioButton_Load(object sender, System.EventArgs e)
		{
		}

		private void RadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			var radioButton = (Wisej.Web.RadioButton)sender;

			if (radioButton.Checked)
				AlertBox.Show($"Selected {radioButton.Text}");
		}
	}
}
