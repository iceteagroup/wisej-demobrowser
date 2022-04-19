using System;
using System.Reflection;
using Wisej.DemoBrowser.Common;
using System.Linq;
using Wisej.Web;
using System.IO;

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
