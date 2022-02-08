using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.FullCalendar;

namespace Wisej.DemoBrowser.FullCalendar
{
	public partial class Appearances : DemoView
	{
		public Appearances()
		{
			InitializeComponent();
		}

		private void Appearances_Load(object sender, EventArgs e)
		{
			comboBox1.DataSource = Enum.GetValues(typeof(ViewType));
			AddEvents();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ViewType OptionSelected;

			if (comboBox1.SelectedValue != null)
			{
				Enum.TryParse<ViewType>(comboBox1.SelectedValue.ToString(),
										out OptionSelected);

				fullCalendar1.View = OptionSelected;
			}
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
				Start = DateTime.Now.Date.AddDays(-1).AddHours(10.5),
				End = DateTime.Now.Date.AddDays(-1).AddHours(11.75),
				Title = "Meeting with ABC Client",
				ClassName = "Meeting",
				BackgroundColor = Color.Chocolate,
				TextColor = Color.White
			});

			fullCalendar1.Events.Add(new Event()
			{
				Id = "Event4",
				Start = DateTime.Now.Date.AddDays(2),
				End = DateTime.Now.Date.AddDays(4),
				AllDay = true,
				Title = "Holidays :-)",
				ClassName = "Vacation"
			});
		}
	}
}