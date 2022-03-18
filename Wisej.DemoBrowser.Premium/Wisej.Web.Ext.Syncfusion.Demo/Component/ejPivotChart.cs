using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPivotChart : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejPivotChart()
		{
			InitializeComponent();

			this.ejPivotChart1.Instance.drillSuccess += new WidgetEventHandler(ejPivotChart1_WidgetEvent);
		}

		private void ejPivotChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExportExcel_Click(object sender, EventArgs e)
		{
			//TODO:
			//this.ejPivotChart1.Instance.exportPivotChart("excel");
		}

		private async void buttonSaveJson_Click(object sender, EventArgs e)
		{
			var data = await this.ejPivotChart1.Instance.optionAsync("dataSource");
			var json = Wisej.Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "pivotchart.json");
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejPivotChart1.Instance.renderChartFromJSON(JSON.Parse(json));

					this.ejPivotChart1.Update();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPivotChart1.Options.enable3D = this.checkBox1.Checked;
			this.ejPivotChart1.Options.zooming = new 
			{ 
				enableScrollbar = this.checkBox2.Checked
			};
			this.ejPivotChart1.Options.rotation = this.numericUpDownRotation.Value;
			this.ejPivotChart1.Options.commonSeriesOptions = new
			{
				type = this.comboBox1.SelectedItem.ToString().ToLower()
			};

			this.ejPivotChart1.Update();
		}

		private void ejPivotChart_Load(object sender, EventArgs e)
		{
			// load the data source.
			this.ejPivotChart1.Options.dataSource = new
			{
				data = GenerateDataSource(),
				rows = new[] 
				{
					new 
					{
						fieldName = "Country",
						fieldCaption = "Country"
					}
				},
				columns = new[]
				{
					new 
					{
						fieldName = "Product",
						fieldCaption = "Product"
					}
				},
				values = new[] 
				{
					new
					{
						fieldName = "Amount",
						fieldCaption = "Amount"
					}
				}
			};

			this.ejPivotChart1.Update();
		}

		private List<Sale> GenerateDataSource()
		{
			var list = new List<Sale>();

			list.Add(new Sale(100, "Canada", "Bike"));
			list.Add(new Sale(200, "Germany", "Van"));
			list.Add(new Sale(300, "Germany", "Car"));
			list.Add(new Sale(150, "United Kingdom", "Bike"));
			list.Add(new Sale(200, "Canada", "Car"));

			return list;
		}

		private class Sale
		{
			public int Amount;

			public string Country;

			public string Product;

			public Sale(int amount, string country, string product)
			{
				this.Amount = amount;
				this.Country = country;
				this.Product = product;
			}
		}
	}
}
