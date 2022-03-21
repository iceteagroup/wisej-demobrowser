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
            this.tagTextBoxAllowedExtensions = new Wisej.Web.TagTextBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/uploader/es5-getting-started/" +
    "";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/uploader/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tagTextBoxAllowedExtensions);
            this.groupBox1.Controls.Add(this.checkBoxSequentiallUpload);
            this.groupBox1.Controls.Add(this.checkBoxMultiple);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxMultiple, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxSequentiallUpload, 0);
            this.groupBox1.Controls.SetChildIndex(this.tagTextBoxAllowedExtensions, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.uploader1);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(871, 24);
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/uploader/default.html";
            // 
            // uploader1
            // 
            this.uploader1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)));
            this.uploader1.Location = new System.Drawing.Point(39, 84);
            this.uploader1.Name = "uploader1";
            this.uploader1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"allowedExtensions\":\".jpg,.png\"}")));
            this.uploader1.Size = new System.Drawing.Size(374, 145);
            this.uploader1.TabIndex = 0;
            this.uploader1.Text = "uploader1";
            // 
            // checkBoxMultiple
            // 
            this.checkBoxMultiple.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMultiple.Location = new System.Drawing.Point(14, 29);
            this.checkBoxMultiple.Name = "checkBoxMultiple";
            this.checkBoxMultiple.Size = new System.Drawing.Size(108, 24);
            this.checkBoxMultiple.TabIndex = 1;
            this.checkBoxMultiple.Text = "Multiple";
            // 
            // checkBoxSequentiallUpload
            // 
            this.checkBoxSequentiallUpload.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxSequentiallUpload.Location = new System.Drawing.Point(14, 65);
            this.checkBoxSequentiallUpload.Name = "checkBoxSequentiallUpload";
            this.checkBoxSequentiallUpload.Size = new System.Drawing.Size(181, 24);
            this.checkBoxSequentiallUpload.TabIndex = 2;
            this.checkBoxSequentiallUpload.Text = "Sequential upload";
            // 
            // tagTextBoxAllowedExtensions
            // 
            this.tagTextBoxAllowedExtensions.LabelText = "Allowed extensions";
            this.tagTextBoxAllowedExtensions.Location = new System.Drawing.Point(14, 103);
            this.tagTextBoxAllowedExtensions.Name = "tagTextBoxAllowedExtensions";
            this.tagTextBoxAllowedExtensions.Size = new System.Drawing.Size(219, 52);
            this.tagTextBoxAllowedExtensions.TabIndex = 3;
            this.tagTextBoxAllowedExtensions.Text = ".jpg,.png";
            // 
            // Uploader
            // 
            this.Name = "Uploader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.Uploader uploader1;
        private TagTextBox tagTextBoxAllowedExtensions;
        private CheckBox checkBoxSequentiallUpload;
        private CheckBox checkBoxMultiple;
    }
}
