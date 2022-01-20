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

        }

        private void txtDemo_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = txtDemo;
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = numericUpDown1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = button1;
        }

        private void checkBox1_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = checkBox1;
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = radioButton1;
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = dateTimePicker1;
        }

        private void timeUpDown1_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = timeUpDown1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = label1;
        }

        private void monthCalendar1_Enter(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = monthCalendar1;
        }

        private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
        {
            AlertBox.Show($"Selected object is {propertyGrid1.SelectedObject.GetType()}");
        }
    }
}
