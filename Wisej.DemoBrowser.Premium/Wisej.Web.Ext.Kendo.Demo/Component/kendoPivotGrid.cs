using System;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoPivotGrid : TestBase
	{
		public kendoPivotGrid()
		{
			InitializeComponent();

			this.kendoPivotGrid1.Instance.onExpandMember += new WidgetEventHandler(kendoPivotGrid1_WidgetEvent);
		}

		private void kendoPivotGrid_Load(object sender, EventArgs e)
		{
			var serviceUrl = this.kendoPivotGrid1.GetServiceURL();

			this.kendoPivotGrid1.Options.filterable = true;
			this.kendoPivotGrid1.Options.sortable = true;
			this.kendoPivotGrid1.Options.columnWidth = 120;
			this.kendoPivotGrid1.Options.dataSource = new
			{
				data = new dynamic[]
				{
					new
					{
						ProductID = 1, ProductName = "Chai", SupplierID = 1, CategoryID = 1,
						QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = 18, UnitsInStock = 39, UnitsOnOrder = 0,
						ReorderLevel = 10, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 2, ProductName = "Chang", SupplierID = 1, CategoryID = 1,
						QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 19, UnitsInStock = 17, UnitsOnOrder = 40,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 3, ProductName = "Aniseed Syrup", SupplierID = 1, CategoryID = 2,
						QuantityPerUnit = "12 - 550 ml bottles", UnitPrice = 10, UnitsInStock = 13, UnitsOnOrder = 70,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", SupplierID = 2, CategoryID = 2,
						QuantityPerUnit = "48 - 6 oz jars", UnitPrice = 22, UnitsInStock = 53, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", SupplierID = 2, CategoryID = 2,
						QuantityPerUnit = "36 boxes", UnitPrice = 21.35, UnitsInStock = 0, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 6, ProductName = "Grandma's Boysenberry Spread", SupplierID = 3, CategoryID = 2,
						QuantityPerUnit = "12 - 8 oz jars", UnitPrice = 25, UnitsInStock = 120, UnitsOnOrder = 0,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", SupplierID = 3, CategoryID = 7,
						QuantityPerUnit = "12 - 1 lb pkgs.", UnitPrice = 30, UnitsInStock = 15, UnitsOnOrder = 0,
						ReorderLevel = 10, Discontinued = false, Category = new
						{
							CategoryID = 7,
							CategoryName = "Produce",
							Description = "Dried fruit and bean curd"
						}
					},
					new
					{
						ProductID = 8, ProductName = "Northwoods Cranberry Sauce", SupplierID = 3, CategoryID = 2,
						QuantityPerUnit = "12 - 12 oz jars", UnitPrice = 40, UnitsInStock = 6, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 9, ProductName = "Mishi Kobe Niku", SupplierID = 4, CategoryID = 6,
						QuantityPerUnit = "18 - 500 g pkgs.", UnitPrice = 97, UnitsInStock = 29, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 6,
							CategoryName = "Meat/Poultry",
							Description = "Prepared meats"
						}
					},
					new
					{
						ProductID = 10, ProductName = "Ikura", SupplierID = 4, CategoryID = 8,
						QuantityPerUnit = "12 - 200 ml jars", UnitPrice = 31, UnitsInStock = 31, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 11, ProductName = "Queso Cabrales", SupplierID = 5, CategoryID = 4,
						QuantityPerUnit = "1 kg pkg.", UnitPrice = 21, UnitsInStock = 22, UnitsOnOrder = 30,
						ReorderLevel = 30, Discontinued = false, Category = new
						{
							CategoryID = 4,
							CategoryName = "Dairy Products",
							Description = "Cheeses"
						}
					},
					new
					{
						ProductID = 12, ProductName = "Queso Manchego La Pastora", SupplierID = 5, CategoryID = 4,
						QuantityPerUnit = "10 - 500 g pkgs.", UnitPrice = 38, UnitsInStock = 86, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 4,
							CategoryName = "Dairy Products",
							Description = "Cheeses"
						}
					},
					new
					{
						ProductID = 13, ProductName = "Konbu", SupplierID = 6, CategoryID = 8,
						QuantityPerUnit = "2 kg box",
						UnitPrice = 6, UnitsInStock = 24, UnitsOnOrder = 0, ReorderLevel = 5, Discontinued = false,
						Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 14, ProductName = "Tofu", SupplierID = 6, CategoryID = 7,
						QuantityPerUnit = "40 - 100 g pkgs.", UnitPrice = 23.25, UnitsInStock = 35, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 7,
							CategoryName = "Produce",
							Description = "Dried fruit and bean curd"
						}
					},
					new
					{
						ProductID = 15, ProductName = "Genen Shouyu", SupplierID = 6, CategoryID = 2,
						QuantityPerUnit = "24 - 250 ml bottles", UnitPrice = 15.5, UnitsInStock = 39, UnitsOnOrder = 0,
						ReorderLevel = 5, Discontinued = false, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 16, ProductName = "Pavlova", SupplierID = 7, CategoryID = 3,
						QuantityPerUnit = "32 - 500 g boxes", UnitPrice = 17.45, UnitsInStock = 29, UnitsOnOrder = 0,
						ReorderLevel = 10, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 17, ProductName = "Alice Mutton", SupplierID = 7, CategoryID = 6,
						QuantityPerUnit = "20 - 1 kg tins", UnitPrice = 39, UnitsInStock = 0, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 6,
							CategoryName = "Meat/Poultry",
							Description = "Prepared meats"
						}
					},
					new
					{
						ProductID = 18, ProductName = "Carnarvon Tigers", SupplierID = 7, CategoryID = 8,
						QuantityPerUnit = "16 kg pkg.", UnitPrice = 62.5, UnitsInStock = 42, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 19, ProductName = "Teatime Chocolate Biscuits", SupplierID = 8, CategoryID = 3,
						QuantityPerUnit = "10 boxes x 12 pieces", UnitPrice = 9.2, UnitsInStock = 25, UnitsOnOrder = 0,
						ReorderLevel = 5, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 20, ProductName = "Sir Rodney's Marmalade", SupplierID = 8, CategoryID = 3,
						QuantityPerUnit = "30 gift boxes", UnitPrice = 81, UnitsInStock = 40, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 21, ProductName = "Sir Rodney's Scones", SupplierID = 8, CategoryID = 3,
						QuantityPerUnit = "24 pkgs. x 4 pieces", UnitPrice = 10, UnitsInStock = 3, UnitsOnOrder = 40,
						ReorderLevel = 5, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 22, ProductName = "Gustaf's Kn�ckebr�d", SupplierID = 9, CategoryID = 5,
						QuantityPerUnit = "24 - 500 g pkgs.", UnitPrice = 21, UnitsInStock = 104, UnitsOnOrder = 0,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 5,
							CategoryName = "Grains/Cereals",
							Description = "Breads, crackers, pasta, and cereal"
						}
					},
					new
					{
						ProductID = 23, ProductName = "Tunnbr�d", SupplierID = 9, CategoryID = 5,
						QuantityPerUnit = "12 - 250 g pkgs.", UnitPrice = 9, UnitsInStock = 61, UnitsOnOrder = 0,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 5,
							CategoryName = "Grains/Cereals",
							Description = "Breads, crackers, pasta, and cereal"
						}
					},
					new
					{
						ProductID = 24, ProductName = "Guaran� Fant�stica", SupplierID = 10, CategoryID = 1,
						QuantityPerUnit = "12 - 355 ml cans", UnitPrice = 4.5, UnitsInStock = 20, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 25, ProductName = "NuNuCa Nu�-Nougat-Creme", SupplierID = 11, CategoryID = 3,
						QuantityPerUnit = "20 - 450 g glasses", UnitPrice = 14, UnitsInStock = 76, UnitsOnOrder = 0,
						ReorderLevel = 30, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 26, ProductName = "Gumb�r Gummib�rchen", SupplierID = 11, CategoryID = 3,
						QuantityPerUnit = "100 - 250 g bags", UnitPrice = 31.23, UnitsInStock = 15, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 27, ProductName = "Schoggi Schokolade", SupplierID = 11, CategoryID = 3,
						QuantityPerUnit = "100 - 100 g pieces", UnitPrice = 43.9, UnitsInStock = 49, UnitsOnOrder = 0,
						ReorderLevel = 30, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 28, ProductName = "R�ssle Sauerkraut", SupplierID = 12, CategoryID = 7,
						QuantityPerUnit = "25 - 825 g cans", UnitPrice = 45.6, UnitsInStock = 26, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 7,
							CategoryName = "Produce",
							Description = "Dried fruit and bean curd"
						}
					},
					new
					{
						ProductID = 29, ProductName = "Th�ringer Rostbratwurst", SupplierID = 12, CategoryID = 6,
						QuantityPerUnit = "50 bags x 30 sausgs.", UnitPrice = 123.79, UnitsInStock = 0,
						UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 6,
							CategoryName = "Meat/Poultry",
							Description = "Prepared meats"
						}
					},
					new
					{
						ProductID = 30, ProductName = "Nord-Ost Matjeshering", SupplierID = 13, CategoryID = 8,
						QuantityPerUnit = "10 - 200 g glasses", UnitPrice = 25.89, UnitsInStock = 10, UnitsOnOrder = 0,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 31, ProductName = "Gorgonzola Telino", SupplierID = 14, CategoryID = 4,
						QuantityPerUnit = "12 - 100 g pkgs", UnitPrice = 12.5, UnitsInStock = 0, UnitsOnOrder = 70,
						ReorderLevel = 20, Discontinued = false, Category = new
						{
							CategoryID = 4,
							CategoryName = "Dairy Products",
							Description = "Cheeses"
						}
					},
					new
					{
						ProductID = 32, ProductName = "Mascarpone Fabioli", SupplierID = 14, CategoryID = 4,
						QuantityPerUnit = "24 - 200 g pkgs.", UnitPrice = 32, UnitsInStock = 9, UnitsOnOrder = 40,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 4,
							CategoryName = "Dairy Products",
							Description = "Cheeses"
						}
					},
					new
					{
						ProductID = 33, ProductName = "Geitost", SupplierID = 15, CategoryID = 4,
						QuantityPerUnit = "500 g",
						UnitPrice = 2.5, UnitsInStock = 112, UnitsOnOrder = 0, ReorderLevel = 20, Discontinued = false,
						Category = new
						{
							CategoryID = 4,
							CategoryName = "Dairy Products",
							Description = "Cheeses"
						}
					},
					new
					{
						ProductID = 34, ProductName = "Sasquatch Ale", SupplierID = 16, CategoryID = 1,
						QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 14, UnitsInStock = 111, UnitsOnOrder = 0,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 35, ProductName = "Steeleye Stout", SupplierID = 16, CategoryID = 1,
						QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = 18, UnitsInStock = 20, UnitsOnOrder = 0,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 36, ProductName = "Inlagd Sill", SupplierID = 17, CategoryID = 8,
						QuantityPerUnit = "24 - 250 g  jars", UnitPrice = 19, UnitsInStock = 112, UnitsOnOrder = 0,
						ReorderLevel = 20, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 37, ProductName = "Gravad lax", SupplierID = 17, CategoryID = 8,
						QuantityPerUnit = "12 - 500 g pkgs.", UnitPrice = 26, UnitsInStock = 11, UnitsOnOrder = 50,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 38, ProductName = "C�te de Blaye", SupplierID = 18, CategoryID = 1,
						QuantityPerUnit = "12 - 75 cl bottles", UnitPrice = 263.5, UnitsInStock = 17, UnitsOnOrder = 0,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 39, ProductName = "Chartreuse verte", SupplierID = 18, CategoryID = 1,
						QuantityPerUnit = "750 cc per bottle", UnitPrice = 18, UnitsInStock = 69, UnitsOnOrder = 0,
						ReorderLevel = 5, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 40, ProductName = "Boston Crab Meat", SupplierID = 19, CategoryID = 8,
						QuantityPerUnit = "24 - 4 oz tins", UnitPrice = 18.4, UnitsInStock = 123, UnitsOnOrder = 0,
						ReorderLevel = 30, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 41, ProductName = "Jack's New England Clam Chowder", SupplierID = 19,
						CategoryID = 8,
						QuantityPerUnit = "12 - 12 oz cans", UnitPrice = 9.65, UnitsInStock = 85, UnitsOnOrder = 0,
						ReorderLevel = 10, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", SupplierID = 20, CategoryID = 5,
						QuantityPerUnit = "32 - 1 kg pkgs.", UnitPrice = 14, UnitsInStock = 26, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = true, Category = new
						{
							CategoryID = 5,
							CategoryName = "Grains/Cereals",
							Description = "Breads, crackers, pasta, and cereal"
						}
					},
					new
					{
						ProductID = 43, ProductName = "Ipoh Coffee", SupplierID = 20, CategoryID = 1,
						QuantityPerUnit = "16 - 500 g tins", UnitPrice = 46, UnitsInStock = 17, UnitsOnOrder = 10,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 1,
							CategoryName = "Beverages",
							Description = "Soft drinks, coffees, teas, beers, and ales"
						}
					},
					new
					{
						ProductID = 44, ProductName = "Gula Malacca", SupplierID = 20, CategoryID = 2,
						QuantityPerUnit = "20 - 2 kg bags", UnitPrice = 19.45, UnitsInStock = 27, UnitsOnOrder = 0,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 2,
							CategoryName = "Condiments",
							Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
						}
					},
					new
					{
						ProductID = 45, ProductName = "Rogede sild", SupplierID = 21, CategoryID = 8,
						QuantityPerUnit = "1k pkg.", UnitPrice = 9.5, UnitsInStock = 5, UnitsOnOrder = 70,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 46, ProductName = "Spegesild", SupplierID = 21, CategoryID = 8,
						QuantityPerUnit = "4 - 450 g glasses", UnitPrice = 12, UnitsInStock = 95, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 8,
							CategoryName = "Seafood",
							Description = "Seaweed and fish"
						}
					},
					new
					{
						ProductID = 47, ProductName = "Zaanse koeken", SupplierID = 22, CategoryID = 3,
						QuantityPerUnit = "10 - 4 oz boxes", UnitPrice = 9.5, UnitsInStock = 36, UnitsOnOrder = 0,
						ReorderLevel = 0, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 48, ProductName = "Chocolade", SupplierID = 22, CategoryID = 3,
						QuantityPerUnit = "10 pkgs.", UnitPrice = 12.75, UnitsInStock = 15, UnitsOnOrder = 70,
						ReorderLevel = 25, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					},
					new
					{
						ProductID = 49, ProductName = "Maxilaku", SupplierID = 23, CategoryID = 3,
						QuantityPerUnit = "24 - 50 g pkgs.", UnitPrice = 20, UnitsInStock = 10, UnitsOnOrder = 60,
						ReorderLevel = 15, Discontinued = false, Category = new
						{
							CategoryID = 3,
							CategoryName = "Confections",
							Description = "Desserts, candies, and sweet breads"
						}
					}
				},
				schema = new
				{
					model = new
					{
						fields = new
						{
							ProductName = new
							{
								type = "string"
							},
							UnitPrice = new
							{
								type = "number"
							},
							UnitsInStock = new
							{
								type = "number"
							},
							Discontinued = new
							{
								type = "boolean"
							},
							CategoryName = new
							{
								field = "Category.CategoryName"
							},
						}
					},
					cube = new
					{
						dimensions = new
						{
							ProductName = new
							{
								caption = "All Products"
							},
							Discontinued = new
							{
								caption = "Discontinued"
							},
							CategoryName = new
							{
								caption = "All Categories"
							},
						},
						measures = new 
						{
							Sum = new 
							{
								field = "UnitPrice",
								format = "{0:c}",
								aggregate = "sum"
							},
							Average = new
							{
								field = "UnitPrice",
								format = "{0:c}",
								aggregate = "average"
							}
						},
					},
				},
				columns = new dynamic[]
				{
					new
					{
						name = "CategoryName", expand = true
					},
					new {name = "ProductName"}
				},
				rows = new dynamic[]
				{
					new {name = "Discontinued", expand = true}
				},
				measures = new string[] { "Sum" },
			};


			this.kendoPivotGrid1.Options.editable = true;
			this.kendoPivotGrid1.Options.toolbar = new[] {"Save"};
			this.kendoPivotGrid1.Options.pdf = new
			{
				forceProxy = true,
				proxyURL = $"{serviceUrl}?action=export"
			};
			this.kendoPivotGrid1.Options.excel = new
			{
				forceProxy = true,
				proxyURL = $"{serviceUrl}?action=export"
			};
		}

		private void kendoPivotGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Instance.saveAsExcel();
		}

		private void kendoPivotGrid1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					ExportDocument(e.Response, e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;
			}
		}

		private void ExportDocument(HttpResponse response, string base64Data, string fileName)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.BinaryWrite(bytes);
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Instance.saveAsPDF();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoPivotGrid1.Options.columnWidth = numericUpDownColumnWidth.Value;
			this.kendoPivotGrid1.Options.reorderable = checkBoxReorderable.Checked;
			this.kendoPivotGrid1.Options.filterable = checkBoxFilterable.Checked;
			this.kendoPivotGrid1.Options.sortable = checkBoxSortable.Checked;

			this.kendoPivotGrid1.Update();
		}
	}
}