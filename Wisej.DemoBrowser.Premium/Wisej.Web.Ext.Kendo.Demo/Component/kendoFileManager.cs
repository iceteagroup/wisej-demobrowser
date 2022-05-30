using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Wisej.Core;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoFileManager : TestBase
	{
		public kendoFileManager()
		{
			InitializeComponent();

			this.kendoFileManager1.Instance.onOpen += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
			this.kendoFileManager1.Instance.onExecute += new WidgetEventHandler(kendoFileManager1_WidgetEvent);
		}

		private void kendoFileManager_Load(object sender, EventArgs e)
		{
			var serviceUrl = ((IWisejHandler)this.kendoFileManager1).GetServiceURL();

			this.kendoFileManager1.Options.toolbar = new
			{
				items = new dynamic[]
				{
					new
					{
						name = "sortDirection"
					},
					new
					{
						name = "sortField"
					},
					new
					{
						name = "changeView"
					},
					new
					{
						name = "spacer"
					},
					new
					{
						name = "details"
					},
					new
					{
						name = "search"
					}
				}
			};

			this.kendoFileManager1.Options.contextMenu = new
			{
				items = new dynamic[]
				{
					new {name = "rename"}
				}
			};

			this.kendoFileManager1.Options.draggable = true;
			this.kendoFileManager1.Options.resizable = true;

			this.kendoFileManager1.Options.dataSource = new
			{
				transport = new
				{
					read = new { url = $"{serviceUrl}?action=read" },
					create = new { url = $"{serviceUrl}?action=create" },
					update = new { url = $"{serviceUrl}?action=update" },
					destroy = new { url = $"{serviceUrl}?action=destroy" }
				}
			};
		}

		private void kendoFileManager1_WebRequest(object sender, WebRequestEventArgs e)
		{
			e.Response.ContentType = "application/json";
			switch (e.Request["action"])
			{
				case "create":
					break;

				case "read":
					e.Response.Write(GetFiles(e.Request["target"]));
					break;

				case "update":
				case "destroy":
					e.Response.Write("{}");
					break;

				default:
					break;
			}
		}

		private string GetFiles(string path)
		{
			var response = new List<dynamic>();
			var basePath = Application.MapPath("Data/FileManager");
			var currentPath = Application.MapPath($"Data/FileManager" + path ?? "");
			var entries = Directory.GetFileSystemEntries(currentPath).Select(f => {

				FileSystemInfo entry;
				if (File.Exists(f))
					entry = new FileInfo(f);
				else
					entry = new DirectoryInfo(f);

				return new
				{
					extension = entry.Extension,
					created = entry.CreationTime,
					modified = entry.LastWriteTime,
					isDirectory = Directory.Exists(f),
					createdUtc = entry.CreationTimeUtc,
					modifiedUtc = entry.LastWriteTimeUtc,
					size = (entry as FileInfo)?.Length ?? 0,
					path = entry.FullName.Replace(basePath, ""),
					name = Path.GetFileNameWithoutExtension(entry.Name),
				};
			});

			return entries.ToJSON();
		}

		private void kendoFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "open":
					AlertBox.Show($"Open {e.Data.entry.path}");
					break;

				default:
					AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);
					break;
			}

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoFileManager1.Options.breadcrumb = this.checkBoxBreadcrumb.Checked;
			this.kendoFileManager1.Options.contextMenu = this.checkBoxContextMenu.Checked;
			
			this.kendoFileManager1.Update();
		}
	}
}
