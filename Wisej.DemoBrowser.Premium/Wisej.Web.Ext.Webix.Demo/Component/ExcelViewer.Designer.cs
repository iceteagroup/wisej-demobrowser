namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class ExcelViewer
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
            this.excelViewer1 = new Wisej.Web.Ext.Webix.ExcelViewer();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__excelviewer.html";
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#excelviewer";
            // 
            // linkAPI
            // 
            this.linkApi.Text = "https://docs.webix.com/api__refs__ui.excelviewer.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.excelViewer1);
            // 
            // excelViewer1
            // 
            this.excelViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.excelViewer1.Location = new System.Drawing.Point(8, 8);
            this.excelViewer1.Name = "excelViewer1";
            this.excelViewer1.Size = new System.Drawing.Size(1073, 542);
            this.excelViewer1.TabIndex = 0;
            this.excelViewer1.Text = "excelViewer1";
            this.excelViewer1.WebRequest += new Wisej.Web.WebRequestHandler(this.excelViewer1_WebRequest);
            // 
            // ExcelViewer
            // 
            this.Name = "ExcelViewer";
            this.Load += new System.EventHandler(this.ExcelViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.ExcelViewer excelViewer1;
	}
}
