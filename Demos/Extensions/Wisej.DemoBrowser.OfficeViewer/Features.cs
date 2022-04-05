using System;
using System.IO;
using System.Reflection;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.OfficeViewer
{
    public partial class Features : DemoView
    {
        private Assembly assembly;
        public Features()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filename = "word_sample.doc";
            var resourceName = $"Wisej.DemoBrowser.OfficeViewer.Files.{filename}";

            Stream stream = assembly.GetManifestResourceStream(resourceName);

            officeViewer1.FileName = filename;
            officeViewer1.FileStream = stream;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filename = "powerpoint_sample.doc";
            var resourceName = $"Wisej.DemoBrowser.OfficeViewer.Files.{filename}";

            Stream stream = assembly.GetManifestResourceStream(resourceName);

            officeViewer1.FileName = filename;
            officeViewer1.FileStream = stream;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filename = "excel_sample.doc";
            var resourceName = $"Wisej.DemoBrowser.OfficeViewer.Files.{filename}";

            Stream stream = assembly.GetManifestResourceStream(resourceName);

            officeViewer1.FileName = filename;
            officeViewer1.FileStream = stream;
        }

        private void Features_Load(object sender, EventArgs e)
        {
            assembly = Assembly.GetExecutingAssembly();

            var filename = "word_sample.doc";
            var resourceName = $"Wisej.DemoBrowser.OfficeViewer.Files.{filename}";

            Stream stream = assembly.GetManifestResourceStream(resourceName);

            officeViewer1.FileName = filename;
            officeViewer1.FileStream = stream;
        }
    }
}
