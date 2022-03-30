using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Scheduler : ViewBase
	{
		public Scheduler()
		{
			InitializeComponent();
		}

		private void Scheduler_Load(object sender, EventArgs e)
		{
			scheduler1.Options = new
			{
				date = "2020-08-31T20:00:00.001",
				url = "https://docs.webix.com/calendar-backend/"
			};
		}
	}
}