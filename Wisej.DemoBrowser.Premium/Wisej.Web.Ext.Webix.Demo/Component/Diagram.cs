using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Diagram : ViewBase
	{
		private void Diagram_Load(object sender, EventArgs e)
		{
			diagram1.Options.items = new dynamic[]
			{
				new
				{
					width = 120,
					height = 70
				}
			};

			diagram1.Options.select = true;

			diagram1.Options.data = new dynamic[]
			{
				new
				{
					id = "root",
					value = "Board of Directors"
				},
				new
				{
					id = "1",
					value = "Managing Director"
				},
				new
				{
					id = "1.1",
					value = "Base Manager"
				},
				new
				{
					id = "1.1.1",
					value = "Store Manager"
				},
				new
				{
					id = "1.1.2",
					value = "Office Assistant"
				},
				new
				{
					id = "1.1.2.1",
					value = "Dispatcher"
				},
				new
				{
					id = "1.1.2.1.1",
					value = "Drivers"
				},
				new
				{
					id = "1.1.3",
					value = "Security"
				},
				new
				{
					id = "1.2",
					value = "Business Development Manager"
				},
				new
				{
					id = "1.2.1",
					value = "Marketing Executive"
				},
				new
				{
					id = "1.3",
					value = "Finance Manager"
				},
				new
				{
					id = "1.3.1",
					value = "Accountant"
				},
				new
				{
					id = "1.3.1.1",
					value = "Accounts Officer"
				},
				new
				{
					id = "1.4",
					value = "Project Manager"
				},
				new
				{
					id = "1.4.1",
					value = "Supervisors"
				},
				new
				{
					id = "1.4.1.1",
					value = "Foremen"
				}
			};

			diagram1.Options.links = new dynamic[]
			{
				new
				{
					source = "root",
					target = "1"
				},
				new
				{
					source = "1",
					target = "1.1"
				},
				new
				{
					source = "1.1",
					target = "1.1.1"
				},
				new
				{
					source = "1.1",
					target = "1.1.2"
				},
				new
				{
					source = "1.1.2",
					target = "1.1.2.1"
				},
				new
				{
					source = "1.1.2.1",
					target = "1.1.2.1.1"
				},
				new
				{
					source = "1.1",
					target = "1.1.3"
				},
				new
				{
					source = "1",
					target = "1.2"
				},
				new
				{
					source = "1.2",
					target = "1.2.1"
				},
				new
				{
					source = "1",
					target = "1.3"
				},
				new
				{
					source = "1.3",
					target = "1.3.1"
				},
				new
				{
					source = "1.3.1",
					target = "1.3.1.1"
				},
				new
				{
					source = "1",
					target = "1.4"
				},
				new
				{
					source = "1.4",
					target = "1.4.1"
				},
				new
				{
					source = "1.4.1",
					target = "1.4.1.1"
				}
			};
		}

		public Diagram()
		{
			InitializeComponent();
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.diagram1.Options.zoom = this.numericUpDownZoomLevel.Value;
			this.diagram1.Options.scroll = this.checkBoxAllowScroll.Checked;
			this.diagram1.Options.select = this.checkBoxAllowSelect.Checked;

			this.diagram1.Update();
        }
    }
}
