namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	partial class igHtmlEditor
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
			this.igHtmlEditor1 = new Wisej.Web.Ext.Ignite.igHtmlEditor();
			this.buttonLoad = new Wisej.Web.Upload();
			this.buttonExportData = new Wisej.Web.Button();
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.checkBox2 = new Wisej.Web.CheckBox();
			this.checkBox3 = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.buttonLoad);
			this.groupBox1.Controls.Add(this.buttonExportData);
			this.groupBox1.Size = new System.Drawing.Size(250, 439);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonExportData, 0);
			this.groupBox1.Controls.SetChildIndex(this.buttonLoad, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 355);
			this.buttonUpdate.TabIndex = 5;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.igHtmlEditor1);
			this.panel.Size = new System.Drawing.Size(560, 439);
			this.panel.TabIndex = 7;
			// 
			// linkDemo
			// 
			this.linkDemo.TabIndex = 6;
			this.linkDemo.Text = "https://www.igniteui.com/html-editor/overview";
			// 
			// linkAPI
			// 
			this.linkAPI.TabIndex = 5;
			this.linkAPI.Text = "http://www.igniteui.com/help/api/2019.2/ui.ightmleditor";
			// 
			// linkDocs
			// 
			this.linkDocs.TabIndex = 4;
			this.linkDocs.Text = "http://www.igniteui.com/help/ightmleditor-ightmleditor";
			// 
			// igHtmlEditor1
			// 
			this.igHtmlEditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.igHtmlEditor1.Location = new System.Drawing.Point(21, 26);
			this.igHtmlEditor1.Name = "igHtmlEditor1";
			this.igHtmlEditor1.Size = new System.Drawing.Size(516, 385);
			this.igHtmlEditor1.TabIndex = 0;
			// 
			// buttonLoad
			// 
			this.buttonLoad.AllowedFileTypes = ".html";
			this.buttonLoad.HideValue = true;
			this.buttonLoad.ImageSource = "icon-file";
			this.buttonLoad.Location = new System.Drawing.Point(28, 272);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(42, 42);
			this.buttonLoad.TabIndex = 3;
			this.buttonLoad.Uploaded += new Wisej.Web.UploadedEventHandler(this.buttonLoad_Uploaded);
			// 
			// buttonExportData
			// 
			this.buttonExportData.Display = Wisej.Web.Display.Icon;
			this.buttonExportData.ImageSource = "icon-save";
			this.buttonExportData.Location = new System.Drawing.Point(76, 272);
			this.buttonExportData.Name = "buttonExportData";
			this.buttonExportData.Size = new System.Drawing.Size(42, 42);
			this.buttonExportData.TabIndex = 4;
			this.buttonExportData.Click += new System.EventHandler(this.buttonExportData_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 35);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Copy Paste Toolbar";
			// 
			// checkBox2
			// 
			this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox2.AutoSize = false;
			this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(28, 114);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(195, 38);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Formatting Toolbar";
			// 
			// checkBox3
			// 
			this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox3.AutoSize = false;
			this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(28, 193);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(195, 38);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Insert Object Toolbar";
			// 
			// igHtmlEditor
			// 
			this.Name = "igHtmlEditor";
			this.Size = new System.Drawing.Size(969, 629);
			this.Load += new System.EventHandler(this.igHtmlEditor_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Ignite.igHtmlEditor igHtmlEditor1;
		private Upload buttonLoad;
		private Button buttonExportData;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
	}
}
