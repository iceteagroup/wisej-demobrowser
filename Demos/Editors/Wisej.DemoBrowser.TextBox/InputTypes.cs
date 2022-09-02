using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TextBox
{
	public partial class InputTypes : DemoView
	{
		public InputTypes()
		{
			InitializeComponent();
		}

		private void textBoxButton_Click(object sender, EventArgs e)
		{
			new Toast("Button Clicked").Show();
		}

		private void textBoxCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			new Toast($"Check Value: {this.textBoxCheckBox.Checked}")
			{
				BackColor = Color.Orange
			}.Show();
		}

        private void InputTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
