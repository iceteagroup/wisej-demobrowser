using System;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igTree : TestBase
	{
		public igTree()
		{
			InitializeComponent();

			igTree1.Instance.onNodeClick += new WidgetEventHandler(igTree_WidgetEvent);
			igTree1.Instance.onNodeExpanded += new WidgetEventHandler(igTree_WidgetEvent);
			igTree1.Instance.onNodeCheckstateChanged += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void igTree_Load(object sender, EventArgs e)
		{
			//igTree1 configuration
			igTree1.Options.dragAndDrop = true;
			igTree1.Options.checkboxMode = "triState";
			igTree1.Options.singleBranchExpand = true;
			igTree1.Options.dataSource = new dynamic[]
			{
				new
				{
					Text = "Computer", Value = "Folder", ImageUrl = "Images/Tree/computer.png", Folder = new dynamic[]
					{
						new
						{
							Text = "Music", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder = new dynamic[]
							{
								new
								{
									Text = "Y.Malmsteen", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "Making Love", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											},
											new
											{
												Text = "Rising Force", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											},
											new
											{
												Text = "Fire and Ice", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											}
										}
								},
								new
								{
									Text = "WhiteSnake", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "Trouble", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											},
											new
											{
												Text = "Bad Boys", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											},
											new
											{
												Text = "Is This Love", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											}
										}
								},
								new
								{
									Text = "AC/DC", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "ThunderStruck", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											},
											new
											{
												Text = "T.N.T.", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											},
											new
											{
												Text = "The Jack", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											}
										}
								},
								new
								{
									Text = "Rock", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "Bon Jovi - Always", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											}
										}
								}
							}
						},
						new
						{
							Text = "My Documents", Value = "Folder", ImageUrl = "Images/Tree/documents-folder.png",
							Folder = new dynamic[]
							{
								new
								{
									Text = "2009", Value = "Folder", ImageUrl = "Images/Tree/documents-folder.png",
									Folder = new dynamic[]
									{
										new
										{
											Text = "Month Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										},
										new
										{
											Text = "Year Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										}
									}
								},
								new
								{
									Text = "2010", Value = "Folder", ImageUrl = "Images/Tree/documents-folder.png",
									Folder = new dynamic[]
									{
										new
										{
											Text = "Month Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										},
										new
										{
											Text = "Year Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										}
									}
								}
							}
						},
						new
						{
							Text = "Pictures", Value = "Folder", ImageUrl = "Images/Tree/coins.png", Folder =
								new dynamic[]
								{
									new
									{
										Text = "BirthDay2009", Value = "Folder", ImageUrl = "Images/Tree/coins.png",
										Folder = new dynamic[]
										{
											new
											{
												Text = "Picture1", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture2", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture3", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture4", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											}
										}
									},
									new
									{
										Text = "BirthDay2010", Value = "Folder", ImageUrl = "Images/Tree/coins.png",
										Folder = new dynamic[]
										{
											new
											{
												Text = "Picture1", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture2", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture3", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											}
										}
									}
								}
						},
						new
						{
							Text = "Network", Value = "Folder", ImageUrl = "Images/Tree/door.png", Folder =
								new dynamic[]
								{
									new
									{
										Text = "Archive", Value = "Folder", ImageUrl = "Images/Tree/door_in.png",
										Folder = ""
									},
									new
									{
										Text = "BackUp", Value = "Folder", ImageUrl = "Images/Tree/door_in.png",
										Folder = ""
									},
									new
									{
										Text = "FTP", Value = "Folder", ImageUrl = "Images/Tree/door_in.png",
										Folder = ""
									}
								}
						},
						new {Text = "Deleted", Value = "Folder", ImageUrl = "Images/Tree/bin_empty.png", Folder = ""}
					}
				}
			};
			igTree1.Options.dataSourceType = "json";
			igTree1.Options.initialExpandDepth = 0;
			igTree1.Options.pathSeparator = ".";

			//igTree2 Configuration
			igTree2.Options.dragAndDrop = true;
			igTree2.Options.checkboxMode = "triState";
			igTree2.Options.singleBranchExpand = true;
			igTree2.Options.dataSource = new dynamic[]
			{
				new
				{
					Text = "Computer", Value = "Folder", ImageUrl = "Images/Tree/computer.png", Folder = new dynamic[]
					{
						new
						{
							Text = "Music", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder = new dynamic[]
							{
								new
								{
									Text = "Y.Malmsteen", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "Making Love", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											},
											new
											{
												Text = "Rising Force", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											},
											new
											{
												Text = "Fire and Ice", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											}
										}
								},
								new
								{
									Text = "WhiteSnake", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "Trouble", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											},
											new
											{
												Text = "Bad Boys", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											},
											new
											{
												Text = "Is This Love", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											}
										}
								},
								new
								{
									Text = "AC/DC", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "ThunderStruck", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											},
											new
											{
												Text = "T.N.T.", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											},
											new
											{
												Text = "The Jack", Value = "File", ImageUrl = "Images/Tree/music.png",
												Folder = ""
											}
										}
								},
								new
								{
									Text = "Rock", Value = "Folder", ImageUrl = "Images/Tree/book.png", Folder =
										new dynamic[]
										{
											new
											{
												Text = "Bon Jovi - Always", Value = "File",
												ImageUrl = "Images/Tree/music.png", Folder = ""
											}
										}
								}
							}
						},
						new
						{
							Text = "My Documents", Value = "Folder", ImageUrl = "Images/Tree/documents-folder.png",
							Folder = new dynamic[]
							{
								new
								{
									Text = "2009", Value = "Folder", ImageUrl = "Images/Tree/documents-folder.png",
									Folder = new dynamic[]
									{
										new
										{
											Text = "Month Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										},
										new
										{
											Text = "Year Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										}
									}
								},
								new
								{
									Text = "2010", Value = "Folder", ImageUrl = "Images/Tree/documents-folder.png",
									Folder = new dynamic[]
									{
										new
										{
											Text = "Month Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										},
										new
										{
											Text = "Year Report", Value = "File",
											ImageUrl = "Images/Tree/documents.png", Folder = ""
										}
									}
								}
							}
						},
						new
						{
							Text = "Pictures", Value = "Folder", ImageUrl = "Images/Tree/coins.png", Folder =
								new dynamic[]
								{
									new
									{
										Text = "BirthDay2009", Value = "Folder", ImageUrl = "Images/Tree/coins.png",
										Folder = new dynamic[]
										{
											new
											{
												Text = "Picture1", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture2", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture3", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture4", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											}
										}
									},
									new
									{
										Text = "BirthDay2010", Value = "Folder", ImageUrl = "Images/Tree/coins.png",
										Folder = new dynamic[]
										{
											new
											{
												Text = "Picture1", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture2", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											},
											new
											{
												Text = "Picture3", Value = "File",
												ImageUrl = "Images/Tree/coins_add.png", Folder = ""
											}
										}
									}
								}
						},
						new
						{
							Text = "Network", Value = "Folder", ImageUrl = "Images/Tree/door.png", Folder =
								new dynamic[]
								{
									new
									{
										Text = "Archive", Value = "Folder", ImageUrl = "Images/Tree/door_in.png",
										Folder = ""
									},
									new
									{
										Text = "BackUp", Value = "Folder", ImageUrl = "Images/Tree/door_in.png",
										Folder = ""
									},
									new
									{
										Text = "FTP", Value = "Folder", ImageUrl = "Images/Tree/door_in.png",
										Folder = ""
									}
								}
						},
						new {Text = "Deleted", Value = "Folder", ImageUrl = "Images/Tree/bin_empty.png", Folder = ""}
					}
				}
			};
			igTree2.Options.dataSourceType = "json";
			igTree2.Options.initialExpandDepth = 0;
			igTree2.Options.pathSeparator = ".";
		}

		private void igTree_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			igTree1.Options.checkboxMode = comboBox1.SelectedItem;
			igTree1.Options.singleBranchExpand = checkBox1.Checked;

			igTree1.Update();
		}

		private void buttonClearSelection_Click(object sender, EventArgs e)
		{
			igTree1.Instance.clearSelection();
		}
	}
}