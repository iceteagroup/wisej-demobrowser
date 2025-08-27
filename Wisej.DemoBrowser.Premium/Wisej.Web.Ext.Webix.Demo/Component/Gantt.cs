using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class Gantt : ViewBase
    {
        public Gantt()
        {
            InitializeComponent();
        }

        private void Gantt_Load(object sender, EventArgs e)
        {
            this.gantt1.Options.url = "https://docs.webix.com/gantt-backend/";
        }
    }
}
