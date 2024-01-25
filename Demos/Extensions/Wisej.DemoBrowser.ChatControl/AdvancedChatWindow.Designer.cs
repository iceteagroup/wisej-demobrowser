using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	partial class AdvancedChatWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool3 = new Wisej.Web.ComponentTool();
			this.panel1 = new Wisej.Web.Panel();
			this.buttonExport = new Wisej.Web.Button();
			this.buttonSettings = new Wisej.Web.Button();
			this.clear = new Wisej.Web.MenuItem();
			this.leftColor = new Wisej.Web.MenuItem();
			this.rightColor = new Wisej.Web.MenuItem();
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
			this.panel1.Controls.Add(this.buttonSettings);
			this.panel1.CssStyle = "border-radius: 0px;";
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(50, 551);
			this.panel1.TabIndex = 1;
			// 
			// buttonExport
			// 
			this.buttonExport.BackColor = System.Drawing.Color.FromName("@window");
			this.buttonExport.Dock = Wisej.Web.DockStyle.Top;
			this.buttonExport.Focusable = false;
			this.buttonExport.ImageSource = "file-zip";
			this.buttonExport.Location = new System.Drawing.Point(0, 37);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.buttonExport.Size = new System.Drawing.Size(50, 39);
			this.buttonExport.TabIndex = 2;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			// 
			// buttonSettings
			// 
			this.buttonSettings.BackColor = System.Drawing.Color.FromName("@window");
			this.buttonSettings.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSettings.Focusable = false;
			this.buttonSettings.ImageSource = "icon-settings";
			this.buttonSettings.Location = new System.Drawing.Point(0, 0);
			this.buttonSettings.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.clear,
            this.leftColor,
            this.rightColor});
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.buttonSettings.Size = new System.Drawing.Size(50, 37);
			this.buttonSettings.TabIndex = 0;
			this.buttonSettings.ItemClicked += new Wisej.Web.MenuButtonItemClickedEventHandler(this.buttonSettings_ItemClicked);
			// 
			// clear
			// 
			this.clear.Index = 0;
			this.clear.Name = "clear";
			this.clear.Text = "Clear";
			// 
			// leftColor
			// 
			this.leftColor.Index = 1;
			this.leftColor.Name = "leftColor";
			this.leftColor.Text = "Left Bubble Color";
			// 
			// rightColor
			// 
			this.rightColor.Index = 2;
			this.rightColor.Name = "rightColor";
			this.rightColor.Text = "Right Bubble Color";
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
			this.panel2.Size = new System.Drawing.Size(298, 551);
			this.panel2.TabIndex = 2;
			// 
			// flexLayoutPanelUsers
			// 
			this.flexLayoutPanelUsers.AutoScroll = true;
			this.flexLayoutPanelUsers.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flexLayoutPanelUsers.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanelUsers.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanelUsers.Location = new System.Drawing.Point(16, 53);
			this.flexLayoutPanelUsers.Name = "flexLayoutPanelUsers";
			this.flexLayoutPanelUsers.Size = new System.Drawing.Size(266, 482);
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
			this.chatBox1.Size = new System.Drawing.Size(750, 551);
			this.chatBox1.TabIndex = 0;
			componentTool1.ImageSource = "icon-upload";
			componentTool1.Name = "upload";
			componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool2.ImageSource = "icon-calendar";
			componentTool2.Name = "calendar";
			componentTool2.Position = Wisej.Web.LeftRightAlignment.Left;
			componentTool3.ImageSource = "menu-overflow";
			componentTool3.Name = "options";
			componentTool3.Position = Wisej.Web.LeftRightAlignment.Left;
			this.chatBox1.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1,
            componentTool2,
            componentTool3});
			this.chatBox1.SendMessage += new SendMessageEventHandler(this.chatBox1_SendMessage);
			this.chatBox1.TypingStart += new System.EventHandler(this.chatBox1_TypingStart);
			this.chatBox1.TypingEnd += new System.EventHandler(this.chatBox1_TypingEnd);
			this.chatBox1.MessageActionInvoke += new System.EventHandler<object>(this.chatBox1_MessageActionInvoke);
			this.chatBox1.ToolClick += new Wisej.Web.ToolClickEventHandler(this.chatBox1_ToolClick);
			this.chatBox1.RenderMessageContent += new Wisej.Web.Ext.ChatControl.RenderMessageContentEventHandler(this.chatBox1_MessageControlNeeded);
			this.chatBox1.FormatMessage += new Wisej.Web.Ext.ChatControl.FormatMessageEventHandler(this.chatBox1_FormatMessage);
			// 
			// upload1
			// 
			this.upload1.AllowMultipleFiles = true;
			this.upload1.Location = new System.Drawing.Point(540, 335);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(200, 30);
			this.upload1.TabIndex = 3;
			this.upload1.Text = "upload1";
			this.upload1.Visible = false;
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
			// 
			// AdvancedChatWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 551);
			this.Controls.Add(this.chatBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.upload1);
			this.Name = "AdvancedChatWindow";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Wisej.NET Advanced Chat";
			this.Load += new System.EventHandler(this.ChatWindow_Load);
			this.Disposed += new System.EventHandler(this.ChatWindow_Disposed);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private ChatBox chatBox1;
		private Panel panel1;
		private Button buttonSettings;
		private Panel panel2;
		private Label label1;
		private MenuItem leftColor;
		private MenuItem rightColor;
		private MenuItem clear;
		private Button buttonExport;
		private Upload upload1;
		private FlexLayoutPanel flexLayoutPanelUsers;
	}
}