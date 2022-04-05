namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class PDFViewer
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
            this.pdfViewer1 = new Wisej.Web.Ext.Webix.PDFViewer();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#pdfviewer";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.pdfviewer.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pdfViewer1);
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(8, 8);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1073, 542);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.WebRequest += new Wisej.Web.WebRequestHandler(this.pdfViewer1_WebRequest);
            // 
            // PDFViewer
            // 
            this.Name = "PDFViewer";
            this.Load += new System.EventHandler(this.PDFViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.PDFViewer pdfViewer1;
	}
}
