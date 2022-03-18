using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igSparkline : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igSparkline()
		{
			InitializeComponent();
		}

		private void igSparkline_Load(object sender, EventArgs e)
		{
			this.igSparkline1.Options.dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/Sparkline/data.json")));
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			this.igSparkline1.Options.dataSource = JSON.Parse(e.Files[0].InputStream);

			this.igSparkline1.Update();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.igSparkline1.Instance.getDataAsync();

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myData.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igSparkline1.Options.displayType = this.comboBox1.SelectedItem;
			this.igSparkline1.Options.lineThickness = this.numericUpDown1.Value;
			this.igSparkline1.Options.trendLineType = this.comboBox2.SelectedItem;

			this.igSparkline1.Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var data = new
			{
				ShipName = Guid.NewGuid().ToString(),
				ShipAddress = "Obere Str. 57",
				ShipCity = "Berlin",
				ShipRegion = "",
				ShipPostalCode = "12209",
				ShipCountry = "Germany",
				CustomerID = "ALFKI",
				CustomerName = "Alfreds Futterkiste",
				Address = "Obere Str. 57",
				City = "Berlin",
				Region = "",
				PostalCode = "12209",
				Country = "Germany",
				Salesperson = "Margaret Peacock",
				OrderID = 10692 + _id++,
				OrderDate = "1997-10-03T00:00:00Z",
				RequiredDate = "1997-10-31T00:00:00Z",
				ShippedDate = "1997-10-13T00:00:00Z",
				ShipperName = "United Package",
				ProductID = 63,
				ProductName = "Vegie-spread",
				UnitPrice = 43.9000,
				Quantity = 20,
				Discount = 0,
				ExtendedPrice = 878.0000 + new Random().Next(1, 2000),
				Freight = 61.0200
			};

			this.igSparkline1.Instance.addItem(data);
		}
		private int _id = 1;
	}
}
