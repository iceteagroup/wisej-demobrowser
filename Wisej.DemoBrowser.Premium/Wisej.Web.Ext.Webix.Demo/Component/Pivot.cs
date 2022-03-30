using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class Pivot : ViewBase
    {
        public Pivot()
        {
            InitializeComponent();
        }

        private void Pivot_Load(object sender, EventArgs e)
        {
            this.pivot1.Options.structure.rows = new[] {"form", "name"};
            this.pivot1.Options.structure.columns = new[] {"year"};
            this.pivot1.Options.structure.values = new dynamic[]
            {
                new
                {
                    name = "oil",
                    operation = new[] {"min", "sum"}
                }
            };
            

            this.pivot1.Options.url = "https://cdn.webix.com/demodata/pivot.json";
        }
    }
}
