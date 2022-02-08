using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.FullCalendar;

namespace Wisej.DemoBrowser.FullCalendar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			AddEvents();
		}

		private void AddEvents()
		{
			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event1",
				Start = DateTime.Now,
				End = DateTime.Now.AddHours(1),
				Title = "Prepare a sales report",
				ClassName = "Other",
				BackgroundColor = Color.Yellow,
				TextColor = Color.Black
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event2",
				Start = DateTime.Now.Date.AddHours(12),
				End = DateTime.Now.Date.AddHours(13),
				Title = "Lunch break",
				ClassName = "Appointment",
				BackgroundColor = Color.AliceBlue,
				TextColor = Color.Brown
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event3",
				Start = DateTime.Now.Date.AddHours(13),
				End = DateTime.Now.Date.AddHours(14),
				Title = "Coffe break",
				ClassName = "Appointment",
				BackgroundColor = Color.AliceBlue,
				TextColor = Color.Brown
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event4",
				Start = DateTime.Now.Date.AddHours(15),
				End = DateTime.Now.Date.AddHours(16),
				Title = "Coffe break",
				ClassName = "Appointment",
				BackgroundColor = Color.AliceBlue,
				TextColor = Color.Brown
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event5",
				Start = DateTime.Now.Date.AddHours(15),
				End = DateTime.Now.Date.AddHours(16),
				Title = "Other break",
				ClassName = "Appointment",
				BackgroundColor = Color.AliceBlue,
				TextColor = Color.Brown
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event5",
				Start = DateTime.Now.Date.AddHours(16),
				End = DateTime.Now.Date.AddHours(17),
				Title = "Also another break",
				ClassName = "Appointment",
				BackgroundColor = Color.AliceBlue,
				TextColor = Color.Brown
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event6",
				Start = DateTime.Now.Date.AddDays(-1).AddHours(10.5),
				End = DateTime.Now.Date.AddDays(-1).AddHours(11.75),
				Title = "Meeting with ABC Client",
				ClassName = "Meeting",
				BackgroundColor = Color.Chocolate,
				TextColor = Color.White
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event7",
				Start = DateTime.Now.Date.AddDays(2),
				End = DateTime.Now.Date.AddDays(4),
				AllDay = true,
				Title = "Holidays :-)",
				ClassName = "Vacation"
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event8",
				Start = DateTime.Now.Date.AddDays(3),
				End = DateTime.Now.Date.AddDays(5),
				AllDay = true,
				Title = "Conference",
				ClassName = "Vacation"
			});
		}

		private void fullCalendar1_EventClick(object sender, EventClickEventArgs e)
		{
			if (e.Event != null)
				AlertBox.Show("Title: " + e.Event.Title + ", " +
							"Id: " + e.Event.Id + ", " +
							"Start: " + e.Event.Start + ", " +
							"End: " + e.Event.End
				);
		}
	}
}