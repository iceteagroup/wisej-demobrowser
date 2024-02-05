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
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.buttonScan1 = new Wisej.Web.Button();
            this.buttonScan2 = new Wisej.Web.Button();
            this.textBox1 = new Wisej.Web.TextBox();
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.panel1 = new Wisej.Web.Panel();
            this.panel4 = new Wisej.Web.Panel();
            this.flowLayoutPanel3 = new Wisej.Web.FlowLayoutPanel();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.panel3 = new Wisej.Web.Panel();
            this.textBox2 = new Wisej.Web.TextBox();
            this.flowLayoutPanel2 = new Wisej.Web.FlowLayoutPanel();
            this.tabPage3 = new Wisej.Web.TabPage();
            this.panel2 = new Wisej.Web.Panel();
            this.textBox3 = new Wisej.Web.TextBox();
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.pictureBoxUploadedImage = new Wisej.Web.PictureBox();
            this.buttonScan3 = new Wisej.Web.Button();
            this.upload1 = new Wisej.Web.Upload();
            this.tabPage4 = new Wisej.Web.TabPage();
            this.camera1 = new Wisej.Web.Ext.Camera.Camera();
            this.tesseract1 = new Wisej.Ext.Tesseract.Tesseract(this.components);
            this.animation1 = new Wisej.Web.Animation(this.components);
            this.textBox_scanResult = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flexLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadedImage)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pictureBox1.ImageSource = "ImagesToScan\\frogText.png";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 345);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // buttonScan1
            // 
            this.buttonScan1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.buttonScan1.Display = Wisej.Web.Display.Icon;
            this.buttonScan1.ImageSource = "icon-search";
            this.buttonScan1.Location = new System.Drawing.Point(557, 3);
            this.buttonScan1.Name = "buttonScan1";
            this.buttonScan1.Size = new System.Drawing.Size(39, 29);
            this.buttonScan1.TabIndex = 0;
            this.buttonScan1.Text = "Scan Picturebox Image for Text";
            this.buttonScan1.Click += new System.EventHandler(this.buttonScan1_Click);
            // 
            // buttonScan2
            // 
            this.buttonScan2.Display = Wisej.Web.Display.Icon;
            this.buttonScan2.ImageSource = "icon-search";
            this.buttonScan2.Location = new System.Drawing.Point(1050, 3);
            this.buttonScan2.Name = "buttonScan2";
            this.buttonScan2.Size = new System.Drawing.Size(48, 30);
            this.buttonScan2.TabIndex = 1;
            this.buttonScan2.Text = "Scan Image from url";
            this.buttonScan2.Click += new System.EventHandler(this.buttonScan2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Label.Position = Wisej.Web.LabelPosition.Left;
            this.textBox1.LabelText = "Image Url:";
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1041, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "https://s3.studylib.net/store/data/025365095_1-9146f77868962fe355e4af075f9ab64b-7" +
    "68x994.png";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(20, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 40, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(1103, 405);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(1, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1101, 364);
            this.tabPage1.Text = "Picturebox Image";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1101, 364);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Location = new System.Drawing.Point(498, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 343);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox_scanResult);
            this.panel4.Dock = Wisej.Web.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 304);
            this.panel4.TabIndex = 11;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.comboBox1);
            this.flowLayoutPanel3.Controls.Add(this.buttonScan1);
            this.flowLayoutPanel3.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(600, 39);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = Wisej.Web.AnchorStyles.Left;
            this.comboBox1.Items.AddRange(new object[] {
            "frogText.png",
            "webDevelopment.jpg",
            "wisej-logo.png"});
            this.comboBox1.Label.Position = Wisej.Web.LabelPosition.Left;
            this.comboBox1.LabelText = "Select image...";
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(548, 30);
            this.comboBox1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(1, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1101, 364);
            this.tabPage2.Text = "Image Url";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Dock = Wisej.Web.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new Wisej.Web.Padding(5);
            this.panel3.Size = new System.Drawing.Size(1101, 324);
            this.panel3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox2.LabelText = "Result:";
            this.textBox2.Location = new System.Drawing.Point(5, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1091, 314);
            this.textBox2.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.buttonScan2);
            this.flowLayoutPanel2.Dock = Wisej.Web.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1101, 40);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.flexLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(1, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new Wisej.Web.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1101, 364);
            this.tabPage3.Text = "Uploaded Image";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(334, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(5);
            this.panel2.Size = new System.Drawing.Size(764, 358);
            this.panel2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox3.LabelText = "Result:";
            this.textBox3.Location = new System.Drawing.Point(5, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(754, 348);
            this.textBox3.TabIndex = 5;
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.Controls.Add(this.pictureBoxUploadedImage);
            this.flexLayoutPanel1.Controls.Add(this.buttonScan3);
            this.flexLayoutPanel1.Controls.Add(this.upload1);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Left;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(331, 358);
            this.flexLayoutPanel1.TabIndex = 3;
            // 
            // pictureBoxUploadedImage
            // 
            this.pictureBoxUploadedImage.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.pictureBoxUploadedImage.Location = new System.Drawing.Point(7, 12);
            this.pictureBoxUploadedImage.Name = "pictureBoxUploadedImage";
            this.pictureBoxUploadedImage.Size = new System.Drawing.Size(317, 230);
            // 
            // buttonScan3
            // 
            this.buttonScan3.Location = new System.Drawing.Point(7, 315);
            this.buttonScan3.Name = "buttonScan3";
            this.buttonScan3.Size = new System.Drawing.Size(317, 37);
            this.buttonScan3.TabIndex = 4;
            this.buttonScan3.Text = "Scan uploaded image";
            // 
            // upload1
            // 
            this.upload1.Location = new System.Drawing.Point(7, 259);
            this.upload1.Name = "upload1";
            this.upload1.Size = new System.Drawing.Size(317, 42);
            this.upload1.TabIndex = 3;
            this.upload1.Text = "Upload Image";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.camera1);
            this.tabPage4.Location = new System.Drawing.Point(1, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new Wisej.Web.Padding(5);
            this.tabPage4.Size = new System.Drawing.Size(1101, 364);
            this.tabPage4.Text = "Image From Camera";
            // 
            // camera1
            // 
            this.camera1.Dock = Wisej.Web.DockStyle.Fill;
            this.camera1.Location = new System.Drawing.Point(5, 5);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(1091, 354);
            this.camera1.TabIndex = 0;
            this.camera1.Text = "camera1";
            // 
            // tesseract1
            // 
            this.tesseract1.Camera = this.camera1;
            this.tesseract1.TextRecognized += new System.EventHandler<Wisej.Ext.Tesseract.TextRecognizedEventArgs>(this.tesseract1_TextRecognized);
            // 
            // textBox_scanResult
            // 
            this.textBox_scanResult.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox_scanResult.LabelText = "Result:";
            this.textBox_scanResult.Location = new System.Drawing.Point(0, 0);
            this.textBox_scanResult.Multiline = true;
            this.textBox_scanResult.Name = "textBox_scanResult";
            this.textBox_scanResult.Size = new System.Drawing.Size(600, 304);
            this.textBox_scanResult.TabIndex = 0;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.tabControl1);
            this.Name = "Features";
            this.Size = new System.Drawing.Size(1152, 474);
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flexLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadedImage)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private Web.PictureBox pictureBox1;
		private Web.TextBox textBox1;
		private Web.Button buttonScan2;
		private Web.Button buttonScan1;
		private Web.TabControl tabControl1;
		private Web.TabPage tabPage1;
		private Web.TabPage tabPage2;
		private Web.TabPage tabPage3;
		private Web.TabPage tabPage4;
		private Web.Ext.Camera.Camera camera1;
		private Ext.Tesseract.Tesseract tesseract1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Panel panel1;
        private Web.FlexLayoutPanel flexLayoutPanel1;
        private Web.PictureBox pictureBoxUploadedImage;
        private Web.Button buttonScan3;
        private Web.Upload upload1;
        private Web.Panel panel2;
        private Web.TextBox textBox3;
        private Web.FlowLayoutPanel flowLayoutPanel2;
        private Web.Panel panel3;
        private Web.TextBox textBox2;
        private Web.Animation animation1;
        private Web.FlowLayoutPanel flowLayoutPanel3;
        private Web.ComboBox comboBox1;
        private Web.Panel panel4;
        private Web.TextBox textBox_scanResult;
    }
}
