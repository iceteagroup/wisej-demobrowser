using Newtonsoft.Json;
using Syncfusion.EJ2.FileManager.Base;
using Syncfusion.EJ2.FileManager.PhysicalFileProvider;
using Syncfusion.EJ2.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	/// <summary>
	/// File Manager Implementation.
	/// See: https://github.com/SyncfusionExamples/ej2-aspmvc-file-provider/blob/73f10f29a61eee5a89f54c1c45bd429612ee1471/Controllers/FileManagerController.cs.
	/// </summary>
	public partial class FileManager : TestBase
	{
		PhysicalFileProvider operation = new PhysicalFileProvider();

		public FileManager()
		{
			InitializeComponent();

			this.fileManager1.Instance.onMenuClick += new WidgetEventHandler(fileManager1_WidgetEvent);
			this.fileManager1.Instance.onFileSelect += new WidgetEventHandler(fileManager1_WidgetEvent);
			this.fileManager1.Instance.onToolbarClick += new WidgetEventHandler(fileManager1_WidgetEvent);
		}

		private void FileManager_Load(object sender, EventArgs e)
		{
			this.operation.RootFolder(Application.StartupPath);
		}

		private void fileManager1_WebRequest(object sender, WebRequestEventArgs e)
		{
			dynamic data = null;
			using (var sr = new StreamReader(e.Request.InputStream))
				data = JSON.Parse(sr.ReadToEnd());

			switch (e.Request.Params["action"])
			{
				case "FileOperations":
					e.Response.Write(ProcessFileOperations(data.action, data));
					break;

				case "GetImage":
					break;

				case "Upload":
				case "Upload,save":
				case "Upload,replace":
				case "Upload,keepboth":
					var status = "400 Files cannot be uploaded in this sample.";
					e.Response.Write(status);
					e.Response.Status = status;
					e.Response.StatusDescription = status;
					e.Response.StatusCode = (int)HttpStatusCode.BadRequest;

					var files = e.Request.Files.AllKeys.Select(item => new HttpPostedFileWrapper(e.Request.Files[item])).ToList<HttpPostedFileBase>();
					ProcessUploadOperation(e.Request.Form["action"], e.Request.Form["path"], files, e.Response);
					break;

				case "Download":
					var download = ProcessDownloadOperation(e.Request.Form["downloadInput"]);
					var fileName = download.FileDownloadName;

					download.FileStream.CopyTo(e.Response.OutputStream);
					e.Response.AddHeader("content-disposition", "attachment;filename=" + fileName);
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// Downloads the requested files.
		/// </summary>
		/// <param name="downloadInput"></param>
		/// <returns></returns>
		private FileStreamResult ProcessDownloadOperation(string downloadInput)
		{
			FileManagerDirectoryContent args = JsonConvert.DeserializeObject<FileManagerDirectoryContent>(downloadInput);
			return this.operation.Download(args.Path, args.Names);
		}

		/// <summary>
		/// Uploads the given files to the server path provided.
		/// </summary>
		/// <param name="action"></param>
		/// <param name="path"></param>
		/// <param name="files"></param>
		/// <param name="response"></param>
		private void ProcessUploadOperation(string action, string path, List<HttpPostedFileBase> files, HttpResponse response)
		{
			if (path == null)
			{
				response.Write("");
				return;
			}

			var uploadResponse = operation.Upload(path, files, action, null);
			if (uploadResponse.Error != null)
			{
				response.Clear();
				response.Status = uploadResponse.Error.Code + " " + uploadResponse.Error.Message;
				response.StatusCode = int.Parse(uploadResponse.Error.Code);
				response.StatusDescription = uploadResponse.Error.Message;
				response.End();
			}
			response.Write("");
		}

		/// <summary>
		/// Processes multiple file operations.
		/// </summary>
		/// <param name="action"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		private string ProcessFileOperations(string action, dynamic args)
		{
			switch (action)
			{
				case "read":
					return operation.ToCamelCase(operation.GetFiles(args.path, args.showHiddenItems));
				case "delete":
					return operation.ToCamelCase(operation.Delete(args.path, args.names));
				case "details":
					if (args.Names == null)
					{
						args.Names = new string[] { };
					}
					var jsonData = JSON.Stringify(args.data);
					var files = JsonConvert.DeserializeObject<FileManagerDirectoryContent[]>(jsonData);
					return operation.ToCamelCase(operation.Details(args.path, args.names, files));
				case "create":
					return ProcessErrorResponse("Cannot crerate files in this sample."); //operation.ToCamelCase(operation.Create(args.path, args.name));
				case "search":
					return operation.ToCamelCase(operation.Search(args.path, args.searchString, args.showHiddenItems, args.caseSensitive));
				case "copy":
					return ProcessErrorResponse("Cannot copy files in this sample."); // operation.ToCamelCase(operation.Copy(args.path, args.targetPath, args.names, args.renameFiles, args.targetData));
				case "move":
					return ProcessErrorResponse("Cannot move files in this sample."); // operation.ToCamelCase(operation.Move(args.path, args.targetPath, args.names, args.renameFiles, args.targetData));
				case "rename":
					return ProcessErrorResponse("Cannot rewrite file names in this sample."); //operation.ToCamelCase(operation.Rename(args.path, args.name, args.newName));
			}
			return null;
		}

        private void fileManager1_WidgetEvent(object sender, WidgetEventArgs e)
        {
			switch (e.Type)
            {
				case "fileSelect":
					AlertBox.Show($"{e.Data.action} {e.Data.fileDetails.name}");
					break;

				case "menuClick":
					AlertBox.Show($"Selected {e.Data.item} on items: {JSON.Stringify(e.Data.fileDetails)}");
					break;

				default:
					AlertBox.Show(
						$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);
					break;
            }
        }

		/// <summary>
		/// Provides an error response.
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
		private string ProcessErrorResponse(string response)
		{
			var error = new FileManagerResponse()
			{
				Error = new ErrorDetails()
				{
					Code = "400",
					Message = response
				},
			};
			return operation.ToCamelCase(error);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.fileManager1.Options.view = this.comboBoxView.Text;
			this.fileManager1.Options.showThumbnail = this.checkBoxThumbnail.Checked;
			this.fileManager1.Options.showHiddenItems = this.checkBoxHiddenItem.Checked;
			this.fileManager1.Options.showFileExtension = this.checkBoxFileExtension.Checked;
			this.fileManager1.Options.allowDragAndDrop = this.checkBoxMultipleSelection.Checked;

			this.fileManager1.Update();
        }
    }
}
