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
				string imageSource = ImageHelper.GetRandomPerson();

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
			this.listViewDemo.SmallImageList = SmallImageList;
			this.listViewDemo.LargeImageList = LargeImageList;
		}

        private void listViewDemo_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
			Faker faker = new Faker();

			string fullName = faker.Name.FullName();
			string address = faker.Address.StreetAddress();
			string phoneNumber = faker.Phone.PhoneNumber();

			ListViewItem item = new ListViewItem(fullName);
			item.SubItems.Add(new ListViewItem.ListViewSubItem(item,address));
			item.SubItems.Add(new ListViewItem.ListViewSubItem(item, phoneNumber));
			item.ImageIndex = faker.Random.Int(0, 19);

			e.Item = item;
		}

        private void Features_Load(object sender, EventArgs e)
		{
			this.listViewDemo.VirtualListSize = 100;

			FillImageLists();
			AttachImageLists();
		}

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
			var view = (View)Enum.Parse(typeof(View), (string)comboBoxView.SelectedItem);
			this.listViewDemo.View = view;
		}

        private void comboBoxSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
			var mode = (SelectionMode)Enum.Parse(typeof(SelectionMode), (string)comboBoxSelectionMode.SelectedItem);
			this.listViewDemo.SelectionMode = mode;
		}
    }
}
