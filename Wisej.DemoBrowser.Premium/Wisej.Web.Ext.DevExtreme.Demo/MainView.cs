
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using Wisej.Web.Ext.DevExtreme.Demo.Component;
using static Wisej.Web.Widget;

namespace Wisej.Web.Ext.DevExtreme.Demo
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

			dxBase.Culture = new CultureInfo("en-US");
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			this.listBoxDemos.SelectedIndex = this.listBoxDemos.FindString(e.Hash);
		}

		private IList PopulateTestList()
		{
			var asm = this.GetType().Assembly;
			return asm.GetTypes()
				.Where(o => o.Name.StartsWith("dx"))
				.Select(o => new { Icon = "Images/devextreme.png", Name = o.Name, Type = o })
				.ToList();
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

			labelDemo.Text = type.Name;
			Application.Hash = type.Name;
		}

        private void comboBoxDXTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
			dxBase.Theme = this.comboBoxDXTheme.Text;
			Application.Reload();
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
			dxBase.Culture = new CultureInfo(this.comboBoxLanguage.Text);
		}

		private void comboBoxWisejTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
			Application.LoadTheme(this.comboBoxWisejTheme.Text);
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
