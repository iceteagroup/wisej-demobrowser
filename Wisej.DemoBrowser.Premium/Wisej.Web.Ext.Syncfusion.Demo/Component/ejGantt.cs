using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejGantt : TestBase
	{
		public ejGantt()
		{
			InitializeComponent();

			this.ejGantt1.Instance.onRowSelected += new WidgetEventHandler(ejGantt1_WidgetEvent);
			this.ejGantt1.Instance.onTaskbarClick += new WidgetEventHandler(ejGantt1_WidgetEvent);
		}

		private void ejGantt_Load(object sender, EventArgs e)
		{
			this.ejGantt1.Options.showProgressStatus = true;
			this.ejGantt1.Options.showResourceNames = true;
			this.ejGantt1.Options.showTaskNames = true;
			this.ejGantt1.Options.allowSelection = true;
			this.ejGantt1.Options.allowSorting = true;
			this.ejGantt1.Options.allowColumnResize = true;
			this.ejGantt1.Options.taskIdMapping = "taskID";
			this.ejGantt1.Options.taskNameMapping = "taskName";
			this.ejGantt1.Options.scheduleStartDate = "02/23/2017";
			this.ejGantt1.Options.scheduleEndDate = "03/20/2017";
			this.ejGantt1.Options.startDateMapping = "startDate";
			this.ejGantt1.Options.endDateMapping = "endDate";
			this.ejGantt1.Options.progressMapping = "progress";
			this.ejGantt1.Options.childMapping = "children";
			this.ejGantt1.Options.treeColumnIndex = 1;
			this.ejGantt1.Options.allowGanttChartEditing = false;
			this.ejGantt1.Options.isResponsive = true;
			this.ejGantt1.Options.dataSource = new object[]
			{
				new
				{
					taskID = 1, taskName = "Parent Task 1",
					startDate = "02/27/2017",
					endDate = "03/03/2017",
					progress = "40",
					isManual = true, children = new object[]
					{
						new
						{
							taskID = 2, taskName = "Child Task 1",
							startDate = "02/27/2017",
							endDate = "03/03/2017",
							progress = "40",
							duration = 4
						},
						new
						{
							taskID = 3, taskName = "Child Task 2",
							startDate = "02/27/2017",
							endDate = "03/03/2017",
							progress = "40",
							isManual = true, duration = 4
						},
						new
						{
							taskID = 4, taskName = "Child Task 3",
							startDate = "02/27/2017",
							endDate = "03/03/2017",
							duration = 4, progress = "40"
						}
					}
				},
				new
				{
					taskID = 5, taskName = "Parent Task 2",
					startDate = "03/06/2017",
					endDate = "03/10/2017",
					progress = "40",
					isManual = true, children = new object[]
					{
						new
						{
							taskID = 6, taskName = "Child Task 1",
							startDate = "03/06/2017",
							endDate = "03/10/2017",
							progress = "40",
							duration = 4
						},
						new
						{
							taskID = 7, taskName = "Child Task 2",
							startDate = "03/06/2017",
							endDate = "03/10/2017",
							progress = "40",
							duration = 4
						},
						new
						{
							taskID = 8, taskName = "Child Task 3",
							startDate = "03/06/2017",
							endDate = "03/10/2017",
							progress = "40",
							isManual = true, duration = 4
						},
						new
						{
							taskID = 9, taskName = "Child Task 4",
							startDate = "03/06/2017",
							endDate = "03/10/2017",
							progress = "40",
							isManual = true, duration = 4
						}
					}
				},
				new
				{
					taskID = 10, taskName = "Parent Task 3",
					startDate = "03/13/2017",
					endDate = "03/17/2017",
					progress = "40",
					children = new object[]
					{
						new
						{
							taskID = 11, taskName = "Child Task 1",
							startDate = "03/13/2017",
							endDate = "03/17/2017",
							progress = "40",
							duration = 4
						},
						new
						{
							taskID = 12, taskName = "Child Task 2",
							startDate = "03/13/2017",
							endDate = "03/17/2017",
							progress = "40",
							duration = 4
						},
						new
						{
							taskID = 13, taskName = "Child Task 3",
							startDate = "03/13/2017",
							endDate = "03/17/2017",
							progress = "40",
							duration = 4
						},
						new
						{
							taskID = 14, taskName = "Child Task 4",
							startDate = "03/13/2017",
							endDate = "03/17/2017",
							progress = "40",
							isManual = true, duration = 4
						},
						new
						{
							taskID = 15, taskName = "Child Task 5",
							startDate = "03/13/2017",
							endDate = "03/17/2017",
							progress = "40",
							duration = 4
						}
					}
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejGantt1.Options.showProgressStatus = this.checkBox1.Checked;
			this.ejGantt1.Options.allowGanttChartEditing = this.checkBox3.Checked;
			this.ejGantt1.Options.enableCollapseAll = this.checkBox4.Checked;
			this.ejGantt1.Options.highlightNonWorkingTime = this.checkBox7.Checked;
			this.ejGantt1.Options.scheduleStartDate = DateTime.Parse(this.textBox1.Text).ToString("MM/dd/yyyy");
			this.ejGantt1.Options.scheduleEndDate = DateTime.Parse(this.textBox2.Text).ToString("MM/dd/yyyy");
			this.ejGantt1.Options.viewtype = this.comboBox1.SelectedItem.ToString().ToLower();

			this.ejGantt1.Update();
		}

		private void ejGantt1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}