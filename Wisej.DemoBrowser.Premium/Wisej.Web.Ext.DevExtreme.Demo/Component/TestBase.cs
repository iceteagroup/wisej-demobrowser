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
        private Spacer spacer1;
        private Button buttonBuy;
        private Line lineMenuDivider3;
        private Button buttonFreeTrial;
        private Button buttonContact;
        private Line lineMenuDivider2;
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
            this.buttonBuy = new Wisej.Web.Button();
            this.lineMenuDivider3 = new Wisej.Web.Line();
            this.buttonFreeTrial = new Wisej.Web.Button();
            this.buttonContact = new Wisej.Web.Button();
            this.lineMenuDivider2 = new Wisej.Web.Line();
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
            this.panel.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.panel.Location = new System.Drawing.Point(358, 86);
            this.panel.Name = "panel";
            this.panel.Padding = new Wisej.Web.Padding(8);
            this.panel.Size = new System.Drawing.Size(890, 578);
            this.panel.TabIndex = 12;
            this.panel.TabStop = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonBuy.AppearanceKey = "button-menu-demo";
            this.buttonBuy.Cursor = Wisej.Web.Cursors.Hand;
            this.buttonBuy.Focusable = false;
            this.buttonBuy.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonBuy.ImageSource = "Images\\Icon Buy.png";
            this.buttonBuy.Location = new System.Drawing.Point(1117, 16);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(131, 57);
            this.buttonBuy.TabIndex = 19;
            this.buttonBuy.Text = "Demo";
            this.buttonBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineMenuDivider3
            // 
            this.lineMenuDivider3.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lineMenuDivider3.Location = new System.Drawing.Point(1105, 7);
            this.lineMenuDivider3.Name = "lineMenuDivider3";
            this.lineMenuDivider3.Orientation = Wisej.Web.Orientation.Vertical;
            this.lineMenuDivider3.Padding = new Wisej.Web.Padding(0, 15, 0, 15);
            this.lineMenuDivider3.Size = new System.Drawing.Size(5, 74);
            // 
            // buttonFreeTrial
            // 
            this.buttonFreeTrial.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonFreeTrial.AppearanceKey = "button-menu-demo";
            this.buttonFreeTrial.Cursor = Wisej.Web.Cursors.Hand;
            this.buttonFreeTrial.Focusable = false;
            this.buttonFreeTrial.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonFreeTrial.ImageSource = "Images\\Icon Free Trial.png";
            this.buttonFreeTrial.Location = new System.Drawing.Point(959, 16);
            this.buttonFreeTrial.Name = "buttonFreeTrial";
            this.buttonFreeTrial.Size = new System.Drawing.Size(140, 57);
            this.buttonFreeTrial.TabIndex = 18;
            this.buttonFreeTrial.Text = "API";
            this.buttonFreeTrial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonContact
            // 
            this.buttonContact.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.buttonContact.AppearanceKey = "button-menu-demo";
            this.buttonContact.Cursor = Wisej.Web.Cursors.Hand;
            this.buttonContact.Focusable = false;
            this.buttonContact.Font = new System.Drawing.Font("@menuDemo", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buttonContact.ImageSource = "Images\\Icon Contact.png";
            this.buttonContact.Location = new System.Drawing.Point(799, 16);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(135, 57);
            this.buttonContact.TabIndex = 17;
            this.buttonContact.Text = "Docs";
            this.buttonContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineMenuDivider2
            // 
            this.lineMenuDivider2.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.lineMenuDivider2.Location = new System.Drawing.Point(938, 7);
            this.lineMenuDivider2.Name = "lineMenuDivider2";
            this.lineMenuDivider2.Orientation = Wisej.Web.Orientation.Vertical;
            this.lineMenuDivider2.Padding = new Wisej.Web.Padding(0, 15, 0, 15);
            this.lineMenuDivider2.Size = new System.Drawing.Size(5, 74);
            // 
            // TestBase
            // 
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.lineMenuDivider3);
            this.Controls.Add(this.buttonFreeTrial);
            this.Controls.Add(this.buttonContact);
            this.Controls.Add(this.lineMenuDivider2);
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

		private void buttonDemo_Click(object sender, EventArgs e)
		{
			Application.Navigate(this.linkDemo.Text, "DevExtreme");
		}

        private void buttonDocs_Click(object sender, EventArgs e)
        {
            Application.Navigate(this.linkDocs.Text, "DevExtreme");
        }

        private void buttonApi_Click(object sender, EventArgs e)
        {
            Application.Navigate(this.linkApi.Text, "DevExtreme");
        }
    }
}