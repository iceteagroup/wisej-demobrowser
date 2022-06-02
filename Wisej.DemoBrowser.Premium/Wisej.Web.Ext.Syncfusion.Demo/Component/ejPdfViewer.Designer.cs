namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejPdfViewer
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
			this.ejPdfViewer1 = new Wisej.Web.Ext.Syncfusion.ejPdfViewer();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.label4 = new Wisej.Web.Label();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.buttonLoad = new Wisej.Web.Upload();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.checkBox4 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.flowLayoutPanelProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "https://help.syncfusion.com/js/pdfviewer/overview";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.TabIndex = 6;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/pdf/GettingStarted";
			// 
			// linkApi
			// 
			this.linkApi.TabIndex = 5;
			this.linkApi.Text = "https://help.syncfusion.com/api/js/ejpdfviewer";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.ejPdfViewer1);
			this.panel.TabIndex = 7;
			// 
			// flowLayoutPanelProperties
			// 
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox1);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox2);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox3);
			this.flowLayoutPanelProperties.Controls.Add(this.checkBox4);
			this.flowLayoutPanelProperties.Controls.Add(this.flexLayoutPanel1);
			this.flowLayoutPanelProperties.Controls.Add(this.buttonLoad);
			// 
			// ejPdfViewer1
			// 
			this.ejPdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
			this.ejPdfViewer1.Location = new System.Drawing.Point(8, 8);
			this.ejPdfViewer1.Name = "ejPdfViewer1";
			this.ejPdfViewer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"documentPath\":\"Data/Wisej-Datasheet-V2.3.pdf\"}")));
			this.ejPdfViewer1.Size = new System.Drawing.Size(872, 560);
			this.ejPdfViewer1.TabIndex = 0;
			this.ejPdfViewer1.Text = "ejPdfViewer1";
			this.ejPdfViewer1.Initialized += new System.EventHandler(this.ejPdfViewer1_Initialized);
			this.ejPdfViewer1.WebRequest += new Wisej.Web.WebRequestHandler(this.ejPdfViewer1_WebRequest);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox1, true);
			this.checkBox1.Location = new System.Drawing.Point(3, 3);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(212, 30);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Enable Markup";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox2, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox2, true);
			this.checkBox2.Location = new System.Drawing.Point(3, 52);
			this.checkBox2.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(212, 30);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Enable Signature";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Zoom (50-400%)";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(6, 27);
			this.trackBar1.Maximum = 400;
			this.trackBar1.Minimum = 50;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(195, 34);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickFrequency = 25;
			this.trackBar1.Value = 100;
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".pdf";
			this.flowLayoutPanelProperties.SetFlowBreak(this.buttonLoad, true);
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(3, 290);
			this.buttonLoad.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 5;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.label4);
			this.flexLayoutPanel1.Controls.Add(this.trackBar1);
			this.flowLayoutPanelProperties.SetFillWeight(this.flexLayoutPanel1, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.flexLayoutPanel1, true);
			this.flexLayoutPanel1.Location = new System.Drawing.Point(3, 199);
			this.flexLayoutPanel1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(212, 72);
			this.flexLayoutPanel1.TabIndex = 4;
			this.flexLayoutPanel1.TabStop = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox3, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox3, true);
			this.checkBox3.Location = new System.Drawing.Point(3, 101);
			this.checkBox3.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(212, 30);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Enable Text Selection";
			// 
			// checkBox4
			// 
			this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox4.AutoSize = false;
			this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox4.Checked = true;
			this.flowLayoutPanelProperties.SetFillWeight(this.checkBox4, 1);
			this.flowLayoutPanelProperties.SetFlowBreak(this.checkBox4, true);
			this.checkBox4.Location = new System.Drawing.Point(3, 150);
			this.checkBox4.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(212, 30);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "Enable Hyperlink";
			// 
			// ejPdfViewer
			// 
			this.Name = "ejPdfViewer";
			this.Load += new System.EventHandler(this.ejPdfViewer_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.flowLayoutPanelProperties.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion.ejPdfViewer ejPdfViewer1;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Label label4;
		private TrackBar trackBar1;
		private Upload buttonLoad;
		private FlexLayoutPanel flexLayoutPanel1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
	}
}
