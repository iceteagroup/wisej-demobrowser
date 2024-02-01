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
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.tabControl1 = new Wisej.Web.TabControl();
			this.tabPage1 = new Wisej.Web.TabPage();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.panel1 = new Wisej.Web.Panel();
			this.textBox_scanResult = new Wisej.Web.TextBox();
			this.tabPage2 = new Wisej.Web.TabPage();
			this.textBox2 = new Wisej.Web.TextBox();
			this.tabPage3 = new Wisej.Web.TabPage();
			this.pictureBoxUploadedImage = new Wisej.Web.PictureBox();
			this.textBox3 = new Wisej.Web.TextBox();
			this.buttonScan3 = new Wisej.Web.Button();
			this.upload1 = new Wisej.Web.Upload();
			this.tabPage4 = new Wisej.Web.TabPage();
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.tesseract1 = new Wisej.Ext.Tesseract.Tesseract(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadedImage)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.None;
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
			this.buttonScan1.Location = new System.Drawing.Point(57, 62);
			this.buttonScan1.Name = "buttonScan1";
			this.buttonScan1.Size = new System.Drawing.Size(265, 37);
			this.buttonScan1.TabIndex = 0;
			this.buttonScan1.Text = "Scan Picturebox Image for Text";
			this.buttonScan1.Click += new System.EventHandler(this.buttonScan1_Click);
			// 
			// buttonScan2
			// 
			this.buttonScan2.Location = new System.Drawing.Point(22, 200);
			this.buttonScan2.Name = "buttonScan2";
			this.buttonScan2.Size = new System.Drawing.Size(255, 37);
			this.buttonScan2.TabIndex = 1;
			this.buttonScan2.Text = "Scan Image from url";
			this.buttonScan2.Click += new System.EventHandler(this.buttonScan2_Click);
			// 
			// textBox1
			// 
			this.textBox1.LabelText = "Image Url:";
			this.textBox1.Location = new System.Drawing.Point(22, 86);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(255, 53);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "https://s3.studylib.net/store/data/025365095_1-9146f77868962fe355e4af075f9ab64b-7" +
    "68x994.png";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBox1.Items.AddRange(new object[] {
            "frogText.png",
            "webDevelopment.jpg",
            "wisej-logo.png"});
			this.comboBox1.LabelText = "Select image...";
			this.comboBox1.Location = new System.Drawing.Point(57, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(265, 53);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedItemChanged += new System.EventHandler(this.comboBox1_SelectedItemChanged);
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
			this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel1.Controls.Add(this.textBox_scanResult);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.buttonScan1);
			this.panel1.Location = new System.Drawing.Point(498, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(408, 343);
			this.panel1.TabIndex = 11;
			// 
			// textBox_scanResult
			// 
			this.textBox_scanResult.LabelText = "Result:";
			this.textBox_scanResult.Location = new System.Drawing.Point(3, 105);
			this.textBox_scanResult.Multiline = true;
			this.textBox_scanResult.Name = "textBox_scanResult";
			this.textBox_scanResult.Size = new System.Drawing.Size(402, 235);
			this.textBox_scanResult.TabIndex = 9;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.buttonScan2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Location = new System.Drawing.Point(1, 40);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1101, 364);
			this.tabPage2.Text = "Image Url";
			// 
			// textBox2
			// 
			this.textBox2.LabelText = "Result:";
			this.textBox2.Location = new System.Drawing.Point(353, 46);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(367, 280);
			this.textBox2.TabIndex = 3;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.pictureBoxUploadedImage);
			this.tabPage3.Controls.Add(this.textBox3);
			this.tabPage3.Controls.Add(this.buttonScan3);
			this.tabPage3.Controls.Add(this.upload1);
			this.tabPage3.Location = new System.Drawing.Point(1, 40);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1101, 364);
			this.tabPage3.Text = "Uploaded Image";
			// 
			// pictureBoxUploadedImage
			// 
			this.pictureBoxUploadedImage.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pictureBoxUploadedImage.Location = new System.Drawing.Point(3, 21);
			this.pictureBoxUploadedImage.Name = "pictureBoxUploadedImage";
			this.pictureBoxUploadedImage.Size = new System.Drawing.Size(317, 230);
			// 
			// textBox3
			// 
			this.textBox3.LabelText = "Result:";
			this.textBox3.Location = new System.Drawing.Point(338, 161);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(296, 156);
			this.textBox3.TabIndex = 2;
			// 
			// buttonScan3
			// 
			this.buttonScan3.Location = new System.Drawing.Point(338, 70);
			this.buttonScan3.Name = "buttonScan3";
			this.buttonScan3.Size = new System.Drawing.Size(296, 37);
			this.buttonScan3.TabIndex = 1;
			this.buttonScan3.Text = "Scan uploaded image";
			this.buttonScan3.Click += new System.EventHandler(this.buttonScan3_Click);
			// 
			// upload1
			// 
			this.upload1.Location = new System.Drawing.Point(3, 268);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(317, 77);
			this.upload1.TabIndex = 0;
			this.upload1.Text = "upload1";
			this.upload1.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload1_Uploaded);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.camera1);
			this.tabPage4.Location = new System.Drawing.Point(1, 40);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1101, 364);
			this.tabPage4.Text = "Image From Camera";
			// 
			// camera1
			// 
			this.camera1.Location = new System.Drawing.Point(30, 39);
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(343, 287);
			this.camera1.TabIndex = 0;
			this.camera1.Text = "camera1";
			// 
			// tesseract1
			// 
			this.tesseract1.Camera = this.camera1;
			this.tesseract1.TextRecognized += new System.EventHandler<Wisej.Ext.Tesseract.TextRecognizedEventArgs>(this.tesseract1_TextRecognized);
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
			this.panel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploadedImage)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.PictureBox pictureBox1;
		private Web.TextBox textBox1;
		private Web.Button buttonScan2;
		private Web.Button buttonScan1;
		private Web.ComboBox comboBox1;
		private Web.TabControl tabControl1;
		private Web.TabPage tabPage1;
		private Web.TabPage tabPage2;
		private Web.TabPage tabPage3;
		private Web.TabPage tabPage4;
		private Web.Upload upload1;
		private Web.Ext.Camera.Camera camera1;
		private Ext.Tesseract.Tesseract tesseract1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Panel panel1;
		private Web.TextBox textBox_scanResult;
		private Web.TextBox textBox2;
		private Web.TextBox textBox3;
		private Web.Button buttonScan3;
		private Web.PictureBox pictureBoxUploadedImage;
	}
}
