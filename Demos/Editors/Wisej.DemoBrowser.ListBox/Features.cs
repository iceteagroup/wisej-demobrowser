using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ListBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void listBoxDefaultCities_SelectedIndexChanged(object sender, EventArgs e)
		{
			new Toast($"Selected {this.listBoxDefaultCities.SelectedItem}")
			{
				BackColor = Color.Crimson
			}.Show();
		}

        private void checkBoxReadOnly_CheckedChanged(object sender, EventArgs e)
        {
			var readOnly = this.checkBoxReadOnly.Checked;

			this.listBoxHtml.ReadOnly = readOnly;
			this.listBoxSpacing.ReadOnly = readOnly;
			this.listBoxDefaultCities.ReadOnly = readOnly;
		}
    }
}
