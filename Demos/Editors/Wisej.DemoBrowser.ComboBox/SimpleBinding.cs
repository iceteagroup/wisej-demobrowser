using System;
using System.ComponentModel;
using Wisej.DemoBrowser.Common;
namespace Wisej.DemoBrowser.ComboBox
{
    public partial class SimpleBinding : DemoView
    {
        public SimpleBinding()
        {
            InitializeComponent();
        }

        private void SimpleBinding_Load(object sender, EventArgs e)
        {
            string[] simpleArray = new string[] { 
            "Product #1",
            "Product #2",
            "Product #3",
            "Product #4",
            "Product #5",
            "Product #6",
            "Product #7",
            "Product #8",
            "Product #9",
            "Product #10",
            "Product #11",
            "Product #12",
            "Product #13",
            "Product #14",
            "Product #15",
            "Product #16",
            "Product #17",
            "Product #18",
            "Product #19",
            "Product #20",
            "Product #21",
            "Product #22",
            "Product #23",
            "Product #24",
            };

            this.comboBox1.DataSource = simpleArray;
            this.comboBox2.DataSource = simpleArray;
            this.comboBox3.DataSource = simpleArray;
        }
    }
}
