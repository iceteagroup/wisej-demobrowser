namespace Wisej.DemoBrowser.Signature
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
			this.panel1 = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.buttonExportImage = new Wisej.Web.Button();
			this.uploadSelectImage = new Wisej.Web.Upload();
			this.checkBoxEmpty = new Wisej.Web.CheckBox();
			this.buttonRedo = new Wisej.Web.Button();
			this.buttonUndo = new Wisej.Web.Button();
			this.buttonClear = new Wisej.Web.Button();
			this.numericUpDownLineWidth = new Wisej.Web.NumericUpDown();
			this.textBoxColor = new Wisej.Web.TextBox();
			this.flowLayoutPanelMain = new Wisej.Web.FlowLayoutPanel();
			this.signature1 = new Wisej.Web.Ext.Signature.Signature();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).BeginInit();
			this.flowLayoutPanelMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.buttonExportImage);
			this.panel1.Controls.Add(this.uploadSelectImage);
			this.panel1.Controls.Add(this.checkBoxEmpty);
			this.panel1.Controls.Add(this.buttonRedo);
			this.panel1.Controls.Add(this.buttonUndo);
			this.panel1.Controls.Add(this.buttonClear);
			this.panel1.Controls.Add(this.numericUpDownLineWidth);
			this.panel1.Controls.Add(this.textBoxColor);
			this.flowLayoutPanelMain.SetFillWeight(this.panel1, 1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.MaximumSize = new System.Drawing.Size(500, 0);
			this.panel1.MinimumSize = new System.Drawing.Size(300, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 350);
			this.panel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(377, 182);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 18);
			this.label1.TabIndex = 18;
			this.label1.Text = "Export Thumbnail";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(377, 206);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 73);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonExportImage
			// 
			this.buttonExportImage.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonExportImage.Location = new System.Drawing.Point(377, 136);
			this.buttonExportImage.Name = "buttonExportImage";
			this.buttonExportImage.Size = new System.Drawing.Size(120, 37);
			this.buttonExportImage.TabIndex = 16;
			this.buttonExportImage.Text = "Export Image";
			this.buttonExportImage.Click += new System.EventHandler(this.buttonExportImage_Click);
			// 
			// uploadSelectImage
			// 
			this.uploadSelectImage.Anchor = Wisej.Web.AnchorStyles.None;
			this.uploadSelectImage.Location = new System.Drawing.Point(193, 182);
			this.uploadSelectImage.Name = "uploadSelectImage";
			this.uploadSelectImage.Size = new System.Drawing.Size(120, 37);
			this.uploadSelectImage.TabIndex = 15;
			this.uploadSelectImage.Text = "Load";
			this.uploadSelectImage.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadSelectImage_Uploaded);
			// 
			// checkBoxEmpty
			// 
			this.checkBoxEmpty.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxEmpty.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxEmpty.AutoSize = false;
			this.checkBoxEmpty.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBoxEmpty.Location = new System.Drawing.Point(193, 316);
			this.checkBoxEmpty.Name = "checkBoxEmpty";
			this.checkBoxEmpty.ReadOnly = true;
			this.checkBoxEmpty.Size = new System.Drawing.Size(174, 23);
			this.checkBoxEmpty.TabIndex = 14;
			this.checkBoxEmpty.Text = "Signature is empty";
			this.checkBoxEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonRedo
			// 
			this.buttonRedo.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonRedo.Enabled = false;
			this.buttonRedo.ImageSource = "icon-redo";
			this.buttonRedo.Location = new System.Drawing.Point(457, 307);
			this.buttonRedo.Name = "buttonRedo";
			this.buttonRedo.Size = new System.Drawing.Size(40, 40);
			this.buttonRedo.TabIndex = 13;
			this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
			// 
			// buttonUndo
			// 
			this.buttonUndo.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonUndo.Enabled = false;
			this.buttonUndo.ImageSource = "icon-undo";
			this.buttonUndo.Location = new System.Drawing.Point(411, 307);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(40, 40);
			this.buttonUndo.TabIndex = 12;
			this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonClear.Location = new System.Drawing.Point(193, 136);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(120, 37);
			this.buttonClear.TabIndex = 9;
			this.buttonClear.Text = "Clear";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// numericUpDownLineWidth
			// 
			this.numericUpDownLineWidth.Anchor = Wisej.Web.AnchorStyles.None;
			this.numericUpDownLineWidth.LabelText = "Line Width";
			this.numericUpDownLineWidth.Location = new System.Drawing.Point(193, 62);
			this.numericUpDownLineWidth.Name = "numericUpDownLineWidth";
			this.numericUpDownLineWidth.Size = new System.Drawing.Size(120, 53);
			this.numericUpDownLineWidth.TabIndex = 3;
			this.numericUpDownLineWidth.Value = new decimal(1);
			this.numericUpDownLineWidth.ValueChanged += new System.EventHandler(this.numericUpDownLineWidth_ValueChanged);
			// 
			// textBoxColor
			// 
			this.textBoxColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.textBoxColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxColor.LabelText = "Line Color";
			this.textBoxColor.Location = new System.Drawing.Point(193, 3);
			this.textBoxColor.Name = "textBoxColor";
			this.textBoxColor.Size = new System.Drawing.Size(120, 53);
			this.textBoxColor.TabIndex = 2;
			this.textBoxColor.Text = "#000000";
			this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
			// 
			// flowLayoutPanelMain
			// 
			this.flowLayoutPanelMain.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelMain.AutoSize = true;
			this.flowLayoutPanelMain.Controls.Add(this.panel1);
			this.flowLayoutPanelMain.Controls.Add(this.signature1);
			this.flowLayoutPanelMain.Location = new System.Drawing.Point(89, 59);
			this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
			this.flowLayoutPanelMain.Size = new System.Drawing.Size(1245, 356);
			this.flowLayoutPanelMain.TabIndex = 8;
			// 
			// signature1
			// 
			this.signature1.Dock = Wisej.Web.DockStyle.Fill;
			this.signature1.Location = new System.Drawing.Point(509, 3);
			this.signature1.Name = "signature1";
			this.signature1.Size = new System.Drawing.Size(706, 350);
			this.signature1.TabIndex = 8;
			this.signature1.Text = "signature1";
			this.signature1.SignatureChange += new System.EventHandler(this.signature1_SignatureChange);
			// 
			// Features
			// 
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanelMain);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.Features_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).EndInit();
			this.flowLayoutPanelMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
        private Web.Panel panel1;
        private Web.FlowLayoutPanel flowLayoutPanelMain;
		private Web.CheckBox checkBoxEmpty;
		private Web.Button buttonRedo;
		private Web.Button buttonUndo;
		private Web.Button buttonClear;
		private Web.NumericUpDown numericUpDownLineWidth;
		private Web.TextBox textBoxColor;
		private Web.Ext.Signature.Signature signature1;
		private Web.Upload uploadSelectImage;
		private Web.Button buttonExportImage;
		private Web.Label label1;
		private Web.PictureBox pictureBox1;
	}
}
