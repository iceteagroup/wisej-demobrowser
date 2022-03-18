using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class ViewBase : Wisej.Web.UserControl
	{
		public ViewBase()
		{
			InitializeComponent();
		}

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			Application.Navigate(e.Link, "_blank");
        }
    }
}
