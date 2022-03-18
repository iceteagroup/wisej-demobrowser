using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ProgressButton : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public ProgressButton()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.progressButton8.Options.isToggle = this.checkBoxIsToggle.Checked;
			this.progressButton8.Options.duration = this.numericUpDownDuration.Value;
			this.progressButton8.Options.enableProgress = this.checkBoxProgress.Checked;

			this.progressButton8.Instance.refresh();
			this.progressButton8.Update();
        }
    }
}
