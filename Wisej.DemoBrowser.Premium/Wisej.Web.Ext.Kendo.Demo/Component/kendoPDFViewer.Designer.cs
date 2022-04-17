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
            this.numericUpDownScale = new Wisej.Web.NumericUpDown();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.kendoPDFViewer1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.Controls.Add(this.numericUpDownScale);
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
            // numericUpDownScale
            // 
            this.numericUpDownScale.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.numericUpDownScale.DecimalPlaces = 2;
            this.numericUpDownScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScale.LabelText = "Scale";
            this.numericUpDownScale.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScale.Name = "numericUpDownScale";
            this.numericUpDownScale.Postfix = "%";
            this.numericUpDownScale.Size = new System.Drawing.Size(212, 57);
            this.numericUpDownScale.TabIndex = 0;
            this.numericUpDownScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // kendoPDFViewer
            // 
            this.MinimumSize = new System.Drawing.Size(886, 537);
            this.Name = "kendoPDFViewer";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanelProperties.ResumeLayout(false);
            this.flowLayoutPanelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Kendo.kendoPDFViewer kendoPDFViewer1;
        private NumericUpDown numericUpDownScale;
    }
}
