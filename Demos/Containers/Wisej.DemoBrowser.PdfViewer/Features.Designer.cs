namespace Wisej.DemoBrowser.PdfViewer
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
            this.pdfViewer1 = new Wisej.Web.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1422, 474);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.ViewerType = Wisej.Web.PdfViewerType.Mozilla;
            // 
            // Features
            // 
            this.Controls.Add(this.pdfViewer1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Web.PdfViewer pdfViewer1;
    }
}
