using System;
using System.Runtime.CompilerServices;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class TreeTable : ViewBase
	{
		private object[] css;

		public TreeTable()
		{
			InitializeComponent();
		}

		private void TreeTable_Load(object sender, EventArgs e)
		{
			treeTable1.Options.areaselect = true;
			treeTable1.Options.columns = new dynamic[]
			{
				new
				{
					id = "id",
					header = "",
					width = 50
				},
				new
				{
					id = "value",
					header = "Film title",
					width = 350,
					template = "{common.treetable()} #value#"
				},
				new
				{
					id = "chapter",
					header = "Mode",
					width = 200
				}
			};
			treeTable1.Options.autoheight = true;
			treeTable1.Options.autowidth = true;
			treeTable1.Options.data = new dynamic[]
			{
				new
				{
					id = 1,
					value = "The Shawshank Redemption",
					open = true,
					data = new dynamic[]
					{
						new
						{
							id = "1.1",
							value = "Part 1",
							chapter = "alpha"
						},
						new
						{
							id = "1.2",
							value = "Part 2",
							chapter = "beta",
							open = true,
							data = new[]
							{
								new
								{
									id = "1.2.1",
									value = "Part 1",
									chapter = "beta-twin"
								},
								new
								{
									id = "1.2.2",
									value = "Part 1",
									chapter = "beta-twin"
								}
							}
						},
						new
						{
							id = "1.3",
							value = "Part 3",
							chapter = "gamma"
						}
					}
				},
				new
				{
					id = "2",
					value = "The Godfather",
					data = new[]
					{
						new
						{
							id = "2.1",
							value = "Part 1",
							chapter = "alpha"
						},
						new
						{
							id = "2.21",
							value = "Part 2",
							chapter = "beta"
						}
					}
				}
			};
		}
	}
}