using System;
using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Notification
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void notification1_Click(object sender, Web.Ext.Notification.NotificationClickEventArgs e)
		{
			AlertBox.Show($"Clicked {e.Title}");
		}

		private void buttonProgress_Click(object sender, EventArgs e)
		{
			this.buttonProgress.Enabled = false;

			Application.StartTask(() =>
			{
				for (int i = 0; i<=4; i++)
				{
					Thread.Sleep(5000);
					
					this.notification1.Show("Progress Update", $"Progress: {i * 25}%", icon: "icon-info", true);
					this.buttonProgress.Text = $"Progress: {i * 25}%";

					Application.Update(this);
				}

				this.buttonProgress.Text = "Start Task";
				this.buttonProgress.Enabled = true;
				
				Application.Update(this);
			});
		}
	}
}
