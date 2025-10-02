using Bogus;
using System;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.DemoBrowser.ChatControl.Controls;
using Wisej.DemoBrowser.ChatControl.Windows;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;
using static System.Net.Mime.MediaTypeNames;

namespace Wisej.DemoBrowser.ChatControl
{
	public partial class AdvancedChatWindow : Form
	{

		#region Constructor

		public AdvancedChatWindow()
		{
			InitializeComponent();
		}

		#endregion

		#region Properties

		public User User { get; set; }

		#endregion

		private void ChatWindow_Load(object sender, EventArgs e)
		{
			LoadOnlineUsers();
			LoadCurrentUser();
			LoadDefaultConversation();

			JoinChatServer();
		}

		private void LoadDefaultConversation()
		{
			var messages = ChatServer.GetMessages();
			foreach (var message in messages)
				this.chatBox1.DataSource.Add(message);
		}

		// create the current user.
		private void LoadCurrentUser()
		{
			var id = (ChatServer.OnlineUsers.Count + 1).ToString();

			var faker = new Faker();
			this.User = new User(id, $"User {id}", faker.Internet.Avatar());
			this.chatBox1.User = User;
		}

		// load a list of online users.
		private void LoadOnlineUsers()
		{
			foreach (var user in ChatServer.OnlineUsers)
				this.flexLayoutPanelUsers.Controls.Add(new UserChat { User = user });
		}

		// joins the chat server and listens for server events.
		private void JoinChatServer()
		{
			ChatServer.Join(this.User);

			ChatServer.UserJoined += ChatServer_UserJoined;
			ChatServer.UserExited += ChatServer_UserExited;
			ChatServer.DeletedMessage += ChatServer_DeletedMessage;
			ChatServer.IncomingMessage += ChatServer_IncomingMessage;
			Application.ApplicationExit += Application_ApplicationExit;
		}

		private void ChatServer_DeletedMessage(object sender, Message e)
		{
			Application.Update(this, () => {
				if (this.chatBox1.DataSource.Contains(e))
					this.chatBox1.DataSource.Remove(e);
			});
		}

		private void Application_ApplicationExit(object sender, EventArgs e)
		{
			LeaveChatServer();
		}

		private void LeaveChatServer()
		{
			ChatServer.Leave(this.User);

			ChatServer.UserJoined -= ChatServer_UserJoined;
			ChatServer.UserExited -= ChatServer_UserExited;
			ChatServer.DeletedMessage -= ChatServer_DeletedMessage;
			ChatServer.IncomingMessage -= ChatServer_IncomingMessage;
		}

		// remove the user from the users list.
		private void ChatServer_UserExited(object sender, User e)
		{
			Application.Update(this, () =>
			{
				var userControl = this.flexLayoutPanelUsers.Controls.FirstOrDefault(c => ((UserChat)c).User == e);
				if (userControl != null)
					this.flexLayoutPanelUsers.Controls.Remove(userControl);
			});
		}

		// add the new user to the users list.
		private void ChatServer_UserJoined(object sender, User e)
		{
			Application.Update(this, () => {
				if (e == this.User)
					return;
				this.flexLayoutPanelUsers.Controls.Add(new UserChat { User = e });
			});
		}

		private void ChatServer_IncomingMessage(object sender, Message e)
		{
			Application.Update(this, () => {
				if (e.User.Id == this.chatBox1.User.Id)
					return;

				this.chatBox1.DataSource.Add(e);
			});
		}

		private void buttonSettings_ItemClicked(object sender, MenuButtonItemClickedEventArgs e)
		{
			switch (e.Item.Name)
			{
				case "clear":
					this.chatBox1.Clear();
					break;
			}
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

		// show the typing indicator.
		private void chatBox1_TypingStart(object sender, EventArgs e)
		{
			if (this._typingMessage == null)
				this._typingMessage = new Message("", "typing", this.User);

			ChatServer.SendMessage(this._typingMessage);
		}

		// hide the typing indicator to other connected clients.
		private void chatBox1_TypingEnd(object sender, EventArgs e)
		{
			ChatServer.DeleteMessage(this._typingMessage);
		}
		private Message _typingMessage;

		private void buttonExport_Click(object sender, EventArgs e)
		{
			var json = this.chatBox1.ExportAsJson();
			var bytes = Encoding.UTF8.GetBytes(json);
			using (var ms = new MemoryStream(bytes))
				Application.Download(ms, "Conversation.json");
		}

		// add different types of messsages.
		private void chatBox1_ToolClick(object sender, ToolClickEventArgs e)
		{
			AlertBox.Show(e.Tool.Name);
			switch (e.Tool.Name)
			{
				case "upload":
					this.upload1.UploadFiles();
					break;

				case "calendar":
					this.chatBox1.DataSource.Add(new Message(DateTime.Now.ToString(), "date"));
					break;

				case "options":
					this.chatBox1.DataSource.Add(new Message("A/B/C/D/E/F", "options"));
					break;
			}
		}

		// uploads a file to the chatbox.
		private void upload1_Uploaded(object sender, UploadedEventArgs e)
		{
			foreach (var key in e.Files.AllKeys)
			{
				var file = e.Files[key];
				var tempFiles = Application.MapPath("TempFiles");
				var tempPath = Path.Combine(tempFiles, file.FileName);
				if (!Directory.Exists(tempFiles))
					Directory.CreateDirectory(tempFiles);

				using (var fs = new FileStream(Application.MapPath($"TempFiles/{file.FileName}"), FileMode.OpenOrCreate))
				{
					file.InputStream.CopyTo(fs);
				}

				this.chatBox1.DataSource.Add(new Message(tempPath, "file"));
			}
		}

        // posts a message from this session to the chat server to be received by other sessions.
        private void chatBox1_SendMessage(object sender, MessageEventArgs e)
        {
            ChatServer.SendMessage(e.Message);
        }

		// disconnect from the chat server.
		private void ChatWindow_Disposed(object sender, EventArgs e)
		{
			LeaveChatServer();
		}

		// render a control based on the content type of the message.
		private void chatBox1_MessageControlNeeded(object sender, RenderMessageControlEventArgs e)
		{
			var message = e.Message;
			var content = message.Content;
			var type = message.ContentType;

			switch (type) 
			{
				case "date":
					e.Control = new CalendarMessageControl();
					break;

				case "file":
					e.Control = GetFileMessage(content);
					break;

				case "link":
					e.Control = new LinkMessageControl(content, content);
					break;

				case "options":
					var options = content.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
					e.Control = new OptionsMessageControl("Select a City...", options)
					{ 
						DisableOnClick = true 
					};
					break;
			}
		}

		// gets a control that can show a file.
		private Control GetFileMessage(string path)
		{
			using (var fs = new FileStream(path, FileMode.OpenOrCreate))
			{
				return new FileMessageControl(fs, fs.Name);
			}
		}

		// formats a message before it's posted.
		private void chatBox1_FormatMessage(object sender, MessageEventArgs e)
		{
			var message = e.Message;
			var content = message.Content;

			// if the message doesn't have a content type.
			if (string.IsNullOrEmpty(message.ContentType))
			{
				// set it as a link if it starts with http.
				if (!string.IsNullOrEmpty(content) && content.StartsWith("http"))
				{
					message.ContentType = "link";
				}
			}
		}
	}
}
