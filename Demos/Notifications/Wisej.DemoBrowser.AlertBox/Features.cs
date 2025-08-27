using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.AlertBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("Hello, World!");
		}

		private void buttonIcons_Click(object sender, EventArgs e)
		{
			var text = ((Control)sender).Text;
			var icon = (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), text);

			Web.AlertBox.Show(text, icon);
		}

		private void buttonNone_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("No Icon", MessageBoxIcon.None);
		}

		private void buttonAlignments_Click(object sender, EventArgs e)
		{
			foreach (var value in Enum.GetValues(typeof(ContentAlignment)))
			{
				var text = (string)Enum.GetName(typeof(ContentAlignment), value);
				
				Web.AlertBox.Show(text, alignment: (ContentAlignment)value);
			}	
		}

		private void buttonAutoCloseDelay_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("Auto-Close Delay: 6 Seconds", autoCloseDelay: 6000);
		}

		private void buttonProgressBar_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("Progress Bar", showProgressBar: true);
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("Close Button", showCloseButton: true);
		}

		private void buttonHtml_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("<b>Hello</b>, <i>World!</i>");
		}

		private void buttonActionOnClose_Click(object sender, EventArgs e)
		{
			Web.AlertBox.Show("Action on Close", showProgressBar: true, showCloseButton: true, onclose: () =>
			{
				new Toast("AlertBox closed.").Show();
			});
		}
	}
}
