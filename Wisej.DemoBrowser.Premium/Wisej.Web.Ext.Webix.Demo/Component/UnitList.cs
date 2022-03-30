using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class UnitList : ViewBase
	{
		public UnitList()
		{
			InitializeComponent();
		}

		private void UnitList_Load(object sender, EventArgs e)
		{
			unitList1.Options.select = true;
			unitList1.Options.padding = 40;

			//this.unitList1.Options.scheme = new dynamic[]
			//{

			//};
			unitList1.Options.template = "#title#</br>#year#<br/>#votes#";
			unitList1.Options.data = new dynamic[]
			{
				new
				{
					id = "1",
					title = "The Shawshank Redemption",
					year = "1994",
					votes = "678.79",
					rating = "9.2",
					rank = "1"
				},
				new
				{
					id = "2",
					title = "The Godfather",
					year = "1972",
					votes = "511.495",
					rating = "9.2",
					rank = "2"
				},
				new
				{
					id = "3",
					title = "The Godfather: Part II",
					year = "1974",
					votes = "319.352",
					rating = "9",
					rank = "3"
				},
				new
				{
					id = "4",
					title = "The Good, the Bad and the Ugly",
					year = "1966",
					votes = "213.03",
					rating = "8.9",
					rank = "4"
				},
				new
				{
					id = "5",
					title = "Pulp Fiction",
					year = "1994",
					votes = "533.848",
					rating = "8.9",
					rank = "5"
				},
				new
				{
					id = "6",
					title = "12 Angry Men",
					year = "1957",
					votes = "164.558",
					rating = "8.9",
					rank = "6"
				},
				new
				{
					id = "7",
					title = "Schindler's List",
					year = "1993",
					votes = "355.638",
					rating = "8.9",
					rank = "7"
				},
				new
				{
					id = "8",
					title = "One Flew Over the Cuckoo's Nest",
					year = "1975",
					votes = "283.176",
					rating = "8.8",
					rank = "8"
				},
				new
				{
					id = "9",
					title = "The Dark Knight",
					year = "2008",
					votes = "612.37",
					rating = "8.8",
					rank = "9"
				},
				new
				{
					id = "10",
					title = "The Lord of the Rings: The Return of the King",
					year = "2003",
					votes = "472.843",
					rating = "8.8",
					rank = "10"
				},
				new
				{
					id = "11",
					title = "Star Wars: Episode V - The Empire Strikes Bac",
					year = "1980",
					votes = "348.012",
					rating = "8.8",
					rank = "11"
				},
				new
				{
					id = "12",
					title = "Inception",
					year = "2010",
					votes = "458.693",
					rating = "8.8",
					rank = "12"
				},
				new
				{
					id = "13",
					title = "Fight Club",
					year = "1999",
					votes = "507.723",
					rating = "9.2",
					rank = "13"
				},
				new
				{
					id = "14",
					title = "Seven Samurai",
					year = "1954",
					votes = "118.925",
					rating = "8.8",
					rank = "14"
				},
				new
				{
					id = "15",
					title = "Goodfellas",
					year = "1990",
					votes = "299.349",
					rating = "8.7",
					rank = "15"
				},
				new
				{
					id = "16",
					title = "The Lord of the Rings: The Fellowship of the Ring",
					year = "2001",
					votes = "494.003",
					rating = "8.7",
					rank = "16"
				},
				new
				{
					id = "17",
					title = "Star Wars",
					year = "1977",
					votes = "678.79",
					rating = "9.2",
					rank = "1"
				},
				new
				{
					id = "18",
					title = "City of God",
					year = "2002",
					votes = "222.818",
					rating = "8.7",
					rank = "18"
				},
				new
				{
					id = "19",
					title = "Casablanca",
					year = "1942",
					votes = "202.051",
					rating = "8.7",
					rank = "19"
				},
				new
				{
					id = "20",
					title = "Once Upon a Time in the West",
					year = "1968",
					votes = "97.931",
					rating = "8.7",
					rank = "20"
				},
				new
				{
					id = "21",
					title = "The Matrix",
					year = "1999",
					votes = "492.325",
					rating = "8.7",
					rank = "21"
				}
			};
		}
	}
}