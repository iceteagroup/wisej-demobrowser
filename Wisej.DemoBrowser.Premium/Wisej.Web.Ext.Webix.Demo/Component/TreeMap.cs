using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class TreeMap : ViewBase
	{
		public TreeMap()
		{
			InitializeComponent();
		}

		private void TreeMap_Load(object sender, EventArgs e)
		{
			treeMap1.Options.rows = new dynamic[]
			{
				new
				{
					view = "toolbar",
					height = 35,
					elements = new[]
					{
						new
						{
							view = "label",
							label = "TreeMap"
						}
					}
				},
				new
				{
					view = "treemap",
					select = true,
					value = "#value#",
					data = new[]
					{
						new
						{
							id = "1",
							label = "Technology",
							data = new[]
							{
								new
								{
									id = "1.1",
									value = "50"
								},
								new
								{
									id = "1.2",
									value = "30"
								},
								new
								{
									id = "1.3",
									value = "20"
								}
							}
						},
						new
						{
							id = "2",
							label = "Healthcare",
							data = new[]
							{
								new
								{
									id = "2.1",
									value = "80"
								},
								new
								{
									id = "2.2",
									value = "10"
								},
								new
								{
									id = "2.3",
									value = "60"
								},
								new
								{
									id = "2.4",
									value = "5"
								},
								new
								{
									id = "2.5",
									value = "8"
								}
							}
						},
						new
						{
							id = "3",
							label = "Basic Materials",
							data = new[]
							{
								new
								{
									id = "3.1",
									value = "80"
								},
								new
								{
									id = "3.2",
									value = "10"
								},
								new
								{
									id = "3.3",
									value = "60"
								}
							}
						},
						new
						{
							id = "4",
							label = "Financial",
							data = new[]
							{
								new
								{
									id = "4.1",
									value = "100"
								},
								new
								{
									id = "4.2",
									value = "15"
								},
								new
								{
									id = "4.3",
									value = "20"
								}
							}
						},
						new
						{
							id = "5",
							label = "Consumer Goods",
							data = new[]
							{
								new
								{
									id = "5.1",
									value = "80"
								},
								new
								{
									id = "5.2",
									value = "10"
								},
								new
								{
									id = "5.3",
									value = "60"
								}
							}
						},
						new
						{
							id = "6",
							label = "Industrial Goods",
							data = new[]
							{
								new
								{
									id = "6.1",
									value = "20"
								},
								new
								{
									id = "6.2",
									value = "5"
								},
								new
								{
									id = "6.3",
									value = "9"
								}
							}
						}
					}
				}
			};
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.treeMap1.Options.select = this.checkBoxEnableSelect.Checked;
			this.treeMap1.Options.multiselect = this.checkBoxEnableMultiSelect.Checked;

			this.treeMap1.Update();
        }
    }
}