using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxFileManager : TestBase
	{
		public dxFileManager()
		{
			InitializeComponent();

			this.dxFileManager1.Instance.onSelectedFileOpened += new WidgetEventHandler(dxFileManager1_WidgetEvent);
			this.dxFileManager1.Instance.onCurrentDirectoryChanged += new WidgetEventHandler(dxFileManager1_WidgetEvent);
		}

		private void dxFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

       
        private void buttonUpdate_Click(object sender, EventArgs e)
		{
			// Guarantees the existence of Options.itemView.
			this.dxFileManager1.Options.itemView = new { mode = this.comboBox1.SelectedItem, showFolders = this.checkBox1.Checked };
			this.dxFileManager1.Options.allowedFileExtensions = this.checkedListBox1.CheckedItems;
			this.dxFileManager1.Options.activeStateEnabled = this.checkBox2.Checked;

			this.dxFileManager1.Update();
		}

		private void checkedListBox1_AfterItemCheck(object sender, ItemCheckEventArgs e)
		{
			var comboString = "";
			foreach (var checkedItem in checkedListBox1.CheckedItems)
			{
				comboString += $"{checkedItem}, ";
			}
			this.userComboBox1.Text = comboString;
		}

        private void dxFileManager_Load(object sender, EventArgs e)
        {
			var data = new object[]
			{
				new
				{
					name = "Documents",
					isDirectory = true,
					items = new object[]
					{
						new
						{
							name = "Projects",
							isDirectory = true,
							items = new object[]
							{
								new
								{
									name = "About.rtf",
									isDirectory = false,
									size = 1024
								},
								new
								{
									name = "Password.rtf",
									isDirectory = false,
									size = 2048
								}
							}
						},
						new
						{
							name = "About.xml",
							isDirectory = false,
							size = 2048
						},
						new
						{
							name = "Manager.rtf",
							isDirectory = false,
							size = 2048
						},
						new
						{
							name = "Todo.txt",
							isDirectory = false,
							size = 2048
						},
						new
						{
							name = "Images",
							isDirectory = true,
							items = new object[]
							{
								new
								{
									name = "logo.png",
									isDirectory = false,
									size = 1024
								},
								new
								{
									name = "banner.gif",
									isDirectory = false,
									size = 2048
								}
							}
						},
						new
						{
							name = "Systems",
							isDirectory = true,
							items = new object[]
							{
								new
								{
									name = "Employee.txt",
									isDirectory = false,
									size = 1024
								},
								new
								{
									name = "PasswordList.txt",
									isDirectory = false,
									size = 2048
								}
							}
						},
						new
						{
							name = "Description.rtf",
							isDirectory = false,
							size = 1024
						},
						new
						{
							name = "Description.txt",
							isDirectory = false,
							size = 2048
						}
					}
				}
			};

			this.dxFileManager1.Options = new
			{
				fileSystemProvider = data,
				name = "fileManager",
				currentPathcurrentPath = "Documents",
				permissions = new
                {
					create = true,
					copy = true,
					move = true,
					remove = true,
					rename = true,
                }
			};

			this.dxFileManager1.Update();

			this.comboBox1.SelectedIndex = 0;
		}
	}
}
