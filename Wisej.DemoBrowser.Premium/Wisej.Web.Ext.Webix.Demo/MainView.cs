
using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using Wisej.Web.Ext.Webix.Demo.Component;

namespace Wisej.Web.Ext.Webix.Demo
{
	public partial class MainView : Page
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void MainView_Load(object sender, EventArgs e)
		{
			var hash = Application.Hash;
			this.listBoxComponents.DataSource = PopulateTestList();

			Application.HashChanged += this.Application_HashChanged;

			if (hash != "")
				this.listBoxComponents.SelectedIndex = this.listBoxComponents.FindString(hash);
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			this.listBoxComponents.SelectedIndex = this.listBoxComponents.FindString(e.Hash);
		}

		private IList PopulateTestList()
		{
			var asm = this.GetType().Assembly;
			return asm.GetTypes()
				.Where(o => !o.Name.StartsWith("ViewBase") && o.IsSubclassOf(typeof(ViewBase)))
				.Select(o => new { Icon = "Images/webix.png", Name = o.Name, Type = o })
				.ToList();
		}

		private void listBoxComponents_SelectedIndexChanged(object sender, EventArgs e)
		{
			var list = (ListBox)sender;
			var type = (Type)((dynamic)list.SelectedItem).Type;
			var testPanel = (ViewBase)Activator.CreateInstance(type);

			var container = this.panelDemo;
			container.Controls.Clear(true);
			testPanel.Dock = DockStyle.Fill;
			testPanel.Parent = container;

			container.Text = type.Name;
			Application.Hash = type.Name;
		}

		private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			wxBase.Theme = this.comboBoxTheme.Text;
			Application.Reload();
		}

		private void comboBoxCulture_SelectedIndexChanged(object sender, EventArgs e)
		{
			wxBase.Culture = new CultureInfo(this.comboBoxCulture.Text);
		}
	}
}
