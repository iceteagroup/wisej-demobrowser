using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejHeatMap : TestBase
	{
		public ejHeatMap()
		{
			InitializeComponent();

			this.ejHeatMap1.Instance.onCellSelected += new WidgetEventHandler(ejHeatMap1_WidgetEvent);
		}

		private void ejHeatMap_Load(object sender, EventArgs e)
		{
			this.ejHeatMap1.Options.itemsMapping = new
			{
				column = new
				{
					propertyName = "productName",
					displayName = "Product Name"
				},
				row = new
				{
					propertyName = "year",
					displayName = "Year"
				},
				value = new
				{
					propertyName = "value"
				},
				columnMapping = new object[]
				{
					new
					{
						propertyName = "Veggies",
						displayName = "Veggie-spread"
					},
					new
					{
						propertyName = "Tofu",
						displayName = "Tofu"
					},
					new
					{
						propertyName = "Alice Mutton",
						displayName = "Alice Mutton"
					},
					new
					{
						propertyName = "Konbu",
						displayName = "Konbu"
					},
					new
					{
						propertyName = "Fløtemysost",
						displayName = "Fløtemysost"
					}
				},
				headerMapping = new
				{
					propertyName = "Year",
					displayName = "Year",
					columnStyle = new
					{
						width = 105,
						textAlign = "right"
					}
				}
			};
			this.ejHeatMap1.Options.colorMappingCollection = new object[]
			{
				new
				{
					value = 0, color = "#8ec8f8",
					label = new
					{
						text = "0"
					}
				},
				new
				{
					value = 100, color = "#0d47a1",
					label = new
					{
						text = "100"
					}
				}
			};
			this.ejHeatMap1.Options.isResponsive = true;
			this.ejHeatMap1.Options.itemsSource = new object[]
			{
				new
				{
					productName = "Veggies",
					year = 2011, value = 1
				},
				new
				{
					productName = "Tofu",
					year = 2011, value = 100
				},
				new
				{
					productName = "Alice Mutton",
					year = 2011, value = 64
				},
				new
				{
					productName = "Konbu",
					year = 2011, value = 10
				},
				new
				{
					productName = "Fløtemysost",
					year = 2011, value = 53
				},
				new
				{
					productName = "Veggies",
					year = 2012, value = 34
				},
				new
				{
					productName = "Tofu",
					year = 2012, value = 87
				},
				new
				{
					productName = "Alice Mutton",
					year = 2012, value = 32
				},
				new
				{
					productName = "Konbu",
					year = 2012, value = 23
				},
				new
				{
					productName = "Fløtemysost",
					year = 2012, value = 65
				},
				new
				{
					productName = "Veggies",
					year = 2013, value = 67
				},
				new
				{
					productName = "Tofu",
					year = 2013, value = 64
				},
				new
				{
					productName = "Alice Mutton",
					year = 2013, value = 34
				},
				new
				{
					productName = "Konbu",
					year = 2013, value = 10
				},
				new
				{
					productName = "Fløtemysost",
					year = 2013, value = 43
				},
				new
				{
					productName = "Veggies",
					year = 2014, value = 14
				},
				new
				{
					productName = "Tofu",
					year = 2014, value = 56
				},
				new
				{
					productName = "Alice Mutton",
					year = 2014, value = 64
				},
				new
				{
					productName = "Konbu",
					year = 2014, value = 86
				},
				new
				{
					productName = "Fløtemysost",
					year = 2014, value = 32
				},
				new
				{
					productName = "Veggies",
					year = 2015, value = 1
				},
				new
				{
					productName = "Tofu",
					year = 2015, value = 100
				},
				new
				{
					productName = "Alice Mutton",
					year = 2015, value = 61
				},
				new
				{
					productName = "Konbu",
					year = 2015, value = 10
				},
				new
				{
					productName = "Fløtemysost",
					year = 2015, value = 43
				},
				new
				{
					productName = "Veggies",
					year = 2016, value = 13
				},
				new
				{
					productName = "Tofu",
					year = 2016, value = 38
				},
				new
				{
					productName = "Alice Mutton",
					year = 2016, value = 96
				},
				new
				{
					productName = "Konbu",
					year = 2016, value = 10
				},
				new
				{
					productName = "Fløtemysost",
					year = 2016, value = 37
				}
			};
		}

		private void ejHeatMap1_Appear(object sender, EventArgs e)
		{
			// Isn't working (need to link the ejHeatMap with the ejHeatMapLegend
			this.ejHeatMap1.Options.legendCollection = new[] {$"id_{this.ejHeatMapLegend1.Handle}_container"};

			this.ejHeatMap1.Update();
		}

		private void ejHeatMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}