using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class TimeLine : ViewBase
	{
		public TimeLine()
		{
			InitializeComponent();
		}

		private void TimeLine_Load(object sender, EventArgs e)
		{
			timeLine1.Options.data = new dynamic[]
			{
				new
				{
					id = 1,
					value = "Available",
					date = "2017-08-01"
				},
				new
				{
					id = 2,
					value = "Taken",
					details = "by Malcolm Merlyn",
					date = "2017-09-10"
				},
				new
				{
					id = 3,
					value = "Broken",
					date = "2017-12-11"
				},
				new
				{
					id = 4,
					value = "Fixed",
					date = "2018-02-10"
				},
				new
				{
					id = 5,
					value = "Available",
					date = "2018-03-15"
				},
				new
				{
					id = 6,
					value = "Taken",
					details = "by Rosa White",
					date = "2018-03-21"
				},
				new
				{
					id = 7,
					value = "Broken",
					date = "2019-05-16"
				},
				new
				{
					id = 8,
					value = "Fixed",
					date = "2019-06-02"
				},
				new
				{
					id = 9,
					value = "Available",
					date = "2019-09-10"
				},
				new
				{
					id = 10,
					value = "Deprecated",
					date = "2019-09-23"
				}
			};
		}
	}
}