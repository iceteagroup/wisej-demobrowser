using System;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoScheduler : TestBase
	{
		public kendoScheduler()
		{
			InitializeComponent();

			kendoScheduler1.Instance.onAdd += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			kendoScheduler1.Instance.onCancel += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			kendoScheduler1.Instance.onChange += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			kendoScheduler1.Instance.onEdit += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
			kendoScheduler1.Instance.onSave += new WidgetEventHandler(kendoScheduler1_WidgetEvent);
		}

		private void kendoScheduler_Load(object sender, EventArgs e)
		{
			kendoScheduler1.Options.date = "2013/6/13";
			kendoScheduler1.Options.startTime = "2013/6/13 07:00 AM";
			kendoScheduler1.Options.views = new object[]
			{
				"day", new
				{
					type = "workWeek",
					selected = true
				},
				"week", "month", "agenda", new
				{
					type = "timeline",
					eventHeight = 50
				}
			};
			kendoScheduler1.Options.timezone = "Etc/UTC";
			kendoScheduler1.Options.dataSource = new
			{
				batch = true,
				transport = new
				{
					read = new
					{
						url = "https://demos.telerik.com/kendo-ui/service/tasks",
						dataType = "jsonp"
					},
					update = new
					{
						url = "https://demos.telerik.com/kendo-ui/service/tasks/update",
						dataType = "jsonp"
					},
					create = new
					{
						url = "https://demos.telerik.com/kendo-ui/service/tasks/create",
						dataType = "jsonp"
					},
					destroy = new
					{
						url = "https://demos.telerik.com/kendo-ui/service/tasks/destroy",
						dataType = "jsonp"
					}
				},
				schema = new
				{
					model = new
					{
						id = "taskId",
						fields = new
						{
							taskId = new
							{
								from = "TaskID",
								type = "number"
							},
							title = new
							{
								from = "Title",
								defaultValue = "No title",
								validation = new
								{
									required = true
								}
							},
							start = new
							{
								type = "date",
								from = "Start"
							},
							end = new
							{
								type = "date",
								from = "End"
							},
							startTimezone = new
							{
								from = "StartTimezone"
							},
							endTimezone = new
							{
								from = "EndTimezone"
							},
							description = new
							{
								from = "Description"
							},
							recurrenceId = new
							{
								from = "RecurrenceID"
							},
							recurrenceRule = new
							{
								from = "RecurrenceRule"
							},
							recurrenceException = new
							{
								from = "RecurrenceException"
							},
							ownerId = new
							{
								from = "OwnerID",
								defaultValue = 1
							},
							isAllDay = new
							{
								type = "boolean",
								from = "IsAllDay"
							}
						}
					}
				},
				filter = new
				{
					logic = "or",
					filters = new dynamic[]
					{
						new
						{
							field = "ownerId",
							@operator = "eq",
							value = 1
						},
						new
						{
							field = "ownerId",
							@operator = "eq",
							value = 2
						}
					}
				}
			};
			kendoScheduler1.Options.resources = new object[]
			{
				new
				{
					field = "ownerId",
					title = "Owner",
					dataSource = new object[]
					{
						new
						{
							text = "Alex",
							value = 1, color = "#f8a398"
						},
						new
						{
							text = "Bob",
							value = 2, color = "#51a0ed"
						},
						new
						{
							text = "Charlie",
							value = 3, color = "#56ca85"
						}
					}
				}
			};


			var serviceUrl = kendoScheduler1.GetServiceURL();
			kendoScheduler1.Options.pdf = new
			{
				forceProxy = true,
				proxyURL = $"{serviceUrl}?action=export"
			};
		}

		private void kendoScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			kendoScheduler1.Instance.saveAsPDF();
		}

		private void kendoScheduler1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					// do whatever you want with the file.
					HandleFile(e.Response, e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;
			}
		}

		private void HandleFile(HttpResponse response, string base64Data, string fileName)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AppendHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.BinaryWrite(bytes);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			kendoScheduler1.Options.snap = checkBoxSnap.Checked;
			kendoScheduler1.Options.allDaySlot = checkBoxAllDay.Checked;
			kendoScheduler1.Options.editable = checkBoxEditable.Checked;
			kendoScheduler1.Options.showWorkHours = checkBoxShowWorkHours.Checked;
		}
	}
}