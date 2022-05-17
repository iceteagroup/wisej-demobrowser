namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ViewBase
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
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.linkDocs = new Wisej.Web.LinkLabel();
            this.imageList2 = new Wisej.Web.ImageList(this.components);
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.spacer1 = new Wisej.Web.Spacer();
            this.buttonUpdate = new Wisej.Web.Button();
            this.linkDemo = new Wisej.Web.LinkLabel();
            this.linkApi = new Wisej.Web.LinkLabel();
            this.panel = new Wisej.Web.Panel();
            this.buttonLinks = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
            // 
            // linkDocs
            // 
            this.linkDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.ImageList = this.imageList2;
            this.linkDocs.Location = new System.Drawing.Point(51, 7);
            this.linkDocs.Name = "linkDocs";
            this.linkDocs.Size = new System.Drawing.Size(818, 24);
            this.linkDocs.TabIndex = 8;
            this.linkDocs.Text = "https://docs.webix.com/";
            this.linkDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.Visible = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageSize = new System.Drawing.Size(32, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.spacer1);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(51, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Wisej.Web.Padding(16);
            this.groupBox1.Size = new System.Drawing.Size(250, 589);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.Text = "Properties";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 463);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // spacer1
            // 
            this.spacer1.Dock = Wisej.Web.DockStyle.Bottom;
            this.spacer1.Location = new System.Drawing.Point(16, 501);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(218, 20);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = Wisej.Web.DockStyle.Bottom;
            this.buttonUpdate.Location = new System.Drawing.Point(16, 521);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(218, 52);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            // 
            // linkDemo
            // 
            this.linkDemo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.ImageList = this.imageList2;
            this.linkDemo.Location = new System.Drawing.Point(51, 51);
            this.linkDemo.Name = "linkDemo";
            this.linkDemo.Size = new System.Drawing.Size(818, 24);
            this.linkDemo.TabIndex = 10;
            this.linkDemo.Text = "https://webix.com/demos/";
            this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.Visible = false;
            // 
            // linkApi
            // 
            this.linkApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkApi.ImageList = this.imageList2;
            this.linkApi.Location = new System.Drawing.Point(51, 29);
            this.linkApi.Name = "linkApi";
            this.linkApi.Size = new System.Drawing.Size(818, 24);
            this.linkApi.TabIndex = 9;
            this.linkApi.Text = "https://docs.webix.com/api__toc__ui.html";
            this.linkApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkApi.Visible = false;
            // 
            // panel
            // 
            this.panel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel.Location = new System.Drawing.Point(358, 86);
            this.panel.Name = "panel";
            this.panel.Padding = new Wisej.Web.Padding(8);
            this.panel.Size = new System.Drawing.Size(890, 578);
            this.panel.TabIndex = 12;
            this.panel.TabStop = true;
            // 
            // buttonLinks
            // 
            this.buttonLinks.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonLinks.BackgroundImageSource = "Images/icons-panel.png";
            this.buttonLinks.Focusable = false;
            this.buttonLinks.Location = new System.Drawing.Point(1072, 22);
            this.buttonLinks.Name = "buttonLinks";
            this.buttonLinks.Size = new System.Drawing.Size(176, 58);
            this.buttonLinks.TabIndex = 18;
            this.buttonLinks.MouseClick += new Wisej.Web.MouseEventHandler(this.buttonLinks_MouseClick);
            // 
            // ViewBase
            // 
            this.Controls.Add(this.buttonLinks);
            this.Controls.Add(this.linkDocs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkDemo);
            this.Controls.Add(this.linkApi);
            this.Controls.Add(this.panel);
            this.Name = "ViewBase";
            this.Size = new System.Drawing.Size(1299, 699);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private ImageList imageList1;
        protected LinkLabel linkDocs;
        private ImageList imageList2;
        protected GroupBox groupBox1;
        protected Button buttonUpdate;
        protected LinkLabel linkDemo;
        protected LinkLabel linkApi;
        protected Panel panel;
        protected FlowLayoutPanel flowLayoutPanel1;
        private Spacer spacer1;
        private Button buttonLinks;
    }
}
