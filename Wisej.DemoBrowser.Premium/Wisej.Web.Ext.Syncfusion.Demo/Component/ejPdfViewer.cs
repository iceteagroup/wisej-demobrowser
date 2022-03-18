using Syncfusion.EJ.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPdfViewer : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejPdfViewer()
		{
			InitializeComponent();
		}

		private void ejPdfViewer1_WebRequest(object sender, WebRequestEventArgs e)
		{
			if (e.Request.HttpMethod == "POST")
			{
				var action = Path.GetFileName(e.Request.Path);
				switch (action)
				{
					case "Load":
						OnPdfLoad(e);
						break;

					case "Download":
						OnPdfDownload(e);
						break;

					default:
						AlertBox.Show($"Action not implemented: {action}", MessageBoxIcon.Stop);
						break;
				}
			}
		}

		private void OnPdfDownload(WebRequestEventArgs e)
		{
			var helper = new PdfViewerHelper();
			var data = JSON.Parse(e.Request.InputStream);
			e.Response.Write(helper.GetDocumentData(ToDictionary(data)));
		}

		private void OnPdfLoad(WebRequestEventArgs e)
		{
			var helper = new PdfViewerHelper();
			var data = JSON.Parse(e.Request.InputStream);

			string fileName = data.file;
			if (!String.IsNullOrEmpty(fileName))
			{
				helper.Load(Application.MapPath(fileName));
				e.Response.Write(helper.ProcessPdf(ToDictionary(data)));

				// remove the temp file.
				if (fileName.StartsWith(Path.GetTempPath()))
				{
					try { File.Delete(fileName); }
					catch { }
				}
			}
			else
			{
				e.Response.Write(helper.ProcessPdf(ToDictionary(data)));
			}
		}

		private Dictionary<string, string> ToDictionary(DynamicObject data)
		{
			var result = new Dictionary<string, string>();
			foreach (var field in data)
			{
				result[field.Name] = Convert.ToString(field.Value);
			}
			return result;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPdfViewer1.Options.enableHighlightAnnotation = this.checkBox1.Checked;
			this.ejPdfViewer1.Options.enableTextMarkupAnnotations = this.checkBox1.Checked;
			this.ejPdfViewer1.Options.enableStrikethroughAnnotation = this.checkBox1.Checked;
			this.ejPdfViewer1.Options.enableSignature = this.checkBox2.Checked;
			this.ejPdfViewer1.Options.enableTextSelection = this.checkBox3.Checked;
			this.ejPdfViewer1.Options.enableHyperlink = this.checkBox4.Checked;

			this.ejPdfViewer1.Instance.zoomTo((int)this.trackBar1.Value);
			this.ejPdfViewer1.Update();
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				var tempPath = Path.Combine(Path.GetTempPath(), e.Files[0].FileName);
				e.Files[0].SaveAs(tempPath);
				this.ejPdfViewer1.Instance.load(tempPath);
			}
		}

		private void ejPdfViewer1_Initialized(object sender, EventArgs e)
		{
			this.ejPdfViewer1.Instance.load("Data\\Wisej-Datasheet-V2.3.pdf");
		}

		private void ejPdfViewer_Load(object sender, EventArgs e)
		{
			this.ejPdfViewer1.Options.enableSignature = false;
			this.ejPdfViewer1.Options.enableHighlightAnnotation = true;
			this.ejPdfViewer1.Options.enableTextMarkupAnnotations = true;
			this.ejPdfViewer1.Options.enableStrikethroughAnnotation = true;
		}
	}
}
