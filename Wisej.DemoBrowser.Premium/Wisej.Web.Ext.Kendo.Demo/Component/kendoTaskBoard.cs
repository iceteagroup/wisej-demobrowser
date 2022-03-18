using System;
using System.IO;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTaskBoard : TestBase
	{
		public kendoTaskBoard()
		{
			InitializeComponent();
		}

		private void kendoTaskBoard_Load(object sender, EventArgs e)
		{
			this.kendoTaskBoard1.Options = new
			{
				columns = new {
					data = new[] { 
						new { id = 1, text = "To-Do", status = "todo" },
						new { id = 2, text = "In Progress", status = "inProgress" },
						new { id = 3, text = "Done", status = "done" }
					}
				},
				dataSource = new { 
					data = JSON.Parse(File.OpenRead(Application.MapPath("Data/TaskBoard/data.json"))),
					schema = new 
					{ 
						model = new
						{
							id = "id",
							fields = new 
							{
								id = new { type = "number" },
								order = new { type = "number" },
								title = new { field = "title", defaultValue = "No title" },
								description = new { field = "description", validation = new { required = true } },
								image = new { from = "image", defaultValue = "" }
							}
						}
					}
				},
				dataOrderField = "order"
			};
		}

		private void kendoTaskBoard1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
