using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeView : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTreeView()
		{
			InitializeComponent();

			this.kendoTreeView1.Instance.onCheck += new WidgetEventHandler(kendoTreeView1_WidgetEvent);
			this.kendoTreeView1.Instance.onSelect += new WidgetEventHandler(kendoTreeView1_WidgetEvent);
		}

		private void kendoTreeView_Load(object sender, EventArgs e)
		{
			this.kendoTreeView1.Options.dataSource = new object[]
			{
				new
				{
					id = 1, text = "My Documents",
					expanded = true, spriteCssClass = "rootfolder",
					items = new object[]
					{
						new
						{
							id = 2, text = "Kendo UI Project",
							expanded = true, spriteCssClass = "folder",
							items = new object[]
							{
								new
								{
									id = 3, text = "about.html",
									spriteCssClass = "html"
								},
								new
								{
									id = 4, text = "index.html",
									spriteCssClass = "html"
								},
								new
								{
									id = 5, text = "logo.png",
									spriteCssClass = "image"
								}
							}
						},
						new
						{
							id = 6, text = "Reports",
							expanded = true, spriteCssClass = "folder",
							items = new object[]
							{
								new
								{
									id = 7, text = "February.pdf",
									spriteCssClass = "pdf"
								},
								new
								{
									id = 8, text = "March.pdf",
									spriteCssClass = "pdf"
								},
								new
								{
									id = 9, text = "April.pdf",
									spriteCssClass = "pdf"
								}
							}
						}
					}
				}
			};
			this.kendoTreeView1.Options.dragAndDrop = true;
			this.kendoTreeView1.Options.checkboxes = new
			{
				checkChildren = false,
			};
			this.kendoTreeView1.Options.loadOnDemand = true;

		}

		private void kendoTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
			$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
			MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoTreeView1.Options.checkboxes = this.checkBoxShowcheckboxes.Checked;
			this.kendoTreeView1.Options.dragAndDrop = this.checkBoxAllowDragAndDrop.Checked;

			this.kendoTreeView1.Update();
		}

		private void buttonAppend_Click(object sender, EventArgs e)
		{
			this.kendoTreeView1.Instance.append(new { text = this.textBoxAppend.Text });
		}
	}
}
