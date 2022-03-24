using Newtonsoft.Json;
using Syncfusion.EJ2.DocumentEditor;
using System;
using System.IO;
using System.Linq;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DocumentEditor : TestBase
	{
		public DocumentEditor()
		{
			InitializeComponent();

			this.documentEditor1.Instance.onToolbarClick += new WidgetEventHandler(documentEditor1_WidgetEvent);
			this.documentEditor1.Instance.onActionComplete += new WidgetEventHandler(documentEditor1_WidgetEvent);
		}

		private void DocumentEditor_Load(object sender, EventArgs e)
		{
			//var defaultFile = "Sample1.docx";
			//var samplesPath = Application.MapPath("Data/DocumentEditor");
			//using (var fs = new FileStream(Path.Combine(samplesPath, defaultFile), FileMode.Open))
			//{
			//	var sfdt = ProcessDocument(fs, "docx");
			//	this.documentEditor1.Call("openFile", sfdt);
			//}

			//var samples = Directory.GetFiles(samplesPath)
			//	.Select(x => Path.GetFileName(x)).ToArray();

			//this.comboBoxDataSource.DataSource = samples;
			//this.comboBoxDataSource.SelectedItem = defaultFile;
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var sfdt = await this.documentEditor1.Instance.documentEditor.serializeAsync();
			using (var stream = WordDocument.Save(sfdt, FormatType.Docx))
			{
				Application.Download(stream, "MyDocument.docx");
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			var path = Application.MapPath($"Data/DocumentEditor/{this.comboBoxDataSource.SelectedItem}");
			using (var fs = new FileStream(path, FileMode.Open))
			{
				var sfdt = ProcessDocument(fs, "docx");
				this.documentEditor1.Call("openFile", sfdt);
			}
		}

		/// <summary>
		/// Provide services to the client-side widget.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void documentEditor1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "Import":
					var files = e.Request.Files;
					// can only load one document at a time.
					if (files.Count > 0)
					{
						var file = files[0];
						var index = file.FileName.LastIndexOf('.');
						var type = file.FileName.Substring(index).ToLower();

						e.Response.ContentType = "text/plain";
						e.Response.Output.Write(ProcessDocument(file.InputStream, type));
					}
					break;

				case "Export":
					var json = new StreamReader(e.Request.InputStream).ReadToEnd();
					Application.DownloadAndOpen("_blank", WordDocument.Save(json, FormatType.Docx), "Document.docx");
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Process widget events.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void documentEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		/// <summary>
		/// Generates the SFDT string for the given document.
		/// </summary>
		/// <param name="stream">The file stream.</param>
		/// <param name="format">The file format.</param>
		/// <returns></returns>
		private string ProcessDocument(Stream stream, string format)
		{
			stream.Position = 0;
			var type = (FormatType)Enum.Parse(typeof(FormatType), format.Replace(".", ""), true);
			var document = WordDocument.Load(stream, type);
			var sfdt = JsonConvert.SerializeObject(document);
			document.Dispose();
			return sfdt;
		}
	}
}
