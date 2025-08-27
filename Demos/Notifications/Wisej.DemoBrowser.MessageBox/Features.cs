using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.MessageBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void buttonIcons_Click(object sender, EventArgs e)
		{
			var text = ((Control)sender).Text;
			var icon = (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), text);

			Web.MessageBox.Show($"{text} Icon", icon: icon);
		}

		private void buttonNone_Click(object sender, EventArgs e)
		{
			Web.MessageBox.Show("No Icon", icon: MessageBoxIcon.None);
		}

		private void buttonNoModal_Click(object sender, EventArgs e)
		{
			Web.MessageBox.Show("Non-Modal Dialog", modal: false);
		}

		private void buttonKeepOnScreen_Click(object sender, EventArgs e)
		{
			Web.MessageBox.Show("Prevents the MessageBox from being moved off-screen", keepOnScreen: true);
		}

		private void buttonAllowHtml_Click(object sender, EventArgs e)
		{
			Web.MessageBox.Show("<b>Hello</b>, <i>World!</i>");
		}

		private void buttonCaption_Click(object sender, EventArgs e)
		{
			Web.MessageBox.Show("Hello, World!", "Popup");
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			Web.MessageBox.Show("Hello, World", "MessageBox");
		}

		private void buttonMessageBoxButtons_Click(object sender, EventArgs e)
		{
			var text = ((Control)sender).Text;
			var buttons = (MessageBoxButtons)Enum.Parse(typeof(MessageBoxButtons), text);

			var result = Web.MessageBox.Show("Select a Response", "MessageBox", buttons: buttons);
			AlertBox.Show($"Selected {result}");
		}
	}
}
