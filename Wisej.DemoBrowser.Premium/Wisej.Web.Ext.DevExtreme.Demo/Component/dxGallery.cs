using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxGallery : TestBase
	{
		public dxGallery()
		{
			InitializeComponent();

			this.dxGallery1.Instance.onItemClick += new WidgetEventHandler(dxGallery1_WidgetEvent);
		}

		private void dxGallery1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxGallery1.Options.loop = this.checkBox1.Checked;
			this.dxGallery1.Options.showIndicator = this.checkBox5.Checked;
			this.dxGallery1.Options.showNavButtons = this.checkBox6.Checked;
			this.dxGallery1.Options.swipeEnabled = this.checkBox7.Checked;

			this.dxGallery1.Update();
		}

        private void dxGallery_Load(object sender, EventArgs e)
        {
			this.dxGallery1.Options = new
			{
				dataSource = new string[]
                {
					"Images/Gallery/1.jpg",
					"Images/Gallery/2.jpg",
					"Images/Gallery/3.jpg",
					"Images/Gallery/4.jpg",
					"Images/Gallery/5.jpg",
					"Images/Gallery/6.jpg",
					"Images/Gallery/7.jpg",
					"Images/Gallery/8.jpg",
					"Images/Gallery/9.jpg"
				},
				stretchImages = true,
				loop = true,
				showNavButtons = true,
				showIndicator = true
			};

			this.dxGallery1.Update();
        }
    }
}
