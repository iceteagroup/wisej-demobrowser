using System;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxNavBar : TestBase
	{
		public dxNavBar()
		{
			InitializeComponent();

			UpdateDataSource(0);

			labelName.DataBindings.Add("Text", this.dataRepeater1.DataSource, "name");
			labelCategory.DataBindings.Add("Text", this.dataRepeater1.DataSource, "category");
			pictureBox1.DataBindings.Add("ImageSource", this.dataRepeater1.DataSource, "image");
			linkLabelEmail.DataBindings.Add("Text", this.dataRepeater1.DataSource, "email");

			this.dxNavBar1.Instance.onItemClick += new WidgetEventHandler(dxNavBar1_WidgetEvent);
		}

		private void dxNavBar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
							$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
							MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);

			UpdateDataSource(e.Data.itemIndex);
		}

		private void UpdateDataSource(int type) 
		{
			switch (type)
			{

				case 0:
					this.dataRepeater1.DataSource = GetAll();
					break;

				case 1:
					this.dataRepeater1.DataSource = GetMissed();
					break;

				case 2:
					this.dataRepeater1.DataSource = GetFavorites();
					break;

				default:
					break;

			}
		}

		private object[] GetAll()
		{
			return new[] {
					new { name = "Kim D. Thomas", phone = "603-583-9043", image = "resource.wx/data/list/06.png", email = "KimDThomas@teleworm.us", category = "Outgoing call" },
					new { name = "Barbara M. Roberts", phone = "614-365-7945", image = "resource.wx/data/list/08.png", email = "BarbaraMRoberts@armyspy.com", category = "Outgoing call" },
					new { name = "Leslie S. Alcantara", phone = "360-684-1334", image = "resource.wx/data/list/01.png", email = "LeslieSAlcantara@teleworm.us", category = "Missed" },
					new { name = "Michael A. Blevins", phone = "530-480-1961", image = "resource.wx/data/list/03.png", email = "MichaelABlevins@armyspy.com", category = "Missed" },
					new { name = "Nicole A. Rios", phone = "213-812-8400", image = "resource.wx/data/list/09.png", email = "NicoleARios@armyspy.com", category = "Missed" },
					new { name = "Barbara J. Coggins", phone = "512-964-2757", image = "resource.wx/data/list/04.png", email = "BarbaraJCoggins@rhyta.com", category = "Favorites" },
					new { name = "Chad S. Miles", phone = "520-573-7903", image = "resource.wx/data/list/02.png", email = "ChadSMiles@rhyta.com", category = "Favorites" },
					new { name = "Jane K. Hernandez", phone = "404-781-0805", image = "resource.wx/data/list/05.png", email = "JaneKHernandez@teleworm.us", category = "Favorites" },
					new { name = "Donald L. Jordan", phone = "772-766-2842", image = "resource.wx/data/list/07.png", email = "DonaldLJordan@dayrep.com", category = "Favorites" },
				};
		}

		private object[] GetMissed()
		{
			return new[] {
					new { name = "Leslie S. Alcantara", phone = "360-684-1334", image = "resource.wx/data/list/01.png", email = "LeslieSAlcantara@teleworm.us", category = "Missed" },
					new { name = "Michael A. Blevins", phone = "530-480-1961", image = "resource.wx/data/list/03.png", email = "MichaelABlevins@armyspy.com", category = "Missed" },
					new { name = "Nicole A. Rios", phone = "213-812-8400", image = "resource.wx/data/list/09.png", email = "NicoleARios@armyspy.com", category = "Missed" },
				};
		}

		private object[] GetFavorites()
		{
			return new[] {
					new { name = "Barbara J. Coggins", phone = "512-964-2757", image = "resource.wx/data/list/04.png", email = "BarbaraJCoggins@rhyta.com", category = "Favorites" },
					new { name = "Chad S. Miles", phone = "520-573-7903", image = "resource.wx/data/list/02.png", email = "ChadSMiles@rhyta.com", category = "Favorites" },
					new { name = "Jane K. Hernandez", phone = "404-781-0805", image = "resource.wx/data/list/05.png", email = "JaneKHernandez@teleworm.us", category = "Favorites" },
					new { name = "Donald L. Jordan", phone = "772-766-2842", image = "resource.wx/data/list/07.png", email = "DonaldLJordan@dayrep.com", category = "Favorites" },
				};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxNavBar1.Options.hoverStateEnabled = this.checkBox1.Checked;
			this.dxNavBar1.Options.selectionMode = this.comboBox1.SelectedItem;
			this.dxNavBar1.Options.selectedIndex = this.numericUpDown1.Value;

			this.dxNavBar1.Update();
		}
	}
}
