﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
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
        protected FlowLayoutPanel flowLayoutPanelProperties;
        protected Spacer spacer1;
        private Button buttonLinks;
        private System.ComponentModel.IContainer components;

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.linkDocs = new Wisej.Web.LinkLabel();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.flowLayoutPanelProperties = new Wisej.Web.FlowLayoutPanel();
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
            this.linkDocs.Size = new System.Drawing.Size(818, 24);
            this.linkDocs.TabIndex = 8;
            this.linkDocs.Text = "https://help.syncfusion.com/js/overview";
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
            this.linkDemo.Text = "https://js.syncfusion.com/demos/jquery/";
            this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.Visible = false;
            // 
            // linkApi
            // 
            this.linkApi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkApi.ImageList = this.imageList1;
            this.linkApi.Location = new System.Drawing.Point(51, 29);
            this.linkApi.Name = "linkApi";
            this.linkApi.Size = new System.Drawing.Size(818, 24);
            this.linkApi.TabIndex = 9;
            this.linkApi.Text = "https://help.syncfusion.com/api/js";
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
            this.buttonLinks.Location = new System.Drawing.Point(1072, 20);
            this.buttonLinks.Name = "buttonLinks";
            this.buttonLinks.Size = new System.Drawing.Size(176, 58);
            this.buttonLinks.TabIndex = 16;
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

		private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Navigate(e.Link, "Syncfusion");
		}

        private void buttonLinks_MouseClick(object sender, MouseEventArgs e)
        {
            var width = this.buttonLinks.Width;
            if (e.X <= width * (1F / 3F))
                Application.Navigate(this.linkApi.Text, "DevExtreme");
            else if (e.X <= width * (2F / 3F))
                Application.Navigate(this.linkDocs.Text, "DevExtreme");
            else
                Application.Navigate(this.linkDemo.Text, "DevExtreme");
        }
    }
}