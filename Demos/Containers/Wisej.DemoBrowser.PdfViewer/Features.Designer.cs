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
            this.comboBoxViewerType = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.pdfViewer1.Location = new System.Drawing.Point(17, 46);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(1387, 412);
            this.pdfViewer1.TabIndex = 0;
            // 
            // comboBoxViewerType
            // 
            this.comboBoxViewerType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxViewerType.Items.AddRange(new object[] {
            "Auto",
            "Google",
            "Mozilla"});
            this.comboBoxViewerType.Label.Position = Wisej.Web.LabelPosition.Left;
            this.comboBoxViewerType.LabelText = "Viewer Type";
            this.comboBoxViewerType.Location = new System.Drawing.Point(17, 8);
            this.comboBoxViewerType.Name = "comboBoxViewerType";
            this.comboBoxViewerType.Size = new System.Drawing.Size(207, 30);
            this.comboBoxViewerType.TabIndex = 1;
            this.comboBoxViewerType.Text = "Auto";
            this.comboBoxViewerType.SelectedIndexChanged += new System.EventHandler(this.comboBoxViewerType_SelectedIndexChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.comboBoxViewerType);
            this.Controls.Add(this.pdfViewer1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(16);
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.PdfViewer pdfViewer1;
        private Web.ComboBox comboBoxViewerType;
    }
}
