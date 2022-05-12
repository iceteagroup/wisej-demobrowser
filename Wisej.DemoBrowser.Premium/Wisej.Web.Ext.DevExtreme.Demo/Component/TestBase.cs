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
        protected Panel panel;
        protected FlowLayoutPanel flowLayoutPanel1;
        private Spacer spacer1;
		protected Button button1;
		protected Button button2;
		protected Button button3;
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
			this.panel = new Wisej.Web.Panel();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.button3 = new Wisej.Web.Button();
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
			// linkAPI
			// 
			this.linkAPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkAPI.ImageList = this.imageList1;
			this.linkAPI.Location = new System.Drawing.Point(51, 29);
			this.linkAPI.Name = "linkAPI";
			this.linkAPI.Size = new System.Drawing.Size(608, 24);
			this.linkAPI.TabIndex = 9;
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Components/";
			this.linkAPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkAPI.Visible = false;
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
			// button1
			// 
			this.button1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(1175, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(73, 54);
			this.button1.TabIndex = 4;
			this.button1.Text = "Update";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(1096, 13);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(73, 54);
			this.button2.TabIndex = 13;
			this.button2.Text = "Update";
			// 
			// button3
			// 
			this.button3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.button3.Location = new System.Drawing.Point(1017, 13);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(73, 54);
			this.button3.TabIndex = 14;
			this.button3.Text = "Update";
			// 
			// TestBase
			// 
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.linkDocs);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkDemo);
			this.Controls.Add(this.linkAPI);
			this.Controls.Add(this.panel);
			this.Name = "TestBase";
			this.Size = new System.Drawing.Size(1299, 699);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Navigate(this.linkDocs.Text, "DevExtreme");
		}
	}
}