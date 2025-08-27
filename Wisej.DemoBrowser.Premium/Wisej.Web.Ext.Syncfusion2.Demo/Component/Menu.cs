using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Menu : TestBase
	{
		public Menu()
		{
			InitializeComponent();

			this.menu1.Instance.onSelect += new WidgetEventHandler(menu1_WidgetEvent);
		}

		private void Menu_Load(object sender, EventArgs e)
		{
			this.menu1.Options.hamburgerMode = true;
			this.menu1.Options.orientation = "Horizontal";
			this.menu1.Options.items = new object[]
			{
				new
				{
					text = "File",
					items = new object[]
					{
						new
						{
							text = "Open"
						},
						new
						{
							text = "Save"
						},
						new
						{
							text = "Exit"
						}
					}
				},
				new
				{
					text = "Edit",
					items = new object[]
					{
						new
						{
							text = "Cut"
						},
						new
						{
							text = "Copy"
						},
						new
						{
							text = "Paste"
						}
					}
				},
				new
				{
					text = "View",
					items = new object[]
					{
						new
						{
							text = "Toolbar"
						},
						new
						{
							text = "Sidebar"
						}
					}
				},
				new
				{
					text = "Tools",
					items = new object[]
					{
						new
						{
							text = "Spelling & Grammar"
						},
						new
						{
							text = "Customize"
						},
						new
						{
							text = "Options"
						}
					}
				},
				new
				{
					text = "Go"
				},
				new
				{
					text = "Help"
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.menu1.Options.orientation = this.comboBoxOrientation.Text;

			this.menu1.Update();
		}

		private void menu1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}