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
            Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoChat));
            this.buttonGetUser = new Wisej.Web.Button();
            this.buttonApplyColor = new Wisej.Web.Button();
            this.colorDialog1 = new Wisej.Web.ColorDialog(this.components);
            this.kendoChat1 = new Wisej.Web.Ext.Kendo.kendoChat();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoChat1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonApplyColor);
            this.groupBox1.Controls.Add(this.buttonGetUser);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonGetUser, 0);
            this.groupBox1.Controls.SetChildIndex(this.buttonApplyColor, 0);
            this.groupBox1.Controls.SetChildIndex(this.flowLayoutPanelProperties, 0);
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
            // buttonGetUser
            // 
            this.buttonGetUser.Location = new System.Drawing.Point(28, 166);
            this.buttonGetUser.Name = "buttonGetUser";
            this.buttonGetUser.Size = new System.Drawing.Size(195, 27);
            this.buttonGetUser.TabIndex = 1;
            this.buttonGetUser.Text = "Get User";
            this.buttonGetUser.Click += new System.EventHandler(this.buttonGetUser_Click);
            // 
            // buttonApplyColor
            // 
            this.buttonApplyColor.Location = new System.Drawing.Point(28, 122);
            this.buttonApplyColor.Name = "buttonApplyColor";
            this.buttonApplyColor.Size = new System.Drawing.Size(195, 27);
            this.buttonApplyColor.TabIndex = 2;
            this.buttonApplyColor.Text = "Change Text Color";
            this.buttonApplyColor.Click += new System.EventHandler(this.buttonApplyColor_Click);
            // 
            // kendoChat1
            // 
            this.kendoChat1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.kendoChat1.Location = new System.Drawing.Point(247, 8);
            this.kendoChat1.Name = "kendoChat1";
            this.kendoChat1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"user\":{\"name\":\"Wisej User\",\"iconUrl\":\"Images/Chat/ANATR.jpg\"},\"toolbar\":{\"toggl" +
        "eable\":true,\"buttons\":[{\"name\":\"sendimage\",\"iconClass\":\"k-icon k-i-image\"}]}}")));
            this.kendoChat1.Size = new System.Drawing.Size(595, 542);
            this.kendoChat1.TabIndex = 0;
            this.kendoChat1.Text = "kendoChat1";
            widgetFunction2.Name = "applyColor";
            widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
            this.kendoChat1.WidgetFunctions = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction[] {
        widgetFunction2};
            // 
            // kendoChat
            // 
            this.Name = "kendoChat";
            this.Load += new System.EventHandler(this.kendoChat_Load);
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoChat kendoChat1;
		private Button buttonGetUser;
        private Button buttonApplyColor;
        private ColorDialog colorDialog1;
    }
}
