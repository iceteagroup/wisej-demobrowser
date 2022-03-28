using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class ReportManager : ViewBase
    {
        public ReportManager()
        {
            InitializeComponent();
        }

        private void ReportManager_Load(object sender, EventArgs e)
        {
            this.reportManager1.Options.url = "https://docs.webix.com/reports-backend/";
        }
    }
}
