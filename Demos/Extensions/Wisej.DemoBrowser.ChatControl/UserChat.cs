using System;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	public partial class UserChat : UserControl
	{
		public UserChat()
		{
			InitializeComponent();
		}

		public User User;

		private void UserChat_Appear(object sender, EventArgs e)
		{
			this.labelName.Text = this.User.Name;
			this.pictureBox1.ImageSource = this.User.ImageSource;
			this.labelLastMessage.Text = "Last Message";
		}
	}
}
