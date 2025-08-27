using System;
using System.IO;
using System.Linq;
using System.Text;
using Bogus;
using Wisej.DemoBrowser.ChatControl.Controls;
using Wisej.DemoBrowser.ChatControl.Windows;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	public class Features : DemoView
	{
		#region Constructors

		public Features()
		{
			InitializeComponent();
		}

		#endregion

		#region Designer

		private Web.Panel panel1;
		private Web.Button buttonExport;
		private Web.Panel panel2;
		private Web.FlexLayoutPanel flexLayoutPanelUsers;
		private Web.Label label1;
		private Web.Ext.ChatControl.ChatBox chatBox1;
		private Web.Upload upload1;

		private void InitializeComponent()
		{
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
			this.panel1 = new Wisej.Web.Panel();
			this.buttonExport = new Wisej.Web.Button();
			this.panel2 = new Wisej.Web.Panel();
			this.flexLayoutPanelUsers = new Wisej.Web.FlexLayoutPanel();
			this.label1 = new Wisej.Web.Label();
			this.chatBox1 = new Wisej.Web.Ext.ChatControl.ChatBox();
			this.upload1 = new Wisej.Web.Upload();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromName("@window");
			this.panel1.Controls.Add(this.buttonExport);
			this.panel1.CssStyle = "border-radius: 0px;";
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(50, 474);
			this.panel1.TabIndex = 5;
			// 
			// buttonExport
			// 
			this.buttonExport.BackColor = System.Drawing.Color.FromName("@window");
			this.buttonExport.Dock = Wisej.Web.DockStyle.Top;
			this.buttonExport.Focusable = false;
			this.buttonExport.ImageSource = "file-zip";
			this.buttonExport.Location = new System.Drawing.Point(0, 0);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.buttonExport.Size = new System.Drawing.Size(50, 39);
			this.buttonExport.TabIndex = 2;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.panel2.Controls.Add(this.flexLayoutPanelUsers);
			this.panel2.Controls.Add(this.label1);
			this.panel2.CssStyle = "border-radius: 0px;";
			this.panel2.Dock = Wisej.Web.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(50, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new Wisej.Web.Padding(16);
			this.panel2.Size = new System.Drawing.Size(298, 474);
			this.panel2.TabIndex = 6;
			// 
			// flexLayoutPanelUsers
			// 
			this.flexLayoutPanelUsers.AutoScroll = true;
			this.flexLayoutPanelUsers.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flexLayoutPanelUsers.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanelUsers.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanelUsers.Location = new System.Drawing.Point(16, 53);
			this.flexLayoutPanelUsers.Name = "flexLayoutPanelUsers";
			this.flexLayoutPanelUsers.Size = new System.Drawing.Size(266, 405);
			this.flexLayoutPanelUsers.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(266, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Active Users";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chatBox1
			// 
			this.chatBox1.CssStyle = "border-radius: 0px;";
			this.chatBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.chatBox1.Location = new System.Drawing.Point(348, 0);
			this.chatBox1.Name = "chatBox1";
			this.chatBox1.Size = new System.Drawing.Size(1074, 474);
			this.chatBox1.TabIndex = 4;
			componentTool1.ImageSource = "icon-upload";
			componentTool1.Name = "upload";
			componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool2.ImageSource = "icon-calendar";
			componentTool2.Name = "calendar";
			componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool3.ImageSource = "menu-overflow";
			componentTool3.Name = "options";
			componentTool3.Position = Wisej.Web.LeftRightAlignment.Left;
			this.chatBox1.Tools.AddRange(new Wisej.Web.ComponentTool[]
			{
				componentTool1,
				componentTool2,
				componentTool3
			});
			this.chatBox1.TypingStart += new System.EventHandler(this.chatBox1_TypingStart);
			this.chatBox1.TypingEnd += new System.EventHandler(this.chatBox1_TypingEnd);
			this.chatBox1.MessageActionInvoke += new System.EventHandler<object>(this.chatBox1_MessageActionInvoke);
			this.chatBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.chatBox1_ToolClick);
			this.chatBox1.FormatMessage += new Wisej.Web.Ext.ChatControl.FormatMessageEventHandler(this.chatBox1_FormatMessage);
			this.chatBox1.Disposed += new System.EventHandler(this.ChatWindow_Disposed);
			this.chatBox1.RenderMessageControl += new RenderMessageControlEventHandler(this.chatBox1_MessageControlNeeded);
			// 
			// upload1
			// 
			this.upload1.AllowMultipleFiles = true;
			this.upload1.Location = new System.Drawing.Point(540, 335);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(200, 30);
			this.upload1.TabIndex = 7;
			this.upload1.Text = "upload1";
			this.upload1.Visible = false;
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
			// 
			// Features
			// 
			this.Controls.Add(this.chatBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.upload1);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.Features_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		#endregion

		#region Properties

		public User User { get; set; }

		#endregion

		#region Methods

		private void Features_Load(object sender, EventArgs e)
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

			this.chatBox1.SentMessage += new Wisej.Web.Ext.ChatControl.MessageEventHandler(this.chatBox1_SendMessage);
		}

		private void ChatServer_DeletedMessage(object sender, Message e)
		{
			Application.Update(this, () =>
			{
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
			Application.Update(this, () =>
			{
				if (e == this.User)
					return;
				this.flexLayoutPanelUsers.Controls.Add(new UserChat { User = e });
			});
		}

		private void ChatServer_IncomingMessage(object sender, Message e)
		{
			Application.Update(this, () =>
			{
				if (e.User.Id == this.chatBox1.User.Id)
					return;

				if (e.ContentType != "typing")
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
				var tempPath = Application.MapPath($"TempFiles/{file.FileName}");
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
			//ChatServer.SendMessage(e.Message);
		}

		// disconnect from the chat server.
		private void ChatWindow_Disposed(object sender, EventArgs e)
		{
			LeaveChatServer();
		}

		// render a control based on the content type of the message.
		private void chatBox1_MessageControlNeeded(RenderMessageControlEventArgs e)
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

				default:
					e.Control = new Wisej.Web.Ext.ChatControl.AutoSizeLabel()
					{
						Text = content
					};
					break;
			}

			message.Control = e.Control;
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
		private void chatBox1_FormatMessage(MessageEventArgs e)
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

		#endregion
	}
}
