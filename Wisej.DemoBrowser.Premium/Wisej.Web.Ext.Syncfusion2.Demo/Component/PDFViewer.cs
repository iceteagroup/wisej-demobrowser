using Newtonsoft.Json;
using Syncfusion.EJ2.PdfViewer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	/// <summary>
	/// PDF Viewer Server Side Configuration Example.
	/// https://github.com/SyncfusionExamples/PdfViewer-Server/blob/master/src/ej2-pdfviewer-server/Controllers/PdfViewerController.cs.
	/// </summary>
	public partial class PDFViewer : TestBase
	{
		public PDFViewer()
		{
			InitializeComponent();

			this.pdfViewer1.Instance.hyperlinkClick += new WidgetEventHandler(pdfViewer1_WidgetEvent);
		}

		private void pdfViewer1_Appear(object sender, EventArgs e)
		{
			this.pdfViewer1.Instance.load("Wisej.pdf", null);
		}

		private void pdfViewer1_WebRequest(object sender, WebRequestEventArgs e)
		{
			// decode payload.
			dynamic payload = null;
			using (StreamReader reader = new StreamReader(e.Request.InputStream))
			{
				var text = reader.ReadToEnd();
				payload = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
			}

			switch(payload["action"])
			{
				case "Load":
					e.Response.Write(LoadPdf(payload));
					break;

				case "RenderPdfPages":
					e.Response.Write(RenderPdfPages(payload));
					break;

				case "RenderPdfTexts":
					e.Response.Write(RenderPdfTexts(payload));
					break;

				case "RenderThumbnailImages":
					e.Response.Write(RenderThumbnailImages(payload));
					break;

				case "Download":
					e.Response.Write(Download(payload));
					break;

				case "PrintImages":
					e.Response.Write(PrintImages(payload));
					break;

				case "RenderAnnotationComments":
					e.Response.Write(RenderAnnotationComments(payload));
					break;

				case "Bookmarks":
					e.Response.Write(Bookmarks(payload));
					break;

				case "Unload":
					e.Response.Write(Unload(payload));
					break;

				default:
					break;

			}
		}

		private string RenderPdfTexts(dynamic payload)
		{
;			var renderer = new PdfRenderer();
			var result = renderer.GetDocumentText(payload);
			return JsonConvert.SerializeObject(result);
		}

		private string LoadPdf(Dictionary<string, string> payload)
		{
			MemoryStream ms;
			PdfRenderer renderer = new PdfRenderer();
			bool isFileName = bool.Parse(payload["isFileName"]);
			if (isFileName)
			{
				var path = Application.MapPath($"Data/PdfViewer/{payload["document"]}");
				var bytes = File.ReadAllBytes(path);
				ms = new MemoryStream(bytes);
			}
			else
			{
				var bytes = Convert.FromBase64String(payload["document"]);
				ms = new MemoryStream(bytes);
			}

			var result = renderer.Load(ms, payload);
			return JsonConvert.SerializeObject(result, Formatting.None);
		}

		private string RenderPdfPages(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			var page = renderer.GetPage(payload);
			return JsonConvert.SerializeObject(page);
		}

		private string RenderThumbnailImages(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			var result = renderer.GetThumbnailImages(payload);
			return JsonConvert.SerializeObject(result);
		}

		private string Download(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			return renderer.GetDocumentAsBase64(payload);
		}

		private string PrintImages(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			var result = renderer.GetPrintImage(payload);
			return JsonConvert.SerializeObject(result);
		}

		private string Unload(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			renderer.ClearCache(payload);
			return "Cleared Cache.";
		}

		private string Bookmarks(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			var result = renderer.GetBookmarks(payload);
			return JsonConvert.SerializeObject(result);
		}

		private string RenderAnnotationComments(Dictionary<string, string> payload)
		{
			var renderer = new PdfRenderer();
			var result = renderer.GetAnnotationComments(payload);
			return JsonConvert.SerializeObject(result);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.pdfViewer1.Instance.load("Annotations.pdf", null);
		}

		private void pdfViewer1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
