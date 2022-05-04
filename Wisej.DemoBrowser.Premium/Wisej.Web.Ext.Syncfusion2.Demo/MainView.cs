using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using Wisej.Web.Ext.Syncfusion2.Demo.Component;
using static Wisej.Web.Widget;

namespace Wisej.Web.Ext.Syncfusion2.Demo
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
			this.listBoxDemos.DataSource = PopulateTestList();

			Application.HashChanged += this.Application_HashChanged;

			if (hash != "")
				this.listBoxDemos.SelectedIndex = this.listBoxDemos.FindString(hash);

			ej2Base.Culture = new CultureInfo("en-US");
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			this.listBoxDemos.SelectedIndex = this.listBoxDemos.FindString(e.Hash);
		}

		private IList PopulateTestList()
		{
			var asm = this.GetType().Assembly;
			return asm.GetTypes()
				.Where(o => !o.Name.StartsWith("Test") && o.BaseType == typeof(TestBase))
				.Select(o => new { Icon="Images/syncfusion.png", Name=o.Name, Type=o })
				.ToList();
		}

		private void listBoxDemos_SelectedIndexChanged(object sender, EventArgs e)
		{
			var list = (Wisej.Web.ListBox)sender;
			var type = (Type)((dynamic)list.SelectedItem).Type;
			var testPanel = (TestBase)Activator.CreateInstance(type);

			var container = this.panelDemo;
			container.Controls.Clear(true);
			testPanel.Dock = DockStyle.Fill;
			testPanel.Parent = container;

			this.labelDemo.Text = type.Name;
			Application.Hash = type.Name;
		}

        private void buttonCollapse_Click(object sender, EventArgs e)
        {
			this.panelComponents.Collapsed = !this.panelComponents.Collapsed;
		}

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
			ej2Base.Culture = new CultureInfo(this.comboBoxLanguage.Text);
			Application.Reload();
        }

        private void comboBoxEJ2Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
			ej2Base.Theme = this.comboBoxEJ2Theme.Text;
			Application.Reload();
		}

        private void buttonContact_Click(object sender, EventArgs e)
        {
			Application.Navigate("https://www.wisej.com/contact-us", "_blank");
		}

        private void buttonFreeTrial_Click(object sender, EventArgs e)
        {
			Application.Navigate("https://wisej.com/products/", "_blank");
		}

        private void buttonBuy_Click(object sender, EventArgs e)
        {
			Application.Navigate("https://wisej.com/products/", "_blank");
		}

        private void buttonDocs_Click(object sender, EventArgs e)
        {
			Application.Navigate("https://docs.wisej.com/", "_blank");
		}

        private void buttonAPI_Click(object sender, EventArgs e)
        {
			Application.Navigate("https://docs.wisej.com/api", "_blank");
		}

        private void buttonSupport_Click(object sender, EventArgs e)
        {
			Application.Navigate("https://www.wisej.com/support", "_blank");
		}

        private void buttonMWW_Click(object sender, EventArgs e)
        {
			Application.Navigate("http://www.madewithwisej.com", "_blank");
		}

        private void comboBoxWisejTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
			Application.LoadTheme(this.comboBoxWisejTheme.Text);
        }

		private void labelNavigationWisejDemos_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://demo.wisej.com/DemoBrowser");
		}

		private void labelNaivgationCategory_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://demo.wisej.com/DemoBrowser/#Extensions/Premium");
		}

		private void labelNavigationPremium_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://demo.wisej.com/DemoBrowser/#Extensions/Premium");
		}
	}
}
