using System;
using System.Drawing;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Uploader : TestBase
	{
		public Uploader()
		{
			InitializeComponent();
		}

		private void Uploader_Load(object sender, EventArgs e)
		{
			var postback = ((IWisejHandler)this.uploader1).GetServiceURL();

			this.uploader1.Options = new
			{
				allowedExtensions = ".jpg,.png",
				asyncSettings = new
				{
					saveUrl = $"{postback}?action=save",
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.uploader1.Options.multiple = this.checkBoxMultiple.Checked;
			this.uploader1.Options.sequentialUpload = this.checkBoxSequentiallUpload.Checked;


			this.uploader1.Update();
        }

        private void uploader1_WebRequest(object sender, WebRequestEventArgs e)
        {
            switch (e.Request["action"])
            {
				case "save":
					var files = e.Request.Files;
					this.pictureBox1.Image = Image.FromStream(files[0].InputStream);
					break;
            }
        }
    }
}
