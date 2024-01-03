using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public class TestBase : UserControl
	{

		public TestBase()
		{
			InitializeComponent();
		}

		protected LinkLabel linkDocs;
		private ImageList imageList1;
		protected GroupBox groupBox1;
		protected Button buttonUpdate;
		protected LinkLabel linkDemo;
		protected LinkLabel linkApi;
		protected Panel panel;
		protected FlowLayoutPanel flowLayoutPanel1;
		protected Spacer spacer1;
		private Button buttonLinks;
		private System.ComponentModel.IContainer components;

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.linkDocs = new Wisej.Web.LinkLabel();
			this.imageList1 = new Wisej.Web.ImageList(this.components);
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
			// linkDocs
			// 
			this.linkDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDocs.ImageList = this.imageList1;
			this.linkDocs.Location = new System.Drawing.Point(51, 7);
			this.linkDocs.Name = "linkDocs";
			this.linkDocs.Size = new System.Drawing.Size(608, 24);
			this.linkDocs.TabIndex = 8;
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/";
			this.linkDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDocs.Visible = false;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
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
			this.flowLayoutPanel1.ScrollBars = Wisej.Web.ScrollBars.Vertical;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 467);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Bottom;
			this.spacer1.Location = new System.Drawing.Point(16, 505);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(218, 16);
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
			this.linkDemo.Location = new System.Drawing.Point(51, 49);
			this.linkDemo.Name = "linkDemo";
			this.linkDemo.Size = new System.Drawing.Size(608, 24);
			this.linkDemo.TabIndex = 10;
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/";
			this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkDemo.Visible = false;
			// 
			// linkApi
			// 
			this.linkApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkApi.ImageList = this.imageList1;
			this.linkApi.Location = new System.Drawing.Point(51, 29);
			this.linkApi.Name = "linkApi";
			this.linkApi.Size = new System.Drawing.Size(608, 24);
			this.linkApi.TabIndex = 9;
			this.linkApi.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Components/";
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
			this.buttonLinks.Location = new System.Drawing.Point(1018, 20);
			this.buttonLinks.Name = "buttonLinks";
			this.buttonLinks.Size = new System.Drawing.Size(230, 58);
			this.buttonLinks.TabIndex = 13;
			this.buttonLinks.MouseClick += new Wisej.Web.MouseEventHandler(this.buttonLinks_MouseClick);
			// 
			// TestBase
			// 
			this.Controls.Add(this.buttonLinks);
			this.Controls.Add(this.linkDocs);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkDemo);
			this.Controls.Add(this.linkApi);
			this.Controls.Add(this.panel);
			this.Name = "TestBase";
			this.Size = new System.Drawing.Size(1299, 699);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void buttonLinks_MouseClick(object sender, MouseEventArgs e)
		{
			var width = this.buttonLinks.Width;
			if (e.X <= width * (1F / 4F))
				Application.Navigate(GetSourceUrl(), "DevExtreme");

			else if (e.X <= width * (2F / 4F))
				Application.Navigate(this.linkApi.Text, "DevExtreme");

			else if (e.X <= width * (3F / 4F))
				Application.Navigate(this.linkDocs.Text, "DevExtreme");

			else
				Application.Navigate(this.linkDemo.Text, "DevExtreme");
		}

		// gets a link to the github source code for the current demo.
		private string GetSourceUrl()
		{
			var baseUrl = $"https://github.com/iceteagroup/wisej-demobrowser/tree/main/Wisej.DemoBrowser.Premium/Wisej.Web.Ext.DevExtreme.Demo/Component";
			var name = this.GetType().Name;

			return $"{baseUrl}/{name}";
		}
	}
}