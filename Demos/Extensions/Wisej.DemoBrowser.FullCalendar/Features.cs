using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.FullCalendar;

namespace Wisej.DemoBrowser.FullCalendar
{
	public partial class Features : DemoView
	{
		private Random r = new Random();

		private string[] eventBank = new[] { "Birthday Party", "Office Party", "Conference",
			"Lunch with John", "Holiday", "Surgery", "Mom's Birthday", "School Event", "Wisdom Teeth Removal" };

		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			AddEvents();

			this.comboBoxView.Items.AddRange(Enum.GetNames(typeof(ViewType)));
		}

		private void AddEvents()
		{
			for (int i = 0; i < eventBank.Length; i++)
            {
				var startDate = DateTime.Now.AddDays(r.Next(30));
				var backgroundColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

				this.fullCalendar1.Events.Add(new Event
				{
					Id = $"Event{i}",
					Start = startDate,
					Title = this.eventBank[i],
					BackgroundColor = backgroundColor,
					End = startDate.AddHours(r.Next(24)).AddMinutes(r.Next(60)),
					TextColor = isDark(backgroundColor) ? Color.White : Color.Black,
				});
			}
		}

		private bool isDark(Color color)
        {
			return color.R * 0.2126 + color.G * 0.7152 + color.B * 0.0722 < 255 / 2;
		}

		private void fullCalendar1_EventClick(object sender, EventClickEventArgs e)
		{
			if (e.Event != null)
				AlertBox.Show(e.Event.ToJSON());
		}

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
			this.fullCalendar1.View = (ViewType)Enum.Parse(typeof(ViewType), comboBoxView.Text);
        }
    }
}