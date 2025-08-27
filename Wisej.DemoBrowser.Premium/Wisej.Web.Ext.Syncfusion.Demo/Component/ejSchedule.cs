using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSchedule : TestBase
	{
		public ejSchedule()
		{
			InitializeComponent();

			this.ejSchedule1.Instance.onCellClick += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.onMenuItemClick += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.onCellDoubleClick += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.onAppointmentClicked += new WidgetEventHandler(ejSchedule1_WidgetEvent);
			this.ejSchedule1.Instance.onAppointmentChanged += new WidgetEventHandler(ejSchedule1_WidgetEvent);
		}

		private void ejSchedule_Load(object sender, EventArgs e)
		{
			this.ejSchedule1.Options.currentDate = "2017-05-05";
			this.ejSchedule1.Options.contextMenuSettings = new
			{
				enable = true,
				menuItems = new
				{
					appointment = new object[]
					{
						new
						{
							id = "open",
							text = "Open Appointment"
						},
						new
						{
							id = "delete",
							text = "Delete Appointment"
						},
						new
						{
							id = "customMenu3",
							text = "Menu Item 3"
						},
						new
						{
							id = "customMenu4",
							text = "Menu Item 4"
						},
						new
						{
							id = "categorize",
							text = "Categorize"
						}
					},
					cells = new object[]
					{
						new
						{
							id = "new",
							text = "New Appointment"
						},
						new
						{
							id = "recurrence",
							text = "New Recurring Appointment"
						},
						new
						{
							id = "today",
							text = "Today"
						},
						new
						{
							id = "gotodate",
							text = "Go to date"
						},
						new
						{
							id = "settings",
							text = "Settings"
						},
						new
						{
							id = "view",
							text = "View",
							parentId = "settings"
						},
						new
						{
							id = "timemode",
							text = "TimeMode",
							parentId = "settings"
						},
						new
						{
							id = "view_Day",
							text = "Day",
							parentId = "view"
						},
						new
						{
							id = "view_Week",
							text = "Week",
							parentId = "view"
						},
						new
						{
							id = "view_Workweek",
							text = "Workweek",
							parentId = "view"
						},
						new
						{
							id = "view_Month",
							text = "Month",
							parentId = "view"
						},
						new
						{
							id = "timemode_Hour12",
							text = "12 Hours",
							parentId = "timemode"
						},
						new
						{
							id = "timemode_Hour24",
							text = "24 Hours",
							parentId = "timemode"
						},
						new
						{
							id = "workhours",
							text = "Work Hours",
							parentId = "settings"
						},
						new
						{
							id = "customMenu1",
							text = "Menu Item 1"
						},
						new
						{
							id = "customMenu2",
							text = "Menu Item 2"
						}
					}
				}
			};
			this.ejSchedule1.Options.categorizeSettings = new
			{
				enable = true,
				allowMultiple = true,
				dataSource = new object[]
				{
					new
					{
						text = "Blue Category",
						id = 1, color = "#43b496",
						fontColor = "#ffffff"
					},
					new
					{
						text = "Green Category",
						id = 2, color = "#7f993e",
						fontColor = "#ffffff"
					},
					new
					{
						text = "Orange Category",
						id = 3, color = "#cc8638",
						fontColor = "#ffffff"
					},
					new
					{
						text = "Purple Category",
						id = 4, color = "#ab54a0",
						fontColor = "#ffffff"
					},
					new
					{
						text = "Red Category",
						id = 5, color = "#dd654e",
						fontColor = "#ffffff"
					},
					new
					{
						text = "Yellow Category",
						id = 6, color = "#d0af2b",
						fontColor = "#ffffff"
					}
				},
				text = "text",
				id = "id",
				color = "color",
				fontColor = "fontColor"
			};
			this.ejSchedule1.Options.appointmentSettings = new
			{
				dataSource = new object[]
				{
					new
					{
						id = 1, subject = "Maintenance",
						startTime = "2017-04-30 02:30:00",
						endTime = "2017-04-10 04:00:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Maintenance",
						roomId = 1, ownerId = 1
					},
					new
					{
						id = 2, subject = "Technology Book Stall",
						startTime = "2017-05-05 12:30:00",
						endTime = "2017-05-05 16:00:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Public Event",
						roomId = 1, ownerId = 1
					},
					new
					{
						id = 3, subject = "Technology Book Stall",
						startTime = "2017-05-15 12:30:00",
						endTime = "2017-05-15 16:00:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Public Event",
						roomId = 1, ownerId = 1
					},
					new
					{
						id = 4, subject = "Technology Book Stall",
						startTime = "2017-05-10 12:30:00",
						endTime = "2017-05-10 16:00:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Public Event",
						roomId = 1, ownerId = 2
					},
					new
					{
						id = 5, subject = "Annual Conference",
						startTime = "2017-05-05 17:30:00",
						endTime = "2017-05-10 21:00:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Commercial Event",
						roomId = 1, ownerId = 1
					},
					new
					{
						id = 6, subject = "Annual Conference",
						startTime = "2017-05-15 17:30:00",
						endTime = "2017-05-15 21:30:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Commercial Event",
						roomId = 1, ownerId = 1
					},
					new
					{
						id = 7, subject = "Annual Conference",
						startTime = "2017-05-10 17:30:00",
						endTime = "2017-05-10 21:00:00",
						description = "",
						allDay = false, recurrence = false, eventType = "Commercial Event",
						roomId = 1, ownerId = 2
					},
					new
					{
						id = 8, subject = "IMI Meeting",
						startTime = "2017-05-05 15:30:00",
						endTime = "2017-05-05 18:30:00",
						description = "International Management Institute",
						allDay = false, recurrence = false, eventType = "Commercial Event",
						roomId = 2, ownerId = 3
					},
					new
					{
						id = 9, subject = "George Birthday Celebration",
						startTime = "2017-05-05 16:00:00",
						endTime = "2017-05-05 19:00:00",
						description = "4th Year Celebration",
						allDay = false, recurrence = false, eventType = "Family Event",
						roomId = 1, ownerId = 2
					},
					new
					{
						id = 10, subject = "John Wedding Aniversary",
						startTime = "2017-05-02 17:00:00",
						endTime = "2017-05-02 20:00:00",
						description = "1st Year Celebration",
						allDay = false, recurrence = false, eventType = "Family Event",
						roomId = 2, ownerId = 3
					}
				},
				id = "id",
				subject = "subject",
				startTime = "startTime",
				endTime = "endTime",
				description = "description",
				allDay = "allDay",
				recurrence = "recurrence",
				recurrenceRule = "recurrenceRule",
				categorize = "categorize"
			};
		}

		private void ejSchedule1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSchedule1.Options.showWeekend = this.checkBox1.Checked;
			this.ejSchedule1.Options.allowDelete = this.checkBox2.Checked;
			this.ejSchedule1.Options.allowKeyboardNavigation = this.checkBox3.Checked;
			this.ejSchedule1.Options.allowInline = this.checkBox4.Checked;
			this.ejSchedule1.Options.showAppointmentNavigator = this.checkBox5.Checked;
			this.ejSchedule1.Options.currentView = this.comboBox1.Text.ToLowerInvariant();
			this.ejSchedule1.Options.orientation = this.comboBox2.Text.ToLowerInvariant();

			this.ejSchedule1.Update();
		}
	}
}