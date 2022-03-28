using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class UserManager : ViewBase
	{
		public UserManager()
		{
			InitializeComponent();
		}

		private void UserManager_Load(object sender, EventArgs e)
		{
			userManager1.Options.url = "https://docs.webix.com/usermanager-backend/";
		}
	}
}