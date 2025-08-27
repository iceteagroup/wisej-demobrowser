using System;
using System.ComponentModel;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.Common.Views;
using Wisej.DemoBrowser.DataGridView.Views.Data;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataGridView.Views
{
	[Description("This sample shows how easy it is to bind data from a .NET object to a DataGridView in Wisej ")]
    [CustomName("Data Binding")]
    [AddToTreeView(true)]
    [ImageSource("resource.wx/Wisej.Ext.VisualStudioIcons/TwoWayDataBinding.svg")]
    public partial class DGVDataBinding : DemoView
    {
        Random random = new Random();
        BindingList<SampleData> data = new BindingList<SampleData>();

        public DGVDataBinding()
        {
            InitializeComponent();
        }
        private void PopulateDataCollection()
        {
            string[] products = new string[]
            {
                "Product 1",
                "Product 2",
                "Product 3",
                "Product 4"
            };

            for(int i = 0; i < 100; i++)
            {
                data.Add(new SampleData()
                {
                    ClientID = GenerateClientID(),
                    Product = products[random.Next(3)],
                    Quantity = random.Next(120),
                    UnitPrice = Math.Round(random.NextDouble() + 25 * 1.4, 2),
                    OrderDate = GenerateRandomDay()
                });
            }
        }
        private string GenerateClientID()
        {
            string clientId = string.Empty;
            for (int i = 0; i < 8; i++)
            {
                var randomDouble = random.NextDouble();
                clientId+=Convert.ToChar(Convert.ToInt32(Math.Floor(25 * randomDouble) + 65));
            }
            return clientId;
        }

        DateTime GenerateRandomDay()
        {
            DateTime start = new DateTime(2021, 1, 12);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
            this.PopulateDataCollection();
            this.dataGridView1.DataSource = data;
        }

        private void customTab1_Click(object sender, EventArgs e)
        {
            AlertBox.Show("UserControl clicked");
            //new Wisej.DemoBrowser.Common.Components.PopUp().ShowPopup(customTab1);
        }
    }
}
