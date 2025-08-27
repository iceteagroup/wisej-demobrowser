using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Animation
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.navigationBar1.UserAvatar = ImageHelper.GetRandomPerson();
		}

		private void buttonShowNavigation_Click(object sender, EventArgs e)
		{
			this.navigationBar1.Show();
		}

		private void buttonHideNavigation_Click(object sender, EventArgs e)
		{
			this.navigationBar1.Hide();
		}

        private void buttonShowPage_Click(object sender, EventArgs e)
        {
			this.flowLayoutPanel1.Show();
        }

        private void buttonHidePage_Click(object sender, EventArgs e)
        {
			this.flowLayoutPanel1.Hide();
        }
    }
}
