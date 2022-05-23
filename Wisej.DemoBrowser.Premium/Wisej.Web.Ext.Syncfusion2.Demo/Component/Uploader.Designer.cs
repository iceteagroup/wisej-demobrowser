namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class Uploader
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
            this.uploader1 = new Wisej.Web.Ext.Syncfusion2.Uploader();
            this.checkBoxMultiple = new Wisej.Web.CheckBox();
            this.checkBoxSequentiallUpload = new Wisej.Web.CheckBox();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/uploader/es5-getting-started/" +
    "";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/uploader/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.uploader1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMultiple);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxSequentiallUpload);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(871, 24);
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/uploader/default.html";
            // 
            // uploader1
            // 
            this.uploader1.Anchor = Wisej.Web.AnchorStyles.None;
            this.uploader1.Location = new System.Drawing.Point(203, 342);
            this.uploader1.Name = "uploader1";
            this.uploader1.Size = new System.Drawing.Size(482, 177);
            this.uploader1.TabIndex = 0;
            this.uploader1.Text = "uploader1";
            this.uploader1.WebRequest += new Wisej.Web.WebRequestHandler(this.uploader1_WebRequest);
            // 
            // checkBoxMultiple
            // 
            this.checkBoxMultiple.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMultiple.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxMultiple, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMultiple, true);
            this.checkBoxMultiple.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMultiple.Name = "checkBoxMultiple";
            this.checkBoxMultiple.Size = new System.Drawing.Size(212, 24);
            this.checkBoxMultiple.TabIndex = 1;
            this.checkBoxMultiple.Text = "Multiple Files";
            // 
            // checkBoxSequentiallUpload
            // 
            this.checkBoxSequentiallUpload.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSequentiallUpload.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxSequentiallUpload, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxSequentiallUpload, true);
            this.checkBoxSequentiallUpload.Location = new System.Drawing.Point(3, 46);
            this.checkBoxSequentiallUpload.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxSequentiallUpload.Name = "checkBoxSequentiallUpload";
            this.checkBoxSequentiallUpload.Size = new System.Drawing.Size(212, 24);
            this.checkBoxSequentiallUpload.TabIndex = 2;
            this.checkBoxSequentiallUpload.Text = "Sequential Upload";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Dashed;
            this.pictureBox1.Location = new System.Drawing.Point(203, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 262);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // Uploader
            // 
            this.Name = "Uploader";
            this.Load += new System.EventHandler(this.Uploader_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.Uploader uploader1;
        private CheckBox checkBoxSequentiallUpload;
        private CheckBox checkBoxMultiple;
        private PictureBox pictureBox1;
    }
}
