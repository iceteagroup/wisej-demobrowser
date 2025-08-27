using System;
using Wisej.Web;
using Wisej.DemoBrowser.Common;
using Wisej.DemoBrowser.Common.Views;
using System.Drawing;
using System.ComponentModel;

namespace Wisej.DemoBrowser.ListView.Views
{
    [AddToTreeView(true)]
    [ImageSource("resource.wx/Wisej.Ext.VisualStudioIcons/Virtual.svg")]
    [CustomName("Virtual Scrolling")]
    [Description("The ListBox control has the ability to use virtual scrolling, a feature that only renders the list items currently visible in the browser.")]
    public partial class VirtualScrolling : DemoView
    {
        const int ItemsCount = 500;
        static readonly string[] Images = {
                "abiword_48.png",
                "bmp.png",
                "disks.png"
        };
        ColumnHeader[] columns;

        public VirtualScrolling()
        {
            InitializeComponent();
        }

        private void VirtualScrolling_Load(object sender, EventArgs e)
        {
            this.listView1.SmallImageList = new ImageList();
            this.listView1.SmallImageList.ImageSize = new Size(24, 24);
            this.listView1.LargeImageList = new ImageList();
            this.listView1.LargeImageList.ImageSize = new Size(32, 32);
            this.listView1.VirtualListSize = ItemsCount;
            this.listView1.VirtualMode = true;

            LoadListViewImages();

            this.comboBox1.DataSource = Enum.GetNames(typeof(View));

        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex == ItemsCount - 1 && !IsHandleCreated)
                AlertBox.Show("Warning: The very last item was requested, which should not happen in load time (not visible yet)");

            // for testing purposes, we are creating one item per
            // invocation
            ListViewItem item = new ListViewItem("Item #" + e.ItemIndex);
            item.SubItems.Add("Sub item " + e.ItemIndex + "-1");
            item.SubItems.Add("Sub item " + e.ItemIndex + "-2");
            if (this.listView1.View == View.Details && e.ItemIndex % 2 == 0)
                item.BackColor = Color.WhiteSmoke;

            item.ImageIndex = e.ItemIndex % Images.Length;
            e.Item = item;
        }

        void LoadListViewImages()
        {
            Image img = global::Wisej.DemoBrowser.ListView.Properties.Resources.abiword_48;
            this.listView1.SmallImageList.Images.Add(img);
            this.listView1.LargeImageList.Images.Add(img);
            img = global::Wisej.DemoBrowser.ListView.Properties.Resources.bmp;
            this.listView1.SmallImageList.Images.Add(img);
            this.listView1.LargeImageList.Images.Add(img);
            img = global::Wisej.DemoBrowser.ListView.Properties.Resources.disks;
            this.listView1.SmallImageList.Images.Add(img);
            this.listView1.LargeImageList.Images.Add(img);
            img = global::Wisej.DemoBrowser.ListView.Properties.Resources.evolution;
            this.listView1.SmallImageList.Images.Add(img);
            this.listView1.LargeImageList.Images.Add(img);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateView((View)this.comboBox1.SelectedIndex);
        }

        void UpdateView(View view)
        {
            if (view == View.Details)
            {
                if (columns == null)
                    columns = new ColumnHeader[] {
                    new ColumnHeader () {Text= "Main column" },
                    new ColumnHeader () {Text= "Sub column #1" },
                    new ColumnHeader () {Text= "Sub column #2" }
                };

                this.listView1.Columns.AddRange(columns);
                this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                this.listView1.Columns.Clear();
            }

            this.listView1.View = view;
        }
    }
}
