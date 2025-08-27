﻿namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class TestBase
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
            this.panel = new Wisej.Web.Panel();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.flowLayoutPanelProperties = new Wisej.Web.FlowLayoutPanel();
            this.spacer1 = new Wisej.Web.Spacer();
            this.buttonUpdate = new Wisej.Web.Button();
            this.linkDemo = new Wisej.Web.LinkLabel();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.linkApi = new Wisej.Web.LinkLabel();
            this.linkDocs = new Wisej.Web.LinkLabel();
            this.buttonLinks = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanelProperties);
            this.groupBox1.Controls.Add(this.spacer1);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(51, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Wisej.Web.Padding(16);
            this.groupBox1.Size = new System.Drawing.Size(250, 589);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.Text = "Properties";
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.AutoScroll = true;
            this.flowLayoutPanelProperties.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanelProperties.Name = "flowLayoutPanelProperties";
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(218, 463);
            this.flowLayoutPanelProperties.TabIndex = 1;
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
            this.linkDemo.ImageList = this.imageList1;
            this.linkDemo.Location = new System.Drawing.Point(51, 51);
            this.linkDemo.Name = "linkDemo";
            this.linkDemo.Size = new System.Drawing.Size(818, 24);
            this.linkDemo.TabIndex = 10;
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/";
            this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
            // 
            // linkApi
            // 
            this.linkApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkApi.ImageList = this.imageList1;
            this.linkApi.Location = new System.Drawing.Point(51, 29);
            this.linkApi.Name = "linkApi";
            this.linkApi.Size = new System.Drawing.Size(818, 24);
            this.linkApi.TabIndex = 9;
            this.linkApi.Text = "https://docs.telerik.com/kendo-ui/api/javascript/kendo";
            this.linkApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkApi.Visible = false;
            // 
            // linkDocs
            // 
            this.linkDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.ImageList = this.imageList1;
            this.linkDocs.Location = new System.Drawing.Point(51, 7);
            this.linkDocs.Name = "linkDocs";
            this.linkDocs.Size = new System.Drawing.Size(818, 24);
            this.linkDocs.TabIndex = 8;
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/introduction";
            this.linkDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.Visible = false;
            // 
            // buttonLinks
            // 
            this.buttonLinks.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonLinks.BackgroundImageSource = "Images/icons-panel.png";
            this.buttonLinks.Focusable = false;
            this.buttonLinks.Location = new System.Drawing.Point(1072, 20);
            this.buttonLinks.Name = "buttonLinks";
            this.buttonLinks.Size = new System.Drawing.Size(176, 58);
            this.buttonLinks.TabIndex = 15;
            this.buttonLinks.MouseClick += new Wisej.Web.MouseEventHandler(this.buttonLinks_MouseClick);
            // 
            // TestBase
            // 
            this.Controls.Add(this.buttonLinks);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkDemo);
            this.Controls.Add(this.linkApi);
            this.Controls.Add(this.linkDocs);
            this.Name = "TestBase";
            this.Size = new System.Drawing.Size(1299, 699);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		protected Panel panel;
		protected GroupBox groupBox1;
		protected Button buttonUpdate;
		protected LinkLabel linkDemo;
		protected LinkLabel linkApi;
		protected LinkLabel linkDocs;
		private ImageList imageList1;
        public FlowLayoutPanel flowLayoutPanelProperties;
        private Button buttonLinks;
        protected Spacer spacer1;
    }
}
