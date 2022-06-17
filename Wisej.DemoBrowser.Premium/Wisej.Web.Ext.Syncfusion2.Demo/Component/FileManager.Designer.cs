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
            this.checkBoxFileExtension = new Wisej.Web.CheckBox();
            this.checkBoxMultipleSelection = new Wisej.Web.CheckBox();
            this.comboBoxView = new Wisej.Web.ComboBox();
            this.checkBoxAllowDragAndDrop = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/file-manager/es5-getting-star" +
    "ted/";
            // 
            // linkApi
            // 
            this.linkApi.Text = "https://ej2.syncfusion.com/javascript/documentation/api/file-manager/";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.fileManager1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowDragAndDrop);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxFileExtension);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxMultipleSelection);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxView);
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
            this.fileManager1.Size = new System.Drawing.Size(872, 560);
            this.fileManager1.TabIndex = 0;
            this.fileManager1.Text = "fileManager1";
            this.fileManager1.WebRequest += new Wisej.Web.WebRequestHandler(this.fileManager1_WebRequest);
            // 
            // checkBoxFileExtension
            // 
            this.checkBoxFileExtension.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxFileExtension.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxFileExtension, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxFileExtension, true);
            this.checkBoxFileExtension.Location = new System.Drawing.Point(3, 46);
            this.checkBoxFileExtension.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxFileExtension.Name = "checkBoxFileExtension";
            this.checkBoxFileExtension.Size = new System.Drawing.Size(212, 24);
            this.checkBoxFileExtension.TabIndex = 3;
            this.checkBoxFileExtension.Text = "Show File Extensions";
            // 
            // checkBoxMultipleSelection
            // 
            this.checkBoxMultipleSelection.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxMultipleSelection.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxMultipleSelection, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxMultipleSelection, true);
            this.checkBoxMultipleSelection.Location = new System.Drawing.Point(3, 89);
            this.checkBoxMultipleSelection.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxMultipleSelection.Name = "checkBoxMultipleSelection";
            this.checkBoxMultipleSelection.Size = new System.Drawing.Size(212, 24);
            this.checkBoxMultipleSelection.TabIndex = 4;
            this.checkBoxMultipleSelection.Text = "Multiple Selection";
            // 
            // comboBoxView
            // 
            this.comboBoxView.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.flowLayoutPanel1.SetFillWeight(this.comboBoxView, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.comboBoxView, true);
            this.comboBoxView.Items.AddRange(new object[] {
            "LargeIcons",
            "Details"});
            this.comboBoxView.LabelText = "View";
            this.comboBoxView.Location = new System.Drawing.Point(3, 132);
            this.comboBoxView.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(212, 57);
            this.comboBoxView.TabIndex = 5;
            this.comboBoxView.Text = "LargeIcons";
            // 
            // checkBoxAllowDragAndDrop
            // 
            this.checkBoxAllowDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowDragAndDrop.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxAllowDragAndDrop, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxAllowDragAndDrop, true);
            this.checkBoxAllowDragAndDrop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxAllowDragAndDrop.Name = "checkBoxAllowDragAndDrop";
            this.checkBoxAllowDragAndDrop.Size = new System.Drawing.Size(212, 24);
            this.checkBoxAllowDragAndDrop.TabIndex = 6;
            this.checkBoxAllowDragAndDrop.Text = "Allow Drag and Drop";
            // 
            // FileManager
            // 
            this.Name = "FileManager";
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private Syncfusion2.FileManager fileManager1;
        private CheckBox checkBoxMultipleSelection;
        private CheckBox checkBoxFileExtension;
        private ComboBox comboBoxView;
        private CheckBox checkBoxAllowDragAndDrop;
    }
}
