using System;
using System.Drawing;
using Bogus;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ListView
{
	public partial class Features : DemoView
	{
		private ImageList LargeImageList = new ImageList();
		private ImageList SmallImageList = new ImageList();
		private ImageList DetailsImageList = new ImageList();

		public Features()
		{
			InitializeComponent();
		}

		private void FillImageLists()
		{
			Faker f = new Faker();
			for (int i = 0; i < 20; i++)
			{
				string imageSource = $"https://i.pravatar.cc/150?img={f.Random.Int(1, 70)}";
				LargeImageList.Images.Add(imageSource);
				SmallImageList.Images.Add(imageSource);
				DetailsImageList.Images.Add(imageSource);
			}

			SmallImageList.ImageSize = new Size(64, 64);
			LargeImageList.ImageSize = new Size(128, 128);
			DetailsImageList.ImageSize = new Size(32, 32);
		}

		private void AttachImageLists()
		{
			this.listView1.SmallImageList = SmallImageList;
			this.listView2.SmallImageList = SmallImageList;
			this.listView3.SmallImageList = SmallImageList;
			this.listView4.SmallImageList = SmallImageList;


			this.listView1.LargeImageList = LargeImageList;
			this.listView2.LargeImageList = LargeImageList;
			this.listView3.LargeImageList = LargeImageList;
			this.listView4.LargeImageList = DetailsImageList;
		}

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			Faker faker = new Faker();

			string fullName = faker.Name.FullName();
			string address = faker.Address.StreetAddress();
			string phoneNumber = faker.Phone.PhoneNumber();

			ListViewItem item = new ListViewItem(fullName);
			item.SubItems.Add(new ListViewItem.ListViewSubItem(item,address));
			item.SubItems.Add(new ListViewItem.ListViewSubItem(item, phoneNumber));
			item.ImageIndex = faker.Random.Int(1, 20);

			e.Item = item;
		}

        private void Features_Load(object sender, EventArgs e)
		{
			FillImageLists();
			AttachImageLists();
		}
    }
}
