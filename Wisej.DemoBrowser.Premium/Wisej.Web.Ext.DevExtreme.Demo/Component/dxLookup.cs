using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxLookup : TestBase
	{
		public dxLookup()
		{
			InitializeComponent();
		}

		private void dxLookup1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxLookup1.Options.isValid = this.checkBox4.Checked;
			this.dxLookup1.Options.searchEnabled = this.checkBox5.Checked;
			this.dxLookup1.Options.closeOnOutsideClick = this.checkBox3.Checked;
			this.dxLookup1.Options.applyValueMode = this.comboBox1.SelectedItem;
			this.dxLookup1.Options.cleanSearchOnOpening = this.checkBox2.Checked;

			this.dxLookup1.Update();
		}

        private void dxLookup_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;

			this.dxLookup1.Options = new
			{
				stylingMode = "outlined",
				items = new object[]
                {
                    "John Heart",
                    "Samantha Bright",
                    "Arthur Miller",
                    "Robert Reagan",
                    "Greta Sims",
                    "Brett Wade",
                    "Sandra Johnson",
                    "Ed Holmes",
                    "Barb Banks",
                    "Kevin Carter",
                    "Cindy Stanwick",
                    "Sammy Hill",
                    "Davey Jones",
                    "Victor Norris",
                    "Mary Stern",
                    "Robin Cosworth",
                    "Kelly Rodriguez",
                    "James Anderson",
                    "Antony Remmen",
                    "Olivia Peyton",
                    "Taylor Riley",
                    "Amelia Harper",
                    "Wally Hobbs",
                    "Brad Jameson",
                    "Karen Goodson",
                    "Marcus Orbison",
                    "Sandy Bright",
                    "Morgan Kennedy",
                    "Violet Bailey",
                    "Ken Samuelson",
                    "Nat Maguiree",
                    "Bart Arnaz",
                    "Leah Simpson",
                    "Arnie Schwartz",
                    "Billy Zimmer",
                    "Samantha Piper",
                    "Maggie Boxter",
                    "Terry Bradley",
                    "Gabe Jones",
                    "Lucy Ball",
                    "Jim Packard",
                    "Hannah Brookly",
                    "Harv Mudd",
                    "Clark Morgan",
                    "Todd Hoffman",
                    "Jackie Garmin",
                    "Lincoln Bartlett",
                    "Brad Farkus",
                    "Jenny Hobbs",
                    "Dallas Lou",
                    "Stu Pizaro"
                }
			};

			this.dxLookup1.Update();
		}
	}
}
