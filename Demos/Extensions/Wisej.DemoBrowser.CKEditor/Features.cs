using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.CKEditor
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void checkBoxReadOnly_CheckedChanged(object sender, EventArgs e)
		{
			this.ckEditor1.ReadOnly = this.checkBoxReadOnly.Checked;
		}

		private void checkBoxFooter_CheckedChanged(object sender, EventArgs e)
		{
			this.ckEditor1.ShowFooter = this.checkBoxFooter.Checked;
		}

		private void checkBoxToolbar_CheckedChanged(object sender, EventArgs e)
		{
			this.ckEditor1.ShowToolbar = this.checkBoxToolbar.Checked;
		}
	}
}
