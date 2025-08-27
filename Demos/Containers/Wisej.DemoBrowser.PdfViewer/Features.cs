using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.PdfViewer
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {
            pdfViewer1.PdfSource = "Files/Wisej.pdf";
        }

        private void comboBoxViewerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pdfViewer1.ViewerType = (PdfViewerType)Enum.Parse(typeof(PdfViewerType), this.comboBoxViewerType.Text);
        }
    }
}
