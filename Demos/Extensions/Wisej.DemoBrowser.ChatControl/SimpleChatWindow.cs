using System;
using System.IO;
using System.Text;
using System.Threading;
using Bogus;
using Wisej.DemoBrowser.ChatControl.Controls;
using Wisej.DemoBrowser.ChatControl.Windows;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	public partial class SimpleChatWindow : Form
	{

		#region Constructor

		public SimpleChatWindow()
		{
			InitializeComponent();
		}

		#endregion

		#region Properties

		public User User { get; set; }

		#endregion

		private void ChatWindow_Load(object sender, EventArgs e)
		{
			LoadCurrentUser();
			StartMessageTask();
		}

		private void StartMessageTask()
		{
			var faker = new Faker();
			var otherUser = new User("OtherUser", $"Other User", faker.Internet.Avatar());

			Application.StartTask(() =>
			{
				for (var i = 1; i <= 10; i++)
				{
					this.chatBox1.DataSource.Add(new Message
					{
						User = otherUser,
						Content = $"Message {i} of 10"
					});

					Application.Update(this);

					Thread.Sleep(5000);
				}
			});
		}

		// create the current user.
		private void LoadCurrentUser()
		{
			var faker = new Faker();
			this.User = new User("SimpleUser", $"Simple User", faker.Internet.Avatar());
			this.chatBox1.User = User;
		}

		private void chatBox1_MessageActionInvoke(object sender, object e)
		{
			if (sender is OptionsMessageControl omControl)
			{
				AlertBox.Show((string)e);
			}
			else if (sender is FileMessageControl fmControl)
			{
				var name = fmControl.FilePath;
				var stream = fmControl.Stream;

				switch (fmControl.ContentType)
				{
					case "image/png":
					case "image/jpg":
					case "image/jpeg":
					case "image/gif":
						new ImagePreviewWindow(name, stream).Show();
						break;

					case "video/mp4":
					case "application/mp4":
						new VideoPreviewWindow(name, stream).Show();
						break;
				}
			}
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			var json = this.chatBox1.ExportAsJson();
			var bytes = Encoding.UTF8.GetBytes(json);
			using (var ms = new MemoryStream(bytes))
				Application.Download(ms, "Conversation.json");
		}

		private void chatBox1_SendMessage(object sender, Message e)
		{
			AlertBox.Show(JSON.Stringify(e));
		}
	}
}
