using System;
using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class DropDownTree : TestBase
	{
		public DropDownTree()
		{
			InitializeComponent();

			this.dropDownTree1.Instance.onChange += new WidgetEventHandler(dropDownTree1_WidgetEvent);
		}

		private void DropDownTree_Load(object sender, EventArgs e)
		{
			this.dropDownTree1.Options.fields = new
			{
				dataSource = new object[]
				{
					new
					{
						id = "01",
						name = "Local Disk (C:)",
						expanded = true, subChild = new object[]
						{
							new
							{
								id = "01-01",
								name = "Program Files",
								subChild = new object[]
								{
									new
									{
										id = "01-01-01",
										name = "Windows NT"
									},
									new
									{
										id = "01-01-02",
										name = "Windows Mail"
									},
									new
									{
										id = "01-01-03",
										name = "Windows Photo Viewer"
									}
								}
							},
							new
							{
								id = "01-02",
								name = "Users",
								expanded = true, subChild = new object[]
								{
									new
									{
										id = "01-02-01",
										name = "Smith"
									},
									new
									{
										id = "01-02-02",
										name = "Public"
									},
									new
									{
										id = "01-02-03",
										name = "Admin"
									}
								}
							},
							new
							{
								id = "01-03",
								name = "Windows",
								subChild = new object[]
								{
									new
									{
										id = "01-03-01",
										name = "Boot"
									},
									new
									{
										id = "01-03-02",
										name = "FileManager"
									},
									new
									{
										id = "01-03-03",
										name = "System32"
									}
								}
							}
						}
					},
					new
					{
						id = "02",
						name = "Local Disk (D:)",
						subChild = new object[]
						{
							new
							{
								id = "02-01",
								name = "Personals",
								subChild = new object[]
								{
									new
									{
										id = "02-01-01",
										name = "My photo.png"
									},
									new
									{
										id = "02-01-02",
										name = "Rental document.docx"
									},
									new
									{
										id = "02-01-03",
										name = "Pay slip.pdf"
									}
								}
							},
							new
							{
								id = "02-02",
								name = "Projects",
								subChild = new object[]
								{
									new
									{
										id = "02-02-01",
										name = "ASP Application"
									},
									new
									{
										id = "02-02-02",
										name = "TypeScript Application"
									},
									new
									{
										id = "02-02-03",
										name = "React Application"
									}
								}
							},
							new
							{
								id = "02-03",
								name = "Office",
								subChild = new object[]
								{
									new
									{
										id = "02-03-01",
										name = "Work details.docx"
									},
									new
									{
										id = "02-03-02",
										name = "Weekly report.docx"
									},
									new
									{
										id = "02-03-03",
										name = "Wish list.csv"
									}
								}
							}
						}
					},
					new
					{
						id = "03",
						name = "Local Disk (E:)",
						icon = "folder",
						subChild = new object[]
						{
							new
							{
								id = "03-01",
								name = "Pictures",
								subChild = new object[]
								{
									new
									{
										id = "03-01-01",
										name = "Wind.jpg"
									},
									new
									{
										id = "03-01-02",
										name = "Stone.jpg"
									},
									new
									{
										id = "03-01-03",
										name = "Home.jpg"
									}
								}
							},
							new
							{
								id = "03-02",
								name = "Documents",
								subChild = new object[]
								{
									new
									{
										id = "03-02-01",
										name = "Environment Pollution.docx"
									},
									new
									{
										id = "03-02-02",
										name = "Global Warming.ppt"
									},
									new
									{
										id = "03-02-03",
										name = "Social Network.pdf"
									}
								}
							},
							new
							{
								id = "03-03",
								name = "Study Materials",
								subChild = new object[]
								{
									new
									{
										id = "03-03-01",
										name = "UI-Guide.pdf"
									},
									new
									{
										id = "03-03-02",
										name = "Tutorials.zip"
									},
									new
									{
										id = "03-03-03",
										name = "TypeScript.7z"
									}
								}
							}
						}
					}
				},
				iconData = new object[]
				{
					new
					{
						nodeId = "01",
						nodeText = "Music",
						icon = "folder",
						nodeChild = new object[]
						{
							new
							{
								nodeId = "01-01",
								nodeText = "Gouttes.mp3",
								icon = "audio"
							}
						}
					},
					new
					{
						nodeId = "02",
						nodeText = "Videos",
						icon = "folder",
						nodeChild = new object[]
						{
							new
							{
								nodeId = "02-01",
								nodeText = "Naturals.mp4",
								icon = "video"
							},
							new
							{
								nodeId = "02-02",
								nodeText = "Wild.mpeg",
								icon = "video"
							}
						}
					},
					new
					{
						nodeId = "03",
						nodeText = "Documents",
						icon = "folder",
						nodeChild = new object[]
						{
							new
							{
								nodeId = "03-01",
								nodeText = "Environment Pollution.docx",
								icon = "docx"
							},
							new
							{
								nodeId = "03-02",
								nodeText = "Global Water, Sanitation, & Hygiene.docx",
								icon = "docx"
							},
							new
							{
								nodeId = "03-03",
								nodeText = "Global Warming.ppt",
								icon = "ppt"
							},
							new
							{
								nodeId = "03-04",
								nodeText = "Social Network.pdf",
								icon = "pdf"
							},
							new
							{
								nodeId = "03-05",
								nodeText = "Youth Empowerment.pdf",
								icon = "pdf"
							}
						}
					},
					new
					{
						nodeId = "04",
						nodeText = "Pictures",
						icon = "folder",
						expanded = true, nodeChild = new object[]
						{
							new
							{
								nodeId = "04-01",
								nodeText = "Camera Roll",
								icon = "folder",
								expanded = true, nodeChild = new object[]
								{
									new
									{
										nodeId = "04-01-01",
										nodeText = "WIN_20160726_094117.JPG",
										image = "//ej2.syncfusion.com/demos/src/drop-down-tree/images/employees/9.png"
									},
									new
									{
										nodeId = "04-01-02",
										nodeText = "WIN_20160726_094118.JPG",
										image = "//ej2.syncfusion.com/demos/src/drop-down-tree/images/employees/3.png"
									}
								}
							},
							new
							{
								nodeId = "04-02",
								nodeText = "Wind.jpg",
								icon = "images"
							},
							new
							{
								nodeId = "04-03",
								nodeText = "Stone.jpg",
								icon = "images"
							}
						}
					},
					new
					{
						nodeId = "05",
						nodeText = "Downloads",
						icon = "folder",
						nodeChild = new object[]
						{
							new
							{
								nodeId = "05-01",
								nodeText = "UI-Guide.pdf",
								icon = "pdf"
							},
							new
							{
								nodeId = "05-02",
								nodeText = "Tutorials.zip",
								icon = "zip"
							},
							new
							{
								nodeId = "05-03",
								nodeText = "Game.exe",
								icon = "exe"
							},
							new
							{
								nodeId = "05-04",
								nodeText = "TypeScript.7z",
								icon = "zip"
							}
						}
					}
				},
				value = "id",
				text = "name",
				child = "subChild",
				expanded = "expanded"
			};
			this.dropDownTree1.Options.placeholder = "Select a folder or file";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dropDownTree1.Options.placeholder = this.textBoxPlaceholder.Text;
			this.dropDownTree1.Options["readonly"] = this.checkBoxReadOnly.Checked;
			this.dropDownTree1.Options.allowFiltering = this.checkBoxFiltering.Checked;
			this.dropDownTree1.Options.allowMultiSelection = this.checkBoxMultiSelection.Checked;

			this.dropDownTree1.Update();
		}

		private void dropDownTree1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}