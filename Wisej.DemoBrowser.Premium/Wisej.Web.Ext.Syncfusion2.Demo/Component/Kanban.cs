using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Kanban : TestBase
	{
		public Kanban()
		{
			InitializeComponent();

			this.kanban1.Instance.onCardClick += new WidgetEventHandler(kanban1_WidgetEvent);
		}

		private void Kanban_Load(object sender, EventArgs e)
		{
			this.kanban1.Options.dataSource = new object[]
			{
				new
				{
					Id = 1, Status = "Open",
					Summary = "Analyze the new requirements gathered from the customer.",
					Type = "Story",
					Priority = "Low",
					Tags = "Analyze,Customer",
					Estimate = 3.5, Assignee = "Nancy Davloio",
					RankId = 1
				},
				new
				{
					Id = 2, Status = "InProgress",
					Summary = "Improve application performance",
					Type = "Improvement",
					Priority = "Normal",
					Tags = "Improvement",
					Estimate = 6, Assignee = "Andrew Fuller",
					RankId = 1
				},
				new
				{
					Id = 3, Status = "Open",
					Summary = "Arrange a web meeting with the customer to get new requirements.",
					Type = "Others",
					Priority = "Critical",
					Tags = "Meeting",
					Estimate = 5.5, Assignee = "Janet Leverling",
					RankId = 2
				},
				new
				{
					Id = 4, Status = "InProgress",
					Summary = "Fix the issues reported in the IE browser.",
					Type = "Bug",
					Priority = "Release Breaker",
					Tags = "IE",
					Estimate = 2.5, Assignee = "Janet Leverling",
					RankId = 2
				},
				new
				{
					Id = 5, Status = "Testing",
					Summary = "Fix the issues reported by the customer.",
					Type = "Bug",
					Priority = "Low",
					Tags = "Customer",
					Estimate = "3.5",
					Assignee = "Steven walker",
					RankId = 1
				},
				new
				{
					Id = 6, Status = "Close",
					Summary = "Arrange a web meeting with the customer to get the login page requirements.",
					Type = "Others",
					Priority = "Low",
					Tags = "Meeting",
					Estimate = 2, Assignee = "Michael Suyama",
					RankId = 1
				},
				new
				{
					Id = 7, Status = "Validate",
					Summary = "Validate new requirements",
					Type = "Improvement",
					Priority = "Low",
					Tags = "Validation",
					Estimate = 1.5, Assignee = "Robert King",
					RankId = 1
				},
				new
				{
					Id = 8, Status = "Close",
					Summary = "Login page validation",
					Type = "Story",
					Priority = "Release Breaker",
					Tags = "Validation,Fix",
					Estimate = 2.5, Assignee = "Laura Callahan",
					RankId = 2
				},
				new
				{
					Id = 9, Status = "Testing",
					Summary = "Fix the issues reported in Safari browser.",
					Type = "Bug",
					Priority = "Release Breaker",
					Tags = "Fix,Safari",
					Estimate = 1.5, Assignee = "Nancy Davloio",
					RankId = 2
				},
				new
				{
					Id = 10, Status = "Close",
					Summary = "Test the application in the IE browser.",
					Type = "Story",
					Priority = "Low",
					Tags = "Testing,IE",
					Estimate = 5.5, Assignee = "Margaret hamilt",
					RankId = 3
				},
				new
				{
					Id = 11, Status = "Validate",
					Summary = "Validate the issues reported by the customer.",
					Type = "Story",
					Priority = "High",
					Tags = "Validation,Fix",
					Estimate = 1, Assignee = "Steven walker",
					RankId = 1
				},
				new
				{
					Id = 12, Status = "Testing",
					Summary = "Check Login page validation.",
					Type = "Story",
					Priority = "Release Breaker",
					Tags = "Testing",
					Estimate = 0.5, Assignee = "Michael Suyama",
					RankId = 3
				},
				new
				{
					Id = 13, Status = "Open",
					Summary = "API improvements.",
					Type = "Improvement",
					Priority = "High",
					Tags = "Grid,API",
					Estimate = 3.5, Assignee = "Robert King",
					RankId = 3
				},
				new
				{
					Id = 14, Status = "InProgress",
					Summary = "Add responsive support to application",
					Type = "Epic",
					Priority = "Critical",
					Tags = "Responsive",
					Estimate = 6, Assignee = "Laura Callahan",
					RankId = 3
				},
				new
				{
					Id = 15, Status = "Open",
					Summary = "Show the retrieved data from the server in grid control.",
					Type = "Story",
					Priority = "High",
					Tags = "Database,SQL",
					Estimate = 5.5, Assignee = "Margaret hamilt",
					RankId = 4
				},
				new
				{
					Id = 16, Status = "InProgress",
					Summary = "Fix cannot open user’s default database SQL error.",
					Priority = "Critical",
					Type = "Bug",
					Tags = "Database,Sql2008",
					Estimate = 2.5, Assignee = "Janet Leverling",
					RankId = 4
				},
				new
				{
					Id = 17, Status = "Testing",
					Summary = "Fix the issues reported in data binding.",
					Type = "Story",
					Priority = "Normal",
					Tags = "Databinding",
					Estimate = "3.5",
					Assignee = "Janet Leverling",
					RankId = 4
				},
				new
				{
					Id = 18, Status = "Close",
					Summary = "Analyze SQL server 2008 connection.",
					Type = "Story",
					Priority = "Release Breaker",
					Tags = "Grid,Sql",
					Estimate = 2, Assignee = "Andrew Fuller",
					RankId = 4
				},
				new
				{
					Id = 19, Status = "Validate",
					Summary = "Validate databinding issues.",
					Type = "Story",
					Priority = "Low",
					Tags = "Validation",
					Estimate = 1.5, Assignee = "Margaret hamilt",
					RankId = 1
				},
				new
				{
					Id = 20, Status = "Close",
					Summary = "Analyze grid control.",
					Type = "Story",
					Priority = "High",
					Tags = "Analyze",
					Estimate = 2.5, Assignee = "Margaret hamilt",
					RankId = 5
				},
				new
				{
					Id = 21, Status = "Close",
					Summary = "Stored procedure for initial data binding of the grid.",
					Type = "Others",
					Priority = "Release Breaker",
					Tags = "Databinding",
					Estimate = 1.5, Assignee = "Steven walker",
					RankId = 6
				},
				new
				{
					Id = 22, Status = "Close",
					Summary = "Analyze stored procedures.",
					Type = "Story",
					Priority = "Release Breaker",
					Tags = "Procedures",
					Estimate = 5.5, Assignee = "Janet Leverling",
					RankId = 7
				},
				new
				{
					Id = 23, Status = "Validate",
					Summary = "Validate editing issues.",
					Type = "Story",
					Priority = "Critical",
					Tags = "Editing",
					Estimate = 1, Assignee = "Nancy Davloio",
					RankId = 1
				},
				new
				{
					Id = 24, Status = "Testing",
					Summary = "Test editing functionality.",
					Type = "Story",
					Priority = "Normal",
					Tags = "Editing,Test",
					Estimate = 0.5, Assignee = "Nancy Davloio",
					RankId = 5
				},
				new
				{
					Id = 25, Status = "Open",
					Summary = "Enhance editing functionality.",
					Type = "Improvement",
					Priority = "Low",
					Tags = "Editing",
					Estimate = 3.5, Assignee = "Andrew Fuller",
					RankId = 5
				}
			};
			this.kanban1.Options.keyField = "Status";
			this.kanban1.Options.columns = new object[]
			{
				new
				{
					headerText = "Backlog",
					keyField = "Open"
				},
				new
				{
					headerText = "In Progress",
					keyField = "InProgress"
				},
				new
				{
					headerText = "Testing",
					keyField = "Testing"
				},
				new
				{
					headerText = "Done",
					keyField = "Close"
				}
			};
			this.kanban1.Options.cardSettings = new
			{
				contentField = "Summary",
				headerField = "Id"
			};
		}
		private void kanban1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kanban1.Options.allowKeyboard = this.checkBoxKeyboard.Checked;
			this.kanban1.Options.showEmptyColumn = this.checkBoxEmptyColumn.Checked;
			this.kanban1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;
			for (var i = 0; i < 4; i++)
				this.kanban1.Options.columns[i].allowToggle = this.checkBoxColumnToggle.Checked;

			this.kanban1.Update();
		}
	}
}