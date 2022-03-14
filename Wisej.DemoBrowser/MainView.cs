using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser
{
	public partial class MainView : Page
	{

		#region Properties

		/// <summary>
		/// The current-selected search item.
		/// </summary>
		private TreeNode SelectedSearchItem;

		/// <summary>
		/// The current search results.
		/// </summary>
		private List<TreeNode> SearchResults = new List<TreeNode>();

		/// <summary>
		/// The default URL for the source code.
		/// </summary>
		private string BASE_SOURCE_CODE_URL = "https://github.com/";

		/// <summary>
		/// The default URL for the documentation.
		/// </summary>
		private string BASE_DOCS_URL = "https://docs.wisej.com/docs/";

		#endregion

		#region Constructor

		public MainView()
		{
			InitializeComponent();
		}

		#endregion

		private void MainView_Load(object sender, EventArgs e)
		{
			var hash = Application.Hash;
			Application.HashChanged += this.Application_HashChanged;

			this.treeViewComponents.Nodes.Clear();
			PopulateTestList();

			if (this.treeViewComponents.Nodes.Count > 0)
				this.treeViewComponents.SelectedNode = this.treeViewComponents.Nodes[0];

			 if (!string.IsNullOrEmpty(hash))
				SelectNode(hash);

			this.panelComponents.ShowHeader = false;
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			SelectNode(e.Hash);
		}

		private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			Application.LoadTheme(this.comboBoxTheme.Text);
		}

		/// <summary>
		/// Populates the TreeView with the available demos.
		/// </summary>
		private void PopulateTestList()
		{
			var text = File.ReadAllText(Path.Combine(Application.MapPath("DemoBrowser.json")));
			var data = Core.WisejSerializer.Parse(text);

			foreach (Core.DynamicObject.Member category in data)
			{
				// create category node.
				var categoryName = category.Name;
				var controls = (dynamic)category.Value;

				var categoryNode = new TreeNode
				{
					Text = categoryName,
					Name = categoryName,
					HideNodeImage = true,
				};
				categoryNode.UserData.Type = "Category";

				foreach (Core.DynamicObject.Member control in controls)
				{
					// create control node.
					var controlName = control.Name;
					var demos = (dynamic)control.Value;

					var controlNode = new TreeNode
					{
						Name = controlName,
						Text = controlName,
						HideNodeImage = demos.Count == 0,
					};
					controlNode.UserData.Type = "Control";

					// apply the "features" image.
					var imageSource = demos["Features"]?.imageSource ?? "";
					var imageIndex = AppendImage(imageSource);

					controlNode.ImageIndex = imageIndex;
					controlNode.SelectedImageIndex = imageIndex;

					categoryNode.Nodes.Add(controlNode);

					foreach (Core.DynamicObject.Member demo in demos)
					{
						// create demo node.
						var demoName = demo.Name;
						var demoContent = (dynamic)demo.Value;
						TreeNode demoNode = null;

						// replace "Features" node with control-node.
						if (demoName == "Features")
						{
							demoNode = controlNode;
						}
						else 
						{
							demoNode = new TreeNode
							{
								Text = demoName,
								Name = demoName,
								HideNodeImage = true,
							};
							controlNode.Nodes.Add(demoNode);
						}
						demoNode.Tag = new
						{
							Category = categoryName,
							Control = controlName,
							Info = demoContent,
							Title = demoName,
						};
						demoNode.UserData.Type = "Demo";
					}
				}
				this.treeViewComponents.Nodes.Add(categoryNode);
			}
		}

		/// <summary>
		/// Appends the image to the imagelist.
		/// </summary>
		/// <param name="imageSource"></param>
		/// <returns></returns>
		private int AppendImage(string imageSource)
		{
			this.imageList1.Images.Add(new ImageListEntry(imageSource));
			return this.imageList1.Images.Count - 1;
		}

		/// <summary>
		/// Selects a node if the given path exists.
		/// </summary>
		/// <param name="path"></param>
		private void SelectNode(string path)
		{
			try
			{
				var nodePath = HttpUtility.UrlDecode(path).Split(this.treeViewComponents.PathSeparator.ToCharArray());
				var categoryNode = this.treeViewComponents.Nodes[nodePath[0]];
				var controlNode = categoryNode.Nodes[nodePath[1]];
				TreeNode demoNode = controlNode;
				if (nodePath.Length > 2)
					demoNode = controlNode.Nodes[nodePath[2]];
				
				this.treeViewComponents.SelectedNode = demoNode;
			} 
			catch
			{
				AlertBox.Show("Unknown Demo.", MessageBoxIcon.Error, showProgressBar: true);
			}
		}

		/// <summary>
		/// Shows the view for the selected node.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void treeViewComponents_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var node = this.treeViewComponents.SelectedNode;
			if (node.Tag == null)
			{
				if (node.Nodes.Count > 0)
					this.treeViewComponents.SelectedNode = node.Nodes[0];
			}
			else
			{
				ProcessNodeSelection(node);
			}
		}

		/// <summary>
		/// Processes the demo data for the given node.
		/// </summary>
		/// <param name="node">The demo node.</param>
		private void ProcessNodeSelection(TreeNode node)
		{
			var container = this.panelDemo;
			container.Controls.Clear(true);

			var data = (dynamic) node.Tag;
			var category = data.Category;
			var control = data.Control;
			var title = data.Title;
			var info = data.Info;

			// retrieve the localized description or default to english.
			var culture = Application.CurrentCulture.TwoLetterISOLanguageName;
			var description = info[$"description-{culture}"] ?? info["description-en"];
			
			var fullyQualifiedName = (string) info.assembly ?? null;
			if (fullyQualifiedName != null)
			{
				var components = fullyQualifiedName.Split(',');
				var assemblyName = components[1].Trim();
				var typeName = components[0].Trim();

				var path = $"{Application.MapPath("bin")}/{assemblyName}";
				var assembly = Assembly.LoadFrom(path);
				var type = assembly.GetTypes().Where(t => t.Name == typeName).ToArray()[0] ?? null;

				var demoInstance = (Control)Activator.CreateInstance(type);

				demoInstance.UserData.args = node.UserData.args;
				demoInstance.Dock = DockStyle.Fill;
				//demoInstance.AutoSize = true;
				container.Controls.Add(demoInstance);

				container.Text = title;
				Application.Hash = node.FullPath;

				this.labelNavigationControl.Text = control;
				this.labelNaivgationCategory.Text = category;
				this.labelDescription.Text = description ?? "";
				this.labelNavigationDemo.Text = title ?? demoInstance.Name;
				this.pictureBoxControl.ImageSource = info?.imageSource ?? "";
				this.labelTitle.Text = $"{control} {title ?? demoInstance.Name}";
			}
		}

		#region Links

		private void buttonDocs_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://docs.wisej.com/", "_blank");
		}

		private void buttonAPI_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://docs.wisej.com/api", "_blank");
		}

		private void buttonSupport_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://www.wisej.com/support", "_blank");
		}

		private void buttonMWW_Click(object sender, EventArgs e)
		{
			Application.Navigate("http://www.madewithwisej.com", "_blank");
		}

		private void buttonContact_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://www.wisej.com/contact-us", "_blank");
		}

		private void buttonFreeTrial_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://wisej.com/products/", "_blank");
		}

		private void buttonBuy_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://wisej.com/products/", "_blank");
		}

		/// <summary>
		/// Open the relevant source code.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSourceCode_Click(object sender, EventArgs e)
		{
			var tag = (dynamic)this.treeViewComponents.SelectedNode.Tag;
			Application.Navigate(tag?.Info?.sourceUrl ?? BASE_SOURCE_CODE_URL, "_blank");
		}

		/// <summary>
		/// Open the relevant documentation.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDocumentation_Click(object sender, EventArgs e)
		{
			var tag = (dynamic)this.treeViewComponents.SelectedNode.Tag;
			Application.Navigate(tag?.Info.docsUrl ?? BASE_DOCS_URL, "_blank");
		}

		#endregion

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			this.textBoxSearch.Focus();
		}

		private void buttonCollapse_Click(object sender, EventArgs e)
		{
			this.panelComponents.Collapsed = !this.panelComponents.Collapsed;
		}

		private void panelComponents_PanelExpanded(object sender, EventArgs e)
		{
			this.panelComponents.ShowHeader = false;
		}

		private void panelComponents_PanelCollapsed(object sender, EventArgs e)
		{
			this.panelComponents.ShowHeader = true;
		}

		#region Search Implementation

		/// <summary>
		/// Selects the previous demo node.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			var node = this.treeViewComponents.SelectedNode;
			var previous = GetPreviousDemo(node, false);
			if (previous != null && previous != node)
				this.treeViewComponents.SelectedNode = previous;
		}

		private TreeNode GetPreviousDemo(TreeNode treeNode, bool check)
		{
			if (check && treeNode.UserData.Type != "Category")
				return treeNode;

			if (treeNode.PrevNode?.LastNode != null) // last node of previous node.
				return treeNode.PrevNode.LastNode;
			else if (treeNode.PrevNode != null) // last node.
				return treeNode.PrevNode;
			else if (treeNode.Parent == null) // parent node.
				return null;

			return GetPreviousDemo(treeNode.Parent, true);
		}

		/// <summary>
		/// Select the next demo node.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonNext_Click(object sender, EventArgs e)
		{
			var node = this.treeViewComponents.SelectedNode;
			//var next = node?.NextNode ?? node.Parent.NextNode ?? node.Parent.Parent.NextNode;
			var next = GetNextDemo(node, false);
			if (next != null && next != node)
				this.treeViewComponents.SelectedNode = next;
		}

		private TreeNode GetNextDemo(TreeNode treeNode,bool check)
		{
			if (check && treeNode.UserData.Type != "Category")
				return treeNode;

			if (treeNode.FirstNode != null)
				return treeNode.FirstNode;
			else if (treeNode.NextNode != null)
				return treeNode.NextNode;

			return GetNextDemo(treeNode.Parent.NextNode, true);
		}

		private void SearchForPhrase(string phrase)
		{
			this.SearchResults.Clear();
			this.textBoxSearch.Tools["back"].Visible = false;
			this.textBoxSearch.Tools["forward"].Visible = false;

			// searching for a node?
			if (string.IsNullOrEmpty(phrase))
				return;
			
			foreach (var node in this.treeViewComponents.Nodes)
				CheckNodeContains(node, phrase);

			var searchResults = this.SearchResults.Count > 0;
			if (searchResults)
			{
				this.textBoxSearch.Tools["back"].Visible = true;
				this.textBoxSearch.Tools["forward"].Visible = true;

				this.SelectedSearchItem = this.SearchResults.First();
				this.treeViewComponents.SelectedNode = this.SearchResults.First();
			}
		}
		
		/// <summary>
		/// Simple method that recursively searches for a phrase from a given root node.
		/// </summary>
		/// <param name="node">The root node.</param>
		/// <param name="phrase">The search phrase.</param>
		private void CheckNodeContains(TreeNode node, string phrase)
		{
			// check the children nodes.
			foreach (var child in node.Nodes)
				CheckNodeContains(child, phrase);

			// check the current node.
			if (node.Text.ToUpper().Contains(phrase.ToUpper())
				&& (node.UserData.Type == "Control" || node.UserData.Type == "Demo"))
				this.SearchResults.Add(node);
		}

		private void textBoxSearch_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "previous":
					SelectPreviousSearchItem();
					break;

				case "next":
					SelectNextSearchItem();
					break;

				case "search":
					SearchForPhrase(this.textBoxSearch.Text);
					break;
			}
		}

		/// <summary>
		/// Navigate to the next or previous search result.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBoxSearch_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "forward":
					SelectNextSearchItem();
					break;

				case "back":
					SelectPreviousSearchItem();
					break;
			}
		}

		/// <summary>
		/// Selects the next search result.
		/// </summary>
		private void SelectNextSearchItem()
		{
			if (this.SearchResults.Count == 0)
				return;

			var nextIndex = this.SearchResults.IndexOf(this.SelectedSearchItem) + 1;
			if (nextIndex < this.SearchResults.Count)
				this.SelectedSearchItem = this.SearchResults[nextIndex];
			else
				this.SelectedSearchItem = this.SearchResults.First();

			this.treeViewComponents.SelectedNode = this.SelectedSearchItem;
		}

		/// <summary>
		/// Selects the previous search result.
		/// </summary>
		private void SelectPreviousSearchItem()
		{
			if (this.SearchResults.Count == 0)
				return;

			var nextIndex = this.SearchResults.IndexOf(this.SelectedSearchItem) - 1;
			if (nextIndex >= 0)
				this.SelectedSearchItem = this.SearchResults[nextIndex];
			else
				this.SelectedSearchItem = this.SearchResults.Last();

			this.treeViewComponents.SelectedNode = this.SelectedSearchItem;
		}

		#endregion

	}
}
