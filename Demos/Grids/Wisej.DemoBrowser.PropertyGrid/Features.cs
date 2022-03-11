using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.PropertyGrid
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = personCard1.Person;
        }

        private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
        {
            AlertBox.Show($"Selected object is {propertyGrid1.SelectedObject.GetType()}");
        }
    }
}
