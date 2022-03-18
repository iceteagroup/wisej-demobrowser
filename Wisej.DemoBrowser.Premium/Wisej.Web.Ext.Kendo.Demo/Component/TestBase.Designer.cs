namespace Wisej.Web.Ext.Kendo.Demo.Component
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
            this.label3 = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.panel = new Wisej.Web.Panel();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.buttonUpdate = new Wisej.Web.Button();
            this.linkDemo = new Wisej.Web.LinkLabel();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.linkAPI = new Wisej.Web.LinkLabel();
            this.linkDocs = new Wisej.Web.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "DEMO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "API:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 36);
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
            this.panel.Location = new System.Drawing.Point(358, 158);
            this.panel.Name = "panel";
            this.panel.Padding = new Wisej.Web.Padding(8);
            this.panel.Size = new System.Drawing.Size(1091, 560);
            this.panel.TabIndex = 12;
            this.panel.TabStop = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Location = new System.Drawing.Point(51, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 315);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.Text = "Properties";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(28, 234);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(195, 52);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            // 
            // linkDemo
            // 
            this.linkDemo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.ImageList = this.imageList1;
            this.linkDemo.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
            this.linkDemo.Location = new System.Drawing.Point(109, 92);
            this.linkDemo.Name = "linkDemo";
            this.linkDemo.Size = new System.Drawing.Size(704, 24);
            this.linkDemo.TabIndex = 10;
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/";
            this.linkDemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDemo.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(32, 16);
            // 
            // linkAPI
            // 
            this.linkAPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkAPI.ImageList = this.imageList1;
            this.linkAPI.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
            this.linkAPI.Location = new System.Drawing.Point(109, 62);
            this.linkAPI.Name = "linkAPI";
            this.linkAPI.Size = new System.Drawing.Size(704, 24);
            this.linkAPI.TabIndex = 9;
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/kendo";
            this.linkAPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkAPI.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
            // 
            // linkDocs
            // 
            this.linkDocs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.ImageList = this.imageList1;
            this.linkDocs.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/link-button.svg";
            this.linkDocs.Location = new System.Drawing.Point(109, 32);
            this.linkDocs.Name = "linkDocs";
            this.linkDocs.Size = new System.Drawing.Size(704, 24);
            this.linkDocs.TabIndex = 8;
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/introduction";
            this.linkDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkDocs.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkDocs_LinkClicked);
            // 
            // TestBase
            // 
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkDemo);
            this.Controls.Add(this.linkAPI);
            this.Controls.Add(this.linkDocs);
            this.Name = "TestBase";
            this.Size = new System.Drawing.Size(1500, 750);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Label label3;
		private Label label2;
		private Label label1;
		protected Panel panel;
		protected GroupBox groupBox1;
		protected Button buttonUpdate;
		protected LinkLabel linkDemo;
		protected LinkLabel linkAPI;
		protected LinkLabel linkDocs;
		private ImageList imageList1;
	}
}
