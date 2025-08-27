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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.checkBoxDragScroll.Checked)
				this.tree1.Options.dragscroll = true;
			this.tree1.Options.select = this.checkBoxEnableSelect.Checked;
			this.tree1.Options.dragscroll = this.checkBoxDragScroll.Checked;
			this.tree1.Options.multiselect = this.checkBoxMultiSelect.Checked;
			this.tree1.Options.threeState = this.checkBoxEnableThreeState.Checked;

			this.tree1.Update();
        }
    }
}