using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class TimeBoard : ViewBase
	{
		public TimeBoard()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.timeBoard1.Options.twelve = this.checkBoxShowTwelve.Checked;
			this.timeBoard1.Options.seconds = this.checkBoxShowSeconds.Checked;
			this.timeBoard1.Options.stringResult = this.checkBoxEnableStringResult.Checked;

			this.timeBoard1.Update();
        }
    }
}
