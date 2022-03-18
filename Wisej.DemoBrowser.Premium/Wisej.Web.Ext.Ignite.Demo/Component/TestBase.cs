using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class TestBase : Wisej.Web.UserControl
	{
		public TestBase()
		{
			InitializeComponent();
		}

		private void linkDocs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Navigate(e.Link, "Ignite UI");
		}
	}
}
