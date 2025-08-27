using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo
{
	public partial class ejTreeGrid : Component.TestBase
	{
		public ejTreeGrid()
		{
			InitializeComponent();

			this.ejTreeGrid1.Instance.onRecordClick += new WidgetEventHandler(ejTreeGrid1_WidgetEvent);
			this.ejTreeGrid1.Instance.onCellSelected += new WidgetEventHandler(ejTreeGrid1_WidgetEvent);
		}

		private void ejTreeGrid_Load(object sender, EventArgs e)
		{
			this.ejTreeGrid1.Options.dataSource = new object[]
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
							duration = 5, progress = 100, approved = true
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
							duration = 2, progress = 100, approved = true
						},
						new
						{
							taskID = 10, taskName = "Design Documentation",
							startDate = "02/13/2017",
							endDate = "02/14/2017",
							duration = 2, progress = 100, approved = true
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
				},
				new
				{
					taskID = 12, taskName = "Implementation Phase",
					startDate = "02/17/2017",
					endDate = "02/27/2017",
					priority = "Normal",
					approved = false, duration = 11, subtasks = new object[]
					{
						new
						{
							taskID = 13, taskName = "Phase 1",
							startDate = "02/17/2017",
							endDate = "02/27/2017",
							priority = "High",
							approved = false, duration = 11, subtasks = new object[]
							{
								new
								{
									taskID = 14, taskName = "Implementation Module 1",
									startDate = "02/17/2017",
									endDate = "02/27/2017",
									priority = "Normal",
									duration = 11, approved = false, subtasks = new object[]
									{
										new
										{
											taskID = 15, taskName = "Development Task 1",
											startDate = "02/17/2017",
											endDate = "02/19/2017",
											duration = 3, progress = "50",
											priority = "High",
											approved = false
										},
										new
										{
											taskID = 16, taskName = "Development Task 2",
											startDate = "02/17/2017",
											endDate = "02/19/2017",
											duration = 3, progress = "50",
											priority = "Low",
											approved = true
										},
										new
										{
											taskID = 17, taskName = "Testing",
											startDate = "02/20/2017",
											endDate = "02/21/2017",
											duration = 2, progress = "0",
											priority = "Normal",
											approved = true
										},
										new
										{
											taskID = 18, taskName = "Bug fix",
											startDate = "02/24/2017",
											endDate = "02/25/2017",
											duration = 2, progress = "0",
											priority = "Critical",
											approved = false
										},
										new
										{
											taskID = 19, taskName = "Customer review meeting",
											startDate = "02/26/2017",
											endDate = "02/27/2017",
											duration = 2, progress = "0",
											priority = "High",
											approved = false
										},
										new
										{
											taskID = 20, taskName = "Phase 1 complete",
											startDate = "02/27/2017",
											endDate = "02/27/2017",
											duration = 0, priority = "Low",
											approved = true
										}
									}
								}
							}
						},
						new
						{
							taskID = 21, taskName = "Phase 2",
							startDate = "02/17/2017",
							endDate = "02/28/2017",
							priority = "High",
							approved = false, duration = 12, subtasks = new object[]
							{
								new
								{
									taskID = 22, taskName = "Implementation Module 2",
									startDate = "02/17/2017",
									endDate = "02/28/2017",
									priority = "Critical",
									approved = false, duration = 12, subtasks = new object[]
									{
										new
										{
											taskID = 23, taskName = "Development Task 1",
											startDate = "02/17/2017",
											endDate = "02/20/2017",
											duration = 4, progress = "50",
											priority = "Normal",
											approved = true
										},
										new
										{
											taskID = 24, taskName = "Development Task 2",
											startDate = "02/17/2017",
											endDate = "02/20/2017",
											duration = 4, progress = "50",
											priority = "Critical",
											approved = true
										},
										new
										{
											taskID = 25, taskName = "Testing",
											startDate = "02/21/2017",
											endDate = "02/24/2017",
											duration = 2, progress = "0",
											priority = "High",
											approved = false
										},
										new
										{
											taskID = 26, taskName = "Bug fix",
											startDate = "02/25/2017",
											endDate = "02/26/2017",
											duration = 2, progress = "0",
											priority = "Low",
											approved = false
										},
										new
										{
											taskID = 27, taskName = "Customer review meeting",
											startDate = "02/27/2017",
											endDate = "02/28/2017",
											duration = 2, progress = "0",
											priority = "Critical",
											approved = true
										},
										new
										{
											taskID = 28, taskName = "Phase 2 complete",
											startDate = "02/28/2017",
											endDate = "02/28/2017",
											duration = 0, priority = "Normal",
											approved = false
										}
									}
								}
							}
						},
						new
						{
							taskID = 29, taskName = "Phase 3",
							startDate = "02/17/2017",
							endDate = "02/27/2017",
							priority = "Normal",
							approved = false, duration = 11, subtasks = new object[]
							{
								new
								{
									taskID = 30, taskName = "Implementation Module 3",
									startDate = "02/17/2017",
									endDate = "02/27/2017",
									priority = "High",
									approved = false, duration = 11, subtasks = new object[]
									{
										new
										{
											taskID = 31, taskName = "Development Task 1",
											startDate = "02/17/2017",
											endDate = "02/19/2017",
											duration = 3, progress = "50",
											priority = "Low",
											approved = true
										},
										new
										{
											taskID = 32, taskName = "Development Task 2",
											startDate = "02/17/2017",
											endDate = "02/19/2017",
											duration = 3, progress = "50",
											priority = "Normal",
											approved = false
										},
										new
										{
											taskID = 33, taskName = "Testing",
											startDate = "02/20/2017",
											endDate = "02/21/2017",
											duration = 2, progress = "0",
											priority = "Critical",
											approved = true
										},
										new
										{
											taskID = 34, taskName = "Bug fix",
											startDate = "02/24/2017",
											endDate = "02/25/2017",
											duration = 2, progress = "0",
											priority = "High",
											approved = false
										},
										new
										{
											taskID = 35, taskName = "Customer review meeting",
											startDate = "02/26/2017",
											endDate = "02/27/2017",
											duration = 2, progress = "0",
											priority = "Normal",
											approved = true
										},
										new
										{
											taskID = 36, taskName = "Phase 3 complete",
											startDate = "02/27/2017",
											endDate = "02/27/2017",
											duration = 0, priority = "Critical",
											approved = false
										}
									}
								}
							}
						}
					}
				}
			};
			this.ejTreeGrid1.Options.childMapping = "subtasks";
			this.ejTreeGrid1.Options.treeColumnIndex = 1;
			this.ejTreeGrid1.Options.isResponsive = true;
			this.ejTreeGrid1.Options.columns = new object[]
			{
				new
				{
					field = "taskID",
					headerText = "Task Id",
					width = 70
				},
				new
				{
					field = "taskName",
					headerText = "Task Name"
				},
				new
				{
					field = "startDate",
					headerText = "Start Date"
				},
				new
				{
					field = "endDate",
					headerText = "End Date"
				},
				new
				{
					field = "duration",
					headerText = "Duration"
				},
				new
				{
					field = "progress",
					headerText = "Progress"
				}
			};
		}

		private void ejTreeGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGetSelectedCells_Click(object sender, EventArgs e)
		{
			var selectedCells = await this.ejTreeGrid1.Instance.getSelectedCellsAsync();

			AlertBox.Show(selectedCells.ToString());
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTreeGrid1.Options.allowTextWrap = this.checkBox1.Checked;
			this.ejTreeGrid1.Options.allowSelection = this.checkBox2.Checked;
			this.ejTreeGrid1.Options.allowColumnReordering = this.checkBox3.Checked;
			this.ejTreeGrid1.Options.allowColumnResize = this.checkBox4.Checked;
			this.ejTreeGrid1.Options.allowDragAndDrop = this.checkBox5.Checked;
			this.ejTreeGrid1.Options.allowFiltering = this.checkBox6.Checked;
			this.ejTreeGrid1.Options.allowKeyboardNavigation = this.checkBox7.Checked;

			this.ejTreeGrid1.Update();
		}
	}
}