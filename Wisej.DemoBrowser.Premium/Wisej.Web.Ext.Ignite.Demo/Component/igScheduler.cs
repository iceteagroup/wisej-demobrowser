using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igScheduler : TestBase
	{
		public igScheduler()
		{
			InitializeComponent();

			igScheduler1.Instance.onAppointmentCreated += new WidgetEventHandler(igScheduler_WidgetEvent);
			igScheduler1.Instance.onAppointmentDeleted += new WidgetEventHandler(igScheduler_WidgetEvent);
			igScheduler1.Instance.onAppointmentCreating += new WidgetEventHandler(igScheduler_WidgetEvent);
			igScheduler1.Instance.onAppointmentDeleting += new WidgetEventHandler(igScheduler_WidgetEvent);
		}

		private void igScheduler_Load(object sender, EventArgs e)
		{
			igScheduler1.Options.selectedDate = "2022-04-13T05:58:18.909";

			igScheduler1.Options.views = new string[] {"monthView", "agendaView"};

			igScheduler1.Options.dataSource = new dynamic[]
			{
				new
				{
					resourceId = 1, id = 11, start = "2022-04-02T06:45:00.000", end = "2022-04-03T06:45:00.000",
					subject = "Marketing conference"
				},
				new
				{
					resourceId = 6, id = 5, end = "2022-04-03T12:45:00.000", start = "2022-04-03T01:45:00.000",
					subject = "Dentist appointment"
				},
				new
				{
					resourceId = 11, id = 10, start = "2022-04-04T08:00:00.000", end = "2022-04-04T08:30:00.000",
					subject = "Distributions sync", description = "Sync with distributions team"
				},
				new
				{
					resourceId = 2, id = 2, start = "2022-04-08T11:00:00.000", end = "2022-04-08T12:00:00.000",
					subject = "Company meeting", location = "Zero hub hall", description = "A company meeting"
				},
				new
				{
					resourceId = 8, id = 7, start = "2022-04-09T11:45:00.000", end = "2022-04-09T02:45:00.000",
					subject = "UX training", location = "Training hall Dragon",
					description = "Monthly user expirience training"
				},
				new
				{
					resourceId = 5, id = 4, start = "2022-04-10T05:45:00.000", end = "2022-04-10T06:15:00.000",
					subject = "Certification exam", location = "Exam room 1"
				},
				new
				{
					resourceId = 7, id = 6, start = "2022-04-14T07:45:00.000", end = "2022-04-16T07:45:00.000",
					subject = "Web Talks Conference", location = "Conference hall Universe",
					description = "A conference about modern web technologies and trends"
				},
				new
				{
					resourceId = 3, id = 32, start = "2022-04-24T12:45:00.000", end = "2022-04-24T02:45:00.000",
					subject = "Team Building", location = "Hawaii plaza hotel",
					description = "Have a teambuilding with colleges"
				},
				new
				{
					resourceId = 4, id = 3, start = "2022-04-30T11:00:00.000", end = "2022-04-30T12:00:00.000",
					subject = "Buisness lunch", location = "The Lavender Road",
					description = "Discuss the new rental system with partner"
				},
				new
				{
					resourceId = 10, id = 9, start = "2022-04-19T09:45:00.000", end = "2022-04-19T09:55:00.000",
					subject = "Morning Yoga class", location = "Training room life"
				},
				new
				{
					resourceId = 9, id = 8, start = "2022-04-25T01:15:00.000", end = "2022-04-25T04:15:00.000",
					subject = "Release review", location = "Conference room Unity", description = "Release review sync"
				},
				new
				{
					id = 11, start = "2022-04-26T10:45:00.000", end = "2022-04-26T12:45:00.000", subject = "Interview",
					location = "Guest room 1", description = "Interview the candidate for Principal Program Agent"
				}
			};
			igScheduler1.Options.resources = new dynamic[]
			{
				new {id = 1, displayName = "Trina Friesen"},
				new {id = 2, displayName = "Mack Koch"},
				new {id = 3, displayName = "Burney O'Kon"},
				new {id = 4, displayName = "Dawson Rohan"},
				new {id = 5, displayName = "Cain Schmidt"},
				new {id = 6, displayName = "Jesenia Rogahn"},
				new {id = 7, displayName = "Tod Heller"},
				new {id = 8, displayName = "Rhonda Cormier"},
				new {id = 9, displayName = "Hayden Lockman"},
				new {id = 10, displayName = "Tierra Witting"},
				new {id = 11, displayName = "Roderic Considine"}
			};
		}

		private void igScheduler_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var start = dateTimePicker1.Value.ToJSON(false);
			var end = dateTimePicker2.Value.ToJSON(false);

			var data = await igScheduler1.CallAsync("getAppointmentsInRange", start, end);

			using (var ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myAppointments.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			igScheduler1.Options.viewMode = comboBox1.SelectedItem ?? "none";

			igScheduler1.Update();
		}
	}
}