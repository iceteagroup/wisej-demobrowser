namespace Wisej.DemoBrowser.Camera
{
	partial class Features
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
			this.pictureBox_picturebox = new Wisej.Web.PictureBox();
			this.buttonScan_picturebox = new Wisej.Web.Button();
			this.buttonScan_url = new Wisej.Web.Button();
			this.textBox_url = new Wisej.Web.TextBox();
			this.tabControl_picturebox = new Wisej.Web.TabControl();
			this.tabPage_picturebox = new Wisej.Web.TabPage();
			this.flowLayoutPanel_picturebox = new Wisej.Web.FlowLayoutPanel();
			this.panel_picturebox1 = new Wisej.Web.Panel();
			this.panel_picturebox2 = new Wisej.Web.Panel();
			this.textBox_picturebox = new Wisej.Web.TextBox();
			this.flowLayoutPanel_picturebox2 = new Wisej.Web.FlowLayoutPanel();
			this.comboBox_picturebox = new Wisej.Web.ComboBox();
			this.tabPage_url = new Wisej.Web.TabPage();
			this.panel_url = new Wisej.Web.Panel();
			this.textBox_url2 = new Wisej.Web.TextBox();
			this.flowLayoutPanel2_url = new Wisej.Web.FlowLayoutPanel();
			this.tabPage_upload = new Wisej.Web.TabPage();
			this.panel_upload = new Wisej.Web.Panel();
			this.textBox_upload = new Wisej.Web.TextBox();
			this.flexLayoutPanel_upload = new Wisej.Web.FlexLayoutPanel();
			this.pictureBox_upload = new Wisej.Web.PictureBox();
			this.button_upload = new Wisej.Web.Button();
			this.upload1 = new Wisej.Web.Upload();
			this.tabPage_camera = new Wisej.Web.TabPage();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.panel1 = new Wisej.Web.Panel();
			this.textBox_camera = new Wisej.Web.TextBox();
			this.tesseract1 = new Wisej.Ext.Tesseract.Tesseract(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_picturebox)).BeginInit();
			this.tabControl_picturebox.SuspendLayout();
			this.tabPage_picturebox.SuspendLayout();
			this.flowLayoutPanel_picturebox.SuspendLayout();
			this.panel_picturebox1.SuspendLayout();
			this.panel_picturebox2.SuspendLayout();
			this.flowLayoutPanel_picturebox2.SuspendLayout();
			this.tabPage_url.SuspendLayout();
			this.panel_url.SuspendLayout();
			this.flowLayoutPanel2_url.SuspendLayout();
			this.tabPage_upload.SuspendLayout();
			this.panel_upload.SuspendLayout();
			this.flexLayoutPanel_upload.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_upload)).BeginInit();
			this.tabPage_camera.SuspendLayout();
			this.flexLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox_picturebox
			// 
			this.pictureBox_picturebox.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pictureBox_picturebox.ImageSource = "ImagesToScan\\frogText.png";
			this.pictureBox_picturebox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox_picturebox.Name = "pictureBox_picturebox";
			this.pictureBox_picturebox.Size = new System.Drawing.Size(489, 345);
			this.pictureBox_picturebox.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonScan_picturebox
			// 
			this.buttonScan_picturebox.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.buttonScan_picturebox.Display = Wisej.Web.Display.Icon;
			this.buttonScan_picturebox.ImageSource = "icon-search";
			this.buttonScan_picturebox.Location = new System.Drawing.Point(433, 3);
			this.buttonScan_picturebox.Name = "buttonScan_picturebox";
			this.buttonScan_picturebox.Size = new System.Drawing.Size(39, 29);
			this.buttonScan_picturebox.TabIndex = 0;
			this.buttonScan_picturebox.Text = "Scan Picturebox Image for Text";
			this.buttonScan_picturebox.Click += new System.EventHandler(this.buttonScan_picturebox_Click);
			// 
			// buttonScan_url
			// 
			this.buttonScan_url.Display = Wisej.Web.Display.Icon;
			this.buttonScan_url.ImageSource = "icon-search";
			this.buttonScan_url.Location = new System.Drawing.Point(945, 3);
			this.buttonScan_url.Name = "buttonScan_url";
			this.buttonScan_url.Size = new System.Drawing.Size(48, 30);
			this.buttonScan_url.TabIndex = 1;
			this.buttonScan_url.Text = "Scan Image from url";
			this.buttonScan_url.Click += new System.EventHandler(this.buttonScan_url_Click);
			// 
			// textBox_url
			// 
			this.textBox_url.Label.Position = Wisej.Web.LabelPosition.Left;
			this.textBox_url.LabelText = "Image Url:";
			this.textBox_url.Location = new System.Drawing.Point(3, 3);
			this.textBox_url.Name = "textBox_url";
			this.textBox_url.Size = new System.Drawing.Size(936, 22);
			this.textBox_url.TabIndex = 2;
			this.textBox_url.Text = "https://s3.studylib.net/store/data/025365095_1-9146f77868962fe355e4af075f9ab64b-7" +
    "68x994.png";
			// 
			// tabControl_picturebox
			// 
			this.tabControl_picturebox.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tabControl_picturebox.Controls.Add(this.tabPage_picturebox);
			this.tabControl_picturebox.Controls.Add(this.tabPage_url);
			this.tabControl_picturebox.Controls.Add(this.tabPage_upload);
			this.tabControl_picturebox.Controls.Add(this.tabPage_camera);
			this.tabControl_picturebox.Location = new System.Drawing.Point(20, 31);
			this.tabControl_picturebox.Name = "tabControl_picturebox";
			this.tabControl_picturebox.PageInsets = new Wisej.Web.Padding(1, 30, 1, 1);
			this.tabControl_picturebox.Size = new System.Drawing.Size(1103, 405);
			this.tabControl_picturebox.TabIndex = 7;
			// 
			// tabPage_picturebox
			// 
			this.tabPage_picturebox.Controls.Add(this.flowLayoutPanel_picturebox);
			this.tabPage_picturebox.Location = new System.Drawing.Point(1, 30);
			this.tabPage_picturebox.Name = "tabPage_picturebox";
			this.tabPage_picturebox.Size = new System.Drawing.Size(1101, 374);
			this.tabPage_picturebox.Text = "Picturebox Image";
			// 
			// flowLayoutPanel_picturebox
			// 
			this.flowLayoutPanel_picturebox.AutoScroll = true;
			this.flowLayoutPanel_picturebox.Controls.Add(this.pictureBox_picturebox);
			this.flowLayoutPanel_picturebox.Controls.Add(this.panel_picturebox1);
			this.flowLayoutPanel_picturebox.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel_picturebox.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel_picturebox.Name = "flowLayoutPanel_picturebox";
			this.flowLayoutPanel_picturebox.Size = new System.Drawing.Size(1101, 374);
			this.flowLayoutPanel_picturebox.TabIndex = 10;
			// 
			// panel_picturebox1
			// 
			this.panel_picturebox1.Controls.Add(this.panel_picturebox2);
			this.panel_picturebox1.Controls.Add(this.flowLayoutPanel_picturebox2);
			this.panel_picturebox1.Location = new System.Drawing.Point(498, 3);
			this.panel_picturebox1.Name = "panel_picturebox1";
			this.panel_picturebox1.Size = new System.Drawing.Size(489, 348);
			this.panel_picturebox1.TabIndex = 11;
			// 
			// panel_picturebox2
			// 
			this.panel_picturebox2.Controls.Add(this.textBox_picturebox);
			this.panel_picturebox2.Dock = Wisej.Web.DockStyle.Fill;
			this.panel_picturebox2.Location = new System.Drawing.Point(0, 39);
			this.panel_picturebox2.Name = "panel_picturebox2";
			this.panel_picturebox2.Size = new System.Drawing.Size(489, 309);
			this.panel_picturebox2.TabIndex = 11;
			// 
			// textBox_picturebox
			// 
			this.textBox_picturebox.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox_picturebox.LabelText = "Result:";
			this.textBox_picturebox.Location = new System.Drawing.Point(0, 0);
			this.textBox_picturebox.Multiline = true;
			this.textBox_picturebox.Name = "textBox_picturebox";
			this.textBox_picturebox.ReadOnly = true;
			this.textBox_picturebox.Size = new System.Drawing.Size(489, 309);
			this.textBox_picturebox.TabIndex = 0;
			// 
			// flowLayoutPanel_picturebox2
			// 
			this.flowLayoutPanel_picturebox2.Controls.Add(this.comboBox_picturebox);
			this.flowLayoutPanel_picturebox2.Controls.Add(this.buttonScan_picturebox);
			this.flowLayoutPanel_picturebox2.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanel_picturebox2.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel_picturebox2.Name = "flowLayoutPanel_picturebox2";
			this.flowLayoutPanel_picturebox2.Size = new System.Drawing.Size(489, 39);
			this.flowLayoutPanel_picturebox2.TabIndex = 10;
			// 
			// comboBox_picturebox
			// 
			this.comboBox_picturebox.Anchor = Wisej.Web.AnchorStyles.Left;
			this.comboBox_picturebox.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBox_picturebox.Items.AddRange(new object[] {
            "frogText.png",
            "webDevelopment.jpg",
            "wisej-logo.png"});
			this.comboBox_picturebox.Label.Position = Wisej.Web.LabelPosition.Left;
			this.comboBox_picturebox.LabelText = "Select image...";
			this.comboBox_picturebox.Location = new System.Drawing.Point(3, 6);
			this.comboBox_picturebox.Name = "comboBox_picturebox";
			this.comboBox_picturebox.Size = new System.Drawing.Size(424, 22);
			this.comboBox_picturebox.TabIndex = 11;
			this.comboBox_picturebox.SelectedItemChanged += new System.EventHandler(this.comboBox_picturebox_SelectedItemChanged_1);
			// 
			// tabPage_url
			// 
			this.tabPage_url.Controls.Add(this.panel_url);
			this.tabPage_url.Controls.Add(this.flowLayoutPanel2_url);
			this.tabPage_url.Location = new System.Drawing.Point(1, 30);
			this.tabPage_url.Name = "tabPage_url";
			this.tabPage_url.Size = new System.Drawing.Size(1101, 374);
			this.tabPage_url.Text = "Image Url";
			// 
			// panel_url
			// 
			this.panel_url.Controls.Add(this.textBox_url2);
			this.panel_url.Dock = Wisej.Web.DockStyle.Fill;
			this.panel_url.Location = new System.Drawing.Point(0, 40);
			this.panel_url.Name = "panel_url";
			this.panel_url.Padding = new Wisej.Web.Padding(5);
			this.panel_url.Size = new System.Drawing.Size(1101, 334);
			this.panel_url.TabIndex = 5;
			// 
			// textBox_url2
			// 
			this.textBox_url2.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox_url2.LabelText = "Result:";
			this.textBox_url2.Location = new System.Drawing.Point(5, 5);
			this.textBox_url2.Multiline = true;
			this.textBox_url2.Name = "textBox_url2";
			this.textBox_url2.ReadOnly = true;
			this.textBox_url2.Size = new System.Drawing.Size(1091, 324);
			this.textBox_url2.TabIndex = 4;
			// 
			// flowLayoutPanel2_url
			// 
			this.flowLayoutPanel2_url.Controls.Add(this.textBox_url);
			this.flowLayoutPanel2_url.Controls.Add(this.buttonScan_url);
			this.flowLayoutPanel2_url.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanel2_url.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel2_url.Name = "flowLayoutPanel2_url";
			this.flowLayoutPanel2_url.Size = new System.Drawing.Size(1101, 40);
			this.flowLayoutPanel2_url.TabIndex = 4;
			// 
			// tabPage_upload
			// 
			this.tabPage_upload.Controls.Add(this.panel_upload);
			this.tabPage_upload.Controls.Add(this.flexLayoutPanel_upload);
			this.tabPage_upload.Location = new System.Drawing.Point(1, 30);
			this.tabPage_upload.Name = "tabPage_upload";
			this.tabPage_upload.Padding = new Wisej.Web.Padding(3);
			this.tabPage_upload.Size = new System.Drawing.Size(1101, 374);
			this.tabPage_upload.Text = "Uploaded Image";
			// 
			// panel_upload
			// 
			this.panel_upload.Controls.Add(this.textBox_upload);
			this.panel_upload.Dock = Wisej.Web.DockStyle.Fill;
			this.panel_upload.Location = new System.Drawing.Point(334, 3);
			this.panel_upload.Name = "panel_upload";
			this.panel_upload.Padding = new Wisej.Web.Padding(5);
			this.panel_upload.Size = new System.Drawing.Size(764, 368);
			this.panel_upload.TabIndex = 4;
			// 
			// textBox_upload
			// 
			this.textBox_upload.Dock = Wisej.Web.DockStyle.Fill;
			this.textBox_upload.LabelText = "Result:";
			this.textBox_upload.Location = new System.Drawing.Point(5, 5);
			this.textBox_upload.Multiline = true;
			this.textBox_upload.Name = "textBox_upload";
			this.textBox_upload.ReadOnly = true;
			this.textBox_upload.Size = new System.Drawing.Size(754, 358);
			this.textBox_upload.TabIndex = 5;
			// 
			// flexLayoutPanel_upload
			// 
			this.flexLayoutPanel_upload.Controls.Add(this.pictureBox_upload);
			this.flexLayoutPanel_upload.Controls.Add(this.button_upload);
			this.flexLayoutPanel_upload.Controls.Add(this.upload1);
			this.flexLayoutPanel_upload.Dock = Wisej.Web.DockStyle.Left;
			this.flexLayoutPanel_upload.Location = new System.Drawing.Point(3, 3);
			this.flexLayoutPanel_upload.Name = "flexLayoutPanel_upload";
			this.flexLayoutPanel_upload.Size = new System.Drawing.Size(331, 368);
			this.flexLayoutPanel_upload.TabIndex = 3;
			// 
			// pictureBox_upload
			// 
			this.pictureBox_upload.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pictureBox_upload.Location = new System.Drawing.Point(7, 12);
			this.pictureBox_upload.Name = "pictureBox_upload";
			this.pictureBox_upload.Size = new System.Drawing.Size(317, 230);
			// 
			// button_upload
			// 
			this.button_upload.Location = new System.Drawing.Point(7, 315);
			this.button_upload.Name = "button_upload";
			this.button_upload.Size = new System.Drawing.Size(317, 37);
			this.button_upload.TabIndex = 4;
			this.button_upload.Text = "Scan uploaded image";
			this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
			// 
			// upload1
			// 
			this.upload1.Location = new System.Drawing.Point(7, 259);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(317, 42);
			this.upload1.TabIndex = 3;
			this.upload1.Text = "Upload Image";
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded_1);
			// 
			// tabPage_camera
			// 
			this.tabPage_camera.Controls.Add(this.flexLayoutPanel1);
			this.tabPage_camera.Location = new System.Drawing.Point(1, 30);
			this.tabPage_camera.Name = "tabPage_camera";
			this.tabPage_camera.Padding = new Wisej.Web.Padding(5);
			this.tabPage_camera.Size = new System.Drawing.Size(1101, 374);
			this.tabPage_camera.Text = "Image From Camera";
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.camera1);
			this.flexLayoutPanel1.Controls.Add(this.panel1);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(1091, 364);
			this.flexLayoutPanel1.TabIndex = 3;
			// 
			// camera1
			// 
			this.camera1.Location = new System.Drawing.Point(3, 3);
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(414, 358);
			this.camera1.TabIndex = 2;
			this.camera1.Text = "camera1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox_camera);
			this.panel1.Location = new System.Drawing.Point(433, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(412, 358);
			this.panel1.TabIndex = 1;
			// 
			// textBox_camera
			// 
			this.textBox_camera.Location = new System.Drawing.Point(31, 58);
			this.textBox_camera.Multiline = true;
			this.textBox_camera.Name = "textBox_camera";
			this.textBox_camera.ReadOnly = true;
			this.textBox_camera.Size = new System.Drawing.Size(359, 183);
			this.textBox_camera.TabIndex = 0;
			// 
			// tesseract1
			// 
			this.tesseract1.TextRecognized += new System.EventHandler<Wisej.Ext.Tesseract.TextRecognizedEventArgs>(this.tesseract1_TextRecognized);
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.tabControl_picturebox);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1152, 474);
			this.Load += new System.EventHandler(this.Features_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_picturebox)).EndInit();
			this.tabControl_picturebox.ResumeLayout(false);
			this.tabPage_picturebox.ResumeLayout(false);
			this.flowLayoutPanel_picturebox.ResumeLayout(false);
			this.panel_picturebox1.ResumeLayout(false);
			this.panel_picturebox2.ResumeLayout(false);
			this.panel_picturebox2.PerformLayout();
			this.flowLayoutPanel_picturebox2.ResumeLayout(false);
			this.flowLayoutPanel_picturebox2.PerformLayout();
			this.tabPage_url.ResumeLayout(false);
			this.panel_url.ResumeLayout(false);
			this.panel_url.PerformLayout();
			this.flowLayoutPanel2_url.ResumeLayout(false);
			this.flowLayoutPanel2_url.PerformLayout();
			this.tabPage_upload.ResumeLayout(false);
			this.panel_upload.ResumeLayout(false);
			this.panel_upload.PerformLayout();
			this.flexLayoutPanel_upload.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_upload)).EndInit();
			this.tabPage_camera.ResumeLayout(false);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Web.PictureBox pictureBox_picturebox;
		private Web.TextBox textBox_url;
		private Web.Button buttonScan_url;
		private Web.Button buttonScan_picturebox;
		private Web.TabControl tabControl_picturebox;
		private Web.TabPage tabPage_picturebox;
		private Web.TabPage tabPage_url;
		private Web.TabPage tabPage_upload;
		private Web.TabPage tabPage_camera;
		private Ext.Tesseract.Tesseract tesseract1;
		private Web.FlowLayoutPanel flowLayoutPanel_picturebox;
		private Web.Panel panel_picturebox1;
        private Web.FlexLayoutPanel flexLayoutPanel_upload;
        private Web.PictureBox pictureBox_upload;
        private Web.Button button_upload;
        private Web.Upload upload1;
        private Web.Panel panel_upload;
        private Web.TextBox textBox_upload;
        private Web.FlowLayoutPanel flowLayoutPanel2_url;
        private Web.Panel panel_url;
        private Web.TextBox textBox_url2;
        private Web.FlowLayoutPanel flowLayoutPanel_picturebox2;
        private Web.ComboBox comboBox_picturebox;
        private Web.Panel panel_picturebox2;
        private Web.TextBox textBox_picturebox;
		private Web.Panel panel1;
		private Web.Ext.Camera.Camera camera1;
		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.TextBox textBox_camera;
	}
}
