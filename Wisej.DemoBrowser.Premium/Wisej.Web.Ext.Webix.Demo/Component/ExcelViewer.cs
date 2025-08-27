using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class ExcelViewer : ViewBase
	{
		public ExcelViewer()
		{
			InitializeComponent();
		}

        private void ExcelViewer_Load(object sender, EventArgs e)
        {
			var serviceUrl = ((IWisejHandler)this.excelViewer1).GetServiceURL();
			this.excelViewer1.Options.url = $"binary->{serviceUrl}?action=load";
        }

        private void excelViewer1_WebRequest(object sender, WebRequestEventArgs e)
        {
			switch (e.Request["action"])
            {
                case "load":
                    e.Response.BinaryWrite(File.ReadAllBytes(Application.MapPath("Data/data.xlsx")));
                    break;

            }
        }
    }
}
