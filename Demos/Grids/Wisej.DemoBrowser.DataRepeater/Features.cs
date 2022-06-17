using Bogus;
using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataRepeater
{
	public partial class Features : DemoView
	{
		private const int ITEM_COUNT = 1000;

		private List<dynamic> users = new List<dynamic>();

		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.dataRepeater1.ItemCount = ITEM_COUNT;

			var faker = new Faker();
			for (int i = 0; i < ITEM_COUNT; i++)
			{
				this.users.Add(new
				{
					Name = faker.Name.FullName(),
					Address = faker.Internet.Email(),
					Phone = faker.Phone.PhoneNumber(),
					Company = faker.Company.CompanyName(),
					Picture = ImageHelper.GetRandomPerson(),
				});
			}
		}

		private void buttonSelect_Click(object sender, EventArgs e)
		{
			var item = this.users[this.dataRepeater1.CurrentItemIndex];
			AlertBox.Show($"Selected {item.Name}");
		}

		private void dataRepeater1_ItemUpdate(object sender, DataRepeaterItemEventArgs e)
		{
			var controls = e.DataRepeaterItem.Controls["panel1"].Controls;
			var item = this.users[e.DataRepeaterItem.ItemIndex];

			controls["labelName"].Text = item.Name;
			controls["labelEmail"].Text = item.Address;
			controls["labelCompany"].Text = item.Company;
			((PictureBox)controls["pictureBoxProfile"]).ImageSource = item.Picture;
		}

        private void checkBoxScrollbar_CheckedChanged(object sender, EventArgs e)
        {
			this.dataRepeater1.ScrollBarVisible = this.checkBoxScrollbar.Checked;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
			(sender as Panel).BackColor = Color.LightGray;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
			(sender as Panel).BackColor = Color.White;
		}
	}
}
