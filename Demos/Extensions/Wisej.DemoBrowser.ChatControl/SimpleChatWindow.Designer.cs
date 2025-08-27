using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl
{
	partial class SimpleChatWindow
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
			this.chatBox1 = new Wisej.Web.Ext.ChatControl.ChatBox();
			this.upload1 = new Wisej.Web.Upload();
			this.SuspendLayout();
			// 
			// chatBox1
			// 
			this.chatBox1.CssStyle = "border-radius: 0px;";
			this.chatBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.chatBox1.Name = "chatBox1";
			this.chatBox1.Size = new System.Drawing.Size(1098, 551);
			this.chatBox1.TabIndex = 0;
			this.chatBox1.MessageActionInvoke += new System.EventHandler<object>(this.chatBox1_MessageActionInvoke);
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
			// 
			// SimpleChatWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 551);
			this.Controls.Add(this.chatBox1);
			this.Controls.Add(this.upload1);
			this.Name = "SimpleChatWindow";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Wisej.NET Simple Chat";
			this.WindowState = Wisej.Web.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ChatWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ChatBox chatBox1;
		private Upload upload1;
	}
}