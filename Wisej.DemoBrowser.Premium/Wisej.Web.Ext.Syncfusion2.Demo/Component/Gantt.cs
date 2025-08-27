using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Gantt : TestBase
	{
		public Gantt()
		{
			InitializeComponent();
		}

		private void Gantt_Load(object sender, EventArgs e)
		{
			this.gantt1.Options.dataSource = new dynamic[]
			{
				new
				{
					TaskID = 1,
					StartDate = DateTime.Parse("04/02/2019"),
					EndDate = DateTime.Parse("04/02/2019"),
					subtasks = new dynamic[]
					{
						new
						{
							TaskID = 2,
							TaskName = "Identify Site location",
							StartDate = DateTime.Parse("04/02/2019"),
							Duration = 0,
							Progress = 50,
						},
						new
						{
							TaskID = 3,
							TaskName = "Perform Soil Test",
							StartDate = DateTime.Parse("04/02/2019"),
							Duration = 4,
							Progress = 50,
							resources = new[] {2, 3, 5}
						},
						new
						{
							TaskID = 4,
							TaskName = "Soil test approval",
							StartDate = DateTime.Parse("04/02/2019"),
							Duration = 4,
							Predecessor = "2FS",
							Progress = 50,
						},
					}
				},
				new
				{
					TaskID = 5,
					TaskName = "Project Estimation",
					StartDate = DateTime.Parse("04/02/2019"),
					EndDate = DateTime.Parse("04/01/2019"),
					subtasks = new dynamic[]
					{
						new
						{
							TaskID = 6,
							TaskName = "Develop floor plan for estimation",
							StartDate = DateTime.Parse("04/04/2019"),
							Duration = 3,
							Progress = 50,
							resources = new[] { 4 }
						},
						new
						{
							TaskID = 7,
							TaskName = "List materials",
							StartDate = DateTime.Parse("04/04/2019"),
							Duration = 3,
							Progress = 50,
							resources = new[] { 4, 8 }
						},
						new
						{
							TaskID = 8,
							TaskName = "Estimation approval",
							StartDate = DateTime.Parse("04/04/2019"),
							Duration = 0,
							Predecessor = "6SS",
							Progress = 50,
							resources = new[] { 12, 5 }
						}
					}
				}
			};
		
			this.gantt1.Options.taskFields = new
			{
				id = "TaskID",
				name = "TaskName",
				startDate = "StartDate",
				endDate = "EndDate",
				progress = "Progress",
				dependency = "Predecessor",
				child = "subtasks"
			};
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.gantt1.Options.durationUnit = this.comboBoxDuration.Text;
			this.gantt1.Options.allowSorting = this.checkBoxSorting.Checked;
			this.gantt1.Options.allowResizing = this.checkBoxResizing.Checked;
			this.gantt1.Options.allowReordering = this.checkBoxReording.Checked;
			this.gantt1.Options.allowSelection = this.checkBoxSelection.Checked;
			this.gantt1.Options.showColumnMenu = this.checkBoxShowColumn.Checked;
			this.gantt1.Options.allowUnscheduledTasks = this.checkBoxUnscheduleTask.Checked;

			this.gantt1.Update();
        }
    }
}
