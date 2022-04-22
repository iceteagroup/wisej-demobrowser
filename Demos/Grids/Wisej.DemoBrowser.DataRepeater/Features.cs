using Bogus;
using System;
using System.Collections.Generic;
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
					Phone = faker.Phone.PhoneNumber(),
					Address = faker.Address.FullAddress(),
					Picture = ImageHelper.GetRandomPerson()
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
			var controls = e.DataRepeaterItem.Controls;
			var item = this.users[e.DataRepeaterItem.ItemIndex];

			controls["labelName"].Text = item.Name;
			controls["labelPhone"].Text = item.Phone;
			controls["labelAddress"].Text = item.Address;
			((PictureBox)controls["pictureBoxProfile"]).ImageSource = item.Picture;
		}
	}
}
