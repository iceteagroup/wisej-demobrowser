using System;
using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.Notification;

namespace Wisej.DemoBrowser.Notification
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void notification1_Click(object sender, NotificationClickEventArgs e)
		{
			AlertBox.Show($"Clicked {e.Title}");
		}

		private void buttonProgress_Click(object sender, EventArgs e)
		{
			this.notification1.Show(this.textBoxTitle.Text, 
				this.textBoxBody.Text, 
				icon: "icon-info", 
				this.checkBoxShowOnClick.Checked, 
				requireInteraction: this.checkBoxRequireInteraction.Checked);
		}
	}
}
