using System;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejKanban : TestBase
	{
		public ejKanban()
		{
			InitializeComponent();

			this.ejKanban1.Instance.onCardDrop += new WidgetEventHandler(ejKanban1_WidgetEvent);
			this.ejKanban1.Instance.onCardClick += new WidgetEventHandler(ejKanban1_WidgetEvent);
		}

		private void ejKanban_Load(object sender, EventArgs e)
		{
			this.ejKanban1.Options.dataSource = new object[]
			{
				new
				{
					id = 1, status = "Open",
					summary = "Analyze the new requirements gathered from the customer.",
					type = "Story",
					priority = "Low",
					tags = "Analyze,Customer",
					estimate = 3.5, assignee = "Nancy Davloio",
					imgUrl = "Images/Kanban/1.png",
					rankId = 1
				},
				new
				{
					id = 2, status = "InProgress",
					summary = "Improve application performance",
					type = "Improvement",
					priority = "Normal",
					tags = "Improvement",
					estimate = 6, assignee = "Andrew Fuller",
					imgUrl = "Images/Kanban/2.png",
					rankId = 1
				},
				new
				{
					id = 3, status = "Open",
					summary = "Arrange a web meeting with the customer to get new requirements.",
					type = "Others",
					priority = "Critical",
					tags = "Meeting",
					estimate = 5.5, assignee = "Janet Leverling",
					imgUrl = "Images/Kanban/3.png",
					rankId = 2
				},
				new
				{
					id = 4, status = "InProgress",
					summary = "Fix the issues reported in the IE browser.",
					type = "Bug",
					priority = "Release Breaker",
					tags = "IE",
					estimate = 2.5, assignee = "Janet Leverling",
					imgUrl = "Images/Kanban/3.png",
					rankId = 2
				},
				new
				{
					id = 5, status = "Testing",
					summary = "Fix the issues reported by the customer.",
					type = "Bug",
					priority = "Low",
					tags = "Customer",
					estimate = "3.5",
					assignee = "Steven walker",
					imgUrl = "Images/Kanban/5.png",
					rankId = 1
				},
				new
				{
					id = 6, status = "Close",
					summary = "Arrange a web meeting with the customer to get the login page requirements.",
					type = "Others",
					priority = "Low",
					tags = "Meeting",
					estimate = 2, assignee = "Michael Suyama",
					imgUrl = "Images/Kanban/6.png",
					rankId = 1
				},
				new
				{
					id = 7, status = "Validate",
					summary = "Validate new requirements",
					type = "Improvement",
					priority = "Low",
					tags = "Validation",
					estimate = 1.5, assignee = "Robert King",
					imgUrl = "Images/Kanban/7.png",
					rankId = 1
				},
				new
				{
					id = 8, status = "Close",
					summary = "Login page validation",
					type = "Story",
					priority = "Release Breaker",
					tags = "Validation,Fix",
					estimate = 2.5, assignee = "Laura Callahan",
					imgUrl = "Images/Kanban/8.png",
					rankId = 2
				},
				new
				{
					id = 9, status = "Testing",
					summary = "Fix the issues reported in Safari browser.",
					type = "Bug",
					priority = "Release Breaker",
					tags = "Fix,Safari",
					estimate = 1.5, assignee = "Nancy Davloio",
					imgUrl = "Images/Kanban/1.png",
					rankId = 2
				},
				new
				{
					id = 10, status = "Close",
					summary = "Test the application in the IE browser.",
					type = "Story",
					priority = "Low",
					tags = "Testing,IE",
					estimate = 5.5, assignee = "Margaret hamilt",
					imgUrl = "Images/Kanban/4.png",
					rankId = 3
				},
				new
				{
					id = 11, status = "Validate",
					summary = "Validate the issues reported by the customer.",
					type = "Story",
					priority = "High",
					tags = "Validation,Fix",
					estimate = 1, assignee = "Steven walker",
					imgUrl = "Images/Kanban/5.png",
					rankId = 1
				},
				new
				{
					id = 12, status = "Testing",
					summary = "Check Login page validation.",
					type = "Story",
					priority = "Release Breaker",
					tags = "Testing",
					estimate = 0.5, assignee = "Michael Suyama",
					imgUrl = "Images/Kanban/6.png",
					rankId = 3
				},
				new
				{
					id = 13, status = "Open",
					summary = "API improvements.",
					type = "Improvement",
					priority = "High",
					tags = "Grid,API",
					estimate = 3.5, assignee = "Robert King",
					imgUrl = "Images/Kanban/7.png",
					rankId = 3
				},
				new
				{
					id = 14, status = "InProgress",
					summary = "Add responsive support to application",
					type = "Epic",
					priority = "Critical",
					tags = "Responsive",
					estimate = 6, assignee = "Laura Callahan",
					imgUrl = "Images/Kanban/8.png",
					rankId = 3
				},
				new
				{
					id = 15, status = "Open",
					summary = "Show the retrieved data from the server in grid control.",
					type = "Story",
					priority = "High",
					tags = "Database,SQL",
					estimate = 5.5, assignee = "Margaret hamilt",
					imgUrl = "Images/Kanban/4.png",
					rankId = 4
				},
				new
				{
					id = 16, status = "InProgress",
					summary = "Fix cannot open user’s default database SQL error.",
					priority = "Critical",
					type = "Bug",
					tags = "Database,Sql2008",
					estimate = 2.5, assignee = "Janet Leverling",
					imgUrl = "Images/Kanban/3.png",
					rankId = 4
				},
				new
				{
					id = 17, status = "Testing",
					summary = "Fix the issues reported in data binding.",
					type = "Story",
					priority = "Normal",
					tags = "Databinding",
					estimate = "3.5",
					assignee = "Janet Leverling",
					imgUrl = "Images/Kanban/3.png",
					rankId = 4
				},
				new
				{
					id = 18, status = "Close",
					summary = "Analyze SQL server 2008 connection.",
					type = "Story",
					priority = "Release Breaker",
					tags = "Grid,Sql",
					estimate = 2, assignee = "Andrew Fuller",
					imgUrl = "Images/Kanban/2.png",
					rankId = 4
				},
				new
				{
					id = 19, status = "Validate",
					summary = "Validate databinding issues.",
					type = "Story",
					priority = "Low",
					tags = "Validation",
					estimate = 1.5, assignee = "Margaret hamilt",
					imgUrl = "Images/Kanban/4.png",
					rankId = 1
				},
				new
				{
					id = 20, status = "Close",
					summary = "Analyze grid control.",
					type = "Story",
					priority = "High",
					tags = "Analyze",
					estimate = 2.5, assignee = "Margaret hamilt",
					imgUrl = "Images/Kanban/4.png",
					rankId = 5
				},
				new
				{
					id = 21, status = "Close",
					summary = "Stored procedure for initial data binding of the grid.",
					type = "Others",
					priority = "Release Breaker",
					tags = "Databinding",
					estimate = 1.5, assignee = "Steven walker",
					imgUrl = "Images/Kanban/5.png",
					rankId = 6
				},
				new
				{
					id = 22, status = "Close",
					summary = "Analyze stored procedures.",
					type = "Story",
					priority = "Release Breaker",
					tags = "Procedures",
					estimate = 5.5, assignee = "Janet Leverling",
					imgUrl = "Images/Kanban/3.png",
					rankId = 7
				},
				new
				{
					id = 23, status = "Validate",
					summary = "Validate editing issues.",
					type = "Story",
					priority = "Critical",
					tags = "Editing",
					estimate = 1, assignee = "Nancy Davloio",
					imgUrl = "Images/Kanban/1.png",
					rankId = 1
				},
				new
				{
					id = 24, status = "Testing",
					summary = "Test editing functionality.",
					type = "Story",
					priority = "Normal",
					tags = "Editing,Test",
					estimate = 0.5, assignee = "Nancy Davloio",
					imgUrl = "Images/Kanban/1.png",
					rankId = 5
				},
				new
				{
					id = 25, status = "Open",
					summary = "Enhance editing functionality.",
					type = "Improvement",
					priority = "Low",
					tags = "Editing",
					estimate = 3.5, assignee = "Andrew Fuller",
					imgUrl = "Images/Kanban/2.png",
					rankId = 5
				},
				new
				{
					id = 26, status = "InProgress",
					summary = "Improve the performance of the editing functionality.",
					type = "Epic",
					priority = "High",
					tags = "Performance",
					estimate = 6, assignee = "Nancy Davloio",
					imgUrl = "Images/Kanban/1.png",
					rankId = 5
				},
				new
				{
					id = 27, status = "Open",
					summary = "Arrange web meeting with the customer to show editing demo.",
					type = "Others",
					priority = "High",
					tags = "Meeting,Editing",
					estimate = 5.5, assignee = "Steven walker",
					imgUrl = "Images/Kanban/5.png",
					rankId = 6
				}
			};
			this.ejKanban1.Options.columns = new object[]
			{
				new
				{
					headerText = "Backlog",
					key = "Open",
					headerTemplate = "#column1"
				},
				new
				{
					headerText = "In Progress",
					key = "InProgress",
					headerTemplate = "#column2"
				},
				new
				{
					headerText = "Testing",
					key = "Testing",
					headerTemplate = "#column3"
				},
				new
				{
					headerText = "Done",
					key = "Close",
					headerTemplate = "#column4"
				}
			};
			this.ejKanban1.Options.keyField = "status";
			this.ejKanban1.Options.allowTitle = true;
			this.ejKanban1.Options.fields = new
			{
				primaryKey = "id",
				content = "summary",
				imageUrl = "imgUrl"
			};
			this.ejKanban1.Options.allowSelection = false;
			this.ejKanban1.Options.allowScrolling = true;
			this.ejKanban1.Options.scrollSettings = new
			{
				height = "auto"
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejKanban1.Options.selectionType = this.comboBox1.Text;
			this.ejKanban1.Options.allowDragAndDrop = this.checkBox1.Checked;
			this.ejKanban1.Options.allowTitle = this.checkBox2.Checked;
			this.ejKanban1.Options.allowSearching = this.checkBox3.Checked;
			this.ejKanban1.Options.allowFiltering = this.checkBox4.Checked;
			this.ejKanban1.Options.allowPrinting = this.checkBox5.Checked;

			this.ejKanban1.Update();
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejKanban1.Instance.dataSource(JSON.Parse(json));
				}
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejKanban1.Instance.optionAsync("dataSource");
			var json = Core.WisejSerializer.Serialize(data);

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "kanban.json");
		}

		private async void buttonGetVisibleColumnNames_Click(object sender, EventArgs e)
		{
			var visibleNames = await this.ejKanban1.Instance.getVisibleColumnNamesAsync();

			AlertBox.Show(Core.WisejSerializer.Serialize(visibleNames));
		}

		private void ejKanban1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}