namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoChat
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoChat));
            this.buttonGetUser = new Wisej.Web.Button();
            this.buttonApplyColor = new Wisej.Web.Button();
            this.colorDialog1 = new Wisej.Web.ColorDialog(this.components);
            this.kendoChat1 = new Wisej.Web.Ext.Kendo.kendoChat();
            this.textBoxMessage = new Wisej.Web.TextBox();
            this.buttonPost = new Wisej.Web.Button();
            this.upload1 = new Wisej.Web.Upload();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoChat1);
            this.panel.Controls.Add(this.upload1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/chat/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/chat";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/conversational-ui/chat/overview";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.textBoxMessage);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonPost);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonApplyColor);
            this.flowLayoutPanelProperties.Controls.Add(this.buttonGetUser);
            // 
            // buttonGetUser
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonGetUser, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonGetUser, true);
            this.buttonGetUser.Location = new System.Drawing.Point(3, 174);
            this.buttonGetUser.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonGetUser.Name = "buttonGetUser";
            this.buttonGetUser.Size = new System.Drawing.Size(212, 35);
            this.buttonGetUser.TabIndex = 1;
            this.buttonGetUser.Text = "Get User";
            // 
            // buttonApplyColor
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonApplyColor, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonApplyColor, true);
            this.buttonApplyColor.Location = new System.Drawing.Point(3, 120);
            this.buttonApplyColor.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.buttonApplyColor.Name = "buttonApplyColor";
            this.buttonApplyColor.Size = new System.Drawing.Size(212, 35);
            this.buttonApplyColor.TabIndex = 2;
            this.buttonApplyColor.Text = "Change Text Color";
            this.buttonApplyColor.Click += new System.EventHandler(this.buttonApplyColor_Click);
            // 
            // kendoChat1
            // 
            this.kendoChat1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.kendoChat1.Location = new System.Drawing.Point(75, 22);
            this.kendoChat1.Name = "kendoChat1";
            this.kendoChat1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"user\":{\"name\":\"Wisej User\",\"iconUrl\":\"Images/Chat/ANATR.jpg\"},\"toolbar\":{\"toggl" +
        "eable\":true,\"buttons\":[{\"name\":\"sendimage\",\"iconClass\":\"k-icon k-i-image\"}]}}")));
            this.kendoChat1.Size = new System.Drawing.Size(939, 513);
            this.kendoChat1.TabIndex = 0;
            this.kendoChat1.Text = "kendoChat1";
            widgetFunction1.Name = "applyColor";
            widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
            this.kendoChat1.WidgetFunctions = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction[] {
        widgetFunction1};
            // 
            // textBoxMessage
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.textBoxMessage, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.textBoxMessage, true);
            this.textBoxMessage.LabelText = "Post a Message";
            this.textBoxMessage.Location = new System.Drawing.Point(3, 3);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(212, 57);
            this.textBoxMessage.TabIndex = 0;
            this.textBoxMessage.Text = "Chicago";
            // 
            // buttonPost
            // 
            this.flowLayoutPanelProperties.SetFillWeight(this.buttonPost, 1);
            this.flowLayoutPanelProperties.SetFlowBreak(this.buttonPost, true);
            this.buttonPost.Location = new System.Drawing.Point(3, 66);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(212, 35);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // upload1
            // 
            this.upload1.AllowedFileTypes = "image/*";
            this.upload1.AllowMultipleFiles = true;
            this.upload1.Location = new System.Drawing.Point(878, 11);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(200, 30);
            this.upload1.TabIndex = 16;
            this.upload1.Text = "Hidden Upload";
            this.upload1.Visible = false;
            this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
            // 
            // kendoChat
            // 
            this.MinimumSize = new System.Drawing.Size(887, 557);
            this.Name = "kendoChat";
            this.Load += new System.EventHandler(this.kendoChat_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoChat kendoChat1;
		private Button buttonGetUser;
        private Button buttonApplyColor;
        private ColorDialog colorDialog1;
        private TextBox textBoxMessage;
        private Button buttonPost;
        private Upload upload1;
    }
}
