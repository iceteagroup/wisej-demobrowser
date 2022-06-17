using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeMap : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTreeMap()
		{
			InitializeComponent();
		}

		private void kendoTreeMap_Load(object sender, EventArgs e)
		{
			this.kendoTreeMap1.Options.type = "squarified";
			this.kendoTreeMap1.Options.dataSource = new object[]
			{
				new
				{
					name = "Population in USA",
					value = 316128839, items = new object[]
					{
						new
						{
							name = "Alabama",
							value = 4833722, items = new object[]
							{
								new
								{
									name = "Birmingham",
									value = 212113
								},
								new
								{
									name = "Montgomery",
									value = 201332
								},
								new
								{
									name = "Mobile",
									value = 194899
								},
								new
								{
									name = "Huntsville",
									value = 186254
								},
								new
								{
									name = "Tuscaloosa",
									value = 95334
								},
								new
								{
									name = "Hoover",
									value = 84126
								},
								new
								{
									name = "Dothan",
									value = 68001
								},
								new
								{
									name = "Auburn",
									value = 58582
								},
								new
								{
									name = "Decatur",
									value = 55816
								}
							}
						},
						new
						{
							name = "Alaska",
							value = 735132, items = new object[]
							{
								new
								{
									name = "Anchorage",
									value = 300950
								},
								new
								{
									name = "Badger",
									value = 20200
								},
								new
								{
									name = "College",
									value = 13400
								},
								new
								{
									name = "Fairbanks",
									value = 32324
								},
								new
								{
									name = "Juneau",
									value = 32660
								},
								new
								{
									name = "Ketchikan",
									value = 8214
								},
								new
								{
									name = "Sitka",
									value = 9020
								}
							}
						},
						new
						{
							name = "Arizona",
							value = 6626624, items = new object[]
							{
								new
								{
									name = "Phoenix",
									value = 1513367
								},
								new
								{
									name = "Tucson",
									value = 526116
								},
								new
								{
									name = "Mesa",
									value = 457587
								},
								new
								{
									name = "Chandler",
									value = 249146
								},
								new
								{
									name = "Glendale",
									value = 234632
								},
								new
								{
									name = "Gilbert",
									value = 229972
								},
								new
								{
									name = "Scottsdale",
									value = 226918
								},
								new
								{
									name = "Tempe",
									value = 168228
								},
								new
								{
									name = "Peoria",
									value = 162592
								},
								new
								{
									name = "Surprise",
									value = 123546
								}
							}
						},
						new
						{
							name = "Arkansas",
							value = 2959373, items = new object[]
							{
								new
								{
									name = "Little Rock",
									value = 197357
								},
								new
								{
									name = "Fort Smith",
									value = 87650
								},
								new
								{
									name = "Fayetteville",
									value = 78960
								},
								new
								{
									name = "Springdale",
									value = 75229
								},
								new
								{
									name = "Jonesboro",
									value = 71551
								},
								new
								{
									name = "North Little Rock",
									value = 66075
								},
								new
								{
									name = "Conway",
									value = 63816
								},
								new
								{
									name = "Rogers",
									value = 60112
								},
								new
								{
									name = "Pine Bluff",
									value = 46094
								},
								new
								{
									name = "Bentonville",
									value = 40167
								}
							}
						},
						new
						{
							name = "California",
							value = 38332521, items = new object[]
							{
								new
								{
									name = "Los Angeles",
									value = 3884307
								},
								new
								{
									name = "San Diego",
									value = 1355896
								},
								new
								{
									name = "San Jose",
									value = 998537
								},
								new
								{
									name = "San Francisco",
									value = 837442
								},
								new
								{
									name = "Fresno",
									value = 509924
								},
								new
								{
									name = "Sacramento",
									value = 479686
								},
								new
								{
									name = "Long Beach",
									value = 469428
								},
								new
								{
									name = "Oakland",
									value = 406253
								},
								new
								{
									name = "Bakersfield",
									value = 363630
								},
								new
								{
									name = "Anaheim",
									value = 345012
								},
								new
								{
									name = "Santa Ana",
									value = 334227
								}
							}
						},
						new
						{
							name = "Colorado",
							value = 5268367, items = new object[]
							{
								new
								{
									name = "Denver",
									value = 649495
								},
								new
								{
									name = "Colorado Springs",
									value = 439886
								},
								new
								{
									name = "Aurora",
									value = 345803
								},
								new
								{
									name = "Fort Collins",
									value = 152061
								},
								new
								{
									name = "Lakewood",
									value = 147214
								},
								new
								{
									name = "Thornton",
									value = 127359
								},
								new
								{
									name = "Arvada",
									value = 111707
								},
								new
								{
									name = "Westminster",
									value = 110945
								},
								new
								{
									name = "Pueblo",
									value = 108249
								},
								new
								{
									name = "Centennial",
									value = 106114
								},
								new
								{
									name = "Boulder",
									value = 103166
								},
								new
								{
									name = "Highlands Ranch",
									value = 102000
								}
							}
						},
						new
						{
							name = "Connecticut",
							value = 3596080, items = new object[]
							{
								new
								{
									name = "Bridgeport",
									value = 147216
								},
								new
								{
									name = "New Haven",
									value = 130660
								},
								new
								{
									name = "Stamford",
									value = 126456
								},
								new
								{
									name = "Hartford",
									value = 125017
								},
								new
								{
									name = "Waterbury",
									value = 109676
								},
								new
								{
									name = "Norwalk",
									value = 87776
								},
								new
								{
									name = "Danbury",
									value = 83684
								},
								new
								{
									name = "New Britain",
									value = 72939
								},
								new
								{
									name = "West Hartford",
									value = 63371
								},
								new
								{
									name = "Bristol",
									value = 60568
								},
								new
								{
									name = "Meriden",
									value = 60456
								}
							}
						}
					}
				}
			};
			this.kendoTreeMap1.Options.valueField = "value";
			this.kendoTreeMap1.Options.textField = "name";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (this.checkedListBoxColors.CheckedItems.Count > 0)
				this.kendoTreeMap1.Options.colors = this.checkedListBoxColors.CheckedItems;
			
			this.kendoTreeMap1.Options.type = this.comboBoxType.SelectedItem.ToString()?.ToLower();

			this.kendoTreeMap1.Update();
		}

		
	}
}
