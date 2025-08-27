using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class TreeGrid : TestBase
	{
		public TreeGrid()
		{
			InitializeComponent();

			this.treeGrid1.Instance.onRowSelected += new WidgetEventHandler(treeGrid1_rowSelected);
		}

		private void TreeGrid_Load(object sender, EventArgs e)
		{
			this.treeGrid1.Options.dataSource = new object[]
			{
				new
				{
					taskID = 1, taskName = "Planning",
					startDate = "02/03/2017",
					endDate = "02/07/2017",
					progress = 100, duration = 5, priority = "Normal",
					approved = false, subtasks = new object[]
					{
						new
						{
							taskID = 2, taskName = "Plan timeline",
							startDate = "02/03/2017",
							endDate = "02/07/2017",
							duration = 5, progress = 100, priority = "Normal",
							approved = false
						},
						new
						{
							taskID = 3, taskName = "Plan budget",
							startDate = "02/03/2017",
							endDate = "02/07/2017",
							duration = 5, progress = 100, priority = "Low",
							approved = true
						},
						new
						{
							taskID = 4, taskName = "Allocate resources",
							startDate = "02/03/2017",
							endDate = "02/07/2017",
							duration = 5, progress = 100, priority = "Critical",
							approved = false
						},
						new
						{
							taskID = 5, taskName = "Planning complete",
							startDate = "02/07/2017",
							endDate = "02/07/2017",
							duration = 0, progress = 0, priority = "Low",
							approved = true
						}
					}
				},
				new
				{
					taskID = 6, taskName = "Design",
					startDate = "02/10/2017",
					endDate = "02/14/2017",
					duration = 3, progress = 86, priority = "High",
					approved = false, subtasks = new object[]
					{
						new
						{
							taskID = 7, taskName = "Software Specification",
							startDate = "02/10/2017",
							endDate = "02/12/2017",
							duration = 3, progress = 60, priority = "Normal",
							approved = false
						},
						new
						{
							taskID = 8, taskName = "Develop prototype",
							startDate = "02/10/2017",
							endDate = "02/12/2017",
							duration = 3, progress = 100, priority = "Critical",
							approved = false
						},
						new
						{
							taskID = 9, taskName = "Get approval from customer",
							startDate = "02/13/2017",
							endDate = "02/14/2017",
							duration = 2, progress = 100, priority = "Low",
							approved = true
						},
						new
						{
							taskID = 10, taskName = "Design Documentation",
							startDate = "02/13/2017",
							endDate = "02/14/2017",
							duration = 2, progress = 100, priority = "High",
							approved = true
						},
						new
						{
							taskID = 11, taskName = "Design complete",
							startDate = "02/14/2017",
							endDate = "02/14/2017",
							duration = 0, progress = 0, priority = "Normal",
							approved = true
						}
					}
				}
			};
			this.treeGrid1.Options.childMapping = "subtasks";
			this.treeGrid1.Options.selectionSettings = new
			{
				mode = "Row",
				cellSelectionMode = "Flow",
				type = "Single"
			};
			this.treeGrid1.Options.treeColumnIndex = 1;
			this.treeGrid1.Options.columns = new object[]
			{
				new
				{
					field = "taskID",
					headerText = "Task ID",
					width = 70, textAlign = "Right"
				},
				new
				{
					field = "taskName",
					headerText = "Task Name",
					width = 200, textAlign = "Left"
				},
				new
				{
					field = "startDate",
					headerText = "Start Date",
					width = 90, textAlign = "Right",
					type = "date",
					format = "yMd"
				},
				new
				{
					field = "endDate",
					headerText = "End Date",
					width = 90, textAlign = "Right",
					type = "date",
					format = "yMd"
				},
				new
				{
					field = "duration",
					headerText = "Duration",
					width = 80, textAlign = "Right"
				},
				new
				{
					field = "progress",
					headerText = "Progress",
					width = 80, textAlign = "Right"
				},
				new
				{
					field = "priority",
					headerText = "Priority",
					width = 90
				}
			};
		}

		private void treeGrid1_rowSelected(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.treeGrid1.Options.allowResizing = this.checkBoxResizing.Checked;
			this.treeGrid1.Options.allowReordering = this.checkBoxReordering.Checked;
			this.treeGrid1.Options.allowRowDragAndDrop = this.checkBoxDragAndDrop.Checked;

			this.treeGrid1.Update();
		}
	}
}