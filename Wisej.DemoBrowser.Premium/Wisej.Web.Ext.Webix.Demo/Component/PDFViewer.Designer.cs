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
			this.SuspendLayout();
			// 
			// pdfViewer1
			// 
			this.pdfViewer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.pdfViewer1.Location = new System.Drawing.Point(415, 38);
			this.pdfViewer1.Name = "pdfViewer1";
			this.pdfViewer1.Size = new System.Drawing.Size(700, 400);
			this.pdfViewer1.TabIndex = 0;
			this.pdfViewer1.Text = "pdfViewer1";
			// 
			// PDFViewer
			// 
			this.Controls.Add(this.pdfViewer1);
			this.Name = "PDFViewer";
			this.Controls.SetChildIndex(this.pdfViewer1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.PDFViewer pdfViewer1;
	}
}
