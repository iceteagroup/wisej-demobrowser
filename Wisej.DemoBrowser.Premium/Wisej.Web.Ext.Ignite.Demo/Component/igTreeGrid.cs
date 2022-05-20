using System;
using System.IO;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igTreeGrid : TestBase
	{
		public igTreeGrid()
		{
			InitializeComponent();

			igTreeGrid1.Instance.onCellClick += new WidgetEventHandler(igTree_WidgetEvent);
			igTreeGrid1.Instance.onCellRightClick += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void igTreeGrid_Load(object sender, EventArgs e)
		{
			igTreeGrid1.Options.dataSource = new dynamic[]
			{
				new
				{
					id = 0, tasks = "Project Plan", start = "6/2/2014", finish = "8/22/2014", duration = "60d",
					progress = "32%", products = new dynamic[]
					{
						new
						{
							id = 1, tasks = "Planning", start = "6/2/2014", finish = "6/4/2014", duration = "3d",
							progress = "100%"
						},
						new
						{
							id = 2, tasks = "Write a specification", start = "6/5/2014", finish = "6/6/2014",
							duration = "2d", progress = "100%"
						},
						new
						{
							id = 3, tasks = "Create a demo application", start = "6/9/2014", finish = "6/11/2014",
							duration = "3d", progress = "100%"
						},
						new
						{
							id = 4, tasks = "Collect a feedback", start = "6/12/2014", finish = "6/12/2014",
							duration = "1d", progress = "100%"
						},
						new
						{
							id = 5, tasks = "Design", start = "6/13/2014", finish = "6/19/2014", duration = "5d",
							progress = "60%", products = new dynamic[]
							{
								new
								{
									id = 8, tasks = "Conceptual Design", start = "6/13/2014", finish = "6/16/2014",
									duration = "2d", progress = "100%"
								},
								new
								{
									id = 9, tasks = "Preliminary Design", start = "6/17/2014", finish = "6/18/2014",
									duration = "2d", progress = "65%"
								},
								new
								{
									id = 10, tasks = "Final Design", start = "6/19/2014", finish = "6/19/2014",
									duration = "1d", progress = "15%"
								}
							}
						},
						new
						{
							id = 6, tasks = "Development", start = "6/20/2014", finish = "8/20/2014", duration = "44d",
							progress = "5%", products = new dynamic[]
							{
								new
								{
									id = 11, tasks = "Implementation", start = "6/20/2014", finish = "7/17/2014",
									duration = "20d", progress = "5%"
								},
								new
								{
									id = 12, tasks = "Testing", start = "7/18/2014", finish = "7/31/2014",
									duration = "10d", progress = "0%"
								},
								new
								{
									id = 13, tasks = "Bug fixing", start = "8/1/2014", finish = "8/14/2014",
									duration = "10d", progress = "0%"
								},
								new
								{
									id = 14, tasks = "Documenting", start = "8/15/2014", finish = "8/20/2014",
									duration = "4d", progress = "0%"
								}
							}
						},
						new
						{
							id = 7, tasks = "Project Complete", start = "8/21/2014", finish = "8/22/2014",
							duration = "2d", progress = "0%"
						}
					}
				}
			};
			igTreeGrid1.Options.autoGenerateColumns = false;
			igTreeGrid1.Options.primaryKey = "id";
			igTreeGrid1.Options.columns = new dynamic[]
			{
				new {headerText = "ID", key = "id", width = "10%", dataType = "number", hidden = true},
				new {headerText = "Tasks", key = "tasks", width = "30%", dataType = "string"},
				new {headerText = "Start", key = "start", width = "20%", dataType = "string"},
				new {headerText = "Finish", key = "finish", width = "20%", dataType = "string"},
				new {headerText = "Duration", key = "duration", width = "20%", dataType = "string"},
				new {headerText = "Progress", key = "progress", width = "10%", dataType = "string"}
			};
			igTreeGrid1.Options.childDataKey = "products";
			igTreeGrid1.Options.features = new dynamic[]
			{
				new
				{
					name = "Paging", mode = "allLevels", pageSize = 10, currentPageIndex = 0, contextRowMode = "parent"
				}
			};
		}
		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			var data = JSON.Parse(e.Files[0].InputStream);

			igTreeGrid1.Instance.dataSourceObject(data);
		}

		private async void buttonExport_Click(object sender, EventArgs e)
		{
			var data = await igTreeGrid1.EvalAsync("this.widget.options.dataSource");

			using (var ms = new MemoryStream())
			{
				using (var sw = new StreamWriter(ms))
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();

					ms.Position = 0;
					Application.Download(ms, "igTreeGrid.json");
				}
			}
		}

		private void igTree_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
				igTreeGrid1.Options.features = new[]
				{
					new {name = "Paging", mode = "allLevels", pageSize = 13}
				};
			else
				igTreeGrid1.Options.features = new { };

			igTreeGrid1.Options.showHeader = checkBox3.Checked;
			igTreeGrid1.Options.enableHoverStyles = checkBox4.Checked;

			igTreeGrid1.Update();
		}

		
	}
}