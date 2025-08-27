using System;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoBreadcrumb : TestBase
	{
		private List<dynamic> items = new List<dynamic>();

		public kendoBreadcrumb()
		{
			InitializeComponent();

			this.kendoBreadcrumb1.Instance.onClick += new WidgetEventHandler(kendoBreadcrumb1_WidgetEvent);
			this.kendoBreadcrumb1.Instance.onChange += new WidgetEventHandler(kendoBreadcrumb1_WidgetEvent);
		}

		private void kendoBreadcrumb_Load(object sender, EventArgs e)
		{
			this.items.AddRange(new dynamic[]
			{
				new { type = "rootitem", text = "All Components", showText = true },
				new { type = "item", text = "Breadcrumb" },
				new { type = "item", text = "Basic Usage" }
			});

			this.kendoBreadcrumb1.Options.items = this.items;
		}

		private void kendoBreadcrumb1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoBreadcrumb1.Update();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			this.items.Add(new
			{
				type = "item",
				text = this.textBoxName.Text
			});

			this.kendoBreadcrumb1.Instance.items(this.items);
		}
	}
}
