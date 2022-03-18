namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Chat
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
			this.chat1 = new Wisej.Web.Ext.Webix.Chat();
			this.SuspendLayout();
			// 
			// flowLayoutPanelExamples
			// 
			this.flowLayoutPanelExamples.Enabled = false;
			// 
			// chat1
			// 
			this.chat1.Dock = Wisej.Web.DockStyle.Fill;
			this.chat1.Enabled = false;
			this.chat1.Location = new System.Drawing.Point(42, 0);
			this.chat1.Name = "chat1";
			this.chat1.Size = new System.Drawing.Size(1488, 477);
			this.chat1.TabIndex = 11;
			this.chat1.Text = "chat1";
			this.chat1.WebRequest += new Wisej.Web.WebRequestHandler(this.chat1_WebRequest);
			// 
			// Chat
			// 
			this.Controls.Add(this.chat1);
			this.Name = "Chat";
			this.Load += new System.EventHandler(this.Chat_Load);
			this.Controls.SetChildIndex(this.flowLayoutPanelExamples, 0);
			this.Controls.SetChildIndex(this.chat1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.Chat chat1;
	}
}
