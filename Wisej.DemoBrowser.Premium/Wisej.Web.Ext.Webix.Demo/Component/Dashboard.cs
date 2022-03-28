using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Dashboard : ViewBase
	{
		private void Dashboard_Load(object sender, EventArgs e)
		{
			dashboard1.Options.gridColumns = 4;
			dashboard1.Options.gridRows = 3;
			dashboard1.Options.cellHeight = 200;
			dashboard1.Options.cellWidth = 300;
			dashboard1.Options.cells = new dynamic[]
			{
				new
				{
					view = "panel",
					x = 0,
					y = 0,
					dx = 1,
					dy = 1,
					resize = true,
					css = "panel_drag_view",
					icon = false,
					body = new[]
					{
						new
						{
							view = "chart",
							type = "pie",
							value = "#voltes#",
							data = new dynamic[]
							{
								new
								{
									id = 1,
									title = "The Shawshank Redemption",
									year = 1994,
									votes = 678790,
									rating = 9.2,
									rank = 1,
									category = "Thriller"
								},
								new
								{
									id = 2,
									title = "The Godfather",
									year = 1972,
									votes = 511495,
									rating = 9.2,
									rank = 2,
									category = "Crime"
								},
								new
								{
									id = 3,
									title = "The Godfather: Part II",
									year = 1974,
									votes = 319352,
									rating = 9,
									rank = 3,
									category = "Crime"
								},
								new
								{
									id = 4,
									title = "The Good, the Bad and the Ugly",
									year = 1966,
									votes = 213030,
									rating = 8.9,
									rank = 4,
									category = "Western"
								},
								new
								{
									id = 5,
									title = "Pulp fiction",
									year = 1994,
									votes = 533848,
									rating = 8.9,
									rank = 5,
									category = "Crime"
								},
								new
								{
									id = 6,
									title = "12 Angry Men",
									year = 1957,
									votes = 164558,
									rating = 8.9,
									rank = 6,
									category = "Western"
								}
							},
							scroll = false
						}
					}
				},
				new
				{
					view = "panel",
					x = 0,
					y = 1,
					dx = 1,
					dy = 2,
					resize = true,
					css = "panel_drag_view",
					icon = false,
					body = new dynamic[]
					{
						new
						{
							view = "list",
							template = "#voltes#",
							data = new dynamic[]
							{
								new
								{
									id = 1,
									title = "The Shawshank Redemption",
									year = 1994,
									votes = 678790,
									rating = 9.2,
									rank = 1,
									category = "Thriller"
								},
								new
								{
									id = 2,
									title = "The Godfather",
									year = 1972,
									votes = 511495,
									rating = 9.2,
									rank = 2,
									category = "Crime"
								},
								new
								{
									id = 3,
									title = "The Godfather: Part II",
									year = 1974,
									votes = 319352,
									rating = 9,
									rank = 3,
									category = "Crime"
								},
								new
								{
									id = 4,
									title = "The Good, the Bad and the Ugly",
									year = 1966,
									votes = 213030,
									rating = 8.9,
									rank = 4,
									category = "Western"
								},
								new
								{
									id = 5,
									title = "Pulp fiction",
									year = 1994,
									votes = 533848,
									rating = 8.9,
									rank = 5,
									category = "Crime"
								},
								new
								{
									id = 6,
									title = "12 Angry Men",
									year = 1957,
									votes = 164558,
									rating = 8.9,
									rank = 6,
									category = "Western"
								}
							},
							scroll = false
						}
					}
				},
				new
				{
					view = "panel",
					type = "space",
					header = "Widget with header",
					x = 1,
					y = 1,
					dx = 3,
					dy = 2,
					resize = true,
					css = "panel_drag_view",
					icon = false,
					body = new dynamic[]
					{
						new
						{
							view = "datatable",
							autoconfig = true,
							data = new dynamic[]
							{
								new
								{
									id = 1,
									title = "The Shawshank Redemption",
									year = 1994,
									votes = 678790,
									rating = 9.2,
									rank = 1,
									category = "Thriller"
								},
								new
								{
									id = 2,
									title = "The Godfather",
									year = 1972,
									votes = 511495,
									rating = 9.2,
									rank = 2,
									category = "Crime"
								},
								new
								{
									id = 3,
									title = "The Godfather: Part II",
									year = 1974,
									votes = 319352,
									rating = 9,
									rank = 3,
									category = "Crime"
								},
								new
								{
									id = 4,
									title = "The Good, the Bad and the Ugly",
									year = 1966,
									votes = 213030,
									rating = 8.9,
									rank = 4,
									category = "Western"
								},
								new
								{
									id = 5,
									title = "Pulp fiction",
									year = 1994,
									votes = 533848,
									rating = 8.9,
									rank = 5,
									category = "Crime"
								},
								new
								{
									id = 6,
									title = "12 Angry Men",
									year = 1957,
									votes = 164558,
									rating = 8.9,
									rank = 6,
									category = "Western"
								}
							},
							scroll = false
						}
					}
				}
			};
		}

		public Dashboard()
		{
			InitializeComponent();
		}
	}
}