using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Uploader : TestBase
	{
		public Uploader()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.uploader1.Options.multiple = this.checkBoxMultiple.Checked;
			this.uploader1.Options.allowedExtensions = this.tagTextBoxAllowedExtensions.Text;
			this.uploader1.Options.sequentialUpload = this.checkBoxSequentiallUpload.Checked;


			this.uploader1.Update();
        }
    }
}
