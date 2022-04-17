using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Kanban : ViewBase
	{
		public Kanban()
		{
			InitializeComponent();
		}

		private void Kanban_Load(object sender, EventArgs e)
		{
			kanban1.Options.view = "kanban";
			kanban1.Options.cols = new dynamic[]
			{
				new
				{
					header = "Backlog",
					body = new
					{
						view = "kanbanlist",
						status = "new"
					}
				},
				new
				{
					header = "In Progress",
					body = new
					{
						view = "kanbanlist",
						status = "work"
					}
				},
				new
				{
					header = "Testing",
					body = new
					{
						view = "kanbanlist",
						status = "test"
					}
				},
				new
				{
					header = "Done",
					body = new
					{
						view = "kanbanlist",
						status = "done"
					}
				}
			};

			kanban1.Options.userList = true;

			kanban1.Options.editor = true;

			kanban1.Options.data = new dynamic[]
			{
				new
				{
					id = 1,
					status = "new",
					text = "Test new authentication service",
					tags = new[] {1, 2, 3}
				},
				new
				{
					id = 2,
					status = "work",
					user_id = 5,
					text = "Performance tests",
					tags = new[] {1}
				},
				new
				{
					id = 3,
					status = "work",
					user_id = 6,
					text = "Kanban tutorial",
					tags = new[] {2}
				},
				new
				{
					id = 4,
					status = "work",
					user_id = 3,
					text = "SpreadSheet NodeJS",
					tags = new[] {3}
				},
				new
				{
					id = 5,
					status = "test",
					user_id = 9,
					text = "Portlets view",
					tags = new[] {4, 2}
				},
				new
				{
					id = 6,
					status = "new",
					user_id = 7,
					text = "Form Builder",
					tags = new[] {4, 6}
				},
				new
				{
					id = 7,
					status = "test",
					text = "Code Snippet",
					tags = new[] {1, 2, 3}
				},
				new
				{
					id = 8,
					status = "work",
					user_id = 1,
					text = "Backend integration",
					tags = new[] {5}
				},
				new
				{
					id = 9,
					status = "work",
					user_id = 2,
					text = "Drag-n-drop with shifting cards",
					tags = new[] {5}
				},
				new
				{
					id = 10,
					status = "work",
					user_id = 4,
					text = "Webix Jet 2.0",
					tags = new[] {4}
				},
				new
				{
					id = 11,
					status = "test",
					user_id = 9,
					text = "Chat app interface",
					tags = new[] {4, 2}
				},
				new
				{
					id = 12,
					status = "done",
					user_id = 8,
					text = "Material skin",
					tags = new[] {4, 6}
				}
			};

			kanban1.Options.tags = new dynamic[]
			{
				new
				{
					id = 1,
					value = "webix"
				},
				new
				{
					id = 2,
					value = "jet"
				},
				new
				{
					id = 3,
					value = "easy"
				},
				new
				{
					id = 4,
					value = "hard"
				},
				new
				{
					id = 5,
					value = "kanban"
				},
				new
				{
					id = 1,
					value = "docs"
				}
			};

			kanban1.Options.users = new dynamic[]
			{
				new
				{
					id = 1,
					value = "Rick Lopes",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/1.jpg"
				},
				new
				{
					id = 2,
					value = "Martin Farrell",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/2.jpg"
				},
				new
				{
					id = 3,
					value = "Douglass Moore",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/3.jpg"
				},
				new
				{
					id = 4,
					value = "Eric Doe",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/4.jpg"
				},
				new
				{
					id = 5,
					value = "Sophi Elliman",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/5.jpg"
				},
				new
				{
					id = 6,
					value = "Anna O'Neal"
				},
				new
				{
					id = 7,
					value = "Marcus Storm",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/7.jpg"
				},
				new
				{
					id = 8,
					value = "Nick Branson",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/8.jpg"
				},
				new
				{
					id = 9,
					value = "CC",
					image = "https://docs.webix.com/samples/63_kanban/common/imgs/9.jpg"
				}
			};

			kanban1.Options.colors = new dynamic[]
			{
				new
				{
					id = 1,
					value = "Normal",
					color = "green"
				},
				new
				{
					id = 2,
					value = "Low",
					color = "orange"
				},
				new
				{
					id = 3,
					value = "Urgent",
					color = "red"
				}
			};
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.kanban1.Options.type = this.comboBoxType.SelectedItem.ToString();

			this.kanban1.Update();
        }
    }
}