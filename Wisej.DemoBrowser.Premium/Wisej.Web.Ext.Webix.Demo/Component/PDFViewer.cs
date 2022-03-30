using System;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class PDFViewer : ViewBase
	{
		public PDFViewer()
		{
			InitializeComponent();
		}

        private void PDFViewer_Load(object sender, EventArgs e)
        {
			var serviceUrl = ((IWisejHandler)this.pdfViewer1).GetServiceURL();

			this.pdfViewer1.Options.toolbar = "toolbar";
			this.pdfViewer1.Options.url = $"binary->{serviceUrl}?action=load";
        }

        private void pdfViewer1_WebRequest(object sender, WebRequestEventArgs e)
        {
            switch (e.Request["action"])
            {
                case "load":
                    e.Response.WriteFile(Application.MapPath("Data/Wisej-Datasheet-V2.2.pdf"));
                    break;
            }
        }
    }
}
