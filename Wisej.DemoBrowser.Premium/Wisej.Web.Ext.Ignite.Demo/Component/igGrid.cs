using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igGrid : TestBase
	{
		public igGrid()
		{
			InitializeComponent();

			igGrid1.Instance.onCellClick += new WidgetEventHandler(igGrid_WidgetEvent);
			igGrid1.Instance.onCellRightClick += new WidgetEventHandler(igGrid_WidgetEvent);
		}


		private void igGrid_Load(object sender, EventArgs e)
		{
			igGrid1.Options.primaryKey = "ProductID";
			igGrid1.Options.columns = new dynamic[]
			{
				new {headerText = "Product ID", key = "ProductID", dataType = "number", width = "15%", hidden = true},
				new
				{
					headerText = "Image", key = "ImageUrl", dataType = "string", width = "15%",
					template = "<img style=\"height:50px; \" src=\"${ImageUrl} \"/>", },
				new {headerText = "Product Name", key = "ProductName", dataType = "string", width = "25%"},
				new {headerText = "Category", key = "CategoryName", dataType = "string", width = "25%"},
				new {headerText = "Units In Stock", key = "InStock", dataType = "number", width = "35%"}
			};


			igGrid1.Options.autofitLastColumn = false;
			igGrid1.Options.autoGenerateColumns = false;
			igGrid1.Options.dataSource = new dynamic[]
			{
				new
				{
					ProductID = 1, ProductName = "Chai", CategoryName = "Beverages", ImageUrl = "Images/Grid/1.jpg",
					InStock = 39
				},
				new
				{
					ProductID = 2, ProductName = "Chang", CategoryName = "Beverages", ImageUrl = "Images/Grid/1.jpg",
					InStock = 17
				},
				new
				{
					ProductID = 3, ProductName = "Aniseed Syrup", CategoryName = "Condiments",
					ImageUrl = "Images/Grid/2.jpg", InStock = 13
				},
				new
				{
					ProductID = 4, ProductName = "Chef Antonu0027s Cajun Seasoning", CategoryName = "Condiments",
					ImageUrl = "Images/Grid/2.jpg", InStock = 53
				},
				new
				{
					ProductID = 5, ProductName = "Chef Antonu0027s Gumbo Mix", CategoryName = "Condiments",
					ImageUrl = "Images/Grid/2.jpg", InStock = 0
				},
				new
				{
					ProductID = 6, ProductName = "Grandmau0027s Boysenberry Spread", CategoryName = "Condiments",
					ImageUrl = "Images/Grid/2.jpg", InStock = 120
				},
				new
				{
					ProductID = 7, ProductName = "Uncle Bobu0027s Organic Dried Pears", CategoryName = "Produce",
					ImageUrl = "Images/Grid/7.jpg", InStock = 15
				},
				new
				{
					ProductID = 8, ProductName = "Northwoods Cranberry Sauce", CategoryName = "Condiments",
					ImageUrl = "Images/Grid/2.jpg", InStock = 6
				},
				new
				{
					ProductID = 9, ProductName = "Mishi Kobe Niku", CategoryName = "Meat/Poultry",
					ImageUrl = "Images/Grid/6.jpg", InStock = 29
				},
				new
				{
					ProductID = 10, ProductName = "Ikura", CategoryName = "Seafood", ImageUrl = "Images/Grid/8.jpg",
					InStock = 31
				},
				new
				{
					ProductID = 11, ProductName = "Queso Cabrales", CategoryName = "Dairy Products",
					ImageUrl = "Images/Grid/4.jpg", InStock = 22
				},
				new
				{
					ProductID = 12, ProductName = "Queso Manchego La Pastora", CategoryName = "Dairy Products",
					ImageUrl = "Images/Grid/4.jpg", InStock = 86
				},
				new
				{
					ProductID = 13, ProductName = "Konbu", CategoryName = "Seafood", ImageUrl = "Images/Grid/8.jpg",
					InStock = 24
				},
				new
				{
					ProductID = 14, ProductName = "Tofu", CategoryName = "Produce", ImageUrl = "Images/Grid/7.jpg",
					InStock = 35
				},
				new
				{
					ProductID = 15, ProductName = "Genen Shouyu", CategoryName = "Condiments",
					ImageUrl = "Images/Grid/2.jpg", InStock = 39
				},
				new
				{
					ProductID = 16, ProductName = "Pavlova", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 29
				},
				new
				{
					ProductID = 17, ProductName = "Alice Mutton", CategoryName = "Meat/Poultry",
					ImageUrl = "Images/Grid/6.jpg", InStock = 0
				},
				new
				{
					ProductID = 18, ProductName = "Carnarvon Tigers", CategoryName = "Seafood",
					ImageUrl = "Images/Grid/8.jpg", InStock = 42
				},
				new
				{
					ProductID = 19, ProductName = "Teatime Chocolate Biscuits", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 25
				},
				new
				{
					ProductID = 20, ProductName = "Sir Rodneyu0027s Marmalade", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 40
				},
				new
				{
					ProductID = 21, ProductName = "Sir Rodneyu0027s Scones", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 3
				},
				new
				{
					ProductID = 22, ProductName = "Gustafu0027s Kn�ckebr�d", CategoryName = "Grains/Cereals",
					ImageUrl = "Images/Grid/5.jpg", InStock = 104
				},
				new
				{
					ProductID = 23, ProductName = "Tunnbr�d", CategoryName = "Grains/Cereals",
					ImageUrl = "Images/Grid/5.jpg", InStock = 61
				},
				new
				{
					ProductID = 24, ProductName = "Guaraná Fantástica", CategoryName = "Beverages",
					ImageUrl = "Images/Grid/1.jpg", InStock = 20
				},
				new
				{
					ProductID = 25, ProductName = "NNuNuCa Nuß-Nougat-Creme", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 76
				},
				new
				{
					ProductID = 26, ProductName = "Gumbär Gummibärchen", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 15
				},
				new
				{
					ProductID = 27, ProductName = "Schoggi Schokolade", CategoryName = "Confections",
					ImageUrl = "Images/Grid/3.jpg", InStock = 49
				},
				new
				{
					ProductID = 28, ProductName = "Rössle Sauerkraut", CategoryName = "Produce",
					ImageUrl = "Images/Grid/7.jpg", InStock = 26
				},
				new
				{
					ProductID = 29, ProductName = "Thüringer Rostbratwurst", CategoryName = "Meat/Poultry",
					ImageUrl = "Images/Grid/6.jpg", InStock = 0
				},
				new
				{
					ProductID = 30, ProductName = "Nord-Ost Matjeshering", CategoryName = "Seafood",
					ImageUrl = "Images/Grid/8.jpg", InStock = 10
				}
			};
			igGrid1.Options.responseDataKey = "results";
			igGrid1.Options.autoCommit = true;
			igGrid1.Options.features = new dynamic[]
			{
				new {name = "Sorting", sortingDialogContainment = "window"},
				new
				{
					name = "Filtering", type = "local", columnSettings = new dynamic[]
					{
						new {columnKey = "ImageUrl", allowFiltering = false},
						new {columnKey = "InStock", condition = "greaterThan"}
					}
				},
				new
				{
					name = "GroupBy", columnSettings = new dynamic[]
					{
						new {columnKey = "CategoryName", isGroupBy = true}
					}
				},
				new {name = "Selection"},
				new {name = "Resizing"},
				new
				{
					name = "Updating", editMode = "dialog", enableAddRow = false, columnSettings = new dynamic[]
					{
						new {columnKey = "ImageUrl", readOnly = false}
					}
				}
			};
		}


		private void igGrid_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			igGrid1.Instance.dataSourceObject(data);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await igGrid1.Instance.getUnboundValuesAsync();

			using (var ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myAppointments.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			igGrid1.Options.enableHoverStyles = checkBox1.Checked;
			igGrid1.Options.alternateRowStyles = checkBox2.Checked;
			igGrid1.Options.showHeader = checkBox4.Checked;

			igGrid1.Update();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var result = await igGrid1.Instance.getCellValueAsync(1, "ProductName");

			AlertBox.Show(result);
		}

		
	}
}