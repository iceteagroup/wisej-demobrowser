using System;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igTree : TestBase
	{
		public igTree()
		{
			InitializeComponent();

			this.igTree1.Instance.onNodeClick += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTree1.Instance.onNodeExpanded += new WidgetEventHandler(igTree_WidgetEvent);
			this.igTree1.Instance.onNodeCheckstateChanged += new WidgetEventHandler(igTree_WidgetEvent);
		}

		private void igTree_Load(object sender, EventArgs e)
		{
			//igTree1 configuration
			this.igTree1.Options.dragAndDrop = true;
			this.igTree1.Options.checkboxMode = "triState";
			this.igTree1.Options.singleBranchExpand = true;
			this.igTree1.Options.dataSource = new dynamic[]
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
			this.igTree1.Options.dataSourceType = "json";
			this.igTree1.Options.initialExpandDepth = 0;
			this.igTree1.Options.pathSeparator = ".";

			this.igTree1.Options.bindings = new
			{
				textKey = "Text",
				valueKey = "Value",
				imageUrlKey = "ImageUrl",
				childDataProperty = "Folder"
			};

			this.igTree1.Options.dragAndDropSettings =
				new
				{
					allowDrop = true,
					customDropValidation = "()=>customDropValidation"
				};


			//igTree2 Configuration
			this.igTree2.Options.dragAndDrop = true;
			this.igTree2.Options.checkboxMode = "triState";
			this.igTree2.Options.singleBranchExpand = true;
			this.igTree2.Options.dataSource = new dynamic[]
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
			this.igTree2.Options.dataSourceType = "json";
			this.igTree2.Options.initialExpandDepth = 0;
			this.igTree2.Options.pathSeparator = ".";

			this.igTree2.Options.bindings = new
			{
				textKey = "Text",
				valueKey = "Value",
				imageUrlKey = "ImageUrl",
				childDataProperty = "Folder"
			};

			this.igTree2.Options.dragAndDropSettings =
				new
				{
					allowDrop = true,
					customDropValidation = "()=>customDropValidation"
				};
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
			this.igTree1.Options.checkboxMode = this.comboBox1.SelectedItem;
			this.igTree1.Options.singleBranchExpand = this.checkBox1.Checked;

			this.igTree1.Update();

			this.igTree2.Options.checkboxMode = this.comboBox1.SelectedItem;
			this.igTree2.Options.singleBranchExpand = this.checkBox1.Checked;

			this.igTree2.Update();
		}

		private void buttonClearSelection_Click(object sender, EventArgs e)
		{
			this.igTree1.Instance.clearSelection();
			this.igTree2.Instance.clearSelection();

			this.igTree1.Update();
			this.igTree2.Update();
		}
	}
}