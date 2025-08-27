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

		private void buttonShowNotification_Click(object sender, EventArgs e)
		{
			this.notification1.Show(title: this.textBoxTitle.Text, 
				body: this.textBoxBody.Text, 
				showOnClick: this.checkBoxShowOnClick.Checked,
				requireInteraction: this.checkBoxRequireInteraction.Checked,
				icon: Application.StartupUrl + "resource.wx/Wisej.DemoBrowser.Notification.Images.avatar.png");
		}
	}
}
