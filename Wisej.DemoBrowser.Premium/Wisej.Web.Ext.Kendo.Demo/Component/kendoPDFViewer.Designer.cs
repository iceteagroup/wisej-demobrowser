namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoPDFViewer
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
            this.kendoPDFViewer1 = new Wisej.Web.Ext.Kendo.kendoPDFViewer();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoPDFViewer1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://demos.telerik.com/kendo-ui/pdfviewer/index";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.telerik.com/kendo-ui/api/javascript/ui/pdfviewer";
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.telerik.com/kendo-ui/controls/PDF/PDFViewer/overview";
            // 
            // kendoPDFViewer1
            // 
            this.kendoPDFViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.kendoPDFViewer1.Location = new System.Drawing.Point(8, 8);
            this.kendoPDFViewer1.Name = "kendoPDFViewer1";
            this.kendoPDFViewer1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"pdfjsProcessing\":{\"file\":\"./Data/PDFViewer/wisej.pdf\"}}")));
            this.kendoPDFViewer1.Size = new System.Drawing.Size(1073, 542);
            this.kendoPDFViewer1.TabIndex = 0;
            this.kendoPDFViewer1.Text = "kendoPDFViewer1";
            // 
            // kendoPDFViewer
            // 
            this.Name = "kendoPDFViewer";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPDFViewer kendoPDFViewer1;
	}
}
