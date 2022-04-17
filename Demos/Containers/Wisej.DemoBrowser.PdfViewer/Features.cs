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
            var assembly = Assembly.GetExecutingAssembly();
            var resources = assembly.GetManifestResourceNames();
            var pdfPath = resources.First((r) => r.EndsWith("Wisej.pdf"));

            pdfViewer1.PdfStream = new MemoryStream();
            assembly.GetManifestResourceStream(pdfPath).CopyTo(pdfViewer1.PdfStream);
        }

        private void comboBoxViewerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pdfViewer1.ViewerType = (PdfViewerType)Enum.Parse(typeof(PdfViewerType), this.comboBoxViewerType.Text);
        }
    }
}
