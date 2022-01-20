using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.CheckBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
		{
			new Toast($"Check Changed: {checkBoxDefault.Checked}").Show();
		}
	}
}