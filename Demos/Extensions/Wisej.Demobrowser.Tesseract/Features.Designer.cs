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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.buttonScan1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.textBox1 = new Wisej.Web.TextBox();
			this.label2 = new Wisej.Web.Label();
			this.comboBox1 = new Wisej.Web.ComboBox();
			this.tabControl1 = new Wisej.Web.TabControl();
			this.tabPage1 = new Wisej.Web.TabPage();
			this.tabPage2 = new Wisej.Web.TabPage();
			this.tabPage3 = new Wisej.Web.TabPage();
			this.upload1 = new Wisej.Web.Upload();
			this.tabPage4 = new Wisej.Web.TabPage();
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.tesseract1 = new Wisej.Ext.Tesseract.Tesseract(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(654, 313);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonScan1
			// 
			this.buttonScan1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.buttonScan1.Location = new System.Drawing.Point(722, 125);
			this.buttonScan1.Name = "buttonScan1";
			this.buttonScan1.Size = new System.Drawing.Size(256, 37);
			this.buttonScan1.TabIndex = 0;
			this.buttonScan1.Text = "Scan Picturebox Image for Text";
			this.buttonScan1.Click += new System.EventHandler(this.buttonScan1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(255, 37);
			this.button2.TabIndex = 1;
			this.button2.Text = "Scan Image from url";
			// 
			// textBox1
			// 
			this.textBox1.LabelText = "Image Url:";
			this.textBox1.Location = new System.Drawing.Point(22, 86);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(255, 53);
			this.textBox1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(417, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBox1.Items.AddRange(new object[] {
            "frogText.png",
            "webDevelopment.jpg",
            "wisej-logo.png"});
			this.comboBox1.LabelText = "Select image...";
			this.comboBox1.Location = new System.Drawing.Point(722, 42);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(237, 53);
			this.comboBox1.TabIndex = 8;
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
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.buttonScan1);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Location = new System.Drawing.Point(1, 40);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1101, 364);
			this.tabPage1.Text = "Picturebox Image";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Location = new System.Drawing.Point(1, 40);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1101, 364);
			this.tabPage2.Text = "Image Url";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.upload1);
			this.tabPage3.Location = new System.Drawing.Point(1, 40);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1101, 364);
			this.tabPage3.Text = "Uploaded Image";
			// 
			// upload1
			// 
			this.upload1.Location = new System.Drawing.Point(72, 65);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(296, 192);
			this.upload1.TabIndex = 0;
			this.upload1.Text = "upload1";
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
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.tabControl1);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1152, 474);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.PictureBox pictureBox1;
		private Web.TextBox textBox1;
		private Web.Button button2;
		private Web.Button buttonScan1;
		private Web.ComboBox comboBox1;
		private Web.Label label2;
		private Web.TabControl tabControl1;
		private Web.TabPage tabPage1;
		private Web.TabPage tabPage2;
		private Web.TabPage tabPage3;
		private Web.TabPage tabPage4;
		private Web.Upload upload1;
		private Web.Ext.Camera.Camera camera1;
		private Ext.Tesseract.Tesseract tesseract1;
	}
}
