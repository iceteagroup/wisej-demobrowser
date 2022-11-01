namespace Wisej.DemoBrowser.Upload
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
            this.uploadImage = new Wisej.Web.Upload();
            this.pictureBox = new Wisej.Web.PictureBox();
            this.labelChoose = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadImage
            // 
            this.uploadImage.AllowedFileTypes = "image/png,image/jpeg";
            this.uploadImage.Anchor = Wisej.Web.AnchorStyles.None;
            this.uploadImage.Location = new System.Drawing.Point(72, 298);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(347, 40);
            this.uploadImage.TabIndex = 3;
            this.uploadImage.Text = "Choose Image";
            this.uploadImage.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadImage_Uploaded);
            // 
            // pictureBox
            // 
            this.pictureBox.AllowDrop = true;
            this.pictureBox.Anchor = Wisej.Web.AnchorStyles.None;
            this.pictureBox.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.pictureBox.CssStyle = "border-radius: 10px;border-width:5px";
            this.pictureBox.Location = new System.Drawing.Point(72, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Padding = new Wisej.Web.Padding(8);
            this.pictureBox.Size = new System.Drawing.Size(347, 243);
            this.pictureBox.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            this.pictureBox.DragDrop += new Wisej.Web.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new Wisej.Web.DragEventHandler(this.pictureBox_DragEnter);
            this.pictureBox.DragLeave += new System.EventHandler(this.pictureBox_DragLeave);
            // 
            // labelChoose
            // 
            this.labelChoose.AllowHtml = true;
            this.labelChoose.Anchor = Wisej.Web.AnchorStyles.None;
            this.labelChoose.Anonymous = true;
            this.labelChoose.Location = new System.Drawing.Point(145, 137);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(200, 49);
            this.labelChoose.TabIndex = 10;
            this.labelChoose.Text = "<b>Choose an Image</b> or drag it here.";
            // 
            // Features
            // 
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(358, 320);
            this.Name = "Features";
            this.Size = new System.Drawing.Size(491, 372);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private Web.Upload uploadImage;
		private Web.PictureBox pictureBox;
        private Web.Label labelChoose;
    }
}
