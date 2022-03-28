using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSchedule : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
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

		private void ejSchedule_Load(object sender, EventArgs e)
		{
			this.ejSchedule1.Options.currentDate = DateTime.Now;

			this.ejSchedule1.Options.contextMenuSettings = new
			{
				enable = true,
				menuItems = new
				{
					appointment = new[] 
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
					cells = new[]
					{
						new
						{
							id = "new",
							text = "New Appointment",
							parentId = ""
						},
						new
						{
							id = "recurrence",
							text = "New Recurring Appointment",
							parentId = ""

						},
						new
						{
							id = "today",
							text = "Today",
							parentId = ""
						},
						new
						{
							id = "gotodate",
							text = "Go to date",
							parentId = ""

						},
						new
						{
							id = "settings",
							text = "Settings",
							parentId = ""
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
							parentId = "view",
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
							text = "Menu Item 1",
							parentId = ""
						},
						new
						{
							id = "customMenu2",
							text = "Menu Item 2",
							parentId = ""
						}
					}
				}
			};
		}
    }
}
