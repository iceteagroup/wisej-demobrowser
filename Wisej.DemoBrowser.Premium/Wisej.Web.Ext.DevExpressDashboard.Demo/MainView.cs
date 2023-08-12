using DevExpress.DashboardWeb;
using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;
using Wisej.Web.Ext.DevExpressDashboard.Demo.Dashboards;

namespace Wisej.Web.Ext.DevExpressDashboard.Demo
{
	public partial class MainView : Page
	{
		private DashboardConfigurator _configurator;
		private DashboardHelper _dashboardHelper;

		public MainView()
		{
			InitializeComponent();
		}

		private void MainView_Load(object sender, EventArgs e)
		{
			var hash = Application.Hash;
			this.listBoxDemos.DataSource = PopulateTestList();

			Application.HashChanged += this.Application_HashChanged;

			if (!String.IsNullOrEmpty(hash))
				this.listBoxDemos.SelectedIndex = this.listBoxDemos.FindString(Split(hash));
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			this.listBoxDemos.SelectedIndex = this.listBoxDemos.FindString(e.Hash);
		}

		private IList PopulateTestList()
		{
			var asm = this.GetType().Assembly;
			return asm.GetTypes()
				.Where(o => (o.BaseType == typeof(TestBase)) && o.Name != "TestBase")
				.Select(o => new { Icon = "Images/devextreme.png", Name = Split(o.Name), Type = o })
				.ToList();
		}

		public string Split(string input)
		{
			return String.Join(" ", Regex.Split(input, "(?<!^)(?=[A-Z])"));
		}

		private void listBoxDemos_SelectedIndexChanged(object sender, EventArgs e)
		{
			var list = (ListBox)sender;
			var type = (Type)((dynamic)list.SelectedItem).Type;
			var testPanel = (TestBase)Activator.CreateInstance(type);

			var container = this.panelDemo;
			container.Controls.Clear(true);
			testPanel.Dock = DockStyle.Fill;
			testPanel.Parent = container;

			labelDemo.Text = Split(type.Name);
			Application.Hash = type.Name;
		}
	}
}
