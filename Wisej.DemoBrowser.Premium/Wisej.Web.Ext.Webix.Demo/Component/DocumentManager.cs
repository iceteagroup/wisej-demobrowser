using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class DocumentManager : ViewBase
    {
        private void DocumentManager_Load(object sender, EventArgs e)
        {
            this.documentManager1.Options.url = "https://docs.webix.com/docmanager-backend/";
        }

        public DocumentManager()
        {
            InitializeComponent();
        }
    }
}
