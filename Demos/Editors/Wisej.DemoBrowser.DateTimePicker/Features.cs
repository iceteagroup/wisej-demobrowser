using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.DateTimePicker
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void dateTimePickerDefault_ValueChanged(object sender, EventArgs e)
		{
			AlertBox.Show($"Selected Date {this.dateTimePickerDefault.Value}");
		}

		private void dateTimePickerDefault_CloseUp(object sender, EventArgs e)
		{
			AlertBox.Show($"Closed Dialog with Date {this.dateTimePickerDefault.Value}");
		}
	}
}
