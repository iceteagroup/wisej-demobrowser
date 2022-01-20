using System;
using System.Reflection;
using Wisej.DemoBrowser.Common;
using System.Linq;
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
            var assembly = Assembly.GetExecutingAssembly();
            var resources = assembly.GetManifestResourceNames();
            var pdfPath = resources.First((r) => r.EndsWith("Wisej.pdf"));

            var pdfStream = assembly.GetManifestResourceStream(pdfPath);

            pdfViewer1.PdfStream = pdfStream;
        }
    }
}
