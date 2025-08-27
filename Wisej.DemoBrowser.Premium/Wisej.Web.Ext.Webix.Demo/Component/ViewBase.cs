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
        private void buttonLinks_MouseClick(object sender, MouseEventArgs e)
        {
            var width = this.buttonLinks.Width;
            if (e.X <= width * (1F / 3F))
                Application.Navigate(this.linkApi.Text, "DevExtreme");
            else if (e.X <= width * (2F / 3F))
                Application.Navigate(this.linkDocs.Text, "DevExtreme");
            else
                Application.Navigate(this.linkDemo.Text, "DevExtreme");
        }
    }
}
