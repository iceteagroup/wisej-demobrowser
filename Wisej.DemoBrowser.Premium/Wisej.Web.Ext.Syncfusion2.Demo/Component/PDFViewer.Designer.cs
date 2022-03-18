namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
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
            this.pdfViewer1 = new Wisej.Web.Ext.Syncfusion2.PDFViewer();
            this.button1 = new Wisej.Web.Button();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/pdfviewer/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/pdfviewer/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pdfViewer1);
            this.panel.Size = new System.Drawing.Size(1102, 626);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/pdfviewer/default.html";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(8, 8);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1084, 608);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.WebRequest += new Wisej.Web.WebRequestHandler(this.pdfViewer1_WebRequest);
            this.pdfViewer1.Appear += new System.EventHandler(this.pdfViewer1_Appear);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Annotations Doc";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDFViewer
            // 
            this.Name = "PDFViewer";
            this.Size = new System.Drawing.Size(1511, 816);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.PDFViewer pdfViewer1;
		private Button button1;
	}
}
