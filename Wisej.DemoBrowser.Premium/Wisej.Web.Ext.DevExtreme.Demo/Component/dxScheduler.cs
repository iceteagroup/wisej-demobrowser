using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxScheduler : TestBase
	{
		public dxScheduler()
		{
			InitializeComponent();

			this.dxScheduler1.Instance.onAppointmentClick += new WidgetEventHandler(dxScheduler1_WidgetEvent);
			this.dxScheduler1.Instance.onAppointmentAdded += new WidgetEventHandler(dxScheduler1_WidgetEvent);
			this.dxScheduler1.Instance.onAppointmentDeleted += new WidgetEventHandler(dxScheduler1_WidgetEvent);
		}

		private void dxScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.dxScheduler1.Options.currentView = this.comboBoxCurrentView.SelectedItem;
			this.dxScheduler1.Options.editing.allowAdding = this.checkBoxAllowAdding.Checked;
			this.dxScheduler1.Options.editing.allowUpdating = this.checkBoxAllowUpdating.Text;
			this.dxScheduler1.Options.editing.allowDragging = this.checkBoxAllowDragging.Checked;
			this.dxScheduler1.Options.editing.allowResizing = this.checkBoxAllowResizing.Checked;
			this.dxScheduler1.Options.editing.allowDeleting = this.checkBoxAllowDeleting.Checked;

			this.dxScheduler1.Update();
        }

        private void dxScheduler_Load(object sender, EventArgs e)
        {
			this.comboBoxCurrentView.SelectedIndex = 2;

			this.dxScheduler1.Options = new
			{
				dataSource = new object[]
                {
                    new {
                        text =  "Helen",
                        employeeID = 2,
                        startDate = "2016-07-02 09:30:00",
                        endDate =  "2016-07-02 11:30:00"
                    },
                    new {
                        text =  "Helen",
                        employeeID = 2,
                        startDate =  "2016-07-11 09:30:00",
                        endDate =  "2016-07-12 11:30"
                    },
                    new {
                        text =  "Alex",
                        employeeID = 1,
                        startDate =  "2016-07-03 09:30",
                        endDate =  "2016-07-03 11:30"
                    },
                    new {
                        text =  "Alex",
                        employeeID = 1,
                        startDate =  "2016-07-12 12:00",
                        endDate =  "2016-07-12 13:00"
                    },
                    new {
                        text =  "Alex",
                        employeeID = 2,
                        startDate =  "2016-07-17 09:30",
                        endDate =  "2016-07-17 11:30"
                    },
                    new {
                        text =  "Stan",
                        employeeID = 1,
                        startDate =  "2016-07-08 09:30",
                        endDate =  "2016-07-08 11:30"
                    },
                    new {
                        text =  "Stan",
                        employeeID = 1,
                        startDate =  "2016-07-29 09:30",
                        endDate =  "2016-07-29 11:30"
                    },
                    new {
                        text =  "Stan",
                        employeeID = 1,
                        startDate =  "2016-07-31 09:30",
                        endDate =  "2016-07-31 11:30"
                    },
                    new {
                        text = "Rachel",
                        employeeID = 2,
                        startDate =  "2016-07-05 09:30",
                        endDate =  "2016-07-05 11:30"
                    },
                    new {
                        text = "Rachel",
                        employeeID = 2,
                        startDate =  "2016-07-08 09:30",
                        endDate =  "2016-07-08 11:30"
                    },
                    new {
                        text = "Rachel",
                        employeeID = 1,
                        startDate =  "2016-07-22 09:30",
                        endDate =  "2016-07-22 11:30"
                    },
                    new {
                        text = "Kelly",
                        employeeID = 2,
                        startDate =  "2016-07-16 09:30",
                        endDate =  "2016-07-16 11:30"
                    },
                    new {
                        text = "Kelly",
                        employeeID = 2,
                        startDate =  "2016-07-30 09:30",
                        endDate =  "2016-07-30 11:30"
                    }
                },
			    views = new string[]
                {
                    "month",
                    "agenda",
                    "day",
                    "timelineDay",
                    "timelineMonth",
                    "timelineWeek",
                    "timelineWorkWeek",
                    "week",
                    "workWeek"
                },
                currentView = "month",
                currentDate = "2016-07-02 11:30",
                firstDayOfWeek = 1,
                startDayHour = 8,
                endDayHour = 18,
                showAllDayPanel = false,
                height = 600,
                groups = new string[] { "employeeID" },
                editing = new
                {
                    allowAdding = true,
                    allowDeleting = true,
                    allowUpdating = true,
                    allowResizing = true,
                    allowDragging = true
                }
            };

			this.dxScheduler1.Update();
		}
	}
}
