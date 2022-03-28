using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Tree : ViewBase
	{
		public Tree()
		{
			InitializeComponent();
		}

		private void Tree_Load(object sender, EventArgs e)
		{
			tree1.Options.data = new dynamic[]
			{
				new
				{
					id = "root",
					value = "Cars",
					open = true,
					data = new dynamic[]
					{
						new
						{
							id = "1",
							open = true,
							value = "Toyota",
							data = new[]
							{
								new
								{
									id = "1.1",
									value = "Avalon"
								},
								new
								{
									id = "1.2",
									value = "Corolla"
								},
								new
								{
									id = "1.3",
									value = "Camry"
								}
							}
						},
						new
						{
							id = "2",
							open = true,
							value = "Skoda",
							data = new[]
							{
								new
								{
									id = "2.1",
									value = "Octavia"
								},
								new
								{
									id = "2.2",
									value = "Fabia"
								},
								new
								{
									id = "2.3",
									value = "Superb"
								}
							}
						}
					}
				}
			};
		}
	}
}