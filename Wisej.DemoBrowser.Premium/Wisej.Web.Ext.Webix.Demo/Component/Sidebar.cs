using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Sidebar : ViewBase
	{
		public Sidebar()
		{
			InitializeComponent();
		}

		private void Sidebar_Load(object sender, EventArgs e)
		{
			// dynamic[] allows different members to have different configs. new[] does not.
			this.sidebar1.Options.data = new dynamic[]
			{
				new
				{
					value = "Dashboards",
					data = new[]
					{
						new { id = "dashboard1", value = "Dashboard 1"},
						new { id = "dashboard2", value = "Dashboard 2"}
					}
				},
				new
				{
					value = "Layouts",
					data = new[]
					{
						new { id = "accordions", value = "Accordions" },
						new { id = "portlets", value = "Portlets" }
					}
				}
			};
		}
	}
}
