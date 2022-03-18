namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class FileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.fileManager1 = new Wisej.Web.Ext.Syncfusion2.FileManager();
            this.checkBoxHiddenItem = new Wisej.Web.CheckBox();
            this.checkBoxThumbnail = new Wisej.Web.CheckBox();
            this.checkBoxFileExtension = new Wisej.Web.CheckBox();
            this.checkBoxMultipleSelection = new Wisej.Web.CheckBox();
            this.comboBoxView = new Wisej.Web.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/file-manager/es5-getting-star" +
    "ted/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/file-manager/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxView);
            this.groupBox1.Controls.Add(this.checkBoxMultipleSelection);
            this.groupBox1.Controls.Add(this.checkBoxFileExtension);
            this.groupBox1.Controls.Add(this.checkBoxThumbnail);
            this.groupBox1.Controls.Add(this.checkBoxHiddenItem);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxHiddenItem, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxThumbnail, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxFileExtension, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxMultipleSelection, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBoxView, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.fileManager1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/file-manager/overview.html";
            // 
            // fileManager1
            // 
            this.fileManager1.Dock = Wisej.Web.DockStyle.Fill;
            this.fileManager1.Location = new System.Drawing.Point(8, 8);
            this.fileManager1.Name = "fileManager1";
            this.fileManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("fileManager1.Options"))));
            this.fileManager1.Size = new System.Drawing.Size(1073, 542);
            this.fileManager1.TabIndex = 0;
            this.fileManager1.Text = "fileManager1";
            this.fileManager1.WebRequest += new Wisej.Web.WebRequestHandler(this.fileManager1_WebRequest);
            // 
            // checkBoxHiddenItem
            // 
            this.checkBoxHiddenItem.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxHiddenItem.Location = new System.Drawing.Point(11, 39);
            this.checkBoxHiddenItem.Name = "checkBoxHiddenItem";
            this.checkBoxHiddenItem.Size = new System.Drawing.Size(156, 24);
            this.checkBoxHiddenItem.TabIndex = 1;
            this.checkBoxHiddenItem.Text = "Show hidden item";
            // 
            // checkBoxThumbnail
            // 
            this.checkBoxThumbnail.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxThumbnail.Location = new System.Drawing.Point(11, 67);
            this.checkBoxThumbnail.Name = "checkBoxThumbnail";
            this.checkBoxThumbnail.Size = new System.Drawing.Size(145, 24);
            this.checkBoxThumbnail.TabIndex = 2;
            this.checkBoxThumbnail.Text = "Show thumbnail";
            // 
            // checkBoxFileExtension
            // 
            this.checkBoxFileExtension.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFileExtension.Location = new System.Drawing.Point(11, 95);
            this.checkBoxFileExtension.Name = "checkBoxFileExtension";
            this.checkBoxFileExtension.Size = new System.Drawing.Size(165, 24);
            this.checkBoxFileExtension.TabIndex = 3;
            this.checkBoxFileExtension.Text = "Show file extension";
            // 
            // checkBoxMultipleSelection
            // 
            this.checkBoxMultipleSelection.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMultipleSelection.Location = new System.Drawing.Point(11, 121);
            this.checkBoxMultipleSelection.Name = "checkBoxMultipleSelection";
            this.checkBoxMultipleSelection.Size = new System.Drawing.Size(187, 24);
            this.checkBoxMultipleSelection.TabIndex = 4;
            this.checkBoxMultipleSelection.Text = "Allow multiple selection";
            // 
            // comboBoxView
            // 
            this.comboBoxView.Items.AddRange(new object[] {
            "LargeIcons",
            "Details"});
            this.comboBoxView.LabelText = "View";
            this.comboBoxView.Location = new System.Drawing.Point(16, 149);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(215, 42);
            this.comboBoxView.TabIndex = 5;
            // 
            // FileManager
            // 
            this.Name = "FileManager";
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.FileManager fileManager1;
        private CheckBox checkBoxMultipleSelection;
        private CheckBox checkBoxFileExtension;
        private CheckBox checkBoxThumbnail;
        private CheckBox checkBoxHiddenItem;
        private ComboBox comboBoxView;
    }
}
