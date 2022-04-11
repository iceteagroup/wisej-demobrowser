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
        protected LinkLabel linkAPI;
        private Label label3;
        private Label label2;
        private Label label1;
        protected Panel panel;
        protected FlowLayoutPanel flowLayoutPanel1;
        private Spacer spacer1;
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
            this.linkAPI = new Wisej.Web.LinkLabel();
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.panel = new Wisej.Web.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.ImageList = this.imageList1;
            this.linkDocs.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
            this.linkDocs.Location = new System.Drawing.Point(109, 25);
            this.linkDocs.Name = "linkDocs";
            this.linkDocs.Size = new System.Drawing.Size(704, 24);
            this.linkDocs.TabIndex = 8;
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/";
            this.linkDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.spacer1);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(51, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Wisej.Web.Padding(16);
            this.groupBox1.Size = new System.Drawing.Size(250, 560);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.Text = "Properties";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 438);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // spacer1
            // 
            this.spacer1.Dock = Wisej.Web.DockStyle.Bottom;
            this.spacer1.Location = new System.Drawing.Point(16, 476);
            this.spacer1.Name = "spacer1";
            this.spacer1.Size = new System.Drawing.Size(218, 16);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = Wisej.Web.DockStyle.Bottom;
            this.buttonUpdate.Location = new System.Drawing.Point(16, 492);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(218, 52);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            // 
            // linkDemo
            // 
            this.linkDemo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.ImageList = this.imageList1;
            this.linkDemo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
            this.linkDemo.Location = new System.Drawing.Point(109, 85);
            this.linkDemo.Name = "linkDemo";
            this.linkDemo.Size = new System.Drawing.Size(704, 24);
            this.linkDemo.TabIndex = 10;
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/";
            this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
            // 
            // linkAPI
            // 
            this.linkAPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkAPI.ImageList = this.imageList1;
            this.linkAPI.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
            this.linkAPI.Location = new System.Drawing.Point(109, 55);
            this.linkAPI.Name = "linkAPI";
            this.linkAPI.Size = new System.Drawing.Size(704, 24);
            this.linkAPI.TabIndex = 9;
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Components/";
            this.linkAPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkAPI.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "DEMO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "API:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "DOCS:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            this.panel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel.Location = new System.Drawing.Point(358, 166);
            this.panel.Name = "panel";
            this.panel.Padding = new Wisej.Web.Padding(8);
            this.panel.Size = new System.Drawing.Size(1091, 560);
            this.panel.TabIndex = 12;
            this.panel.TabStop = true;
            // 
            // TestBase
            // 
            this.Controls.Add(this.linkDocs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkDemo);
            this.Controls.Add(this.linkAPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Name = "TestBase";
            this.Size = new System.Drawing.Size(1500, 750);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void linkDocs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Navigate(e.Link, "DevExtreme");
		}
	}
}